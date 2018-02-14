using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://codereview.stackexchange.com/questions/60314/console-blackjack-game
namespace Blackjack
{
    public enum Suit
    {
        Heart,
        Diamond,
        Spade,
        Club
    }

    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Value { get; set; }
    }

    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            this.Initialize();

        }

        public void Initialize()
        {
            cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j });

                    if (j <= 8)
                    {
                        cards[cards.Count - 1].Value = j + 1;
                    }
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
        }

        public void Suffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n>1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = cards[k];
                

            }
        }

        public Card DrawACard()
        {
            if (cards.Count <= 0)
            {
                this.Initialize();
                this.Suffle();
            }

            Card cardToReturn = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return cardToReturn;
        }

        public int GetAmountOfRemainingCards()
        {
            return cards.Count;
        }

        public void PrintDeck()
        {
            int i = 1;
            foreach(Card card in cards)
            {
                Console.WriteLine("Card {0}: {1} of {2}. Value {3}",i,card.Face,card.Suit, card.Value);
            }
        }
    }
    
    class Program
    {
        static int chips;
        static Deck deck;
        static List<Card> userHand;
        static List<Card> dealerHand;

        static void Main(string[] args)
        {
            Console.Title = "♠♥♣♦ Blackjack Game by Niv Harel";
            Console.WriteLine("Welcome to blackjack");

            chips = 100;
            deck = new Deck();
            deck.Suffle();

            while (chips > 0)
            {
                DealHand();
                Console.WriteLine("\nPress any key for the next hand...\n");
                ConsoleKeyInfo userInput = Console.ReadKey(true);
            }

            Console.WriteLine("You lost! See you next time....");
        }

        static void DealHand()
        {
            if (deck.GetAmountOfRemainingCards() < 20)
            {
                deck.Initialize();
                deck.Suffle();
            }

            Console.WriteLine("Remaining Cards: {0}", deck.GetAmountOfRemainingCards());
            Console.WriteLine("Current Chips: {0}", chips);
            Console.WriteLine("How much would you like to bet (1 - {0})",chips);
            string input = Console.ReadLine().Trim().Replace(" ", "");
            int betAmount;
            while (!Int32.TryParse(input, out betAmount) || betAmount < 1 || betAmount > chips)
            {
                Console.WriteLine("Amount is illegal. How much would you like to bet? (1 - {0})", chips);
                input = Console.ReadLine().Trim().Replace(" ", "");
            }
            Console.WriteLine();

            userHand = new List<Card>();
            userHand.Add(deck.DrawACard());
            userHand.Add(deck.DrawACard());

            foreach (Card card in userHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Player]");
            Console.WriteLine("Card 1: {0} of {1}", userHand[0].Face, userHand[0]);
            Console.WriteLine("Card 2: {0} of {1}", userHand[1].Face, userHand[1]);
            Console.WriteLine("Total: {0}\n", userHand[0].Value + userHand[1].Value);

            dealerHand = new List<Card>();
            dealerHand.Add(deck.DrawACard());
            dealerHand.Add(deck.DrawACard());

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Dealer]");
            Console.WriteLine("Card 1: {0} of {1}",dealerHand[0].Face, dealerHand[1].Suit);
            Console.WriteLine("Card 2: [Hole Card]");
            Console.WriteLine("Total: {0}\n", dealerHand[0].Value);

            bool insurance = false; ;

            if (dealerHand[0].Face == Face.Ace)
            {
                Console.WriteLine("Insurance? (y / n)");
                string userInput = Console.ReadLine();

                while (userInput != "y" && userInput != "n")
                {
                    Console.WriteLine("Could not understand. Insurance? (y / n)");
                    userInput = Console.ReadLine();
                }

                if (userInput == "y")
                {
                    insurance = true;
                    //chips -= betAmout / 2;
                    Console.WriteLine("\n[Insurance Accepted!]\n");
                }

                else
                {
                    insurance = false;
                    Console.WriteLine("\n[Insurance Rejected]\n");
                }
            }

            if (dealerHand[0].Face == Face.Ace || dealerHand[0].Value == 10)
            {
                Console.WriteLine("Dealer checks if he has blackjack...\n");
                Thread.Sleep(2000);

            }
        }
    }
}
