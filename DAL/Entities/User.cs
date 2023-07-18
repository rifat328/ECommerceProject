using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } ////   - Password(hashed and salted)
        public string UserType { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property for one-to-one relationship with Cart (optional)
        public Cart Cart { get; set; }
        // Navigation property for one-to-many relationship with Order
        public ICollection<Order> Orders { get; set; }

        // Navigation property for one-to-many relationship with Review
        public ICollection<Review> Reviews { get; set; }

        // Navigation property for one-to-many relationship with Wishlist
        public ICollection<Wishlist> Wishlists { get; set; }


    }
}
