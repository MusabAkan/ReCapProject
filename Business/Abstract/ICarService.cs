using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOS;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car brand);
        IResult Update(Car brand);
        IResult Delete(Car brand);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
    }
}
