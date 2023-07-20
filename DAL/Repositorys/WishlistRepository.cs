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
    public class WishlistRepository : IWishlistRepository
    {
        ECommerceDataContext _context;
        public WishlistRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool AddWishlist(Wishlist wishlist)
        {
            _context.Wishlists.Add(wishlist);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteWishlist(int wishlistId)
        {
            var wishlist = _context.Wishlists.FirstOrDefault(w => w.WishlistId == wishlistId);
            if (wishlist != null)
            {
                _context.Wishlists.Remove(wishlist);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<Wishlist> GetAllWishlists()
        {
            return _context.Wishlists
                    .Include(w => w.User)
                    .ToList();

        }

        public Wishlist GetWishlistById(int wishlistId)
        {
            return _context.Wishlists.FirstOrDefault(w => w.WishlistId == wishlistId);
        }

        public bool UpdateWishlist(Wishlist wishlist)
        {
            _context.Wishlists.Update(wishlist);
            return _context.SaveChanges() > 0;
        }
    }
}
