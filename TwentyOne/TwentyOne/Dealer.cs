using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        //properties that a dealer has
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //Hand is a list so it has the built in method add to add something to the list
            //Deck has a list of cards. First is a method available to a list that takes the very first item in that list
            
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
           
            //Then prints it to the console
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //RemoveAt is a method that any list has and were taking the first item on the list and remove it from the deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
