using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOS;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
    }
}
