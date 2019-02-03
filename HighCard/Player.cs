namespace HighCard
{
    internal class Player
    {
        private string player_name;
        private int score;
        public Player()
        {
        }

        public void setName(string name)
        {
            player_name = name;
        }
        public string getName()
        {
            return player_name;
        }

        public void incrementScore()
        {
            score++;
        }
        public int getScore()
        {
            return score;
        }
        public void clearScore()
        {
            score = 0;
        }
    }
}