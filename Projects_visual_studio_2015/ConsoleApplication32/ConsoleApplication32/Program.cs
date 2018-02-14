using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.

            Console.Write("Input sentence: ");
            string sentence = Console.ReadLine();
            IsPalindrome(sentence);

            //10.
            Console.Write("Input lenght binary: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] binary = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Give {0}. value (0 or 1) :", (i + 1));
                binary[i] = Convert.ToInt32(Console.ReadLine());
            }

            Not(lenght, binary);

            //11.
            List<string> list2 = new List<string>()
            {
                "carrot","fox", "explorer"
            };

            First(list2);

            //12.
            List<string> list1 = new List<string>()
            {
                "carrot","fox", "explorer"
            };

            Average(list1);
        }


        private static void Average(List<string> list1) //12.
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += list1[i].Length;
            }
            double avg = sum / 3.0;
            Console.WriteLine("Average is: " + avg);
        }


        private static void First(List<string> list2) //11.
        {
            Console.WriteLine("\n1st word is: "+list2[0]);
        }

        private static void Not(int lenght, int[] binary) //10.
        {
            Console.Write("New binary is: ");
            for (int i = 0; i < lenght; i++)
            {
                if (binary[i] == 0)
                {
                    binary[i] = 1;
                }
                else if (binary[i] == 1)
                {
                    binary[i] = 0;
                }

                Console.Write(binary[i]);
            }
        }

        private static void IsPalindrome(string sentence)  //9.
        {
            int count = 0;
            bool pal = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == sentence[sentence.Length - i - 1])
                {
                    count++;
                }

                if (count == sentence.Length)
                {
                    pal = true;
                }
            }

            Console.WriteLine(pal);
        }
    }
}
