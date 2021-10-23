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
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
            //int age = 22;

            //if (age > 30)
            //{ 
            //    Console.WriteLine("Older than 30");
            //}
            //else if (age < 20)
            //{
            //    Console.WriteLine("Younnger than 20");
            //}
            //else if (age != 22)
            //{
            //    Console.WriteLine("You're not 22"); 
            //}
            //else
            //{
            //    Console.WriteLine("I'm sure you're some age");
            //    Console.ReadLine();
            //}

            ////Example of a Ternary operator..represented by the symbol "?"
            //int num1 = 7;
            //int num2 = 12;
            ////If it is true the message on the left of the ":" will print, if false the right side will print
            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            //Console.WriteLine(result);
        }
    }
}
