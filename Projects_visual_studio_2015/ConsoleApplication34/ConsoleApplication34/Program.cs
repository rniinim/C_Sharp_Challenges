using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Elephant
    {
        public int Weight { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "qwerty", "asd", "zx" };
            int[] lenghts = new int[3];
            AllLenghts(words, lenghts);

        }

        private static void AllLenghts(List<string> words, int[] lenghts)
        {
            for (int i = 0; i < 3; i++)
            {
                lenghts[i] = words[i].Length;
            }
        }

    }
}
