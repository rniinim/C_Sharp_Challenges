using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Sharp Data Types Exercises
            //1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
            Console.WriteLine("Give three letters: ");
            char aLetter = Convert.ToChar(Console.ReadLine());
            char bLetter = Convert.ToChar(Console.ReadLine());
            char cLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}, {1}, {2}", cLetter, bLetter, aLetter);

            //2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
            Console.Write("Give value of a number: ");
            string aValue = Console.ReadLine();
            Console.Write("Give width: ");
            int wValue = int.Parse(Console.ReadLine());
            for (int rivi = 0 ;wValue!= rivi; wValue--)
            {
                for(int pystysarake = 0; wValue!= pystysarake; pystysarake++)
                { 
                Console.Write(aValue );

                }
                Console.WriteLine("\t"); 
             }

            //3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected. 
            Console.WriteLine("Please give your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please give your password:");
            string password = Console.ReadLine();
            bool login=false;
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Please give your username:");
                string username1 = Console.ReadLine();
                Console.WriteLine("Please give your password:");
                string password1 = Console.ReadLine();

                if (username1 == username && password == password1)
                {
                    login = true;
                    break;
                }
            }
            
            if (login == true)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Go out!");
            }

            //4. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.
            Console.Write("Give two numbers: ");
            double numeroA = double.Parse(Console.ReadLine());
            double numeroB = double.Parse(Console.ReadLine());
            Console.WriteLine(numeroA+" + "+numeroB+" = "+(numeroA+numeroB) );
            Console.WriteLine(numeroA + " - " + numeroB + " = " + (numeroA - numeroB));
            Console.WriteLine(numeroA + " / " + numeroB + " = " + (numeroA /numeroB));
            Console.WriteLine(numeroA + " X " + numeroB + " = " + (numeroA * numeroB));

            //5. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
            Console.Write("Anna ympyrän säteen pituus: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ympyrän säde on: ");
            Console.WriteLine(2 * Math.PI * radius);

            //6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
            //x = y2 + 2y + 1
            Console.Write("Anna funktion \"x = y^2 + 2y + 1\" y:lle arvo: ");
            double valueY = double.Parse(Console.ReadLine());
            Console.WriteLine("Here is +5/-5 values of x: "+((valueY*valueY)+(2*valueY)+6)+" and "+((valueY * valueY) + (2 * valueY) -4));

            //7. Write a C# Sharp program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour. 
            Console.Write("Input distance in kilometers: ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Input time in hours: ");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine("Speed is "+(distance/time)+"km/h");
            Console.WriteLine("Speed is "+((distance/time)* 0.621371192) +"mp/h");


            //8. Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
            Console.Write("Give radius of sphere: ");
            radius = Convert.ToDouble(Console.ReadLine());
            double area = (4 * Math.PI * Math.Pow(radius, 2));
            double volume = ((4/3) * Math.PI * Math.Pow(radius, 3));
            Console.WriteLine("Area is: "+area+"\tVolume is: "+volume);

            //9. Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.
            char input = char.Parse(Console.ReadLine());
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("Symbool is lowercase vowel.");
            }
           else if (input >= 0 && input <= 9)
            {
                Console.WriteLine("Symbol is sigit");
            }
            else
                Console.WriteLine("Symbol is something else.");

            //10. Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd. 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool bothEven;

            bothEven = ((a % 2 ==0) && (b % 2 == 0)) ? true : false;
            Console.WriteLine(bothEven ? "Both are even":"Numbers are odd");

            //11.  Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form. 
            int dec = int.Parse(Console.ReadLine());
            string result = "";
            while (dec>1)
            {
                int remainder = dec % 2;
                result = Convert.ToString(remainder) + result;
                dec /= 2;
            }
            Console.WriteLine("binay: "+result);
        }

        }
    }
