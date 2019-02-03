namespace HighCard
{
    class Cards
    {
        public enum card { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };
        public enum suits { Heart = 1, Diamond = 2, Club = 3, Spade = 4 };
        int myCard, mySuit;
        public Cards(int i, int j)
        {
            myCard = i;
            mySuit = j;
        } 
        public card getCard(int cardNum)
        {
            card card = (card)cardNum;
            return card;
        }
        public card getSuit(int suitNum)
        {
            card suit = (card)suitNum;
            return suit;
        }
        public int getCardNum()
        {
            return myCard;
        }
        public int getSuitNum()
        {
            return mySuit;
        }
        //Override a card's ToString to return the suit and cardType of a card (Ace of Spades)
        public override string ToString()
        {
            return (card)myCard + " of " + (suits)mySuit + "s";
        }

    }
}