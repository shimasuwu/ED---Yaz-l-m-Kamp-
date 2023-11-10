using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Elma";
            p1.Description = "Eksi ve sulu yesil elma";
            p1.price = 20.99;

            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "Armut";
            p2.Description = "sulu sulu bahceden taze armut";
            p2.price = 25.99;

            Product[] products = new Product[] {p1, p2 }; //Product tipinden olan dizi, icerisine Product tipinden almis oludugu veri kaynaklarini tutar.

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " (" + item.Description + ")" + " : " + item.price + "TL");
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------------------Metotlar--------------------");
            
            CartManager cm = new CartManager();
            cm.Add(p1);
            cm.Add(p2);

            Console.WriteLine("");
            
            //Encapsulation
            cm.Add2("Portakal", "C Vitamini Yenur", 15.99, 5);


            Console.ReadLine();
        }
    }
}
