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
            initPlayers();
            Deck deck = new Deck();
            Console.ReadKey();
        }

        public static void initPlayers()
        {
            Console.WriteLine("Input Player One");
            String name = Console.ReadLine();
            Player player1 = new Player(name);

            Console.WriteLine("Input Player Two");
            name = Console.ReadLine();
            Player player2 = new Player(name);
            Console.WriteLine("Hello Player 1: " + player1.getName() + " and Player 2: " + player2.getName());
        }
        
    }
}
