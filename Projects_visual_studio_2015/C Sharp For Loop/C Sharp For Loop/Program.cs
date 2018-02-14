using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Write a program in C# Sharp to display the first 10 natural numbers. 
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            //2. Write a C# Sharp program to find the sum of first 10 natural numbers.
            int a = 0;
            for (int i = 1; i < 11; i++)
            {
                a = a + i;
            }
            Console.WriteLine(a);
            //3. Write a program in C# Sharp to display n terms of natural number and their sum.
            Console.WriteLine("Give natural number");
            a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            for (int i = 1; i < a+1; i++)
            {
                Console.WriteLine(i);
                b = b + i;
            }
            Console.WriteLine("The sum of natural number upto {0} terms: {1}",a,b);
            //4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            int sum = 0;
            Console.WriteLine("Write 10 integers");
            for (int i = 1; i < 11; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine("Sum is {0} and average is {1}",sum,(sum/10));
            //5.  Write a program in C# Sharp to display the cube of the number upto given an integer. 
            Console.WriteLine("Give amount of numers to cube");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Number is :  {0} and cube of the {0} is :{1} ",i,(i*i*i));
            }
            //6. Write a program in C# Sharp to display the multiplication table of a given integer.
            Console.WriteLine("Write integer");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= 10; i++)
            {
                Console.WriteLine("{0} times {1} is {2}",a,i,(a*i));
            }
            //7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
            Console.WriteLine("Input upto table satrt and end values.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int j;
            for (int i = a; i <= 10; i++)
            {
                for (j = 1; j <= b; j++)             
                {
                    Console.WriteLine("{0} times {1} is {2}",j,i,(i*j));
                }
            }
            //8. Write a program in C# Sharp to display the n terms of odd natural number and their sum 
            Console.WriteLine("Input number of terms");
            a = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            b = 0;
            sum = 0;
            while (b < a)
            {
                if (c % 2 != 0)
                {
                    Console.WriteLine(c);
                    sum = sum + c;
                    b++;
                }
                c++;
            }
            Console.WriteLine("Sum of numbers is {0}",sum);
            //9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
            Console.WriteLine("Write number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
            }
            //10. Write a program in C# Sharp to display the pattern like right angle triangle with a number.
            Console.WriteLine("Write number of rows: ");
            rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            //11. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
            Console.WriteLine("Write number of rows: ");
            rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
            //12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
            Console.WriteLine("Write number of rows: ");
            int k = 1;
            rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++,k++)
                {
                    Console.Write(k+ " ");
                }
                Console.WriteLine("");
            }
            //13. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.
            Console.WriteLine("Write number of rows: ");
            k = 1;
            rows = int.Parse(Console.ReadLine());
            int x = 0;
            int spc = (rows / 2)+1;
            for (int i = 1; i <= rows; i++,spc--)
            {
                for (x=spc; x >= 1; x--)
                {
                    Console.Write(" ");
                }
                for (int t = 1; t <= i; t++)
                {
                    Console.Write(k++ + " " );
                }
                Console.Write("\n");
            }
            //14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
            Console.WriteLine("Write number of rows: ");
            k = 1;
            rows = int.Parse(Console.ReadLine());
            spc = (rows / 2) + 1;
            for (int i = 1; i <= rows; i++, spc--)
            {
                for (x = spc; x >= 1; x--)
                {
                    Console.Write(" ");
                }
                for (int t = 1; t <= i; t++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            //15. Write a C# Sharp program to calculate the factorial of a given number.
            Console.WriteLine("Write number which factorial to calculate");
            a = Convert.ToInt32(Console.ReadLine());
            sum = 1;

            for (int i = 1; i <= a; i++)
            {
                sum =  (sum * i);

            }
            Console.WriteLine(sum);
            //16. Write a program in C# Sharp to display the n terms of even natural number and their sum.
            Console.WriteLine("Input number of terms");
            a = Convert.ToInt32(Console.ReadLine());
            c = 1;
            b = 0;
            sum = 0;
            while (b < a)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine(c);
                    sum = sum + c;
                    b++;
                }
                c++;
            }
            //17. Write a program in C# Sharp to make such a pattern like a pyramid witha number which will repeat the number in the same row.
            k = 1;
            Console.WriteLine("Kirjoita rivit");
            rows = int.Parse(Console.ReadLine());
            spc = (rows / 2) + 1;
            for (int i = 1; i <= rows; i++, spc--)
            {
                for (x = spc; x >= 1; x--)
                {
                    Console.Write(" ");
                }
                for (int t = 1; t <= i; t++)
                {
                    Console.Write(i+" ");
                }
                Console.Write("\n");
            }
            //19. Write a program in C# Sharp to display the n terms of harmonic series and their sum
            double summa = 1;
            Console.WriteLine("Input amount of terms");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                summa += 1 /(float) i;
            }
            Console.WriteLine(summa);
            //20. Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.
            Console.WriteLine("write number of rows");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            //21.  Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]
            int u = 9;
            sum = 0;
            Console.WriteLine("write number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                sum += u;
                Console.Write("{0} ",u);
                u = u * 10 + 9;
            }
            Console.WriteLine("{0} is sum",sum);
            //22. Write a program in C# Sharp to print the Floyd's Triangle. 
            int p, q;
            Console.WriteLine("write number of rows");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { p = 1; q = 0; }
                else
                { p = 0; q = 1; }
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("{0}", p);
                    else
                        Console.Write("{0}", q);
                }
                Console.Write("\n");
            }
            //24. Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 + ......]
            double  no_row, ctr;
            double sum1 = 0;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ x - x^3 + x^5 + ......]:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum1 = x; no_row = x;
            for (int i = 1; i < n; i++)
            {
                ctr = (2 * i) * (2 * i + 1);
                no_row = -no_row * x * x / ctr;
                sum1 = sum1 + no_row;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
            //25. 6. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms
            Console.WriteLine("Input number of terms");
            a = Convert.ToInt32(Console.ReadLine());
            int t1 = 1;
            
            for (int i = 1; i <= a; i++)
            {

                Console.Write("{0} + ",t1);
                sum += t1;
                t1 = (t1 * 10) + 1;
            }
            Console.WriteLine(sum);
            
        }
    }
}
