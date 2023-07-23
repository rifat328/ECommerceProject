using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.DTO
{
    public class StockDTO
    {
        
        public int StockID { get; set; }
       public int ProductID { get; set; }
        public int? Quantity { get; set; }
        public string? Location { get; set; }
        public int? MinStockLevel { get; set; }



        // Foreign key for Product (optional)
        public ProductDTO Product { get; set; }

    }
}
