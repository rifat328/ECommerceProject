﻿using ECommerceProject.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Services
{
    public class ReviewDTO
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}

        // Foreign keys for User and Product
        // public int UserId { get; set; }
        public UserDTO User { get; set; }

       //  public int ProductId { get; set; }
        public ProductDTO Product { get; set; }

        //        - ReviewID(Primary Key)
        //- ProductID(Foreign Key referencing the Product Table)
        //- UserID(Foreign Key referencing the User Table)
        //- Rating
        //- Comment
        //- CreatedAt

    }
}
