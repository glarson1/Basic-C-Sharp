using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class MathOps
    {
        //made all public so main() can call upon them
        //This is the method that takes an int and returns an int
        public void myMethod (int i)
        {
            int theThree = 3;
            Console.WriteLine("Your number plus three is " + (i + theThree));
        }
        //This is the method that takes a decimal and returns an int
        public void myMethod (decimal i)
        {
            int theFour = 4;
            Console.WriteLine("Your decimal minus 4 equals the int " + ((Convert.ToInt32(i)) - theFour));
        }
        //This is the method that takes a string and returns an int
        public void myMethod (string i)
        {
            int theFive = 5;
            Console.WriteLine("Your string times 5 equals the int " + ((Convert.ToInt32(i)) * theFive));
        }
    }
}
