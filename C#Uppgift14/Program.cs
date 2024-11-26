using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int Lenght = 5;


            int[] multipicationArray = new int[Lenght];



            Console.WriteLine($"multiplicaion Table for {num}:");
            for ( int i = 1; i <= 5; i++ )
            {
                Console.WriteLine( $"{num} x {i} = {num * i}");
            }



            Console.ReadLine();
        }
    }
}
