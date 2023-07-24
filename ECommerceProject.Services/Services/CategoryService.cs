using AutoMapper;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using ECommerceProject.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IProductRepository productRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<CategoryDTO> GetAllCategories()
        {
            List<Category> categories = _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDTO>>(categories);
        }

        public CategoryDTO GetCategoryById(int id)
        {
            Category category = _categoryRepository.GetCategory(id);
            return _mapper.Map<CategoryDTO>(category);
        }

        public void AddCategory(CategoryDTO categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            _categoryRepository.Add(category);
        }

        public void UpdateCategory(CategoryDTO categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            _categoryRepository.Edit(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<ProductDTO> GetProductsByCategory(int categoryId)
        {
            List<Product> products = _productRepository.GetProductsByCategoryId(categoryId);
            return _mapper.Map<List<ProductDTO>>(products);
        }




    }
}
