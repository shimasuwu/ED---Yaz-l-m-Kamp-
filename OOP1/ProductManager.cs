using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager //product class'i  ile ilgili yurtulecek olan islemlerin (metotlarin) barinacagi class.
    {
        //Encapsulation
        public void Add(Product product) //disaridan Product tipinden veri alimi gerceklesecek.
        {
            Console.WriteLine(product.ProductName + " Added.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Updated.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " Deleted.");
        }

        public int Topla(int num1, int num2) 
        {
            return num1 + num2;
        }
        public void Topla2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
