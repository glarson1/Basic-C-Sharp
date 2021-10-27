using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //This needs to be here in order to use newClass in the main program
            NewClass newClass = new NewClass();

            //Gets user input and saves it as var response
            Console.WriteLine("Enter in a number to perform math operations");
            int response = Convert.ToInt32(Console.ReadLine());

            //method called on that uses response
            newClass.AddTen(response);

            //method called on that uses response
            newClass.MinusTwo(response);
           
            //method called on that uses response
            newClass.TimesTwo(response);
            Console.Read();


        }

    }
}
