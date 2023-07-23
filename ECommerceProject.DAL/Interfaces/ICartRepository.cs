using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface ICartRepository
    {
        List<Cart> GetAllCarts();
        Cart GetCartById(int cartId);
        bool AddCart(Cart cart);
        bool UpdateCart(Cart cart);
        bool DeleteCart(int cartId);
    }
}
