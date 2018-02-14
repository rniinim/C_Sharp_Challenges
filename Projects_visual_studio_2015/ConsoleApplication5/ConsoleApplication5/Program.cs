using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("hello");
            int number = 32;
            int number1;
            number1 = 21;
            //on mahdollista ensin lisätä muuttuja ilman arvoa ja lisätä se muuttujalle vasta myöhemmin.
            const int i = 10;
            Console.WriteLine(i);
            //cons = constants eli vakio. Ei pysty määräämisen jälkeen enää muuttamaan.
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers2[0]);
            // array = ryhmä, [] tekoon sekä tulostukseen sivu12
            int q = 1;
            int w = 3;
            int e = 6;
            Console.WriteLine((q+w+e)/3);
        }
    }
}
