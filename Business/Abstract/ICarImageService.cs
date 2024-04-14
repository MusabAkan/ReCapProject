using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(int carId, IFormFile? file);
        IResult Delete(int id);  
        IResult Uptade(CarImage carImage, IFormFile? file );
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
    }
}
