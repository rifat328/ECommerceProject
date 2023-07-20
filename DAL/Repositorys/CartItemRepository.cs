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
    public class CartItemRepository : ICartItemRepository
    {
        private readonly ECommerceDataContext _dbContext;

        public CartItemRepository(ECommerceDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCartItem(CartItem cartItem)
        {
            try
            {
                _dbContext.CartItems.Add(cartItem);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCartItem(int cartItemId)
        {
            try
            {
                var cartItem = _dbContext.CartItems.Find(cartItemId);
                if (cartItem != null)
                {
                    _dbContext.CartItems.Remove(cartItem);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CartItem> GetAllCartItems()
        {
            return _dbContext.CartItems.ToList();
        }

        public CartItem GetCartItemById(int cartItemId)
        {
            return _dbContext.CartItems.FirstOrDefault(ci => ci.CartItemId == cartItemId);
        }

        public bool UpdateCartItem(CartItem cartItem)
        {
            try
            {
                _dbContext.CartItems.Update(cartItem);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
