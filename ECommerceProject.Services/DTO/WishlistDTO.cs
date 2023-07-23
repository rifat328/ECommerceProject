using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.DTO
{
    public class WishlistDTO
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Foreign key for User
        // public int UserId { get; set; }
        public UserDTO User { get; set; }

        // Navigation property for one-to-many relationship with WishlistItem
        public ICollection<WishlistItemDTO> WishlistItems { get; set; }



        //        10. Wishlist Table:
        //    - WishlistID(Primary Key)
        //    - UserID(Foreign Key referencing the User Table)
        //    - CreatedAt




    }
}
