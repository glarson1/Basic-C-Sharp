using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciating the class MathOps which will allow me to use the variable mathOps from here on out
            MathOps mathOps = new MathOps();

            //getting user input and making sure it is saved as an int
            Console.WriteLine("Enter in a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //calling the myMethod. It should tell by the data type what I am trying to do
            mathOps.myMethod(userInput);

         
            //getting user input and making sure it is saved as a decimal
            Console.WriteLine("Enter in a decimal:");
            decimal userNum = Convert.ToDecimal(Console.ReadLine());
            //calling the myMethod. It should tell by the data type what I am trying to do
            mathOps.myMethod(userNum);

       
            //getting user input and making sure it is saved as a string
            Console.WriteLine("Enter a number (it will begin in string form)");
            string userString = Console.ReadLine();
            //calling the myMethod. It should tell by the data type what I am trying to do
            mathOps.myMethod(userString);

            Console.ReadLine();
        }
    }
}
