using System;
using System.Collections.Generic;
namespace HighCard
{
    internal class Deck
    {
        public const int NUMBER_OF_SUITS = 4;
        public const int NUMBER_OF_CARDTYPES = 13;
        public List<Cards> myDeck = new List<Cards>();
        public Deck()
        {
            for(int i = 1; i <= NUMBER_OF_CARDTYPES; i++)
            {
                for(int j = 1; j <= NUMBER_OF_SUITS; j++)
                {
                    Cards myCard = new Cards(i, j);
                    myDeck.Add(myCard);
                }
            }
        }
        public List<Cards> getDeck()
        {
            return myDeck;
        }
        //Fisher–Yates shuffle algorithm stackoverflow.com/questions/49570175/simple-way-to-randomly-shuffle-list
        public void shuffle()
        {
            Random random = new Random();
            int n = myDeck.Count;

            for (int i = myDeck.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Cards value = myDeck[rnd];
                myDeck[rnd] = myDeck[i];
                myDeck[i] = value;
            }
        }
        public int getDeckSize()
        {
            return myDeck.Count;
        }
        //Remove a card at the front of our deck list
        public void removeCard()
        {
            myDeck.RemoveAt(0);
        }
        //Return a card while simultaneously calling removeCard()
        public Cards draw()
        {
            Cards myCard = myDeck[0];
            removeCard();
            return myCard;
        }
    }
}