using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{ // ********* adding a ":" and then the class "Game"  MEANS TWENTYONEGAME IS INHERITING FROM GAME
    //THIS AVOIDS HAVING TO REWRITE CODE ...Also is able to also inherit from IWalkAway because IWalkAway is an interface
    //and not a class. You can only inherit one class but can inherit multiple interfaces
    public class TwentyOneGame : Game, IWalkAway
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
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
