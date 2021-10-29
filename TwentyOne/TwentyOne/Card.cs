using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
       
        //the card class has a property of data type enum Suit called SUIT and you can GET this property or SET the property
        //public means its accessible to other parts of the program
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    //Defining an enum
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Jack,
        Queen,
        King,
        Ace
    }
}
