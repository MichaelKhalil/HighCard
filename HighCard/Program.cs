using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create objects for game
            Player player1 = new Player("");
            Player player2 = new Player("");
            Deck deck = new Deck();
            //Randomize our deck list using Fisher-Yates shuffle algorithm
            deck.shuffle();
            //Name our players
            initPlayers(player1, player2);

            compare(player1, player2, deck);

            Console.ReadKey();
        }

        public static void initPlayers(Player player1, Player player2)
        {
            //Read input from console, call Player class's setName() function, and output greeting
            Console.WriteLine("Input Player One");
            player1.setName(Console.ReadLine());
            Console.WriteLine("Input Player Two");
            player2.setName(Console.ReadLine());
            Console.WriteLine("Hello Player 1: " + player1.getName() + " and Player 2: " + player2.getName());
        }
        public static void compare(Player player1, Player player2, Deck deck)
        {
            Cards player1Card = deck.draw();
            Cards player2Card = deck.draw();

            Console.WriteLine("There are currently: " + deck.getDeckSize() + " cards in the deck.");
            Console.WriteLine(player1Card + " VS " + player2Card);
            if (player1Card.getCardNum() == player2Card.getCardNum())
            {
                if (player1Card.getSuitNum() > player2Card.getSuitNum())
                {
                    Console.WriteLine("Player 1 WINS");
                }
                else
                {
                    Console.WriteLine("Player 2 WINS");
                }
            }
            else
            {
                if (player1Card.getCardNum() > player2Card.getCardNum())
                {
                    Console.WriteLine("Player 1 WINS");
                }
                else
                {
                    Console.WriteLine("Player 2 WINS");
                }
            }
           
        }
    }
}
