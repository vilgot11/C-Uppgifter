using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);
             

            int LegalAge = 18;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult!: ");
            }
            else
            {
                Console.WriteLine("You are under the leagle age: ");
            }


            var name = "welcome john";

            Console.WriteLine(name);


            int Counter = 1;
            while (Counter <= 5)
            {
                Console.WriteLine($"Counter: {Counter}");
                Counter++;
                
            }


            switch (Counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    break;
                    
            }

          

            Console.ReadLine();





        }
    }
}
