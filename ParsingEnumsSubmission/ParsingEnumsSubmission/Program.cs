using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try catch block to prepare for possible user input errors
            try 
            {
                //instanciated the ClassWithEnum
                ClassWithEnum variable = new ClassWithEnum();
                //Prompt user to enter day of the week
                Console.WriteLine("Enter the current day of the week:");
                string userInput = Console.ReadLine();
                variable.Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("Yes that is it");
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week. (example, Monday)");
            }          
            Console.ReadLine();
            

        }
    }
}
