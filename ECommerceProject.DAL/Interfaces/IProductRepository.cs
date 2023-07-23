using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProduct(int id);
        bool Add(Product product);
        bool Edit(Product product);
        bool Delete(int id);
    }
}
