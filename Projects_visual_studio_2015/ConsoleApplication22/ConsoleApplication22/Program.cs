using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            //21
            int[] intArray = new int[4];
            int i;
            for (i = 0; i < intArray.Length ; i++)
            {
                Console.WriteLine("Give value of " + (i + 1) + ". number");
                intArray[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[3 - i]);
            }
            Console.WriteLine("");
            
            //22
            //Average of intArray
            double sum = intArray.Sum();
            Console.WriteLine("Average is: "+sum / i);
            //or Console.WriteLine((intArray[0]+intArray[1]+intArray[2]+intArray[3])/i);
            Console.WriteLine("");
           
            //23
            int[] tau = new int[6];
            Random rnd1 = new Random();
            for (i = 0; i < tau.Length; i++)
            {
                tau[i] = rnd1.Next(1, 100);
                Console.WriteLine(tau[i]);
            }
            Console.WriteLine("Min value is: "+tau.Min());
            Console.WriteLine("");
            
            //24 a)
            Console.WriteLine("Max value: "+tau.Max());
            Console.WriteLine("Sum of numbers: " + tau.Sum());
            Console.WriteLine("Average of numbers: " + tau.Average());

        }
    }
}
