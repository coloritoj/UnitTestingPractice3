using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public enum Name
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public enum Suit
    {
        Spades, Hearts, Diamonds, Clubs
    }

    public class Card
    {
        public Name CardName { get; set; }

        public Suit CardSuit { get; set; }

        private int cardValue;

        public int CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = ConvertCardValue();
            }
        }

        public int ConvertCardValue()
        {
            if (CardName == Name.Ace)
            {
                return 1;
            }
            else if (CardName == Name.Two)
            {
                return 2;
            }
            else if (CardName == Name.Three)
            {
                return 3;
            }
            else if (CardName == Name.Four)
            {
                return 4;
            }
            else if (CardName == Name.Five)
            {
                return 5;
            }
            else if (CardName == Name.Six)
            {
                return 6;
            }
            else if (CardName == Name.Seven)
            {
                return 7;
            }
            else if (CardName == Name.Eight)
            {
                return 8;
            }
            else if (CardName == Name.Nine)
            {
                return 9;
            }
            else if (CardName == Name.Ten || CardName == Name.Jack || CardName == Name.Queen || CardName == Name.King)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        public Card(Name cardName, Suit cardSuit)
        {
            this.CardName = cardName;
            this.CardSuit = cardSuit;
            this.CardValue = ConvertCardValue();
        }

        public void DisplayCardInfo()
        {
            Console.WriteLine($"Name: {this.CardName}");
            Console.WriteLine($"Value: {this.CardValue}");
            Console.WriteLine($"Suit: {this.CardSuit}");
        }

        public static bool AreCardsEqualValue(Card firstCard, Card secondCard)
        {
            if (firstCard.cardValue == secondCard.CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AreCardsSameSuit(Card firstCard, Card secondCard)
        {
            if (firstCard.CardSuit == secondCard.CardSuit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
