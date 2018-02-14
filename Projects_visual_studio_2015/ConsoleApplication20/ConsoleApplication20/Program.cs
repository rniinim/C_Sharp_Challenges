using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 3);
            }
        }
    }
}
