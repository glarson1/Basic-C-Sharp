using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //keyword abstract means this class can never be instanciated. Only meant to be inherited from. 
    //We are never going to have an instance of "Game". We will always have specific games ex: blackjack,poker
    //Game is an example of a BASE CLASS which is another word for ABSTRACT CLASS
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //abstract methods can only exist inside of an abstract class and they contain no implimentation
        //any class inheriting this class must impliment this method
        public abstract void Play();

        //virtual method means that this method gets inherited by an inheriting class but it can be overriten
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
