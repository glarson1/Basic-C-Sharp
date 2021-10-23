using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input an save it as an int to be compared in a boolean
            Console.WriteLine("What year is it?");
            int yearGuessed = Convert.ToInt32(Console.ReadLine());
            bool rightOrNot = yearGuessed == 2021;
            //start of the do while loop
            do
            {
                switch (yearGuessed)
                {
                    //if any of these cases occur these strings will pop up and user will be prompted to start again unless case 2021
                    case 2020:
                        Console.WriteLine("You're about a year off");
                        Console.WriteLine("What year is it?");
                        yearGuessed = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2022:
                        Console.WriteLine("You must be from the future");
                        Console.WriteLine("What year is it?");
                        yearGuessed = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2000:
                        Console.WriteLine("Not even close");
                        Console.WriteLine("What year is it?");
                        yearGuessed = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2021:
                        Console.WriteLine("That's right thanks!");
                        rightOrNot = true;
                        break;
                    default:
                        Console.WriteLine("Nope");
                        Console.WriteLine("What year is it?");
                        yearGuessed = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!rightOrNot);



           // END OF WHILE DO. NOW MOVING ON TO JUST A WHILE LOOP

            Console.WriteLine("What color is a lemon?");
            string colorGuessed = Console.ReadLine();
            bool guessCorrect = colorGuessed == "yellow";

            while (!guessCorrect)
            {
                switch (colorGuessed)
                {
                    case "red":
                        Console.WriteLine("Nope not red. Try again");
                        Console.WriteLine("What color is a lemon?");
                        colorGuessed = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("Nope not blue. Try again");
                        Console.WriteLine("What color is a lemon?");
                        colorGuessed = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yep lemons are yellow");
                        guessCorrect = true;
                        break;
                    default:
                        Console.WriteLine("Nope not whatever you typed in. Try again");
                        Console.WriteLine("What color is a lemon?");
                        colorGuessed = Console.ReadLine();
                        break;

                }
                Console.ReadLine();
            }



        }
        
        
        
           
            

            
    }
}
