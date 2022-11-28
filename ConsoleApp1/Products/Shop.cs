
namespace ConsoleApp1.Products
{
    internal class Shop
    {
        public List<string> products;
        public event Action<string> OnShop;
        public void AddNewproduct()
        {

            OnShop("Abc");

        }
    }
}
