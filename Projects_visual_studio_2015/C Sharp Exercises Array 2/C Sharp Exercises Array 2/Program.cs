using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 8.
            //8. Write a program in C# Sharp to count the frequency of each element of an array.
            Console.WriteLine("Task 8.");
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int kierros, i, j, counter;


            Console.Write("\n\nCount the frequency of each element of an array: \n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            kierros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", kierros);
            for (i = 0; i < kierros; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = -1;
            }
            for (i = 0; i < kierros; i++)
            {
                counter = 1;
                for (j = i + 1; j < kierros; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        counter++;
                        arr2[j] = 0;
                    }
                }

                if (arr2[i] != 0)
                {
                    arr2[i] = counter;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < kierros; i++)
            {
                if (arr2[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], arr2[i]);
                }
            }
            Console.WriteLine("");
            #endregion

            #region Task 9.
            //9. Write a program in C# Sharp to find maximum and minimum element in an array.
            Console.WriteLine("Task 9.");

            Console.Write("Find maximum and minimum element in an array.\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array: ");
            kierros = int.Parse(Console.ReadLine());

            int[] lista = new int[kierros];

            Console.Write("Input {0} elements in the array : ", kierros);
            for (i = 0; i < kierros; i++)
            {
                Console.Write("Element - {0} : ", (i + 1));
                lista[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (kierros != 0)
            {
                int max = lista[kierros - 1];
                int min = lista[kierros - 1];


                for (i = 0; i < kierros - 1; i++)
                {
                    if (lista[i] >= lista[i + 1] && lista[i] >= lista[kierros - 1])
                    {
                        max = lista[i];
                        lista[i + 1] = lista[i];
                    }
                }

                for (i = 0; i < kierros - 1; i++)
                {
                    if (lista[i] <= lista[i + 1] && lista[i] <= lista[(kierros - 1)])
                    {
                        min = lista[i];
                        lista[i + 1] = lista[i];
                    }
                }

                Console.WriteLine("\nMax is {0} and Min is {1}", max, min);
            }
            Console.WriteLine("");
            #endregion

            #region Task 10.
            //10. Write a programin C# Sharp to separate odd and even integers in separate arrays. 
            Console.WriteLine("\nTask 10.");

            Console.Write("Separate odd and even integers in separate arrays.\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array: ");
            kierros = int.Parse(Console.ReadLine());

            lista = new int[kierros];
            int[] odd = new int[kierros];
            int[] even = new int[kierros];

            for (i = 0; i < kierros; i++)
            {
                Console.Write("Element - {0}: ", (i + 1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            int oddk = 0;
            int evenk = 0;

            for (i = 0; i < kierros; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    even[evenk] = lista[i];
                    evenk++;
                }
                else if (lista[i] % 2 != 0)
                {
                    odd[oddk] = lista[i];
                    oddk++;
                }
            }

            odd = new int[oddk];
            even = new int[evenk];

            oddk = 0;
            evenk = 0;

            for (i = 0; i < kierros; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    even[evenk] = lista[i];
                    evenk++;
                }
                else if (lista[i] % 2 != 0)
                {
                    odd[oddk] = lista[i];
                    oddk++;

                }
            }



            Console.Write("\n Even numbers are: ");
            for (i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.Write("\nOdd numbers are: ");
            for (i = 0; i < odd.Length; i++)
            {
                Console.Write((odd[i]) + " ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Task 11.
            //11.  11. Write a program in C# Sharp to sort elements of array in ascending order.
            Console.WriteLine("Task 11.");

            Console.Write("Sort elements of the array\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the size of array :");
            kierros = int.Parse(Console.ReadLine());
            lista = new int[kierros];

            for (i = 0; i < kierros; i++)
            {
                Console.Write("Give element - {0} : ", (i + 1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < kierros; k++)
            {
                for (i = 0; i < kierros - 1; i++)
                {
                    if (lista[i] >= lista[i + 1])
                    {
                        j = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = j;
                    }
                }
            }

            Console.WriteLine("Values in arrays are: ");
            for (i = 0; i < kierros; i++)
            {
                Console.Write("{0} ", lista[i]);
            }
            #endregion

            #region Task 12.
            //12.  Write a program in C# Sharp to sort elements of the array in descending order.
            Console.WriteLine("\nTask 12.");

            Console.Write("Sort elements of the array\n");
            Console.Write("----------------------------------------------------\n");


            Console.Write("Input the size of array: ");
            kierros = int.Parse(Console.ReadLine());
            lista = new int[kierros];

            for (i = 0; i < kierros; i++)
            {
                Console.Write("Element - {0}: ", (i + 1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < kierros; k++)
            {
                for (i = 0; i < kierros - 1; i++)
                {
                    if (lista[i] <= lista[i + 1])
                    {
                        j = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = j;
                    }
                }
            }

            Console.WriteLine("Elements of the array: ");
            for (i = 0; i < kierros; i++)
            {
                Console.WriteLine("{0} ", lista[i]);
            }
            #endregion

            //13. Write a program in C# Sharp to insert New value in the array
            Console.WriteLine("Task 13.");

            Console.Write("Input the size of array: ");
            kierros = int.Parse(Console.ReadLine());
            Console.Write("Input the value to be inserted: ");
            j = int.Parse(Console.ReadLine());

            lista = new int[kierros];

            for (i = 0; i < kierros; i++)
            {
                Console.Write("Input element - {0}: ",(i+1));
                lista[i] = int.Parse(Console.ReadLine());
            }
            

            for (int k = 0; k < kierros; k++)
            {
                for (int l = 0; l < kierros-1; l++)
                {
                    if (lista[i] >= lista[i+1])
                    {
                        counter = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = counter;
                    }
                }
            }

            Console.WriteLine("The exist array list is: ");
            for (int k = 0; k < kierros+1; k++)
            {
                Console.Write(lista[k]);
            }

            Console.WriteLine("After insert the list: ");
            for (int k = 0; k < kierros; k++)
            {
                if (lista[k]<=j && lista[k+1]>=j)
                {
                    for (int p = 0; p < kierros; p++)
                    {
                        if (lista[k] <= j && lista[k + 1] >= j)
                        {
                            Console.Write(j);
                        }
                        Console.Write(lista[p]);
                    }
                }
            }
        }
    }
}
