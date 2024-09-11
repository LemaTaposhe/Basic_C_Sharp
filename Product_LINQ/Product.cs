using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_LINQ
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }


        public int ProductModelId { get; set; }
        public int ProductCategoryId { get; set; }


        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        public Product()
        {

        }
        public Product(int productId, string name, string productNumber, string color, double standardCost, double listPrice, int size, double weight, int productModelId, int productCategoryId)
        {
            ProductId = productId;
            Name = name;
            ProductNumber = productNumber;
            Color = color;
            StandardCost = standardCost;
            ListPrice = listPrice;
            Weight = weight;
            Size = size;
            ProductModelId = productModelId;
            ProductCategoryId = productCategoryId;
        }
    }
}
