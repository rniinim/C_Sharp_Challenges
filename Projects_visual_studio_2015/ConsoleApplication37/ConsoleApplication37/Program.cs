using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            VolumeOfSphere();
        }

        private static void VolumeOfSphere()
        {
            // This is solution for Volume Of Sphere
            double radius, sphere, PI;
            PI = Math.PI;

            Console.Write("Input radius of sphere in cm:");
            radius = int.Parse(Console.ReadLine());
            sphere = (4.0 / 3.0) * PI * Math.Pow(radius, 3);

            Console.WriteLine("With radius of: {0}cm, volume of sphere is: {1}cm^3", radius, sphere);
        }

        private static void DecimalToBinary()
        {

            // This is solution for Decimal To Binary
            string answer, result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = remainder.ToString() + result;
                num /= 2;
            }
            result = num.ToString() + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
    
        private static void YearsInSeconds()
        {
            // This is solution for calculate years in seconds

            Console.Write("Give input amount of years: ");
            int years = int.Parse(Console.ReadLine());
            double seconds = (years * 365.25 * 24 * 3600);

            Console.WriteLine("{0} Years is ~{1} seconds", years, seconds);
        }

        private static void PassGenerator()
        {
            // This is solution for Password Generator

            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rng = new Random();

            Console.Write("Give lenght of password: ");
            int length = int.Parse(Console.ReadLine());
            string password = "";

            for (int i = 0; i < length; i++)
            {
                password += characters[rng.Next(0, characters.Length)];
            }

            Console.WriteLine(password);
        }

        private static void NumberPassGenerator()
        {
            // This is solution for number password generator

            Random rng = new Random();

            Console.Write("Give lenght of password: ");
            int length = int.Parse(Console.ReadLine());
            int temp;
            string password = "";

            for (int i = 0; i < length; i++)
            {
                temp = rng.Next(0, 10);
                password += temp;
            }
            Console.WriteLine(password);
        }

        private static void LettersOfWord()
        {
            // This is solution for Letters of word

            Console.Write("Give word: ");
            string word = Console.ReadLine();

            for (int i = 1; i <= word.Length; i++)
            {
                Console.WriteLine(word.Substring(0, i));
            }
        }

        private static void PrintNumbers()
        {
            // This is solution for numbers 1 to 100

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }
        }

        private static void Reverse_Word()
        {
            // This is solution for reverse word

            Console.Write("Give word: ");
            string word = Console.ReadLine();
            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            Console.WriteLine(reversed);
        }

        private static void Russian_Roulette_Game()
        {
            // This solution for Russian roulette game

            bool alive = true;
            Random rng = new Random();
            int shot = 0;

            while (alive)
            {
                shot = rng.Next(0, 7);
                Console.WriteLine("Press enter to pull trigger");
                Console.ReadKey();

                if (shot == 6)
                {
                    alive = false;
                }
                else
                {
                    Console.WriteLine("Click!");
                }
            }
            Console.WriteLine("Boom! Game over");
        }

        private static void Even_Or_Odd()
        {
            //This is solution for check if number is even or odd

            Console.WriteLine("Give nubmer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even number.", number);
            }

            else
            {
                Console.WriteLine("{0} is odd number.", number);
            }
        }

        private static void Addition()
        {
            // This is solution for addition

            Console.Write("Give first value: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Give second value: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", value1, value2, value1 + value2);
        }

        private static void SimpleCalculator()
        {
            // This is solution for simple calculator

            Console.WriteLine("What do you want to do? (+, -, * or /)");
            string cal = Console.ReadLine();

            Console.Write("Input 1st term: ");
            double term1 = double.Parse(Console.ReadLine());
            Console.Write("Input 2nd term: ");
            double term2 = double.Parse(Console.ReadLine());

            if (cal == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", term1, term2, (term1 + term2));
            }
            else if (cal == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", term1, term2, (term1 - term2));
            }
            else if (cal == "*")
            {
                Console.WriteLine("{0} * {1} = {2}", term1, term2, (term1 * term2));
            }
            else if (cal == "/")
            {
                Console.WriteLine("{0} / {1} = {2}", term1, term2, (term1 / term2));
            }
            else
            {
                Console.WriteLine("You have to write +, -, * or / !");
            }
        }

        private static void askName()
        {
            // This is solution for ask name - greet name

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hey {0}!", name);
        }

        private static void MultiplicationTable()
        {
            // This is solution from print results of multiplication table from 1 to 10

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.Write("\n");
            }
        }

        private static void TemperatureConverter()
        {
            // This is solution for Temperature converter fromn celsius to fahrenheit
            double value = 0;
            double result = 0;
            bool dNumber = false;

            while (!dNumber)
            {
                Console.Write("Give Celsius degrees (e.g 20.8): ");
                dNumber = double.TryParse(Console.ReadLine(), out value);
            }

            result = value * 9 / 5 + 32;
            Console.WriteLine("{0} Celsius degrees is {1} in Fahrenheit", value, result);
        }

        private static void Rock_Paper_Scissors_Lizard_Spock()
        {
            // This is solution for Rock, Paper, Sissors, Lizard, Spock

            string playerChoise;
            int computerChoise;
            Random rng = new Random();

            Console.Write("Write rock , paper, scissors, lizard or spock : ");
            playerChoise = Console.ReadLine();
            playerChoise = playerChoise.ToLower();
            computerChoise = rng.Next(0, 5);

            if (playerChoise == "rock")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("Computer won!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 3)
                {
                    Console.WriteLine("Computer selected lizard");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 4)
                {
                    Console.WriteLine("Computer selected spock");
                    Console.WriteLine("You lost.");
                }
            }

            else if (playerChoise == "paper")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 3)
                {
                    Console.WriteLine("Computer selected lizard");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 4)
                {
                    Console.WriteLine("Computer selected spock");
                    Console.WriteLine("You won!");
                }
            }

            else if (playerChoise == "scissors")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 3)
                {
                    Console.WriteLine("Computer selected lizard");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 4)
                {
                    Console.WriteLine("Computer selected spock");
                    Console.WriteLine("You lost.");
                }
            }

            else if (playerChoise == "lizard")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 3)
                {
                    Console.WriteLine("Computer selected lizard");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 4)
                {
                    Console.WriteLine("Computer selected spock");
                    Console.WriteLine("You won!");
                }
            }

            else if (playerChoise == "spock")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("You lost");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 3)
                {
                    Console.WriteLine("Computer selected lizard");
                    Console.WriteLine("You lost!");
                }

                else if (computerChoise == 4)
                {
                    Console.WriteLine("Computer selected spock");
                    Console.WriteLine("Tie!");
                }
            }

            else
            {
                Console.WriteLine("You have to choose rock, paper, scissors, lizard or spock !");
            }
        }

        private static void Rock_Pape_Scissors()
        {
            // This is solution for Rock - Paper - Scissors

            string playerChoise;
            int computerChoise;
            Random rng = new Random();


            Console.Write("Write rock , paper or scissors : ");
            playerChoise = Console.ReadLine();
            computerChoise = rng.Next(0, 3);
            playerChoise = playerChoise.ToLower();

            if (playerChoise == "rock")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("Computer won.");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You won!");
                }
            }

            else if (playerChoise == "paper")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("Tie!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("You lost.");
                }
            }

            else if (playerChoise == "scissors")
            {
                if (computerChoise == 0)
                {
                    Console.WriteLine("Computer selected rock");
                    Console.WriteLine("You lost.");
                }

                else if (computerChoise == 1)
                {
                    Console.WriteLine("Computer selected paper");
                    Console.WriteLine("You won!");
                }

                else if (computerChoise == 2)
                {
                    Console.WriteLine("Computer selected scissors");
                    Console.WriteLine("Tie!");
                }
            }

            else
            {
                Console.WriteLine("You have to choose rock, paper or scissors !");
            }
        }

        private static void HeadOrTails()
        {
            // This is solution for Head/tails challenge

            int throws, coin;
            Console.Write("How many times do you want to flip a coin? ");
            throws = int.Parse(Console.ReadLine());


            Random rng = new Random();
            for (int i = 0; i < throws; i++)
            {
                coin = rng.Next(0, 2);
                if (coin == 0)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
            }  /* This is solution for addition */
        }
        }
    }

