using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even: " + number);
            }
            else
            {
                Console.WriteLine("Number is odd: " + number);
            }

            Console.ReadLine();
        }
    }
}
