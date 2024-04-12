using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorRepository : EfEntityRepositoryBase<Color, RecapContext>, IColorDal
    {

    }
}
