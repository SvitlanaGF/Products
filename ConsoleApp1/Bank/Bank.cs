using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bank
{
    internal class Bank
    {
        public void StartEv()
        {
            Shop shop = new Shop();
            shop.OnShop += Shop_OnShop;
            shop.AddNewproduct();
        }

        private void Shop_OnShop(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
