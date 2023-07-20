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
    public class WishlistItemRepository : IWishlistItemRepository
    {
        private readonly ECommerceDataContext _context;

        public WishlistItemRepository(ECommerceDataContext context)
        {
            _context = context;
        }

        public bool AddWishlistItem(WishlistItem wishlistItem)
        {
            _context.WishlistItems.Add(wishlistItem);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteWishlistItem(int wishlistItemId)
        {
            var wishlistItem = _context.WishlistItems.FirstOrDefault(w => w.WishlistItemId == wishlistItemId);
            if (wishlistItem != null)
            {
                _context.WishlistItems.Remove(wishlistItem);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<WishlistItem> GetAllWishlistItems()
        {
            return _context.WishlistItems
                .Include(wi => wi.Wishlist)
                    .ThenInclude(w => w.User)
                .Include(wi => wi.Product)
                .ToList();
        }

        public WishlistItem GetWishlistItemById(int wishlistItemId)
        {
            return _context.WishlistItems
            .Include(wi => wi.Wishlist)
            .ThenInclude(w => w.User)
            .Include(wi => wi.Product)
            .FirstOrDefault(wi => wi.WishlistItemId == wishlistItemId);
        }

        public bool UpdateWishlistItem(WishlistItem wishlistItem)
        {
            _context.WishlistItems.Update(wishlistItem);
            return _context.SaveChanges() > 0;
        }
    }
}
