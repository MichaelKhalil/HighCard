using System;
using System.Collections.Generic;
namespace HighCard
{
    internal class Deck
    {
        public const int NUMBER_OF_SUITS = 4;
        public const int NUMBER_OF_CARDTYPES = 13;
        public List<Cards> my_deck = new List<Cards>();
        public Deck()
        {
            addCards();
        }
        public List<Cards> getDeck()
        {
            return my_deck;
        }
        //Add a default 52 unshuffled cards to the deck
        private void addCards()
        {
            for (int i = 1; i <= NUMBER_OF_CARDTYPES; i++)
            {
                for (int j = 1; j <= NUMBER_OF_SUITS; j++)
                {
                    Cards my_card = new Cards(i, j);
                    my_deck.Add(my_card);
                }
            }
        }
        //Fisher–Yates shuffle algorithm stackoverflow.com/questions/49570175/simple-way-to-randomly-shuffle-list
        public void shuffle()
        {
            Random random = new Random();
            int n = my_deck.Count;

            for (int i = my_deck.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Cards value = my_deck[rnd];
                my_deck[rnd] = my_deck[i];
                my_deck[i] = value;
            }
        }
        //Remove all cards from the deck, add 52 unshuffled cards and randomize
        public void remake()
        {
            my_deck.Clear();
            addCards();
            shuffle();
        }
        //Return the current number of cards in the deck
        public int getDeckSize()
        {
            return my_deck.Count;
        }
        //Remove a card at the front of our deck list
        public void removeCard()
        {
            my_deck.RemoveAt(0);
        }
        //Return a card while simultaneously calling removeCard()
        public Cards draw()
        {
            Cards myCard = my_deck[0];
            removeCard();
            return myCard;
        }
    }
}