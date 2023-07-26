using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using ECommerceProject.Service.DTO;
using ECommerceProject.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<ProductDTO>> GetAllProducts()
        {
            try
            {
                List<ProductDTO> products = _productService.GetAllProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while getting the products.");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProductById(int id)
        {
            try
            {
                ProductDTO product = _productService.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while getting the product.");
            }
        }

        [HttpPost]
        public ActionResult AddProduct(ProductDTO productDto)
        {
            try
            {
                _productService.AddProduct(productDto);
                return Ok("Product added successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while adding the product.");
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductDTO productDto)
        {
            try
            {
                if (id != productDto.ProductId)
                {
                    return BadRequest("Invalid product ID.");
                }

                _productService.UpdateProduct(productDto);
                return Ok("Product updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while updating the product.");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                _productService.DeleteProduct(id);
                return Ok("Product deleted successfully.");
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while deleting the product.");
            }
        } // for extra info about dto to domain conversion  https://youtu.be/e1hpjbClopA?t=6362
    }
}
