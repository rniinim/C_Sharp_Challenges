using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            double tupla = 3.1;

            Calculate(tupla);

            //2.
            string sana = "Tansku";

            FirstChar(sana);

            //3.
            int[] array = new int[5] { 0, 4, 5, 5, 3 };

            Greatest(array);

            //4.
            string[] array3 = new string[] { "0", "1", "2" };
            string word = "word";

            Ocurrences(array3, word);

            //5.
            string[] words = { "Taneli", "Meemi", "Fartlek", "SOTE-uudistus", "Mämmi", "Sauna", " Isäm maa", "karjala", "perkele", "sauna", "kirves", "vaimo", "6-1", "omakotitalo", "vene", "terva", "mäntysuopa", "suomempystykorva " };

            Choose(words);

            //6.

            Console.Write("Input amount of values: ");
            int amount = int.Parse(Console.ReadLine());
            int[] array2 = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                Console.Write("Give {0}. value: ", (i + 1));
                array2[i] = int.Parse(Console.ReadLine());
            }

            SmallestAndGreatest(array2);

            //7.
            HowAreYou();

            //8.
            Console.WriteLine("Input word");
            sana = Console.ReadLine();
            EverySecond(sana);

            //9.
            word = "saippuakauppias";
            amount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[(word.Length- i)])
                {
                    amount += 1;
                    if (amount == word.Length)
                    {
                        Console.WriteLine("Sentence is palindrome");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static string EverySecond(string sana) //8.
        {
            string uusisana = "";

            for (int i = 0; i < sana.Length; i++)
            {
                if (i % 2 == 0)
                {
                    uusisana += sana[i];
                }
            }
            return uusisana;
        }

        private static void HowAreYou() //7.
        {
            Console.Write("How are you today?");
            String mood = Console.ReadLine();
            Console.WriteLine("Mee too!");
        }


        private static Tuple<int, int> SmallestAndGreatest(int[] array2) //6.
        {
            int smallest = array2[0];
            int biggest = array2[0];

            for (int i = 0; i < array2.Length; i++)
            {
                if (smallest > array2[i])
                {
                    smallest = array2[i];
                }

                if (biggest < array2[i])
                {
                    biggest = array2[i];
                }
            }

            var result = Tuple.Create(smallest, biggest);
            return result;
        }

        private static string Choose(string[] words) //5.
        {
            Random rng = new Random();
            int randomNumber = rng.Next(0, words.Length);
            Console.WriteLine(words[randomNumber]);
            return words[randomNumber];
        }

        private static int Ocurrences(string[] array3, string word) //4.
        {
            return word.Length + array3.Length;
        }

        private static int Greatest(int[] array) //3.
        {
            return array.Max();
        }

        private static char FirstChar(string sana) //2.
        {
            return sana[0];
        }

        private static void Calculate(double tupla) //1.
        {
            Console.WriteLine(tupla);
        }

    }
}
