using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Conditional_Statement
{
    class Program

    {
        
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.WriteLine("Give two integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a ==b)
            {
                Console.WriteLine("Integers {0} and {1} are equal.",a,b);
            }
            else
                Console.WriteLine("Integers are not equal.");

            //2. Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Give integer: ");
            a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("{0} is even number",a);
            }
            else
                Console.WriteLine("{0} is odd number",a);

            //3. Write a C# Sharp program to check whether a given number is positive or negative.
            Console.Write("Give one integer: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine("{0} is positive.",a);
            }
            else if (a<0)
            {
                Console.WriteLine("{0} is negative",a);
            }
            else
            {
                Console.WriteLine("{0} is 0 ",a);
            }

            //4. Write a C# Sharp program to find whether a given year is a leap year or not.
            Console.Write("Give some year: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a%4==0)
            {
                Console.WriteLine("{0} is a leap year.",a);
            }
            else
            {
                Console.WriteLine("It's not leap year.");
            }

            //5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
            Console.WriteLine("What is your age?");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>=18)
            {
                Console.WriteLine("You can cast your vote.");
            }
            else
            {
                Console.WriteLine("You have to wait "+(18-a)+" years.");
            }

            //6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when
            Console.WriteLine("Give value");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine("1");
            }
            else if (a<0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("0");
            }

            //7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
            Console.WriteLine("Give you heigh");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>=200)
            {
                Console.WriteLine("Are you giraffe?");
            }
            else if (a>=180&&a<200)
            {
                Console.WriteLine("You are pretty tall.");
            }
            else if (a >= 160 && a < 180)
            {
                Console.WriteLine("There is no hope for you.");

            }
            else
                Console.WriteLine("Well, you are hobbit.");

            //8.Write a C# Sharp program to find the largest of three numbers.
            Console.WriteLine("Pls write three nice numbers.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a>b&&a>c)
            {
                Console.WriteLine(a+" is biggest");
            }
            else if (b>c&&b>a)
            {
                Console.WriteLine(b+" is biggest.");
            }
            else
                Console.WriteLine(c+" is biggest.");

            //9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
            Console.Write("Tell some point in xy-doordinates. First x-coordinate:");
            string qua = "";
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Then y-coordinate: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>0 && b>0)
            {
                qua = "First";
            }
            else if (a>0&&b<0)
            {
                qua = "second";
            }
            else if (a < 0 && b < 0)
            {
                qua = "Third";
            }
            else if (a < 0 && b > 0)
            {
                qua = "Forth";
            } 

            Console.WriteLine(qua+" quarant.");

            //10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
            Console.Write("Give your Math grade: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give your Physics grade: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give your Chemistry grade: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a >= 65 && b >= 55 && c >= 50 && (a + b + c) >= 180 || (a + b) > 140 || (a + c) > 140)
            {
                Console.WriteLine("Candinaite passes the trial.");
            }
            else
                Console.WriteLine("We are sorry to announce that you are not eligible for admission.");

            //11. Write a C# Sharp program to calculate root of Quadratic Equation. 
            Console.WriteLine("Give three values for quadratic equation");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double d = (b * b) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Root are imaginary, no Solution.");
            }
            else
                Console.WriteLine("x="+((-b+d)/2*a)+" or x="+ ((-b - d) / 2 * a));
            //12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
            Console.WriteLine("Give students roll number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give students name");
            string name = Console.ReadLine();
            Console.WriteLine("Give marks of math, chemistry and computer science (max 100)");
            b = (Convert.ToInt32(Console.ReadLine()));
            c = (Convert.ToInt32(Console.ReadLine()));
            d = (Convert.ToInt32(Console.ReadLine()));
            int total = (b + c + (int)d);
            double per = total / 3.0;
            
            if (total>250)
            {
                Console.WriteLine("First division");
            }
            else if (total>200)
            {
                Console.WriteLine("Second division");
            }
            else if (total > 150)
            {
                Console.WriteLine("Third division");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            //13.Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below
            Console.WriteLine("Give temperature ion celcius");
            a = Convert.ToInt32(Console.ReadLine());
            if (a<-20)
            {
                Console.WriteLine("That is pretty cold");
            }
            else if (a<0)
            {
                Console.WriteLine("Better put coat on");
            }
            else if (a<20)
            {
                Console.WriteLine("Perfect weather for barbeque");
            }
            else
            {
                Console.WriteLine("Don't go into sun or you will be roasted.");
            }

            //14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.WriteLine("Give triangle side lenghts");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a==b&&a==c)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else if (a==b||b==c||c==a)
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }

            //15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
            Console.WriteLine("Give angles of traingle");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a + b + c) == 180)
            {
                Console.WriteLine("Triangle is valid");
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
            }

            //16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant. 
            Console.WriteLine("Give alphabet");
            char chr = Convert.ToChar(Console.ReadLine());
            switch (chr)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'y':
                    Console.WriteLine("It is vowel");
                    break;
                case 'å':
                    Console.WriteLine("It is vowel");
                    break;
                case 'ä':
                    Console.WriteLine("It is vowel");
                    break;

                default:
                    Console.WriteLine("It's not vovel");
                    break;   
            }

            //17. Write a C# Sharp program to calculate profit and loss on a transaction.
            Console.WriteLine("Give companys spendings in euros");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give companys revenue in euros");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Companys total turnover is: {0} euros.",b-a);

            //18. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer.
            Console.Write("Give your customer IDNO: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give your name: ");
            name = Console.ReadLine();
            Console.Write("unit consumed: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b<=199)
            {
                d = 1.20;
            }
            else if (b<400)
            {
                d = 1.5;
            }
            else if (b<600)
            {
                d = 1.8;
            }
            else
            {
                d = 2.0;
            }
            Console.WriteLine("Amount charges @Rs. {0} per unit: {1}",d,d*b);

            //19. Write a program in C# Sharp to accept a grade and declare the equivalent description
            Console.WriteLine("Give grade (E, V, G, A, F)");
            char grade = Convert.ToChar(Console.ReadLine());
            string arvo = "";
            switch (grade)
            {
                case 'E':
                    arvo = "Excellent";
                    break;
                case 'V':
                    arvo = "Very good";
                    break;
                case 'G':
                    arvo = "Great";
                    break;
                case 'A':
                    arvo = "Average";
                    break;
                case 'F':
                    arvo = "Fail";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Result is: {0}",arvo);
            //20.  Write a program in C# Sharp to read any day number in integer and display day name in the word.
            Console.WriteLine("Give day number");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    break;
            }
            //23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month. 
            Console.WriteLine("Give number of some month");
            a = Convert.ToInt32(Console.ReadLine());

            if (a==1||a==3||a==5||a==7||a==8||a==10||a==12)
            {
                Console.WriteLine("Mont have 31 days");
            }
            else if (a==2)
            {
                Console.WriteLine("Moth have 28 days exept in leap year 29 days");
            }
            else if (a>12||a<1)
            {
                Console.WriteLine("There month does not exist.");
            }
            else 
            {
                Console.WriteLine("Monh have 30 days");
            }
            //24.  Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape.
            Console.WriteLine("Choose what type of shape is the case");
            Console.WriteLine("1 = Circle, 2 = Rectangle, 3 = Square");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Give radius");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0} and perimeter is {1}",(Math.PI*d*d),(2*Math.PI*d));
                    break;
                case 2:
                    Console.WriteLine("Give lenght of 1st side");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Give lenght of 2st side");
                    per = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0} and perimeter is {1}",(d*per),(per+per+d+d));
                    break;
                case 3:
                    Console.WriteLine("Give lenght of side");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is {0} and perimeter is {1}",(d*d),(d+d+d+d));
                    break;
                default:
                    break;
            }

            //25. Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
            double value2;
            double value1;
            while (true)
            {
                Console.WriteLine("What calculation you want to do? ");
                Console.WriteLine("Here are the options : 1- Addition 2- Substraction 3- Multiplication 4- Division 5- Exit. ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a>5||a<1)
                {
                    Console.WriteLine("You should choose betveen 1 and 5");
                }
                else if (a==1)
                {
                    Console.WriteLine("Give values to calculate");
                    value1 = double.Parse(Console.ReadLine());
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} + {1} is {2}",value1, value2,(value1+value2));
                }
                else if (a==2)
                {
                    Console.WriteLine("Give values to calculate");
                    value1 = double.Parse(Console.ReadLine());
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} - {1} is {2}", value1, value2, (value1 - value2));
                }
                else if (a==3)
                {
                    Console.WriteLine("Give values to calculate");
                    value1 = double.Parse(Console.ReadLine());
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} * {1} is {2}", value1, value2, (value1 * value2));
                }
                else if (a==4)
                {
                    Console.WriteLine("Give values to calculate");
                    value1 = double.Parse(Console.ReadLine());
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} / {1} is {2}", value1, value2, (value1 / value2));
                }
                else if (a==5)
                {
                    Console.WriteLine("Bye bye");
                    Console.Read();
                    break;
                }
            }

        }
    }
}
