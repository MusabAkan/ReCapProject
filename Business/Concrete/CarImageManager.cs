using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Constants;
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
        public IResult Add(int carId, IFormFile? file)
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
        public IResult Delete(int id)
        {
            var exists = _carImageDal.Get(i => i.Id == id);
            if (exists != null)
            {
                _fileHelper.DeleteImageFile(exists.ImagePath);
                _carImageDal.Delete(exists);
                return new SuccessResult(Messages.Deleted);
            }
            else
                return new ErrorResult(Messages.NotFoundCar);
        }
        public IResult Uptade(CarImage carImage, IFormFile? file)
        {
            var exists = _carImageDal.Get(i => i.Id == carImage.Id);
            if (exists != null)
            {
                if (file != null)
                {
                    _fileHelper.DeleteImageFile(carImage.ImagePath);
                    var resultFile = _fileHelper.UploadImageFile(file);

                    if (!resultFile.Success)
                        return new ErrorResult(Messages.ImageNotUpload);
                }
                exists.Date = DateTime.Now; 
                _carImageDal.Update(exists);
                return new SuccessResult(Messages.ImageUpdated);
            }
            return new ErrorResult(Messages.NotFoundCar);
        }
        public IDataResult<CarImage> GetById(int id)
        {
            var data = _carImageDal.Get(i => i.Id == id);
            if (data != null)
                return new SuccessDataResult<CarImage>(data);
            return new ErrorDataResult<CarImage>();
        }
        public IDataResult<List<CarImage>> GetAll()
        {
            var data = _carImageDal.GetList();
            if (data != null)
                return new SuccessDataResult<List<CarImage>>(data);
            return new ErrorDataResult<List<CarImage>>();
        }
        private IResult CheckIsCar(int carId)
        {
            var state = _carService.GetById(carId).Data is not null;
            return state ? new SuccessResult() : new ErrorResult(Messages.NotFoundCar);
        }
        private IResult CheckCarHaveUpFivePictures(int carId)
        {
            var state = _carImageDal.GetList(i => i.CarId == carId).Count <= 5;
            return state ? new SuccessResult() : new ErrorResult(Messages.MustCarFiveImage);

        }


    }
}
