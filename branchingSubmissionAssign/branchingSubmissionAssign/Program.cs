using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingSubmissionAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting an input, converting and saving it as an int
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //If the package weight is greater than 50 this message will be shown and the program will end there. If not the program will continue on
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //getting an input, converting and saving it as an int
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                //getting an input, converting and saving it as an int
                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                //getting an input, converting and saving it as an int
                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                //calculating the dimensions for the package
                int dimensions = packageHeight * packageLength * packageWidth;

                //if the dimensions are greater than 50 an error message will be shown and the program will end. Otherwise it will continue on
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    //calculating the quote price for the package by multiplying ((height x width x length) x (weight)) and dividing by 100
                    //each measurement has to first be converted into a decimal for the final answer to have two decimal places as money should
                    decimal quote = ((Convert.ToDecimal(packageHeight) * Convert.ToDecimal(packageWidth) * Convert.ToDecimal(packageLength)) * Convert.ToDecimal(packageWeight)) / 100;

                    //Displays the users quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }
            Console.ReadLine();

        }
    }
}
