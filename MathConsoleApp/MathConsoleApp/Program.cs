using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets a user input converts it to an int and saves it as userNum
            Console.WriteLine("enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //takes the user input and multiplies it by 50
            int multiplied = userNum * 50;
            Console.WriteLine("Your number multiplied by 50 is " + multiplied);
            Console.ReadLine();

            //Gets a user input, converts it to an int and saves it as userNum2
            Console.WriteLine("enter a number:");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //takes the user input and adds 25 to it
            int adding = userNum2 + 25;
            Console.WriteLine("Your number plus 25 is " + adding);
            Console.ReadLine();

            //Gets a user input and converts it to a double before saving it as a double to make dividing by a double easier in the next step
            Console.WriteLine("enter a number:");
            double userNum3 = Convert.ToDouble(Console.ReadLine());

            //takes the users double and divides it by double of 12.5
            double division = userNum3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + division);
            Console.ReadLine();

            //Gets user input converts and saves it as an int
            Console.WriteLine("enter a number:");
            int userNum4 = Convert.ToInt32(Console.ReadLine());

            //Takes the user input and chest if it is greater than 50 as a true or false
            bool greaterOrNo = userNum4 > 50;
            Console.WriteLine("It is " + greaterOrNo + " that your number is greater than 50");
            Console.ReadLine();

            //Get a user input and saves it as double
            Console.WriteLine("enter a number:");
            double userNum5 = Convert.ToDouble(Console.ReadLine());

            //takes the users double and divides it by 7, printing the remainder to the console
            double whatRemains = userNum5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + whatRemains);
            Console.ReadLine();
            



        }
    }
}
