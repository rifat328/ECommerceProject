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
    public class UserRepository : IUserRepository
    {
        ECommerceDataContext _context;
        public UserRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool AddUser(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                user.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Where(u=>u.IsDeleted==false).ToList();
                
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public bool UpdateUser(User user)
        {
            _context.Users.Update(user);
            return _context.SaveChanges() > 0;
        }
    }
}
