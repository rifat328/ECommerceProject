using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageURL { get; set; }=string.Empty; 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation property for one-to-one relationship with Stock
        public Stock Stock { get; set; }



    }
}
