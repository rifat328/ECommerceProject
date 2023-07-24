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
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductDTO> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAll();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public ProductDTO GetProductById(int id)
        {
            Product product = _productRepository.GetProduct(id);
            return _mapper.Map<ProductDTO>(product);
        }

        // Implement other business logic operations here (Add, Edit, Delete, etc.)
        public void AddProduct(ProductDTO productDto)
        {
            if (string.IsNullOrEmpty(productDto.Name))
            {
                throw new ArgumentException("Product name cannot be empty.");
            }

            // Map the ProductDTO to the Product entity
            Product product = _mapper.Map<Product>(productDto);

            // Set the created date
            product.CreatedDate = DateTime.Now;

            // Call the repository method to add the product
            _productRepository.Add(product);
        }

        public void UpdateProduct(ProductDTO productDto)
        {
            // Input validation: Ensure the product name is not empty
            if (string.IsNullOrEmpty(productDto.Name))
            {
                throw new ArgumentException("Product name cannot be empty.");
            }

            // Map the ProductDTO to the Product entity
            Product product = _mapper.Map<Product>(productDto);

            // Get the existing product from the database
            Product existingProduct = _productRepository.GetProduct(product.ProductId);
            if (existingProduct == null)
            {
                throw new ArgumentException("Product not found.");
            }

            // Set the updated date
            product.UpdatedDate = DateTime.Now;

            // Update only the properties that are allowed to be updated
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Company = product.Company;
            existingProduct.Price = product.Price;
            existingProduct.ImageURL = product.ImageURL;
            existingProduct.CategoryId = product.CategoryId;

            // Call the repository method to update the product
            _productRepository.Edit(existingProduct);
        }

        public void DeleteProduct(int productId)
        {
            // Get the existing product from the database
            Product existingProduct = _productRepository.GetProduct(productId);
            if (existingProduct == null)
            {
                throw new ArgumentException("Product not found.");
            }
            // Call the repository method to delete the product
            _productRepository.Delete(productId);
        }
    }




}

