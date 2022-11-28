
namespace ConsoleApp1.Products
{
    internal class Shop
    {
        public Dictionary<int, Product> products { get; set; }
        public event Action<string> NewProduct ;
        
        public void AddNewproduct(Product product)
        {

            products.Add(products.Count()+1, product);
            
            NewProduct($"We have added {product.product} with price {product.price}");

        }
        public void AllProducts()
        {
            Console.WriteLine("All products in a shop:");
            foreach(var product in products)
            {
                Console.WriteLine($"[{product.Key}] -- Product: {product.Value.product} -- Price: {product.Value.price}");
            }
        }
    }
}
