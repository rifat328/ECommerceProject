using ECommerceProject.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Services
{
    public class CartItemDTO
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantiry { get; set; }
        public decimal Price { get; set; }

        // Foreign key for Cart
        public int CartId { get; set; }
        public ProductDTO Product { get; set; }
        public CartDTO Cart { get; set; }

    }
}
