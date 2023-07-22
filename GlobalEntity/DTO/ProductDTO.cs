using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }

        // Navigation property for one-to-one relationship with Stock
        public StockDTO Stock { get; set; }



    }
}
