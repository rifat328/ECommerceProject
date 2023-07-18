using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Wishlist
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Foreign key for User
        // public int UserId { get; set; }
        public User User { get; set; }

        // Navigation property for one-to-many relationship with WishlistItem
        public ICollection<WishlistItem> WishlistItems { get; set; }



        //        10. Wishlist Table:
        //    - WishlistID(Primary Key)
        //    - UserID(Foreign Key referencing the User Table)
        //    - CreatedAt




    }
}
