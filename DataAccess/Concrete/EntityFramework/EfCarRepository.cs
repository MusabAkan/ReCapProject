using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarRepository : EfEntityRepositoryBase<Car, MasterContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (var context = new MasterContext())
            {
                var result = from cr in context.Cars
                             join b in context.Brands on cr.BrandId equals b.Id
                             join c in context.Colors on cr.ColorId equals c.Id
                             select new CarDetailsDto { BrandName = b.Name, CarName = cr.Description, ColorName = c.Name, DailyPrice = cr.DailyPrice };
                return result.ToList();
            }
        }
    }
}
