using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_LINQ
{
    internal class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public ProductCategory() 
        {
        Products = new HashSet<Product>();
        }
        public ProductCategory(int productCategoryId, string name) : this()
        {   
            ProductCategoryId = productCategoryId;
            Name = name;
           
        }
    }
}
