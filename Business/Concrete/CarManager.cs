using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _dal;
        public CarManager(ICarDal dal)
        {
            _dal = dal;
        }
        public IResult Add(Car brand)
        {
            if (brand.DailyPrice > 0)
            {
                _dal.Add(brand);
                return new SuccessResult();
            }
            else
                return new ErrorResult(Messages.MustGreaterThanZero);
        }
        public IResult Delete(Car brand)
        {
            _dal.Delete(brand);
            return new SuccessResult();
        }
        public IDataResult<List<Car>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Car>>(data);
        }
        public IDataResult<Car> GetById(int id)
        {
            var data = _dal.Get(i => i.Id == id);
            return new SuccessDataResult<Car>(data);
        }
        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            var data = _dal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailsDto>>(data);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var data = _dal.GetList(i => i.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(data);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var data = _dal.GetList(i => i.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(data);
        }
        public IResult Update(Car brand)
        {
            _dal.Update(brand);
            return new SuccessResult();
        }
    }
}
