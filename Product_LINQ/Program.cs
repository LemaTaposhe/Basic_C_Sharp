using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                    new Product { ProductId = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 5, Name = "LL Road Frame - Red, 60", ProductNumber = "FR-R38R-60", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 60, Weight = 1124.9, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 6, Name = "LL Road Frame - Red, 62", ProductNumber = "FR-R38R-62", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 62, Weight = 1133.98, ProductCategoryId = 18, ProductModelId = 9 },
                    new Product { ProductId = 7, Name = "ML Road Frame - Red, 44", ProductNumber = "FR-R72R-44", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 44, Weight = 1006.97, ProductCategoryId = 18, ProductModelId = 16 },
                    new Product { ProductId = 8, Name = "ML Road Frame - Red, 48", ProductNumber = "FR-R72R-48", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 48, Weight = 1025.11, ProductCategoryId = 18, ProductModelId = 16 },
                    new Product { ProductId = 9, Name = "ML Road Frame - Red, 52", ProductNumber = "FR-R72R-52", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 52, Weight = 1043.26, ProductCategoryId = 18, ProductModelId = 16 },
                    new Product { ProductId = 10, Name = "ML Road Frame - Red, 58", ProductNumber = "FR-R72R-58", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 58, Weight = 1070.47, ProductCategoryId = 18, ProductModelId = 16 },
                    new Product { ProductId = 11, Name = "ML Road Frame - Red, 60", ProductNumber = "FR-R72R-60", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 60, Weight = 1079.54, ProductCategoryId = 18, ProductModelId = 16 },
                    new Product { ProductId = 12, Name = "HL Mountain Frame - Silver, 44", ProductNumber = "FR-M94S-44", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 44, Weight = 1251.91, ProductCategoryId = 16, ProductModelId = 5 },
                    new Product { ProductId = 13, Name = "HL Mountain Frame - Silver, 48", ProductNumber = "FR-M94S-52", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 48, Weight = 1270.05, ProductCategoryId = 16, ProductModelId = 5 },
                    new Product { ProductId = 14, Name = "HL Mountain Frame - Black, 44", ProductNumber = "FR-M94B-44", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 44, Weight = 1251.91, ProductCategoryId = 16, ProductModelId = 5 },
                    new Product { ProductId = 15, Name = "HL Mountain Frame - Black, 48", ProductNumber = "FR-M94B-48", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 48, Weight = 1270.05, ProductCategoryId = 16, ProductModelId = 5 },
                    new Product { ProductId = 16, Name = "Road-150 Red, 62", ProductNumber = "BK-R93R-62", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 62, Weight = 6803.85, ProductCategoryId = 6, ProductModelId = 25 },
                    new Product { ProductId = 17, Name = "Road-150 Red, 44", ProductNumber = "BK-R93R-44", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 44, Weight = 6245.93, ProductCategoryId = 6, ProductModelId = 25 },
                    new Product { ProductId = 18, Name = "Road-150 Red, 48", ProductNumber = "BK-R93R-48", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 48, Weight = 6409.23, ProductCategoryId = 6, ProductModelId = 25 },
                    new Product { ProductId = 19, Name = "Road-150 Red, 52", ProductNumber = "BK-R93R-52", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 52, Weight = 6540.77, ProductCategoryId = 6, ProductModelId = 25 },
                    new Product { ProductId = 20, Name = "Road-150 Red, 56", ProductNumber = "BK-R93R-56", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 56, Weight = 6658.7, ProductCategoryId = 6, ProductModelId = 25 },
                    new Product { ProductId = 21, Name = "Road-450 Red, 58", ProductNumber = "BK-R68R-58", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 58, Weight = 8069.37, ProductCategoryId = 6, ProductModelId = 28 },
                    new Product { ProductId = 22, Name = "Road-450 Red, 60", ProductNumber = "BK-R68R-60", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 60, Weight = 8119.26, ProductCategoryId = 6, ProductModelId = 28 },
                    new Product { ProductId = 23, Name = "Road-450 Red, 44", ProductNumber = "BK-R68R-44", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 44, Weight = 7606.7, ProductCategoryId = 6, ProductModelId = 28 },
                    new Product { ProductId = 24, Name = "Road-450 Red, 48", ProductNumber = "BK-R68R-48", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 48, Weight = 7770, ProductCategoryId = 6, ProductModelId = 28 },
                    new Product { ProductId = 25, Name = "Road-450 Red, 52", ProductNumber = "BK-R68R-52", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 52, Weight = 7901.54, ProductCategoryId = 6, ProductModelId = 28 },
                    new Product { ProductId = 26, Name = "Road-650 Red, 58", ProductNumber = "BK-R50R-58", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 58, Weight = 8976.55, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 27, Name = "Road-650 Red, 60", ProductNumber = "BK-R50R-60", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 60, Weight = 9026.44, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 28, Name = "Road-650 Red, 62", ProductNumber = "BK-R50R-62", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 62, Weight = 9071.8, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 29, Name = "Road-650 Red, 44", ProductNumber = "BK-R50R-44", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 44, Weight = 8513.88, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 30, Name = "Road-650 Red, 48", ProductNumber = "BK-R50R-48", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 48, Weight = 8677.18, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 31, Name = "Road-650 Red, 52", ProductNumber = "BK-R50R-52", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 52, Weight = 8808.72, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 32, Name = "Road-650 Black, 58", ProductNumber = "BK-R50B-58", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 58, Weight = 8976.55, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 33, Name = "Road-650 Black, 60", ProductNumber = "BK-R50B-60", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 60, Weight = 9026.44, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 34, Name = "Road-650 Black, 62", ProductNumber = "BK-R50B-62", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 62, Weight = 9071.8, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 35, Name = "Road-650 Black, 44", ProductNumber = "BK-R50B-44", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 44, Weight = 8513.88, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 36, Name = "Road-650 Black, 48", ProductNumber = "BK-R50B-48", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 48, Weight = 8677.18, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 37, Name = "Road-650 Black, 52", ProductNumber = "BK-R50B-52", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 52, Weight = 8808.72, ProductCategoryId = 6, ProductModelId = 30 },
                    new Product { ProductId = 38, Name = "Mountain-100 Silver, 38", ProductNumber = "BK-M82S-38", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 38, Weight = 9230.56, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 39, Name = "Mountain-100 Silver, 42", ProductNumber = "BK-M82S-42", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 42, Weight = 9421.06, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 40, Name = "Mountain-100 Silver, 44", ProductNumber = "BK-M82S-44", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 44, Weight = 9584.36, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 41, Name = "Mountain-100 Silver, 48", ProductNumber = "BK-M82S-48", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 48, Weight = 9715.9, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 42, Name = "Mountain-100 Black, 38", ProductNumber = "BK-M82B-38", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 38, Weight = 9230.56, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 43, Name = "Mountain-100 Black, 42", ProductNumber = "BK-M82B-42", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 42, Weight = 9421.06, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 44, Name = "Mountain-100 Black, 44", ProductNumber = "BK-M82B-44", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 44, Weight = 9584.36, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 45, Name = "Mountain-100 Black, 48", ProductNumber = "BK-M82B-48", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 48, Weight = 9715.9, ProductCategoryId = 5, ProductModelId = 19 },
                    new Product { ProductId = 46, Name = "Mountain-300 Black, 38", ProductNumber = "BK-M47B-38", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 38, Weight = 11498.51, ProductCategoryId = 5, ProductModelId = 21 },
                    new Product { ProductId = 47, Name = "Mountain-300 Black, 40", ProductNumber = "BK-M47B-40", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 40, Weight = 11689.01, ProductCategoryId = 5, ProductModelId = 21 },
                    new Product { ProductId = 48, Name = "Mountain-300 Black, 44", ProductNumber = "BK-M47B-44", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 44, Weight = 11852.31, ProductCategoryId = 5, ProductModelId = 21 },
                    new Product { ProductId = 49, Name = "Mountain-300 Black, 48", ProductNumber = "BK-M47B-48", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 48, Weight = 11983.85, ProductCategoryId = 5, ProductModelId = 21 },
                    new Product { ProductId = 50, Name = "Road-250 Red, 44", ProductNumber = "BK-R89R-44", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 44, Weight = 6699.52, ProductCategoryId = 6, ProductModelId = 26 },
                    new Product { ProductId = 51, Name = "Road-250 Red, 48", ProductNumber = "BK-R89R-48", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 48, Weight = 6862.82, ProductCategoryId = 6, ProductModelId = 26 },
                    new Product { ProductId = 52, Name = "Road-250 Red, 52", ProductNumber = "BK-R89R-52", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 52, Weight = 6994.36, ProductCategoryId = 6, ProductModelId = 26 },
                    new Product { ProductId = 53, Name = "ML Mountain Frame - Black, 38", ProductNumber = "FR-M63B-38", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 38, Weight = 1238.3, ProductCategoryId = 16, ProductModelId = 15 },
                    new Product { ProductId = 54, Name = "ML Mountain Frame - Black, 40", ProductNumber = "FR-M63B-40", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 40, Weight = 1256.44, ProductCategoryId = 16, ProductModelId = 14 },
                    new Product { ProductId = 55, Name = "ML Mountain Frame - Black, 44", ProductNumber = "FR-M63B-44", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 44, Weight = 1274.59, ProductCategoryId = 16, ProductModelId = 14 },
                    new Product { ProductId = 56, Name = "ML Mountain Frame - Black, 48", ProductNumber = "FR-M63B-48", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 48, Weight = 1292.73, ProductCategoryId = 16, ProductModelId = 14 }
            };
            ProductCategory[] productCategories = new ProductCategory[]
             {
                    new ProductCategory { ProductCategoryId = 1, Name = "Bikes" },
                    new ProductCategory { ProductCategoryId = 2, Name = "Components" },
                    new ProductCategory { ProductCategoryId = 3, Name = "Clothing" },
                    new ProductCategory { ProductCategoryId = 4, Name = "Accessories" },
                    new ProductCategory { ProductCategoryId = 5, Name = "Mountain Bikes" },
                    new ProductCategory { ProductCategoryId = 6, Name = "Road Bikes" },
                    new ProductCategory { ProductCategoryId = 7, Name = "Touring Bikes" },
                    new ProductCategory { ProductCategoryId = 8, Name = "Handlebars" },
                    new ProductCategory { ProductCategoryId = 9, Name = "Bottom Brackets" },
                    new ProductCategory { ProductCategoryId = 10, Name = "Brakes" },
                    new ProductCategory { ProductCategoryId = 11, Name = "Chains" },
                    new ProductCategory { ProductCategoryId = 12, Name = "Cranksets" },
                    new ProductCategory { ProductCategoryId = 13, Name = "Derailleurs" },
                    new ProductCategory { ProductCategoryId = 14, Name = "Forks" },
                    new ProductCategory { ProductCategoryId = 15, Name = "Headsets" },
                    new ProductCategory { ProductCategoryId = 16, Name = "Mountain Frames" },
                    new ProductCategory { ProductCategoryId = 17, Name = "Pedals" },
                    new ProductCategory { ProductCategoryId = 18, Name = "Road Frames" },
                    new ProductCategory { ProductCategoryId = 19, Name = "Saddles" },
                    new ProductCategory { ProductCategoryId = 20, Name = "Touring Frames" },
                    new ProductCategory { ProductCategoryId = 21, Name = "Wheels" },
                    new ProductCategory { ProductCategoryId = 22, Name = "Bib-Shorts" },
                    new ProductCategory { ProductCategoryId = 23, Name = "Caps" },
                    new ProductCategory { ProductCategoryId = 24, Name = "Gloves" },
                    new ProductCategory { ProductCategoryId = 25, Name = "Jerseys" },
                    new ProductCategory { ProductCategoryId = 26, Name = "Shorts" },
                    new ProductCategory { ProductCategoryId = 27, Name = "Socks" },
                    new ProductCategory { ProductCategoryId = 28, Name = "Tights" },
                    new ProductCategory { ProductCategoryId = 29, Name = "Vests" },
                    new ProductCategory { ProductCategoryId = 30, Name = "Bike Racks" },
                    new ProductCategory { ProductCategoryId = 31, Name = "Bike Stands" },
                    new ProductCategory { ProductCategoryId = 32, Name = "Bottles and Cages" },
                    new ProductCategory { ProductCategoryId = 33, Name = "Cleaners" },
                    new ProductCategory { ProductCategoryId = 34, Name = "Fenders" },
                    new ProductCategory { ProductCategoryId = 35, Name = "Helmets" },
                    new ProductCategory { ProductCategoryId = 36, Name = "Hydration Packs" },
                    new ProductCategory { ProductCategoryId = 37, Name = "Lights" },
                    new ProductCategory { ProductCategoryId = 38, Name = "Locks" },
                    new ProductCategory { ProductCategoryId = 39, Name = "Panniers" },
                    new ProductCategory { ProductCategoryId = 40, Name = "Pumps" },
                    new ProductCategory { ProductCategoryId = 41, Name = "Tires and Tubes" }
             };
            ProductModel[] productModels = new ProductModel[]
            {
                new ProductModel { ProductModelId = 1, Name = "Classic Vest" },
                new ProductModel { ProductModelId = 2, Name = "Cycling Cap" },
                new ProductModel { ProductModelId = 3, Name = "Full-Finger Gloves" },
                new ProductModel { ProductModelId = 4, Name = "Half-Finger Gloves" },
                new ProductModel { ProductModelId = 5, Name = "HL Mountain Frame" },
                new ProductModel { ProductModelId = 6, Name = "HL Road Frame" },
                new ProductModel { ProductModelId = 7, Name = "HL Touring Frame" },
                new ProductModel { ProductModelId = 8, Name = "LL Mountain Frame" },
                new ProductModel { ProductModelId = 9, Name = "LL Road Frame" },
                new ProductModel { ProductModelId = 10, Name = "LL Touring Frame" },
                new ProductModel { ProductModelId = 11, Name = "Long-Sleeve Logo Jersey" },
                new ProductModel { ProductModelId = 12, Name = "Men's Bib-Shorts" },
                new ProductModel { ProductModelId = 13, Name = "Men's Sports Shorts" },
                new ProductModel { ProductModelId = 14, Name = "ML Mountain Frame" },
                new ProductModel { ProductModelId = 15, Name = "ML Mountain Frame-W" },
                new ProductModel { ProductModelId = 16, Name = "ML Road Frame" },
                new ProductModel { ProductModelId = 17, Name = "ML Road Frame-W" },
                new ProductModel { ProductModelId = 18, Name = "Mountain Bike Socks" },
                new ProductModel { ProductModelId = 19, Name = "Mountain-100" }
            };
            var result = products
                .Select(pd => new { pd.Name, pd.ProductNumber, pd.ListPrice, pd.Weight, pd.ProductCategoryId, pd.ProductModelId })
                .Join(productCategories, pr => pr.ProductCategoryId, pc => pc.ProductCategoryId, (pr, pc) => new { pr.Name, Category = pc.Name, pr.ProductNumber, pr.ListPrice, pr.Weight, pr.ProductModelId })
                .Join(productModels, prac => prac.ProductModelId, pm => pm.ProductModelId, (prac, pm) => new { prac.Name, prac.Category, Model = pm.Name, prac.ProductNumber, prac.ListPrice, prac.Weight })
                .OrderBy(ob => ob.Name)
                .ThenBy(tb => tb.Category)
                .ThenBy(tb => tb.Model);

            foreach (var row in result)
            {
                string prod = row.ToString();
                Console.WriteLine(prod.Replace("{ ", "").Replace(" }", ""));
            }
            Console.ReadLine();
        }
    }
}
