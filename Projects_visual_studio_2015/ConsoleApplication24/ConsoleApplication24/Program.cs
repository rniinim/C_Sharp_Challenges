using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program in C# Sharp to store elements in an array and print it.
            int[] lista = new int[10];
            int i;
            Console.WriteLine("input 10 numbers of array");
            for (i = 0; i < 10; i++)
            {
                lista[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
