using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    class CardFactory
    {
        public static Card CreateCard(CardFace cardFace, CardSuit cardSuit)
        {
            return new Card(cardFace, cardSuit);
        }

    }
}
