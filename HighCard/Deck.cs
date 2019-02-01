using System.Collections.Generic;

namespace HighCard
{
    internal class Deck
    {
        private List<Cards> myDeck;
        public Deck()
        {

        }
        public List<Cards> getDeck()
        {
            return myDeck;
        }
    }
}