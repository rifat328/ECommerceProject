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
        public bool AddCartItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCartItem(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetAllCartItems()
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemById(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCartItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
