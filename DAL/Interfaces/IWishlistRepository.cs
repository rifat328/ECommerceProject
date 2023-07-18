using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IWishlistRepository
    {
        List<Wishlist> GetAllWishlists();
        Wishlist GetWishlistById(int wishlistId);
        bool AddWishlist(Wishlist wishlist);
        bool UpdateWishlist(Wishlist wishlist);
        bool DeleteWishlist(int wishlistId);

    }
}
