using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_LINQ
{
    internal class ProductModel
    {
        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }

        public ProductModel(int productModelId, string name) : this()
        {
            ProductModelId = productModelId;
            Name = name;
        }
    }
}

