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
        public Dictionary<int, double> BankAccounts = new Dictionary<int, double>();
        public void CustomerWantsBuy(Customer.Customer customer)
        {
            customer.AddProduct += Customer_AddProduct;
            var prodInfoFromCustomer = customer.AddProdEvent().FirstOrDefault();

            if (BankAccounts.Keys.Contains(customer.BankAccount) && BankAccounts[customer.BankAccount] >= prodInfoFromCustomer.Value.price)
            {
                BankAccounts[customer.BankAccount] -= prodInfoFromCustomer.Value.price;
                customer.AddProd(prodInfoFromCustomer.Value);
            }
            else if(BankAccounts[customer.BankAccount] <= prodInfoFromCustomer.Value.price)
            {
                Console.WriteLine($"{customer.Name} doesn`t have enough money");
            }else if(BankAccounts.Keys.Contains(customer.BankAccount) == false)
            {
                Console.WriteLine($"User {customer.Name} doesn`t exist in the bank");
            }
            Console.WriteLine("Am I a joke for you?");
        }

        private void Customer_AddProduct(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
