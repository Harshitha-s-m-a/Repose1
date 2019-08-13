using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Div
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            displaydivide(a, b);
        }
        private static int divide(int a,int b,out int rem)
        {
            int q = a / b;
            rem = a % b;
            return q;
                

        }
        private static void displaydivide(int a,int b)
        {
            int rem;
            int res = divide(a, b, out rem);
            Console.WriteLine($"q={res}");
            Console.WriteLine($"rem={rem}");
        }
    }
}
