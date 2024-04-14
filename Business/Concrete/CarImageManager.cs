using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;
        private readonly ICarService _carService;
        private readonly IFileHelper? _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper? fileHelper, ICarService carService)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
            _carService = carService;
        }
        public IResult AddImageFile(int carId, IFormFile? file)
        {
            var result = BusinessRules.Run(
                CheckIsCar(carId),
                CheckCarHaveUpFivePictures(carId)
                );

            if (result != null)
                return result;

            var resultFile = _fileHelper.UploadImageFile(file);

            if (resultFile.Success)
            {
                _carImageDal.Add(new CarImage
                {
                    CarId = carId,
                    Date = DateTime.Now,
                    ImagePath = resultFile.Message
                });
                return new SuccessResult(Messages.Added);

            }
            else
                return new ErrorResult(resultFile.Message);

        }

        private IResult CheckIsCar(int carId)
        {
            var state = _carService.GetById(carId).Data is not null;
            return state ? new SuccessResult() : new ErrorResult(Messages.NotFoundCar );

        }
        private IResult CheckCarHaveUpFivePictures(int carId)
        {
            var state = _carImageDal.GetList(i => i.CarId == carId).Count <= 5;
            return state ? new SuccessResult() : new ErrorResult(Messages.MustCarFiveImage);

        }

    }
}
