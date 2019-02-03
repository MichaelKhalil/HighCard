namespace HighCard
{
    class Cards
    {
        //enum for card and suits that attributes it's comparison score in relation to the others.
        //The higher the number, the higher the priority when comparing. Rearrange to change priority
        public enum card {Two = 1, Three = 2, Four = 3, Five = 4, Six = 5, Seven = 6, Eight = 7, Nine = 8, Ten = 9, Jack = 10, Queen = 11, King = 12, Ace = 13};
        public enum suits {Spade = 1, Heart = 2, Club = 3, Diamond = 4};
        int my_card, my_suit;
        public Cards(int i, int j)
        {
            my_card = i;
            my_suit = j;
        } 
        //Return the card type for comparison
        public int getCardNum()
        {
            return my_card;
        }
        //return the suit of a card for comparison
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