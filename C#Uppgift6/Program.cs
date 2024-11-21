using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of loops? ");
            string message = Console.ReadLine();

            Console.Write("How many repeats?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());



                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }

            Console.WriteLine("loop done");

                Console.ReadLine();


            }
    }
}
