using Entities.Concrete;
using Entities.DTOS;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car brand);
        void Update(Car brand);
        void Delete(Car brand);
        List<CarDetailsDto> GetCarDetails();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
    }
}
