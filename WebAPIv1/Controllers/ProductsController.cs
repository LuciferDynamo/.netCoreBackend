using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPIv1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled - Gevşek Bağımlılık
        //IoC Container - Inversion of control  || Bellek deki bir yer liste gibi ben oraya new Pm() , new EfPD()
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            Thread.Sleep(1000);

            var result = _productService.GetAll();

            if (result.Succes == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            var result = _productService.GetById(id);

            if(result.Succes == true)
            {
                Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getbycategory")]
        public IActionResult GetAllByCategoryId(int categoryId)
        {

            var result = _productService.GetAllByCategoryId(categoryId);

            if (result.Succes == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);

            if(result.Succes == true)
            {
               return Ok(result);
            }

            return BadRequest(result);

        }


    }
}