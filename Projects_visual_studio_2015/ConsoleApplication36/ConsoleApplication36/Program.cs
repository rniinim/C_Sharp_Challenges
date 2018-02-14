using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = { { "x value", "y value", "expression", "result" }, { "10", "5", "x+y+3", "x=8" } };
            foreach (var item in array)
            {
                Console.Write(item);
            }
        }
    }
}
