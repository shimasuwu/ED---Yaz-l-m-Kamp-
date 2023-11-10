using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Tablet",
                UnitPrice = 5000,
                UnitsInStock = 3
            };

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Tablet Kalemi",
                UnitPrice = 1500,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 4); //7
            int sonuc = productManager.Topla(3, 4); //7
            Console.WriteLine(sonuc*2);//14
            Console.WriteLine();


            Console.WriteLine("---------------------------------");

            Product[] productArray = new Product[] {product1, product2}; //product1  degiskenini icindeki degerler p1 dizisinini  0. indeksine, product2 degerleri ise 1. indeksine atandi.
            Console.WriteLine(productArray[0].ProductName + " : " + productArray[0].UnitPrice, productArray[1].ProductName + " : " + productArray[1].UnitPrice); //yalnizca sifirinci indeksteki degerler yazilir.


            Console.WriteLine("\n-------foreach ile array'in butun indekslerine ait verileri yazdirma-----");

            foreach (Product p in productArray)
            {
                Console.WriteLine(p.ProductName+ " "+ p.UnitPrice); 
            }


            Console.Read();
        }
    }
}
