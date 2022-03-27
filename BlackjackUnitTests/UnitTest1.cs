using NUnit.Framework;
using Blackjack;
using System.Collections.Generic;

namespace BlackjackUnitTests
{
    public class BlackjackValueTests
    {
        [Test]
        public void TEST01_Ace_Returns_1()
        {
            // ARRANGE
            Card card = new Card(Name.Ace, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(1, card.CardValue);
        }

        [Test]
        public void TEST02_Two_Returns_2()
        {
            // ARRANGE
            Card card = new Card(Name.Two, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(2, card.CardValue);
        }

        [Test]
        public void TEST03_Three_Returns_3()
        {
            // ARRANGE
            Card card = new Card(Name.Three, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(3, card.CardValue);
        }

        [Test]
        public void TEST04_Four_Returns_4()
        {
            // ARRANGE
            Card card = new Card(Name.Four, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(4, card.CardValue);
        }

        [Test]
        public void TEST05_Ten_Returns_10()
        {
            // ARRANGE
            Card card = new Card(Name.Ten, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(10, card.CardValue);
        }

        [Test]
        public void TEST06_Jack_Returns_10()
        {
            // ARRANGE
            Card card = new Card(Name.Jack, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(10, card.CardValue);
        }

        [Test]
        public void TEST07_Queen_Returns_10()
        {
            // ARRANGE
            Card card = new Card(Name.Queen, Suit.Clubs);

            // ACT
            // Not needed

            // ASSERT
            Assert.AreEqual(10, card.CardValue);
        }
    }

    public class BlackjackValueAreEqualTests
    {
        [Test]
        public void TEST01_King_Equals_Queen()
        {
            // ARRANGE
            Card card1 = new Card(Name.King, Suit.Clubs);
            Card card2 = new Card(Name.Queen, Suit.Clubs);

            // ACT
            bool areCardsEqual = Card.AreCardsEqualValue(card1, card2);

            // ASSERT
            Assert.IsTrue(areCardsEqual);
        }

        [Test]
        public void TEST02_King_Equals_10()
        {
            // ARRANGE
            Card card1 = new Card(Name.King, Suit.Hearts);
            Card card2 = new Card(Name.Ten, Suit.Hearts);

            // ACT
            // Going to combine with assert

            // ASSERT
            Assert.IsTrue(Card.AreCardsEqualValue(card1, card2));
        }

        [Test]
        public void TEST03_King_Does_Not_Equal_9()
        {
            Card card1 = new Card(Name.King, Suit.Diamonds);
            Card card2 = new Card(Name.Nine, Suit.Hearts);

            Assert.IsFalse(Card.AreCardsEqualValue(card1, card2));
        }
    }

    public class BlackjackSuitAreEqualTests
    {
        [Test]
        public void TEST01_Hearts_Equals_Hearts()
        {
            Card card1 = new Card(Name.Seven, Suit.Hearts);
            Card card2 = new Card(Name.Two, Suit.Hearts);

            Assert.IsTrue(Card.AreCardsSameSuit(card1, card2));
        }

        [Test]
        public void TEST02_Spades_Equals_Spades()
        {
            Card card1 = new Card(Name.King, Suit.Spades);
            Card card2 = new Card(Name.Three, Suit.Spades);

            Assert.IsTrue(Card.AreCardsSameSuit(card1, card2));
        }

        [Test]
        public void TEST03_Spades_Does_Not_Equal_Diamonds()
        {
            Card card1 = new Card(Name.Ace, Suit.Spades);
            Card card2 = new Card(Name.Ace, Suit.Diamonds);

            Assert.IsFalse(Card.AreCardsSameSuit(card1, card2));
        }
    }

    public class BlackjackHandValueTests
    {
        [Test]
        public void TEST01_Queen_Plus_King_Returns_20()
        {
            Card card1 = new Card(Name.Queen, Suit.Clubs);
            Card card2 = new Card(Name.King, Suit.Clubs);

            List<Card> mycards = new List<Card>();
            mycards.Add(card1);
            mycards.Add(card2);

            Assert.AreEqual(20, Hand.GetHandValue(mycards));
        }

        [Test]
        public void TEST02_Queen_Plus_Seven_Returns_17()
        {
            Card card1 = new Card(Name.Queen, Suit.Clubs);
            Card card2 = new Card(Name.Seven, Suit.Hearts);

            List<Card> mycards = new List<Card>();
            mycards.Add(card1);
            mycards.Add(card2);

            Assert.AreEqual(17, Hand.GetHandValue(mycards));
        }

        [Test]
        public void TEST03_Five_Plus_Jack_Returns_15()
        {
            Card card1 = new Card(Name.Five, Suit.Clubs);
            Card card2 = new Card(Name.Jack, Suit.Diamonds);

            List<Card> mycards = new List<Card>();
            mycards.Add(card1);
            mycards.Add(card2);

            Assert.AreEqual(15, Hand.GetHandValue(mycards));
        }

        [Test]
        public void TEST04_Jack_Plus_Two_Plus_Four_Returns_16()
        {
            Card card1 = new Card(Name.Jack, Suit.Clubs);
            Card card2 = new Card(Name.Two, Suit.Diamonds);
            Card card3 = new Card(Name.Four, Suit.Clubs);

            List<Card> mycards = new List<Card>();
            mycards.Add(card1);
            mycards.Add(card2);
            mycards.Add(card3);

            Assert.AreEqual(16, Hand.GetHandValue(mycards));
        }
    }
}