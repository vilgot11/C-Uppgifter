using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift12
{
    internal class Program
    {
        private static string password2;

        static void Main(string[] args)
        {

            Console.WriteLine("write password");
            string password1 = Console.ReadLine();

            Console.WriteLine("write password again");
            string password2 = Console.ReadLine();




            if (password1.Length <= 5)
            {
                Console.WriteLine("Write pleas write longer password");
            }

            if (password2.Length <= 5)
            {
                Console.WriteLine("Write pleas write longer password");
            }


            if (password1 == null || password1 == "")
            {
                Console.WriteLine("pleas enter a Password");
            }

            if (password2 == null || password2 == "")
            {
                Console.WriteLine("pleas enter a Password");
            }






            if (password1 == password2)
            {
                Console.WriteLine("Password match");
            }
            else
            {
                Console.WriteLine("Password do not match");
            }


            Console.ReadLine();
        }
    }
}
