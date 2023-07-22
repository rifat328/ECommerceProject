using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Services
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Foreign key for Order
        public int OrderId { get; set; }
        public OrderDTO Order { get; set; }
        public ProductDTO Product { get; set; }

        //        - OrderItemID(Primary Key)
        //- OrderID(Foreign Key referencing the Order Table)
        //- ProductID(Foreign Key referencing the Product Table)
        //- Quantity
        //- Price

    }
}
