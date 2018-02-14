using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Dice
    {
        public static void Throw(int kerta) //35.
        {
            int result;
            int[] array = new int[kerta];
            Random rnd = new Random();

            for (int i = 0; i < kerta; i++)
            {
                result = rnd.Next(1, 7);
                array[i] = result;
                Console.Write(array[i]); 
            }

            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dice.Throw(3); //35.
            Console.WriteLine("");

            List<string> list = new List<string>(); //36.

            string word = "";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Input word: ");
                word = Console.ReadLine();
                list.Add(word);
            }

            List<string> list1 = new List<string>(); //37.

            while (true)
            {
                Console.Write("Input word: ");
                word = Console.ReadLine();
                if (word == "end" || word == "End")
                {
                    break;
                }
                list1.Add(word);
            }

            List<int> list2 = new List<int>(); //38.
            Random rng = new Random();
            int result;
            int amountOfHeads = 0;
            int amountOfTails = 0;


            for (int i = 0; i < 100; i++)
            {
                result = rng.Next(1, 3);
                list2.Add(result);
                if (result == 1)
                {
                    amountOfHeads++;
                }
                else if (result == 2)
                {
                    amountOfTails++;
                }
            }


            const int määrä = 7; //39
            List<int> lotteryNumbers = new List<int>();

            while (lotteryNumbers.Count < määrä)
            {
                int lottoNumber = rng.Next(1, 40); 
                if (!lotteryNumbers.Contains(lottoNumber))
                {
                    lotteryNumbers.Add(lottoNumber);
                }
            }
            Console.WriteLine(String.Join(", ", lotteryNumbers.ToArray()));

        }
    }
}
