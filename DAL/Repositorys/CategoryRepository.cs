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
    public class CategoryRepository : ICategoryRepository
    {
        ECommerceDataContext _context;
        public CategoryRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool Add(Category category)
        {
            _context.Categorys.Add(category);
            return _context.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
           var Category= _context.Categorys.FirstOrDefault(c=>c.CategoryId==id);
            if (Category != null)
            {
                Category.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public bool Edit(Category category)
        {
            _context.Categorys.Update(category);
            return _context.SaveChanges()>0;
        }

        public List<Category> GetAll()
        {
            return _context.Categorys.Where(c=>!c.IsDeleted).ToList();
        }

        public Category GetCategory(int id)
        {
            var category=_context.Categorys.Where(c=>c.CategoryId == id).FirstOrDefault();
            return category;
        }
    }
}
