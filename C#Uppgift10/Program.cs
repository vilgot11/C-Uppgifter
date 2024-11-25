using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num5 / num6);

            Console.WriteLine(++num6);
            Console.WriteLine(--num6);

            Console.WriteLine(num5 += 5);
            Console.WriteLine(num5 -= 5);
            Console.WriteLine(num5 *= 5);
            Console.WriteLine(num5 /= 5);
            Console.WriteLine(num5 %= 5);

            Console.ReadLine();
        }
    }
}
