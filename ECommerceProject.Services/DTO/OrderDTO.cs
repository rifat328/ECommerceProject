using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.DTO
{
    public class OrderDTO
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public ICollection<OrderItemDTO> OrderItems { get; set; }

        // // Navigation property for one-to-many relationship with OrderItem
        // 

        // // Foreign key for User
        //// public int UserId { get; set; }
        // public UserDTO User { get; set; }

        // public OrderDTO()
        // {
        //     OrderItems = new List<OrderItemDTO>();
        // }




        //        - OrderID(Primary Key)
        //- UserID(Foreign Key referencing the User Table)
        //- OrderDate
        //- TotalAmount
        //- ShippingAddress

    }
}
