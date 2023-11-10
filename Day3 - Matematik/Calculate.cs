using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3___Matematik
{
    internal class Calculate
    {
        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result) ;
        }

        public void Minus(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        public void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
