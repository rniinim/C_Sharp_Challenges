using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 6\n");

            int x = 5;
            int y = 8;
            Console.WriteLine("Number "+x+" added to "+y+" is "+(x+y));
            Console.WriteLine("Number {0} added to {1} is {2}\n",x,y,x+y);

            Console.WriteLine("Tehtävä 7\n");
            x = 3;
            y = 4;
            int z = 5;
            Console.WriteLine(y*y-(4*x*z));
            //b^2-4*a*c

            Console.WriteLine("\nTehtävä 8");
            Console.WriteLine("Antakaa kolme arvoa:");
            Double a;
            Double b;
            Double c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a+b+c)/3);
            Console.WriteLine("\nTehtävä 9");
            Console.WriteLine("How many inches? ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(m+" is "+(m*2.549)+"cm");
        }
    }
}
