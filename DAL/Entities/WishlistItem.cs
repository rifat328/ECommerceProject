using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class WishlistItem
    {
        public int WishlistItemId { get; set; }
        public int WishlistId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}

        //11. WishlistItem Table:
        //    - WishlistItemID(Primary Key)
        //    - WishlistID(Foreign Key referencing the Wishlist Table)
        //    - ProductID(Foreign Key referencing the Product Table)
        //    - CreatedAt
    }
}
