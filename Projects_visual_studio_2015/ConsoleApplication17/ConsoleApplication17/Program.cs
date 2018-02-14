using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tehtävä 15
            for (int numero = 100; numero > 0; numero -= 10)
            {
                if (numero > 10)
                    Console.Write(numero + ", ");
                else
                    Console.Write(numero+"\n");
            }
            #endregion

            #region Tehtävä 16
            Console.WriteLine("Kirjoita sana");
            string Sana = Console.ReadLine();
            for (int x = Sana.Length; x > 0; x--)
            {
                Console.Write(Sana[x - 1]);
                Console.Write(" ");
            }
            #endregion

            #region Tehtävä 17
            //int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8, i = 9, j = 10;
            /*Console.WriteLine("\n\n    " + a + "  " + b + "  " + c + "  " + d + "  " + e + "  " + f + "  " + g + "  " + h + "  " + i + "  " + j);*/

            //for (int z = 0; z < 10; z++)
            //{
            //    int b1 = a * b, c1 = c * a, d1 = d * a, e1 = e * a, f1 = f * a, g1 = g * a, h1 = h * a, i1 = i * a, j1 = a * j;
            //    if (a == 10)
            //        Console.WriteLine("" + a + " " + a + " " + b1 + " " + c1 + " " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + " " + j1);
            //    else if (a == 9)
            //        Console.WriteLine(" " + a + "  " + a + " " + b1 + " " + c1 + " " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + "  " + j1);
            //    else if (a > 4)
            //        Console.WriteLine(" " + a + "  " + a + " " + b1 + " " + c1 + " " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + "  " + j1);
            //    else if (a == 4)
            //        Console.WriteLine(" " + a + "  " + a + "  " + b1 + " " + c1 + " " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + "  " + j1);
            //    else if (a == 3)
            //        Console.WriteLine(" " + a + "  " + a + "  " + b1 + "  " + c1 + " " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + "  " + j1);
            //    else if (a == 2)
            //        Console.WriteLine(" " + a + "  " + a + "  " + b1 + "  " + c1 + "  " + d1 + " " + e1 + " " + f1 + " " + g1 + " " + h1 + " " + i1 + "  " + j1);
            //    else if (a == 1)
            //        Console.WriteLine(" " + a + "  " + a + "  " + b1 + "  " + c1 + "  " + d1 + "  " + e1 + "  " + f1 + "  " + g1 + "  " + h1 + "  " + i1 + "  " + j1);
            //    a = a + 1;}


            #endregion
            Console.WriteLine("\n");

            for (int rivi = 1; rivi <= 10; rivi++)
            {
            
                for (int sarake = 1; sarake <= 10; sarake++)
                {
                    if (rivi == 1 && sarake == 1)
                    {
                        for (int e = 1; e <= 10; e++)
                        {
                            Console.Write("\t" + e);
                        }
                        Console.Write("\n");
                        Console.Write(sarake + "\t");
                        for (int p = 1; p <= 10; p++)
                        {
                            Console.Write(p + "\t");
                        }
                        Console.Write("\n");
                    }
                    else if (rivi == 2)
                    {
                        Console.Write("");
                    }
                    
                    else if (sarake == 1)//a==1 b== >=2
                    {
                        Console.Write(sarake * rivi + "\t" + sarake * rivi + "\t");
                    }
                    else if (sarake > 1)//a>1 b == >=2
                    {
                        Console.Write(sarake * rivi + "\t");
                    }
                }
                if (rivi != 2)
                Console.Write("\n");
                

            
            }
            
        }
    }
}
