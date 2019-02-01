namespace HighCard
{
    internal class Player
    {
        private string player_name;
        public Player(string name)
        {
            player_name = name;
        }
        public string getName()
        {
            return player_name;
        }
    }
}