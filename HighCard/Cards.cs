namespace HighCard
{
    class Cards
    {
        //enum for card and suits that attributes it's comparison score in relation to the others.
        public enum card { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };
        public enum suits { Spade = 1, Heart = 2, Club = 3, Diamond = 4 };
        int my_card, my_suit;
        public Cards(int i, int j)
        {
            my_card = i;
            my_suit = j;
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
            return my_card;
        }
        public int getSuitNum()
        {
            return my_suit;
        }
        //Override a card's ToString to return the suit and cardType of a card (prints: Ace of Spades)
        public override string ToString()
        {
            return (card)my_card + " of " + (suits)my_suit + "s";
        }

    }
}