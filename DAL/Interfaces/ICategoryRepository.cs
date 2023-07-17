using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetCategory(int id);
        bool Add(Category category);
        bool Edit(Category category);
        bool Delete(int id);
    }
}
