using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface ICartItemRepository
    {
        List<CartItem> GetAllCartItems();
        CartItem GetCartItemById(int cartItemId);
        bool AddCartItem(CartItem cartItem);
        bool UpdateCartItem(CartItem cartItem);
        bool DeleteCartItem(int cartItemId);
    }
}
