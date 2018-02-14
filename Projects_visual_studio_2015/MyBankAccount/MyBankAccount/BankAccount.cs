using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankAccount
{
    class BankAccount
    {
        // Ominaisuudet (properties) Id, Owner, Balance
        public int Id { get; set; }
        public string Owner { get; set; }
        public double Balance { get; set; }
        // Staattinen ominaisuus Rate. Jokaisella tilillä on sama korko
        public static double Rate { get; set; }
        // Metodit Deposit, Withdraw 
        public void Deposit(double euros)
        {
            Console.WriteLine("Tilille talletetaan {0} euroa", euros);
            Balance += euros;
        }
        public void Withdraw(double euros)
        {
            Console.WriteLine("Tililtä otetaan {0} euroa", euros);
            Balance -= euros;
        }
        public void Show()
        {
            Console.WriteLine("Owner: {0}", Owner);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Balance: {0}", Balance);
        }
    }
}
