using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Pleas enter message C# is fun I am going to coad C# tomorrow ");
            var message = Console.ReadLine();

            char[] messageArrey = message.ToCharArray();
            Array.Reverse(messageArrey);


            Console.WriteLine(new string(message.Reverse().ToArray()));






            foreach (char letter in messageArrey)
                Console.WriteLine(letter);





            foreach (char c in messageArrey) 
                Console.WriteLine(c);





            Console.ReadLine();


        }
    }
}
