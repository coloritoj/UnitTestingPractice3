using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Hand
    {
        public static int GetHandValue(List<Card> handValue)
        {
            int valueCounter = 0;

            foreach (Card card in handValue)
            {
                valueCounter += card.CardValue;
            }

            return valueCounter;
        }
    }
}
