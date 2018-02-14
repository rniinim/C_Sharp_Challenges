using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Write a program in C# Sharp to store elements in an array and print it.
            
            Console.WriteLine("Task 1.");
            int[] lista = new int[1];
            Console.WriteLine("Input 1 numbers of array");
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Give {0}. elemet: ", (i+1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("{0} ",i);
            }

            //2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order.

            Console.WriteLine("Task 2.");
            Console.WriteLine("Input the number of elements to store in the array :");
            int kerta = int.Parse(Console.ReadLine());

            Console.WriteLine("Input {0} number of elements in the array :", kerta);
            int[] lista2 = new int[kerta];
            for (int i = 0; i < kerta; i++)
            {
                lista2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements stored in values");
            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("Element - {0}: {1}",(i+1), lista2[i]);
            }

            Console.WriteLine("The values store into the array in reverse are :");
            int intkierros = 0;
            for (int i = (kerta-1); i >= 0; i--)
            {
                intkierros++;
                Console.WriteLine("Element - {0}: {1}", intkierros, lista2[i]);
            }

            //3. Write a program in C# Sharp to find the sum of all elements of the array.
            Console.WriteLine("Task 3.");
            Console.WriteLine("Input numeers to be stored in array : ");
            kerta = int.Parse(Console.ReadLine());
            lista2 = new int[kerta];
            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("Element {0}",(i+1));
                lista2[i] = int.Parse(Console.ReadLine());
            }
            int sum = lista2.Sum();
            Console.WriteLine("Sum of array is: {0}",sum);

            //4. Write a program in C# Sharp to copy the elements one array into another array.
            Console.WriteLine("Task 4.");
            Console.WriteLine("Input numeers to be stored in array : ");
            kerta = int.Parse(Console.ReadLine());
            lista2 = new int[kerta];
            lista = new int[kerta];
            //Takes values to array and transfer them to another array
            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("Element {0}", (i + 1));
                lista2[i] = int.Parse(Console.ReadLine());
                lista[i] = lista2[i];
            }

            Console.WriteLine("Values of arrays are:");
            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("{0} value of 1st array: {1}",(i+1),lista[i]);
                Console.WriteLine("{0} value of 1st array: {1}", (i+1), lista2[i]);
            }

            //5. Write a program in C# Sharp to count a total number of duplicate elements in an array.
            Console.WriteLine("Task 5.");
            Console.WriteLine("Input number of values to be stored in array.");
            kerta = int.Parse(Console.ReadLine());
            lista = new int[kerta];
            sum = 0;

            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("{0} element: ",(i+1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < kerta; i++)
            {
                for (int j = 0; j < kerta; j++)
                {
                    if (lista[i] == lista[j] && i!=j)
                    {
                        sum += 1;
                    }
                }
            }
            Console.WriteLine("Amount of duplicate values is: {0}",sum/2);

            //6.  Write a program in C# Sharp to print all unique elements in an array.
            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i2, j2, k;


            Console.Write("\n\nPrint all unique elements of an array:\n");
            Console.Write("------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i2 = 0; i2 < n; i2++)
            {
                Console.Write("element - {0} : ", i2);
                arr1[i2] = Convert.ToInt32(Console.ReadLine());
            }

            /*Checking duplicate elements in the array */
            Console.Write("\nThe unique elements found in the array are : \n");
            for (i2 = 0; i2 < n; i2++)
            {
                ctr = 0;

                /*Check duplicate bifore the current position and
                increase counter by 1 if found.*/
                for (j2 = 0; j2 < i2 - 1; j2++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i2] == arr1[j2])
                    {
                        ctr++;
                    }
                }
                /*Check duplicate after the current position and
                  increase counter by 1 if found.*/
                for (k = i2 + 1; k < n; k++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i2] == arr1[k])
                    {
                        ctr++;
                    }
                }
                /*Print the value of the current position of the array as unique value 
                when counter remain contains its initial value.*/
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i2]);
                }
            }
            Console.Write("\n\n");

            //7.Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
            Console.WriteLine("Task 7.");

            Console.Write("Input number of values to be stored in 1st array: ");
            kerta = int.Parse(Console.ReadLine());

            Console.Write("Input number of values to be stored in 2nd array: ");
            int kerta2 = int.Parse(Console.ReadLine());

            lista2 = new int[kerta];
            lista = new int[kerta2];
            int[] lista3 = new int[(kerta + kerta2)];
            int y;

            for (int i = 0; i < kerta; i++)
            {
                Console.WriteLine("Give value of {0}. element in 1st array.",(i+1));
                lista[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < kerta2; i++)
            {
                Console.WriteLine("Give value of {0}. element in 2nd array.", (i + 1));
                lista2[i] = int.Parse(Console.ReadLine());
            }

            for (y = 0; y < kerta; y++)
            {
                lista3[y] = lista[y];
            }
            

            for (int j = 0; j < kerta2; j++)
            {
                lista3[y] = lista[j];
                y++;
            }
            k = 0;
            //Console.WriteLine("The merged array in ascending order is : ");
            for (int i = 0; i < (kerta + kerta2); i++)
            {
                for (int j = 0; j < (kerta + kerta2 -1); j++)
                {
                    if (lista3[j]>=lista3[j+1])
                    {
                        k = lista3[j + 1];
                        lista3[j + 1] = lista3[j];
                        lista3[j] = k;
                        
                    } 
                }
            }
            Console.Write("\nThe merged array in ascending order is :\n");
            for (int i = 0; i < (kerta + kerta2); i++)
            {
                Console.Write("{0} ", lista3[i]);
            }

            //8. Write a program in C# Sharp to count the frequency of each element of an array.
            Console.WriteLine("Task 8.");

            Console.Write("Input number of values to be stored in array: ");
            kerta = int.Parse(Console.ReadLine());

            lista = new int[kerta];
            int[] fr1 = new int[kerta];

            for (int i = 0; i < kerta; i++)
            {
                lista[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                ctr = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }

            Console.Write("\nThe frequency of all elements of the array : \n");
            for (int i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }
        }
    }
}
