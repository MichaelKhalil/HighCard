using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCard
{
    class Program
    {
        //Main game logic loop
        static void Main(string[] args)
        {
            //Create objects/variables for game
            Player player1 = new Player();
            Player player2 = new Player();
            Deck deck = new Deck();
            bool game_state = true;
            
            //Name our players
            initPlayers(player1, player2);
            //Determine if the player needs to press enter between each card draw
            bool autorun = checkAutorun();
            //Randomize our deck list using Fisher-Yates shuffle algorithm
            deck.shuffle();

            //Play a round until the deck is empty 
            while (game_state == true)
            {
                while (deck.getDeckSize() > 0)
                {
                    //Main game loop
                    compare(player1, player2, deck);
                    //Wait for the user to press enter
                    if(autorun == false)
                    {
                        Console.ReadLine();
                    }
                }
                declareWinner(player1, player2);
                //See if we will still be playing
                game_state = checkGame();
                //if we are playing, creake a new shuffled deck to play from
                if(game_state == true)
                {
                    deck.remake();
                }
            }
        }


        public static void initPlayers(Player player1, Player player2)
        {
            //Read input from console, call Player class's setName() function, and output greeting
            Console.WriteLine("Input Player One");
            player1.setName(Console.ReadLine());
            Console.WriteLine("Input Player Two");
            player2.setName(Console.ReadLine());
            Console.WriteLine("Hello Player 1: " + player1.getName() + " and Player 2: " + player2.getName());
            Console.WriteLine("~---~~---~~---~~---~~---~~---~~---~~---~");
        }
        public static void compare(Player player1, Player player2, Deck deck)
        {
            //Draw and remove a card from the deck for both players
            Cards player1Card = deck.draw();
            Cards player2Card = deck.draw();
            Console.WriteLine("There are currently: " + deck.getDeckSize() + " cards left in the deck.");
            Console.WriteLine(player1.getName() + ": " + player1Card + "\n" + player2.getName() + ": " + player2Card + "\n");
            
            //Determine which player is scored a point, if a players card number is higher award a point,
            //If a suit is higher(refer to documentation or cards.cs)
            if (player1Card.getCardNum() == player2Card.getCardNum())
            {
                if (player1Card.getSuitNum() > player2Card.getSuitNum())
                {
                    addPoint(player1);
                }
                else
                {
                    addPoint(player2);
                }
            }
            else
            {
                if (player1Card.getCardNum() > player2Card.getCardNum())
                {
                    addPoint(player1);
                }
                else
                {
                    addPoint(player2);
                }
            }
            //Print score
            Console.WriteLine("The score is\n" + player1.getName() + ": " + player1.getScore() + "\n" +
                player2.getName() + ": " + player2.getScore());
            Console.WriteLine("~---~~---~~---~~---~~---~~---~~---~~---~");
        }
        private static void addPoint(Player player)
        {
            //Give a point to winner and print their name
            Console.WriteLine(player.getName() + " WINS THIS ROUND!\n");
            player.incrementScore();
        }
        public static bool checkAutorun()
        {
            Console.WriteLine("Would like like the game to run automatically? y/n");
            string response = Console.ReadLine();
            if (response.Equals("y", StringComparison.InvariantCultureIgnoreCase)
                || response.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            Console.WriteLine("\nOkay! Press the Enter key to deal each card.\n");
            return false;
        }
        public static void declareWinner(Player player1, Player player2)
        {
            //Print the winner and delete each players score
            Console.WriteLine("\n~~~!!~~~!!~~~!!~~~!!~~~!!~~~!!~~~");
            if (player1.getScore() > player2.getScore())
            {
                Console.WriteLine(player1.getName() + " HAS WON THE GAME!");
            }
            else if (player1.getScore() == player2.getScore())
            {
                Console.WriteLine("IT'S A TIE");                
            }
            else
            {
                Console.WriteLine(player2.getName() + " HAS WON THE GAME!");
            }
            Console.WriteLine("~~~!!~~~!!~~~!!~~~!!~~~!!~~~!!~~~");
            player1.clearScore();
            player2.clearScore();
        }
        public static bool checkGame()
        {
            Console.WriteLine("Continue Playing? y/n");
            String response = Console.ReadLine();
            if (response.Equals("y", StringComparison.InvariantCultureIgnoreCase) 
                || response.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;

        }
    }
}
