using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        public static void Main(string[] args)
        {
            //27.
            Console.WriteLine("Give values for x,y,z");
            Console.WriteLine("Give value of X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Give value of Y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Give value of Z");
            double z = double.Parse(Console.ReadLine());

            double tulos = Lasku(x, y, z);

            Console.WriteLine(tulos);

            //28.
            Console.WriteLine("Write two strings.");
            Console.Write("First string: ");
            string first = Console.ReadLine();
            Console.Write("Second string: ");
            string second = Console.ReadLine();

            string lauseke = Lasku(first, second);

            Console.WriteLine(lauseke);

            //29
            Console.WriteLine("Write two integers.");
            Console.Write("First integer: ");
            int first1 = int.Parse(Console.ReadLine());
            Console.Write("Second integer: ");
            int second2 = int.Parse(Console.ReadLine());

            string numerot = NewMethod1(first1, second2);

            Console.WriteLine(numerot);

            //30a
            Console.WriteLine("Write two strings.");
            Console.Write("First string: ");
            string Name = Console.ReadLine();
            Console.Write("Second string: ");
            string Surname = Console.ReadLine();

            string initials = NewMethod(Name, Surname);

            Console.WriteLine(initials);

            //30b
            int[] joukko;
            
            NewMethod2(joukko);

            /* 30b
            Console.Write("Write amoutn of values in array: ");
            int i = int.Parse(Console.ReadLine());
            int[] joukko = new int[i];
            for (int j = 0; j < i; j++)
            {
                Console.Write("Write " + (j + 1) + ". value: ");
                joukko[j] = int.Parse(Console.ReadLine());
            }

            NewMethod2(i, joukko);
            Console.WriteLine(joukko[1]);*/

            //30c
            int[] joukko1;

            NewMethod3(joukko1);
            /*
            30c;
            Console.Write("Write amoutn of values in array: ");
            i = int.Parse(Console.ReadLine());
            int[] joukko1 = new int[i];

            for (int j = 0; j < i; j++)
            {
                Console.Write("Write " + (j + 1) + ". value: ");
                joukko1[j] = int.Parse(Console.ReadLine());
            }*/
        }
        
        //30c
        private static void NewMethod3(int[] joukko1)
        {
            Console.Write("Give number of array to change: ");
            int p = int.Parse(Console.ReadLine());
            joukko1[p + 1] = joukko1[p + 1] * 2;
            return 
        }

        /*private static int[] NewMethod3(int i, int[] joukko1)
        {
            Console.Write("Give number of array to change: ");
            int p = int.Parse(Console.ReadLine());
            joukko1[p+1] = joukko1[p+1] * 2;
            
            return joukko1[p+1];}*/
        
        //30b
        private static void NewMethod2(int[] joukko)
        {
            
            Console.Write("Give number of array to change: ");
            int p = int.Parse(Console.ReadLine());
            joukko[p + 1] = joukko[p + 1] * 2;

            /*         
             private static void NewMethod2(int i, int[] joukko)
             {
                for (int j = 0; j < i; j++)
                {
                    joukko[j] = joukko[j] * 2;
                }
             }*/

        }
        //30a
        private static string NewMethod(string Name, string Surname)
        {
            return Name[0] + "." + Surname[0];
        }
        //29
        private static string NewMethod1(int first1, int second2)
        {
            return first1.ToString() + second2;
        }
        //28
        private static string Lasku(string first, string second)
        {

            return first + second;
        }
        //27
        private static double Lasku(double x, double y, double z)
        {
            double answer = (x + y + z) / 3;
            return answer;
        }

    }
}
