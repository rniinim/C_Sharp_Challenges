using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 30.
            //30. Write a program in C# Sharp to accept two matrices and check whether they are equal.
            Console.WriteLine("Input amount of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] array1 = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Element {0}, {1} in 1st array: ", i, j);
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] array2 = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Element {0}, {1} in 2nd array: ", i, j);
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int kertoma = rows * columns;
            int kertymä = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array1[i, j] == array2[i, j])
                    {
                        kertymä++;
                    }
                }
            }

            Console.WriteLine("Matrices can be compared: ");
            if (kertymä == kertoma)
            {
                Console.WriteLine("Matrices are equal.");
            }
            else
            {
                Console.WriteLine("Matrices are not equal.");
            }
            #endregion

            #region Task 31.
            //31. Write a program in C# Sharp to Check whether a Given Matrix is an Identity Matrix.
            Console.Write("Input the size of square matrix: ");
            int koko;
            koko = GiveNumber();
            int[,] array = new int[koko, koko];

            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    Console.WriteLine("Input element - {0}, {1}: ", i, j);
                    array[i, j] = GiveNumber();
                }
            }

            int truth = 1;
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    if (i != j && array[i, j] != 0)
                    {
                        truth = 0;
                        break;
                    }
                    else if (i == j && array[i, j] != 1)
                    {
                        truth = 0;
                        break;
                    }
                }
            }

            if (truth == 1)
            {
                Console.WriteLine("The matrix is an Identity Matrix");
            }
            else if (truth == 0)
            {
                Console.WriteLine("The matrix is not an Identity Matrix");
            } 
            #endregion
        }

        private static int GiveNumber()
        {
            int koko;
            bool res = int.TryParse(Console.ReadLine(), out koko);
            while (res == false)
            {
                Console.WriteLine("Write integer number.");
                res = int.TryParse(Console.ReadLine(), out koko);
            }

            return koko;
        }
    }
}
