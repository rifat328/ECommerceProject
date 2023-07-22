using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Stock
    {
        
        public int StockID { get; set; }
       public int ProductID { get; set; }
        public int? Quantity { get; set; }
        public string? Location { get; set; }
        public int? MinStockLevel { get; set; }

        // Foreign key for Product (optional)
      
        public Product Product { get; set; } // not sure

        //- ProductID(Foreign Key referencing the Product Table)
        //- Quantity
        //- Location
        //- MinStockLevel

    }
}
