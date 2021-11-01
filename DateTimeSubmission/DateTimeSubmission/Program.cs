using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a DateTime named datetime that is equal to the current date and time
            DateTime datetime = DateTime.Now;
            //prints current date and time to the console
            Console.WriteLine("The current date and time is " + datetime);
            
            //Getting a number from the user and saving it as an int
            Console.WriteLine("Please give me a number");
            int usersNum = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the exact time it will be in X hours, X being the number the user entered in
            Console.WriteLine("The current time plus that amount of hours = " + datetime.AddHours(usersNum));

            Console.ReadLine();
        }
    }
}
