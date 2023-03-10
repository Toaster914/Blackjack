//Toaster914, 3/7/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public Suit suit { get; }
        public Face face { get; }

        /// <summary>
        /// Constructs a new card.
        /// </summary>
        /// <param name="suit">The suit of the card</param>
        /// <param name="face">The face of the card.</param>
        public Card(Suit suit, Face face)
        {
            this.suit = suit;
            this.face = face;
        }

        /// <summary>
        /// Gets the value of a card. Jacks, Queens, and Kings are 10's.
        /// </summary>
        /// <returns>The value of a card.</returns>
        public int GetCardValue()
        {
            if(face == Face.Jack || face == Face.Queen || face == Face.King)
            {
                return 10;
            }
            else
            {
                return (int)face;
            }
        }
    }
}
