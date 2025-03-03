using Task2.Model;

namespace Task2
{
    internal class Program
    {
        public static int Price { get; private set; }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 50000 },
                new Product { ProductID = 2, Name = "Phone", Category = "Electronics", Price = 30000 },
                new Product { ProductID = 3, Name = "Shoes", Category = "Fashion", Price = 2000 },
                new Product { ProductID = 4, Name = "T-Shirt", Category = "Fashion", Price = 800 }
            };
            var electronic = products.Where(p => p.Price > 1000);
            Console.WriteLine("Product which are above 1000");

            

            foreach (var product in electronic)
            {
                Console.WriteLine($"{product.Category} and {product.Price}");
            }
            Console.WriteLine("Most expensive price");
            var electronic1 = products.MaxBy(e => e.Price);

            Console.WriteLine($"Expensive product {electronic1.Price}");
    }

};
        
    }

