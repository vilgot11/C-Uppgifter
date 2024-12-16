using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift18
{
    internal class Program
    {


        
        static void Main(string[] args)
        {
           
        
        
            Console.WriteLine("Enter Widght: ");
            double Widght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            double area = (Widght * Height) / 2;

            Console.WriteLine($"The area of the triangle is {area}");

            Console.ReadLine();
        }
        
    }
        
        
    }

