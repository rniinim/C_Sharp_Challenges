using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statement 
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
            Console.WriteLine("Give two values: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine(a+" and "+b+" are equal.");
            }

            else
                Console.WriteLine(a + " and " + b + " are not equal.");

            //2. Write a C# Sharp program to check whether a given number is even or odd. 
            Console.WriteLine("Give integer");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a+" is equal.");
            }
            else
                Console.WriteLine(a+" is odd.");

            //3. Write a C# Sharp program to check whether a given number is positive or negative.
            Console.WriteLine("Give integer");
            a = int.Parse(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine(a+" is negative.");
            }

            else if (a>=0)
            {
                Console.WriteLine(a+" is positive.");
            }
            
            //4. Write a C# Sharp program to find whether a given year is a leap year or not.
            Console.WriteLine("Write some year.");
            a = int.Parse(Console.ReadLine());
            if (a%4==0)
            {
                Console.WriteLine("It is a leap year.");
            }
            else
                Console.WriteLine("Its not leap year.");

            //5. 5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
            Console.WriteLine("Give your age.");
            a = int.Parse(Console.ReadLine());
            if (a>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting his vote");
            }
            else if (a<18)
            {
                Console.WriteLine("Sorry but you have to wait.");
            }
            //6. Write a C# Sharp program to read the value of an integer a and display the value of n is 1 when a is larger than 0, 0 when a is 0 and -1 when a is less than 0.
            Console.WriteLine("Give some nice integer");
            a = int.Parse(Console.ReadLine());
            if (a!=0)
            {
                if (a>0)
                {
                    Console.WriteLine("The value of n is: 1");
                }
                else if (a<0)
                {
                    Console.WriteLine("The value of n is: -1");
                }
            }

            else if (a == 0)
            {
                Console.WriteLine("The value of n is: 0");
            }
            //7.  Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. 
            Console.WriteLine("Give you height");
            a = int.Parse(Console.ReadLine());
            if (a<160)
            {
                Console.WriteLine("You are Hobbit");
            }

            else if (a>=160 && a<180)
            {
                Console.WriteLine("You still have hope!");
            }

            else if (a>=180 && a<200)
            {
                Console.WriteLine("wow! dude you are pretty tall.");
            }
            else if (a>=200)
            {
                Console.WriteLine("Are you giraffe?");
            }
            //8. Write a C# Sharp program to find the largest of three numbers. 
            Console.WriteLine("Give three (3) integers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b&&a>c)
            {
                Console.WriteLine("{0} is biggest value.",a);
            }
            else if (b>a&&b>c)
            {
                Console.WriteLine("{0} is biggest value.",b);
            }
            else if (c>a&&c>b)
            {
                Console.WriteLine("{0} is biggest value.",c);
            }
            //9.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.WriteLine("Give two coordinates pls. First x then y.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            string paikka =" BAMBOOOZLE ";
            if (a>0 && b>0)
            {
                paikka = "first";
            }
            else if (a>0 && b<0)
            {
                paikka = "second";
            }
            else if (a<0 && b<0)
            {
                paikka = "third";
            }
            else if(a<0 && b > 0)
            {
                paikka = "fourth";
            }
            else if (a==0 || b == 0)
            {
                Console.WriteLine("{0} or {1} is 0 due to that point is not in any sactor.",a,b);
            }
            Console.WriteLine("Coordinate point ({0},{1}) is in {2} quadrant.",a,b,paikka);

            //10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
        }
    }
}
