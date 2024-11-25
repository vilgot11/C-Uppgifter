using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;

            bool istrue = true;

            Console.WriteLine((num1 > num3) && (num2 < num4));
            Console.WriteLine((num1 < num3) || (num2 > num4));


            Console.WriteLine(num1 > num3);
            Console.WriteLine(num2 < num4);
            Console.WriteLine(num1 == num4);
            Console.WriteLine(num2 != num3);

            
            bool expression1 = true;
            bool expression2 = false;

            Console.WriteLine((expression1 && expression2));


            Console.ReadLine();

        }
    }
}
