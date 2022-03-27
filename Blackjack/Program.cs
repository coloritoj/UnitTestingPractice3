using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(Name.Queen, Suit.Clubs);
            card1.DisplayCardInfo();

            Console.WriteLine("");
            Card card2 = new Card(Name.King, Suit.Diamonds);
            card2.DisplayCardInfo();

            Console.WriteLine("");
            Card card3 = new Card(Name.Nine, Suit.Diamonds);
            card3.DisplayCardInfo();

            Console.WriteLine("");
            Console.WriteLine($"Are cards equal value?: {Card.AreCardsEqualValue(card1, card2)}");

            Console.WriteLine("");
            Console.WriteLine($"Are cards equal value?: {Card.AreCardsEqualValue(card1, card3)}");

            Console.WriteLine("");
            Console.WriteLine($"Are cards same suit?: {Card.AreCardsSameSuit(card1, card2)}");

            Console.WriteLine("");
            Console.WriteLine($"Are cards same suit?: {Card.AreCardsSameSuit(card2, card3)}");

            Console.ReadLine();
        }
    }
}
