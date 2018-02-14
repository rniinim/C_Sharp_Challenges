using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Dice
    {
        public static int[] Throw(int a)
        {
            Random rng = new Random();
            int[] throws = new int[a];
            int kerta;

            for (int i = 0; i < a; i++)
            {
                kerta = rng.Next(1, 3);
                throws[i] = kerta;
            }
            return throws;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times dice will be throwed?");
            int kerta = Convert.ToInt32(Console.ReadLine());
            int[] array = Dice.Throw(kerta);

            foreach (int item in array)
            {
                if (item == 1)
                {
                    Console.Write("Head ");
                }
                else if (item == 2)
                {
                    Console.Write("Tails ");
                }
            }
        }
    }
}
