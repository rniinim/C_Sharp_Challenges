using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Give length of string: ");
            bool res = int.TryParse(Console.ReadLine(), out length);
            while (res == false)
            {
                res = int.TryParse(Console.ReadLine(), out length);
                if (res == true)
                {
                    break;
                }
            }

            NameGenerator(length);
        }

        private static void NameGenerator(int length)
        {
            Random rng = new Random();

            char[] vowels = { 'a', 'e', 'i', 'u', 'y', 'o' };
            char[] cons = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z' };
            string name1 = "";
            StringBuilder name = new StringBuilder(name1);
            int randomv;
            int randomc;
            int chose;
            for (int i = 0; i < length; i++)
            {
                randomv = rng.Next(0,vowels.Length);
                randomc = rng.Next(0, cons.Length);
                chose = rng.Next(0, 2);
                if (chose == 1)
                {
                    name.Append(vowels[randomv]);
                }
                else
                {
                    name.Append(cons[randomc]);
                }

                foreach (char x in vowels)
                {
                    if (i>0 && name[i] == 'x')
                    {
                        foreach (char y in vowels)
                        {
                            if (i>0 && name[i-1] == 'y' && i<length-1)
                            {
                                name.Append(cons[randomc]);
                                i++;

                            }
                        }
                    }
                }
                foreach (char x in cons)
                {
                    if (i > 0 && name[i] == 'x')
                    {
                        foreach (char y in cons)
                        {
                            if (i > 0 && name[i - 1] == 'y' && i < length - 1)
                            {
                                name.Append(vowels[randomv]);
                                i++;
                            }
                        }
                    }
                }

            }
            Console.WriteLine(name.ToString());
        }
    }
}
