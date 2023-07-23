using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Foreign key for Order
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

        //        - OrderItemID(Primary Key)
        //- OrderID(Foreign Key referencing the Order Table)
        //- ProductID(Foreign Key referencing the Product Table)
        //- Quantity
        //- Price

    }
}
