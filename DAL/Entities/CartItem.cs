using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantiry { get; set; }
        public decimal Price { get; set; }

        // Foreign key for Cart
        public int CartId { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }

    }
}
