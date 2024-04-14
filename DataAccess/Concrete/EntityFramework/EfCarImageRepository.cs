using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageRepository : EfEntityRepositoryBase<CarImage, RecapContext>, ICarImageDal
    {
    }
}
