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
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
