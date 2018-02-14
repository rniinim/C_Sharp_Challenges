using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, imaginary;
            Console.WriteLine("\n\n Calculating the roots of x^2 + b x + c = 0");
            Console.Write("Give a value for variable a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Give a value for variable b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Give a value for variable c: ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two Real Roots {0} and {1}", x1, x2);
            }
            else if (d < 0)
            {
                d = -d;
                x = -b / (2 * a);
                imaginary = Math.Sqrt(d) / (2 * a);
                Console.WriteLine("Imaginary roots {0} + {1} i or {2} + {3} i", x, imaginary, x, imaginary);
            }
            else
            {
                x = (-b + Math.Sqrt(d) / (2 * a));
                Console.WriteLine("One Real Solution: {0}", x);
            }
        }
    }
}
