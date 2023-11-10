using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[3]); //halil

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; //icerisine girildigi miktarlarda veri alabilir ve bu  veriler programin ileriki asamalarinda Add metodu  ile genisletilip listeye yeni elemanlar eklenebilir.
            Console.WriteLine(isimler2[0]);
            isimler2.Add("Hayri");
            Console.WriteLine(isimler2[4]); //var olan listeye yeni bir veri atandi.

            Console.Read();
        }
    }
}

