using HomeworkTwentySeven.Library;
using System;

namespace HomeworkTwentySeven.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackjackDeck deck = new BlackjackDeck();

            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();

            PokerDeck pokerDeck = new PokerDeck();

            var pokerHand = pokerDeck.DealCards();

            foreach (var pokerCard in pokerHand)
            {
                Console.WriteLine($"{pokerCard.Value} of {pokerCard.Suit}");
            }

            Console.ReadLine();
        }
    }
}
