using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int num1 = 10;
            int num2 = 30;

            num1 = num2;//num1 = 30
            num2 = 60;

            Console.WriteLine(num1); //30

            //Reference Type
            int[] nums1 = new int[] { 10, 20, 30 };
            int[] nums2 = new int[] { 100, 200, 300 };

            nums1 = nums2; // nums1'in ram'de isaret ettigi alan ile nums2'nin isaret ettigi alan eslesti ve garbage collector nums1'in ram'deki alanini sildi.
            nums2[0] = 1000;

            Console.WriteLine(nums1[0]); //1000


            Console.Read();
        }
    }
}
