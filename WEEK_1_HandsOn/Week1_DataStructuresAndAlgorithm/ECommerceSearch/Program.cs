using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"{ProductId} - {ProductName} ({Category})";
        }
    }

    class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Fashion"),
                new Product(3, "Phone", "Electronics"),
                new Product(4, "Shirt", "Fashion")
            };

            Console.WriteLine("Linear Search:");
            var found1 = LinearSearch(products, "Phone");
            if (found1 != null)
                Console.WriteLine(found1);
            else
                Console.WriteLine("Product not found");


            Console.WriteLine("\nBinary Search:");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToList();
            var found2 = BinarySearch(sortedProducts, "Phone");
            if (found2 != null)
                Console.WriteLine(found2);
            else
                Console.WriteLine("Product not found");



            Console.ReadLine(); 
        }

        public static Product LinearSearch(List<Product> products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName == targetName)
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(List<Product> products, string targetName)
        {
            int low = 0;
            int high = products.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return products[mid];
                }
                else if (comparison < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return null;
        }
    }
}
