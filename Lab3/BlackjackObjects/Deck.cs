using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Deck
    {
        List<Card> _deck = new List<Card>();

        public Deck()
        {
            CreateAllCards();
        }
        public void CreateAllCards()
        {
            // suit
            for (int i = 1; i < 4; i++)
            {
                // face
                for (int j = 1; j < 13; j++)
                {
                    _deck.Add(CardFactory.CreateCard((CardFace)j, (CardSuit)i));
                }
            }
        }
        public void Shuffle()
        {
            Random rando = new Random();
            List<Card> tempDeck = new List<Card>();
            while (_deck.Count > 0)
            {
                int temp = rando.Next(_deck.Count-1);
                tempDeck.Add(_deck[temp]);
                _deck.RemoveAt(temp);
            }
            _deck = tempDeck;
        }
        public Card Deal()
        {
            Card dealt = _deck[0];
            _deck.RemoveAt(0);
            if(_deck.Count == 0)
            {
                CreateAllCards();
                Shuffle();
            }
            return dealt;
        }
    }
}
