using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        ECommerceDataContext _DataContext;
        public ProductRepository(ECommerceDataContext DbContext) { 
            _DataContext = DbContext;
        }
        public bool Add(Product product)
        {
            _DataContext.Products.Add(product);
        }

        public bool Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
