

using ConsoleApp1.Products;

namespace ConsoleApp1.Customer
{
    internal class Customer
    {
        public string Name { get; set; }
        public Shop shop { get; set; }
        public int BankAccount { get; set; }
        List<Product> products { get; set; }
        public event Action<string> AddProduct;
        public Customer(string name, int bankAccount, Shop shop)
        {
            Name = name;
            BankAccount = bankAccount;
            this.shop = shop;
        }

        public Dictionary<int, Product> AddProdEvent()
        {
            shop.AllProducts();
            Console.WriteLine("Do you want to buy something?");
            var answer = Console.ReadLine();
            if(answer.ToLower() == "yes")
            {
                Console.WriteLine("Input number of a product:");
                int prod = Convert.ToInt32(Console.ReadLine());
                if(shop.products.Keys.Contains(prod))
                {
                    Dictionary<int, Product> dictn = new Dictionary<int, Product>();
                    AddProduct($"The customer {Name} wants to buy {shop.products[prod].product} with price {shop.products[prod].price}");
                    dictn.Add(BankAccount, shop.products[prod]);
                    return dictn;
                }
            }
            else if(answer.ToLower() == "no")
            {
                Console.WriteLine("Ok(");
                return new Dictionary<int, Product>();
            }
            Console.WriteLine("Am I a joke for you?");
            return new Dictionary<int, Product>();

        }
        public void AddProd(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.product} was added for {Name}");
        }
        public void NewProdInShop()
        {
            shop.NewProduct += Shop_NewProduct;
        }

        private void Shop_NewProduct(string obj)
        {
            Console.WriteLine(obj);
        }

    }
}
