using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            //the {0} is used as a place holder for playername to be inserted to
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            //if they say yes they enter the if statement
            if (answer == "yes" || answer == "yeah" || answer == "yuh" || answer == "y")
            {
                //Created a player
                Player player = new Player(playerName, bank);
                //Created a game
                Game game = new TwentyOneGame();
                //Added player to the game
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            //If they say no they go straight to this
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
       
    } 

       
}
