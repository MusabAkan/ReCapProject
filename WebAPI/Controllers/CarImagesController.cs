using Business.Abstract;
using Entities.Concrete;
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
        [HttpPost("deleteimagefile")]
        public IActionResult DeleteImageFile([FromRoute] int id)
        {
            var result = _carImageService.Delete(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut("uptadeimagefile")]
        public IActionResult UpdateImageFile([FromBody] CarImage? carImage, IFormFile? file)
        {
            var result = _carImageService.Uptade(carImage, file);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("addimagefile")]
        public IActionResult AddImageFile([FromBody] int carCarId, IFormFile file)
        {
            var result = _carImageService.Add(carCarId, file);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById([FromRoute]int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
