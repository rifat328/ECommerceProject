using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Services
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property for one-to-many relationship with Product
        public ICollection<ProductDTO> Products { get; set; }

        public CategoryDTO()
        {
            Products = new List<ProductDTO>();
        }

    }
}
