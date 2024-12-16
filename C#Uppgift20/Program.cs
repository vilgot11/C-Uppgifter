using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift20
{
    internal class Program

    {
        class Circle
        {
            public double Radius { get; private set; }

            public Circle(double raidius)
            {
                Radius = raidius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
            public double CalculateCircumfrence()
            {
                return 2 * Math.PI * Radius * Radius;
            }

            class program
            {
                static void Main(string[] args)
                {
                    Circle circle = new Circle(1.5);

                    double area = circle.CalculateArea();

                    Console.WriteLine("Area of the circle is: " + area);

                    Console.ReadLine();
                }

            }



        }
        

    }
}
