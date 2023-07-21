using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [ResponseCache(Duration = 10)]
        [HttpGet]
        public IActionResult GetAll()
        {
            var Products = _productRepository.GetAll();
            return Ok(Products);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var Products = _productRepository.GetProduct(id);
            return Ok(Products);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            try
            {
                bool isSaved = _productRepository.Add(product);
                if (isSaved)
                {
                    return Ok("Product has been saved.");
                }
                return BadRequest("Product saved failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Product product)
        {
            try
            {
                bool isUpdated = _productRepository.Edit(product);
                if (isUpdated)
                {
                    return Ok("Product has been modified.");
                }
                return BadRequest("Product modified failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                bool isDeleted = _productRepository.Delete(id);
                if (isDeleted)
                {
                    return Ok("Product has been deleted.");
                }
                return BadRequest("Product deleted failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
