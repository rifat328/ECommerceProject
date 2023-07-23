using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property for one-to-many relationship with Product
        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }

    }
}
