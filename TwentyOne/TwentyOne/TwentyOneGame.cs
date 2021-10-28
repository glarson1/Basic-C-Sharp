using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{ // ********* adding a ":" and then the class "Game"  MEANS TWENTYONEGAME IS INHERITING FROM GAME
    //THIS AVOIDS HAVING TO REWRITE CODE
    public class TwentyOneGame : Game
    {
        //override keyword satisfies that we are using the abstract method Play from abstract Game class
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
