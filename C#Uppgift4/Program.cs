using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int age = 17;


            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote!: ");
            }
                else
            {
                Console.WriteLine("Not Eligible to vote: ");
            }

            Console.ReadLine();
        }
    }
}
