using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        enum Kortit
        {
            Kaksi = 2, Kolme = 3, Neljä = 4, Viisi = 5, Kuusi = 6, Seitsemän = 7, Kahdeksan = 8, Yhdeksän = 9, Kymmenen = 10, Jätkä = 11, Kuningatar = 12, Kuningas = 13, Ässä = 14
        }
        enum Vuodenajat
        {
            Kesä, Syksy, Talvi, Kevät
        }
        static void Main(string[] args)
        {
            //24b
            var muuttuja = Enum.GetValues(typeof(Kortit));
            Console.WriteLine("Enum type\n");
            foreach (var item in muuttuja)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nInteger\n");
            foreach (int arvo in muuttuja)
            {
                Console.WriteLine(arvo);
            }
            //24c
            Console.Write("\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((Vuodenajat)i);
            }
            //24d
            Console.WriteLine("\n");
            Vuodenajat[] vuodenaika = {Vuodenajat.Kesä, Vuodenajat.Syksy, Vuodenajat.Talvi, Vuodenajat.Kevät};
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(vuodenaika[i]);
            }
        }
    }
}
