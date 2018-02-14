using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program in C# Sharp to find the length of a string without using library function.
            string lause2 = "Poppari";
            Console.WriteLine("Length of the {0} is : "+lause2.Length,lause2);

            //3.  Write a program in C# Sharp to separate the individual characters from a string.

            /* muodostetaan taulukko merkeistä ja tulostetaan taulukko */
            char[] merkki = new char[lause2.Length];
            for (int i = 0; i < lause2.Length; i++)
            {
                merkki[i]  = char.Parse(lause2.Substring(i,1));
                Console.Write(merkki[i] + " ");
            }

            //5. Write a program in C# Sharp to count the total number of words in a string.
            string lause5 = "C sharp exercise";
            int words = 1;
            /* Kerätään muuttujaan words sanojen määrä käyttäen välejä */
            for (int i = 0; i < lause5.Length; i++)
            {
                if (lause5[i] == ' '|| lause5[i] == '\t' || lause5[i]=='\n')
                {
                    words++;
                }
            }
            Console.WriteLine("\nString is {0}\nAmount of words = "+words,lause5);

            //7. Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.
            string lause7 = "https://www.youtube.com/watch?v=l65hR94nfqY&t=6734s";
            int amountOfAlphabets = 0;
            int amountOfDigits = 0;
            int amountOfSpecial = 0;
            /*kerätään muuttujiin merkkien sisällön mukaiset määrät*/
            for (int i = 0; i < lause7.Length; i++)
            {
                if (lause7[i]<='z'&&lause7[i]>='a'|| lause7[i] <= 'Z' && lause7[i] >= 'A')
                {
                    amountOfAlphabets++;
                }
                else if (lause7[i] >= '0' && lause7[i] <= '9')
                {
                    amountOfDigits++;
                }
                else
                {
                    amountOfSpecial++;
                }
            }
            Console.WriteLine("\nString is {0},\namount of digits: {1}, amount alphabets: {2} and amount of special characters: {3}.",lause7,amountOfDigits,amountOfAlphabets,amountOfSpecial);

            //8. Write a program in C# Sharp to copy one string to another string.
            string lause8a = "This is a string to be copied.";
            string lause8b = "";

            for (int i = 0; i < lause8a.Length; i++)
            {
                lause8b += lause8a[i];
            }
            Console.WriteLine("\nString 1 is {0} \nString 2 is now {1}",lause8a,lause8b);

            //9. Write a program in C# Sharp to count a total number of vowel or consonant in a string.
            string lause9 = "welcome to w3resource.com";
            int amountOfVowels = 0;
            int amoutOfconsonant = 0;

            for (int i = 0; i < lause9.Length; i++)
            {
                switch (lause9[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        amountOfVowels++;
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'x':
                    case 'z':
                        amoutOfconsonant++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("\nIn string: {2}\nAmount of vowels: {0}\nAmount of consonant: {1}", amountOfVowels, amoutOfconsonant,lause9);

            //11.Write a program in C# Sharp to sort a string array in ascending order.
            string lause11 = "this is a string";
            char c;
            StringBuilder sb = new StringBuilder(lause11);
            for (int j = 0; j < lause11.Length; j++)
            {
                for (int i = 0; i < lause11.Length; i++)
                {
                    if (sb[i] > sb[i + 1])
                    {
                        c = sb[i];
                        sb[i] = sb[i + 1];
                        sb[i + 1] = c;
                    }
                }
            }
            Console.WriteLine("\nOrginal string was: {0}", lause11);
            lause11 = sb.ToString();
            Console.WriteLine("New string is: {0}", lause11);

        }
    }
}
