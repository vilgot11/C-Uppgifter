﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Counter = 1;
            while (Counter <= 5)
            {
                Console.WriteLine(Counter + 1);
                Counter++;
                
            }

            Console.WriteLine("loop Finished");
            Console.ReadLine();



        } 
           
        }
    }

