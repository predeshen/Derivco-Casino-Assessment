using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Derivco_Casino_Assesment
{
    internal class Program
    {
        static List<string> deck = new List<string>();
        static List<string> playersHand = new List<string>();
        static List<string> dealersHand = new List<string>();
        static int PlayerTotal = 0;
        static int DealerTotal = 0;
        static string card = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Player");

            GenerateDeck();

            DealPlayer();

            if(PlayerTotal > 21)
            {
                Console.WriteLine("Dealer Wins");
            }
            else
            {
                DealDealer();
                if (DealerTotal > 21)
                {
                    Console.WriteLine("Player wins");
                    
                }
                else
                {
                    if (PlayerTotal > DealerTotal)
                    {
                        Console.WriteLine("Player Wins");
                    }
                    else
                    {
                        Console.WriteLine("Dealer Wins");
                    }
                }
            }

            Console.WriteLine("Players Total : " + PlayerTotal);
            Console.WriteLine("Dealers Total : " + DealerTotal);
            Console.ReadKey();
        }

        static void GenerateDeck()
        {
                for(int j = 1; j < 11; j++)
                {
                    deck.Add("Diamonds - " + j);
                    deck.Add("Hearts - " + j);
                    deck.Add("Spades - " + j);
                    deck.Add("Clubs - " + j);
                    if (j == 10)
                    {
                        deck.Add("Diamonds Jack - " + 10); deck.Add("Diamonds Queen - " + 10); deck.Add("Diamonds King - " + 10);
                        deck.Add("Hearts Jack - " + 10); deck.Add("Hearts Queen - " + 10); deck.Add("Hearts King - " + 10);
                        deck.Add("Spades Jack - " + 10); deck.Add("Spades Queen - " + 10); deck.Add("Spades King - " + 10);
                        deck.Add("Clubs Jack - " + 10); deck.Add("Clubs Queen - " + 10); deck.Add("Clubs King - " + 10);
                    }
                }          
        }
        static string GetRandomCard()
        {
            var random = new Random();
            int index = random.Next(deck.Count);
            string card = deck.ElementAt(index);
            deck.RemoveAt(index);

            return card;
        }
        static void DealPlayer()
        {            
            Console.WriteLine("If you want to stop please press 'S' or 'Enter to receive your next card'");           
            Console.WriteLine("Players Cards :");
            while (Console.ReadKey().Key != ConsoleKey.S)
            {
                GetCards("Player");
                if (PlayerTotal > 21)
                {
                    break;
                }
            }
        }
        static void DealDealer()
        {
            while (PlayerTotal <=21 && DealerTotal < 17)
            {
                GetCards("Dealer");
            }
            if(DealerTotal == PlayerTotal)
            {
                GetCards("Dealer");
            }
            Console.WriteLine("Dealers cards :");
            dealersHand.ForEach(Console.WriteLine);
        }

        static void GetCards(string player)
        {
            int cardValue = 0;

            if (player == "Player")
            {
                card = GetRandomCard();
                playersHand.Add(card);
                int.TryParse(card.Split('-').Last(), out cardValue);
                PlayerTotal = PlayerTotal + cardValue;
                Console.WriteLine(card);
            }
            if (player == "Dealer")
            {
                card = GetRandomCard();
                dealersHand.Add(card);
                int.TryParse(card.Split('-').Last(), out cardValue);
                DealerTotal = DealerTotal + cardValue;
            }
        }
    }
}
