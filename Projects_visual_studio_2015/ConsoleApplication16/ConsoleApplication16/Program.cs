using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            //12b
            Console.WriteLine("failed, fair, good or excellent.");
            string value = Console.ReadLine();
            switch (value)
            { 

                case "failed":
                Console.WriteLine("0");
                break;

                case "fair":
                Console.WriteLine("1 or 2");
                break;

                case "good":
                Console.WriteLine("3 or 4");
                break;

                case "excellent":
                Console.WriteLine("5");
                break;

            }

            //12c

            Console.WriteLine("Give two numbers");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("Choose one. (1-4)");
            double lasku = Convert.ToDouble(Console.ReadLine());

            if (lasku == 1)
            {
                Console.WriteLine(a+b);
            }

            else if (lasku == 2)
            {
                Console.WriteLine(a-b);
            }

            else if (lasku == 3)
            {
                Console.WriteLine(a * b);
            }

            else if (lasku == 4)
            {
                Console.WriteLine(a / b);
            }

            else
            {
                Console.WriteLine("Something went wrong.");
            }
            
            //13
            for(int i = 0; i < 30; i++)
            {
                Console.WriteLine("Good");
            }

            //14

            for(double luku = 1; luku <= 100; luku++)
            {
                if (luku % 2 == 0)
                {
                    Console.WriteLine(luku);
                }
            
            }
        }


    }
}
