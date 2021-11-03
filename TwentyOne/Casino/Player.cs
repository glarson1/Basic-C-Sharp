using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        
        //amount is the amount the player enters in that they want to bet
        public bool Bet(int amount)
        {
            //if the player bets more than they have
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                //same as saying Balance = Balance - amount;
                Balance -= amount;
                return true;
            }

        }
        
        //overloading operator+, its taking two opperands: a Game and a Player and its returning a Game
        public static Game operator+ (Game game, Player player)
        {
            //Takes game adds players to it and returns game
            game.Players.Add(player);
            return game;

        }
        //creates subtract overload operator
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
