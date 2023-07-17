using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        ECommerceDataContext _context;
        public ProductRepository(ECommerceDataContext DbContext) { 
            _context = DbContext;
        }

        public bool Add(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product != null)
            {
                product.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public bool Edit(Product product)
        {
           _context.Products.Update(product);
            return _context.SaveChanges()>0;
            
        }

        public List<Product> GetAll()
        {
           return _context.Products.Include(c=>c.Category).ToList();
            
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.Where(p => p.ProductId == id).FirstOrDefault();

            return product;
        }
    }
}
