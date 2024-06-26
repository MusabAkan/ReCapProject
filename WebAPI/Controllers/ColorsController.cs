﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;
namespace WebAPI.Controllers
{
    public class ColorsController : BaseController
    {
        private readonly IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _colorService.GetById(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
