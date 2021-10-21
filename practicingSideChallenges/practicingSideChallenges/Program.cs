using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingSideChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;

            if (age > 30)
            { 
                Console.WriteLine("Older than 30");
            }
            else if (age < 20)
            {
                Console.WriteLine("Younnger than 20");
            }
            else if (age != 22)
            {
                Console.WriteLine("You're not 22"); 
            }
            else
            {
                Console.WriteLine("I'm sure you're some age");
                Console.ReadLine();
            }

            //Example of a Ternary operator..represented by the symbol "?"
            int num1 = 7;
            int num2 = 12;
            //If it is true the message on the left of the ":" will print, if false the right side will print
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
        }
    }
}
