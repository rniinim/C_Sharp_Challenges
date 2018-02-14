using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {

            Warning();

            char c = First("abc");
            Console.WriteLine(c);

            string p = Console.ReadLine();
            char last = Last(p);
            Console.WriteLine(last);
        }

        private static void Warning()
        {
            Console.WriteLine("The weather is bad today");
        }

        private static char First(string p)
        {
            char first = p[0];
            return first;
        }

        private static char Last(string p)
        {
            char last = p[p.Length - 1];
            return last;
        }

    }
}
