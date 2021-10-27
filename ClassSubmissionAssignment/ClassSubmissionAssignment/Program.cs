using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //allows methods to be called in
            MathOperations mathOperations = new MathOperations();

            //gets a user input to be used for the methods 
            Console.WriteLine("Enter a number to be divided by 2:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //does method and displays
            mathOperations.doingMath(userInput);
            Console.ReadLine();

            //does method and displays. uses out
            Console.WriteLine("Your number will be added to 10");
            mathOperations.doingMath(userInput, out int b);
            Console.WriteLine(b);
            Console.ReadLine();

            //does method and displays
            int apple = theStaticOne.subtract(userInput);
            Console.WriteLine("Your number minus 10 is " + apple);

            Console.ReadLine();

        }
        
    }

}
