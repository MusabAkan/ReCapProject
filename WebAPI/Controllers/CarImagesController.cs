using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers
{

    public class CarImagesController : BaseController
    {
        private readonly ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("addimagefile")]
        public IActionResult AddImageFile(int carCarId, IFormFile file)
        {
            var result = _carImageService.Add(carCarId, file);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);

        }
    }
}
