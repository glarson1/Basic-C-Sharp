using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        //the card class has a property of data type STRING called SUIT and you can GET this property or SET the property
        //public means its accessible to other parts of the program
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
