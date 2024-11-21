using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a gread: ");
            int gread = Convert.ToInt32(Console.ReadLine());


            switch (gread)
            {
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 2:
                    Console.WriteLine("ok");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
            }
            Console.ReadLine();
            }
    }
}
