using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //4
            Console.WriteLine((-1+4)*6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14-4*6/11);
            Console.WriteLine(2+15/6*1-7%2);
            //5
            Console.WriteLine("Kirjoita 2 numeroa");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("1. on "+a);
            Console.WriteLine("2. on "+b);
            //6
            Console.WriteLine("Anna kolmen numeroa");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a*b*c);
            //7
            Console.WriteLine("Anna 2 numeroa");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;
            Console.WriteLine(a + " + " + b + " = " + a + b);
            Console.WriteLine(a + " - " + b + " = " + c);
            Console.WriteLine(a + " x " + b + " = " + a * b);
            Console.WriteLine(a + " / " + b + " = " + a / b);
            Console.WriteLine(a + " mod " + b + " = " + a % b);
            //8
            Console.WriteLine("Anna 1 numero");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(a+"x"+i+"="+(a*i));
            }
            //9
            Console.WriteLine("Anna 4 lukua (keskiarvo)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a+b+c+d)/4);
            //10
            Console.WriteLine("Anna 3 numeroa: x,y ja z");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tulos arvoilla:"+a+", "+b+" ja "+c+ " (x+y)·z on "+(a+b)*c+ " ja x·y + y·z on "+((a*b)+b*c));
            //11
            Console.WriteLine("Anna ikäsi");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Olet yli "+a+"-vuotta");
            //12
            Console.WriteLine("Anna luku");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(a + " " + a + " " + a + " " + a);
                Console.WriteLine((a) +""+ (a)+"" + (a)+"" + (a));
            }
            //13
            Console.WriteLine("Anna luku");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}", a);
            Console.WriteLine("{0}  {0}", a);
            Console.WriteLine("{0}  {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
            //14
            Console.WriteLine("Anna lämpötila");
            double celsius = Convert.ToInt32(Console.ReadLine());
            double farenheit = celsius * 1.8 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("Kelvin = {0}",kelvin);
            Console.WriteLine("Farenheit = {0}", farenheit);
        }
    }
}
