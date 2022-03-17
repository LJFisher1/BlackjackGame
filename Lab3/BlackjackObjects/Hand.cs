using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Hand
    {
        protected List<Card> _cards = new List<Card>();
        public void AddCard(Card _card)
        {
            _cards.Add(_card);
        }
        public void Print(int x, int y)
        {
            Deck deck = new Deck();
            foreach (var card in _cards)
            {
                deck.Deal().Print(x,y);
            }
        }
    }
}
