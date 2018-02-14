using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            char temperature;
            bool res = false;
            while (res == false)
            {
                Console.Write("What is temperature you want to convert Kelvnin, Farenheit or Celcius (k,f,c)? ");
                res = char.TryParse(Console.ReadLine(), out temperature);
                if (temperature != 'k' || temperature != 'c' || temperature != 'f')
                {
                    res = false;
                }
            }
            string temp;

            //switch (temperature)
            //{
            //    case 'k':
            //        temp = "Kelvin";
            //        break;
            //    case 'f':
            //        temp = "Fahrenheit";
            //        break;
            //    case 'c':
            //        temp = "Celsius";
            //        break;
            //    default:
            //        break;
            //}


        }
    }
}
