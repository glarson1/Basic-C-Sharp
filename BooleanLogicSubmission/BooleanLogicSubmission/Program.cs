using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting user input, converting and saving as an int
            Console.WriteLine("What is your age? (answer with integer. ex: 43)");
            int age = Convert.ToInt32(Console.ReadLine());

            //Getting user input, converting and saving as an int
            Console.WriteLine("Have you ever had a DUI? (answer with true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //Getting user input, converting and saving as an int
            Console.WriteLine("How many speeding tickets do you have? (answer with integer. ex: 3)");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Checking if input meets requirements. Will print a true or false if user meets requirements
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.ReadLine();
        }
    }
}
