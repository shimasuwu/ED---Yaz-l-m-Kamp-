using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3___Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            cal.Sum(4, 5); //9
            cal.Minus(4, 5); //-1
            cal.Multiply(4, 5); //20
            cal.Divide(10, 2); //5 

            Console.Read();
        }
    }
}
