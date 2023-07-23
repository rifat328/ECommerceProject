using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Order
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public bool IsShipped { get; set; }


        // Navigation property for one-to-many relationship with OrderItem
        public ICollection<OrderItem> OrderItems { get; set; }

        // Foreign key for User
       // public int UserId { get; set; }
        public User User { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }




        //        - OrderID(Primary Key)
        //- UserID(Foreign Key referencing the User Table)
        //- OrderDate
        //- TotalAmount
        //- ShippingAddress

    }
}
