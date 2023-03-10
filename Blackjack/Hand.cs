//Toaster914, 3/7/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Hand
    {

        private List<Card> cards;
        
        /// <summary>
        /// Constructs a new list with type card.
        /// </summary>
        public Hand()
        {
            cards = new List<Card>();
        }

        /// <summary>
        /// adds a card to the list.
        /// </summary>
        /// <param name="card">The card to add.</param>
        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// Totals up the value of all the cards in the card list.
        /// </summary>
        /// <returns></returns>
        public int GetHandValue()
        {
            int total = 0;
            foreach(Card card in cards)
            {
                total += card.GetCardValue();
            }
            return total;
        }
    }
}
