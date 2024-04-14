using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(int carId, IFormFile? file);
        //IResult UpdateImageFile(CarImage carImage);
        //IResult DeleteImageFie(CarImage carImage);       
    }
}
