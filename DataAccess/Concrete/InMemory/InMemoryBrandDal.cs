using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new()
            {
                new (){BrandId = 1,  Description = "Ferrari", ModelYear = 2002 , ColorId = Entities.Enums.Color.Red, DailyPrice = 10000000},
                new (){BrandId = 2,  Description = "BMW", ModelYear = 1970 , ColorId = Entities.Enums.Color.Green, DailyPrice = 20000000},
                new (){BrandId = 3,  Description = "FIAT", ModelYear = 2010 , ColorId = Entities.Enums.Color.Yellow, DailyPrice = 30000000},
                new (){BrandId = 4,  Description = "Mercedes", ModelYear = 2005 , ColorId = Entities.Enums.Color.Blue, DailyPrice = 40000000}
            };

        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            var deletedEntity = _brands.SingleOrDefault(i => i.BrandId == brand.BrandId);
            if (deletedEntity != null)
                _brands.Remove(deletedEntity);

        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int brandId)
        {
            return _brands.SingleOrDefault(i => i.BrandId == brandId);
        }

        public void Update(Brand brand)
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
