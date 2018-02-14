using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;

            int summa;
            int erotus;
            int tulo;
            double osamaara;

            summa = x + y;
            erotus = x - y;
            tulo = 5 * 7;
            osamaara = (double)x / y;

            Console.WriteLine(summa);
            Console.WriteLine(erotus);
            Console.WriteLine(tulo);
            Console.WriteLine(osamaara);

            x+= 5;
            Console.WriteLine(x);


        }
    }
}
