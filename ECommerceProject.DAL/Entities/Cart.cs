﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        //Navigational Property.
        public ICollection<CartItem> CartItems { get; set; }
        // Foreign key for User
        //public int UserId { get; set; }
        public User User { get; set; }

        //        - CartID(Primary Key)
        //- UserID(Foreign Key referencing the User Table)
        //- CreatedAt

    }
}
