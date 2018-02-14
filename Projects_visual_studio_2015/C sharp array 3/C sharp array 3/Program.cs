using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 14.
            //14. Write a program in C# Sharp to insert New value in the array 
            Console.Write("Input the size of array: ");
            int koko = int.Parse(Console.ReadLine());
            int[] array = new int[(koko + 1)];
            for (int i = 0; i < koko; i++)
            {
                Console.WriteLine("Give {0}. element: ", (i + 1));
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Input the value to be inserted: ");
            int arvo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the position where the value to be inserted: ");
            int paikka = int.Parse(Console.ReadLine());
            int holder = 0;
            int pituus = koko - paikka - 1;


            for (int i = 0; i <= pituus + 2; i++)
            {
                holder = array[paikka - 1 + i];
                array[paikka - 1 + i] = arvo;

                arvo = holder;

            }

            for (int i = 0; i <= koko; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion

            #region Task 15.
            //15. Write a program in C# Sharp to delete an element at desired position from an array.

            Console.Write("Input size of array: ");
            koko = int.Parse(Console.ReadLine());
            array = new int[koko];
            int[] array2 = new int[koko - 1];

            for (int i = 0; i < koko; i++)
            {
                Console.Write("Input {0}. element: ", (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input position where to delete: ");
            arvo = int.Parse(Console.ReadLine());

            for (int i = 0; i < arvo - 1; i++)
            {
                array2[i] = array[i];
            }

            pituus = koko - arvo;

            for (int i = 0; i < pituus; i++)
            {
                array2[arvo - 1 + i] = array[arvo + i];
            }

            for (int i = 0; i < koko - 1; i++)
            {
                Console.WriteLine(array2[i]);
            }
            #endregion

            #region Task 16
            //16. Write a program in C# Sharp to find the second largest element in an array.
            Console.Write("Input the size of array: ");
            koko = int.Parse(Console.ReadLine());

            array = new int[koko];

            for (int i = 0; i < koko; i++)
            {
                Console.Write("Input {0}. element: ", (i + 1));
                array[i] = int.Parse(Console.ReadLine());

            }

            int biggest = array[0];
            int place = 0;
            for (int i = 1; i < koko; i++)
            {
                if (array[i] >= biggest)
                {
                    biggest = array[i];
                    place = i;
                }
            }
            Console.WriteLine(biggest);

            int second = array[0];
            for (int i = 0; i < koko; i++)
            {
                if (i == place)
                {
                    //placeholder
                }
                else if (array[i] >= second)
                {
                    second = array[i];
                }

            }
            Console.WriteLine("Biggest: " + biggest + " Second: " + second);
            #endregion

            #region Task 18
            //Task. 18. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix. 

            Console.WriteLine("Input values of matrix.");
            int[,] array2d = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2d[i, j]);
                }
                Console.WriteLine("");

            }
            #endregion

            #region Task 19
            //19. Write a program in C# Sharp for addition of two Matrices of same size.
            Console.WriteLine("Input size of the square matrix (less 5): ");
            koko = Convert.ToInt32(Console.ReadLine());

            int[,] array19a = new int[koko, koko];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    Console.Write("element - " + i + ", " + j + ": ");
                    array19a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] array19b = new int[koko, koko];
            Console.WriteLine("Input elements in the second matrix: ");
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    Console.Write("element - " + i + ", " + j + ": ");
                    array19b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] array19c = new int[koko, koko];
            Console.WriteLine("Input elements in the second matrix: ");
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    array19c[i, j] = (array19a[i, j] + array19b[i, j]);
                    Console.Write(array19c[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion

            #region Task 22
            //22. Write a program in C# Sharp to find transpose of a given matrix.
            Console.WriteLine("Input the rows and columns of the matrix : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix22 = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix22[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix22[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("The second matrix is:");
            int[,] matrixt22 = new int[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixt22[j, i] = matrix22[i, j];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrixt22[i, j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion

            //25. Write a program in C# Sharp to find sum of rows an columns of a Matrix.
            Console.WriteLine("Input size of square matrix: ");
            koko = Convert.ToInt32(Console.ReadLine());

            int[,] array25a = new int[koko, koko];
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    Console.Write("Elemnt - {0}, {1}: ", i, j);
                    array25a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] array25b = new int[koko, (koko + 1)];
            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < koko; j++)
                {
                    array25b[i, j] = array25a[i, j];
                }
            }

            int kasaus = 0;
            for (int i = 0; i < koko; i++)
            {
                kasaus = 0;
                for (int j = 0; j < koko; j++)
                {
                    kasaus += array25a[i, j];
                }
                array25b[i,koko] = kasaus;
            }

            int[] array25c = new int[koko];
            for (int i = 0; i < koko; i++)
            {
                kasaus = 0;
                for (int j = 0; j < koko; j++)
                {
                    kasaus+=array25a[j, i];
                }
                array25c[i] = kasaus;
            }

            for (int i = 0; i < koko; i++)
            {
                for (int j = 0; j < (koko+1); j++)
                {
                    Console.Write(array25b[i,j]+" ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < koko; i++)
            {
                Console.Write(array25c[i]+" ");
            }
        }
    }
}
