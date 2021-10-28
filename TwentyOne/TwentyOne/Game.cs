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
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //abstract methods can only exist inside of an abstract class and they contain no implimentation
        //any class inheriting this class must impliment this method
        public abstract void Play();

        //virtual method means that this method gets inherited by an inheriting class but it can be overriten
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
