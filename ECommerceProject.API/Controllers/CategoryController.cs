using ECommerceProject.Service.DTO;
using ECommerceProject.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService=categoryService;
        }
        [HttpGet]
        public ActionResult <List<CategoryDTO>> GetAllCategories()
        {
            try
            {
                List<CategoryDTO> category = _categoryService.GetAllCategories();
                return Ok(category);
            }catch (Exception ex)
            {
                return StatusCode(500,"An error has occurred while getting the category");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetCategoryById(int id)
        {
            try
            {
                CategoryDTO category = _categoryService.GetCategoryById(id);
                if (category == null)
                {
                    return NotFound();
                }
                return Ok(category);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while getting the category.");
            }
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryDTO categoryDto)
        {
            try
            {
                _categoryService.AddCategory(categoryDto);
                return Ok("Category added successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while adding the Category.");
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, CategoryDTO categoryDto)
        {
            try
            {
                if (id != categoryDto.CategoryId)
                {
                    return BadRequest("Invalid product ID.");
                }

                _categoryService.UpdateCategory(categoryDto);
                return Ok("Product updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while updating the Category.");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                _categoryService.DeleteCategory(id);
                return Ok("Product deleted successfully.");
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate error response
                return StatusCode(500, "An error occurred while deleting the Category.");
            }
        }


    }
}
