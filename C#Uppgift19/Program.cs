using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift19
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            int sum = SumOfNumbers(numbers);

            Console.WriteLine("Totale is " + sum);

            Console.WriteLine("Array lenght " + numbers.Length);

            if (numbers.Length > 0 )
            {
                if(sum > -1)
                {
                    Console.WriteLine("The total is " + sum);
                }
                else
                {
                    Console.WriteLine("Cannot add upp an array with negative value");
                }
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            

            Console.ReadLine();


            }
        static int SumOfNumbers(int[] array)
        { 
            int sum = 0;
            foreach (int num in array)
            { 
                sum += num;
            }
            return sum;
        }
    }

}
