using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IWishlistItemRepository
    {
        List<WishlistItem> GetAllWishlistItems();
        WishlistItem GetWishlistItemById(int wishlistItemId);
        bool AddWishlistItem(WishlistItem wishlistItem);
        bool UpdateWishlistItem(WishlistItem wishlistItem);
        bool DeleteWishlistItem(int wishlistItemId);
    }
}
