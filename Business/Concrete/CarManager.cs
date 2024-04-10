using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _dal;
        public CarManager(ICarDal dal)
        {
            _dal = dal;
        }
        public void Add(Car brand)
        {
            if (brand.DailyPrice > 0)
                _dal.Add(brand);
            else
                throw new Exception("Araba günlük fiyatı 0'dan büyük olmalıdır.");
        }

        public void Delete(Car brand)
        {
            _dal.Delete(brand);
        }
        public List<Car> GetAll()
        {
            return _dal.GetList();
        }

        public Car GetById(int id)
        {
            return _dal.Get(i => i.Id == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _dal.GetList(i => i.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _dal.GetList(i => i.ColorId == colorId);
        }

        public void Update(Car brand)
        {
            _dal.Update(brand);
        }
    }
}
