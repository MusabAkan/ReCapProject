using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : ICarDal
    {
        List<Car> _brands;

        public InMemoryBrandDal()
        {
            _brands = new()
            {
                //new (){BrandId = 1,  Description = "Ferrari", ModelYear = 2002 , ColorId = Entities.Enums.Color.Red, DailyPrice = 10000000},
                //new (){BrandId = 2,  Description = "BMW", ModelYear = 1970 , ColorId = Entities.Enums.Color.Green, DailyPrice = 20000000},
                //new (){BrandId = 3,  Description = "FIAT", ModelYear = 2010 , ColorId = Entities.Enums.Color.Yellow, DailyPrice = 30000000},
                //new (){BrandId = 4,  Description = "Mercedes", ModelYear = 2005 , ColorId = Entities.Enums.Color.Blue, DailyPrice = 40000000}
            };

        }

        public void Add(Car brand)
        {
            _brands.Add(brand);
        }

        public List<CarDetailsDto> CarDetails()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car brand)
        {
            var deletedEntity = _brands.SingleOrDefault(i => i.BrandId == brand.BrandId);
            if (deletedEntity != null)
                _brands.Remove(deletedEntity);

        }

        public Car Get(Expression<Func<Car, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _brands;
        }

        public Car GetById(int brandId)
        {
            return _brands.SingleOrDefault(i => i.BrandId == brandId);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetList(Expression<Func<Car, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car brand)
        {
            var updatedEntity = _brands.SingleOrDefault(i => i.BrandId == brand.BrandId);

            updatedEntity.DailyPrice = brand.DailyPrice;
            updatedEntity.ModelYear = brand.ModelYear;
            updatedEntity.ColorId = brand.ColorId;
            updatedEntity.Description = brand.Description;
            updatedEntity.ModelYear = brand.ModelYear;

        }
    }
}
