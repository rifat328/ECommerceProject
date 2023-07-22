using AutoMapper;
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
    }




}
}
