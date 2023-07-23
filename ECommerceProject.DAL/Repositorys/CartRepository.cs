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
    public class CartRepository : ICartRepository
    {
        ECommerceDataContext _context;
        public CartRepository(ECommerceDataContext DbContext)
        {
            _context = DbContext;
        }

        public bool AddCart(Cart carts)
        {
            _context.Carts.Add(carts);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteCart(int id)
        {
            var carts = _context.Carts.FirstOrDefault(c => c.CartId == id);
            if (carts != null)
            {
                _context.Carts.Remove(carts);
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public bool UpdateCart(Cart carts)
        {
            _context.Carts.Update(carts);
            return _context.SaveChanges() > 0;

        }

        public List<Cart> GetAllCarts()
        {
            // return _context.Carts.Include(c => c.User).ToList();
            return _context.Carts
                    .Include(c => c.User)         // Include the User entity
                    .Include(c => c.CartItems)    // Include the CartItems collection
                    .ToList();

        }

        public Cart GetCartById(int id)
        {
            var cart = _context.Carts.Where(c => c.CartId == id).FirstOrDefault();

            return cart;
        }
    }
}
