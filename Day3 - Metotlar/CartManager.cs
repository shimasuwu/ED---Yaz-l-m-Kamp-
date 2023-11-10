using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3___Metotlar
{
    internal class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " added to the cart.");
        }

        public void Add2(string productName, string desc, double price, int stock)
        {
            Console.WriteLine(productName + " " + desc + " " + price);
        }
    }
}
