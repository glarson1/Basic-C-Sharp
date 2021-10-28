using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        
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
