using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string valinta = "";
            double raha = 0;
            // Luodaan BankAccount-olio! tili1
            BankAccount tili1 = new BankAccount();
            // vertaa: Random gen = new Random()
            tili1.Id = 34567; // set = asettaa ominaisuudelle arvon
            tili1.Owner = "Paul Redrum";
            tili1.Balance = 15000;
            //Luodaan toinen tili
            BankAccount tili0 = new BankAccount();
            tili0.Id = 7869;
            tili0.Owner = "Kauppisen Pete";
            tili0.Balance = -900;

            #region while duunaus
            while (true)
            {
                Console.WriteLine("Mitä haluat Tehdä? 1 = Katsoa saldoni, 2 = Nostaa rahaaa, 3 = Tallettaa rahaa, 4 = Lopettaa");
                Console.Write("Anna vastauksesi: ");
                valinta = Console.ReadLine();
                while (true)
                {
                    if (valinta == "1" || valinta == "2" || valinta == "3" || valinta == "4")
                    {
                        break;
                    }
                    Console.WriteLine("Kirjoititko varmasti 1, 2, 3 tai 4?");
                    Console.Write("Anna vastauksesi: ");
                    valinta = Console.ReadLine();
                }

                switch (valinta)
                {
                    case "1":
                        Console.WriteLine("Owner: {0}, Saldo: {1}", tili1.Owner, tili1.Balance);
                        goto Jatkuu;

                    case "2":
                        Console.Write("Nostettavan rahan määrä euroissa: ");
                        raha = double.Parse(Console.ReadLine());
                        tili1.Withdraw(raha);
                        Console.WriteLine("Tilisi saldo on nyt: {0} euroa", tili1.Balance);
                        goto Jatkuu;
                    case "3":
                        Console.Write("Talletettavan rahan määrä euroissa: ");
                        raha = double.Parse(Console.ReadLine());
                        tili1.Deposit(raha);
                        Console.WriteLine("Tilisi saldo on nyt: {0} euroa", tili1.Balance);
                        goto Jatkuu;
                    default:
                        break;
                }
                break;
                Jatkuu: { }
            } 
            #endregion

        }
    }
}
