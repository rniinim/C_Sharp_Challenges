using System;

namespace ConsoleApplication2
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            

            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers [i] + ",");
            }
            Console.WriteLine();

            numbers.ReamoveAT(2);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] + ",");
            }

            Console.ReadKey();

        }
    }
}
