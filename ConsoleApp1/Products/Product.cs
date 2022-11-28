using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    internal class Product
    {
        public string product { get; set; }
        public int price { get; set; }
        public Product(string product, int price)
        {
            this.product = product;
            this.price = price;
        }
    }
}
