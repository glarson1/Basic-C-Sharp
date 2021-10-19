using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome screen. User will read and then press enter to continue on
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            Console.ReadLine();

            //collecting data from user that will be saved as string variable
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            //collecting data from user that will be saved as string variable
            Console.WriteLine("What course are you on?:");
            string course = Console.ReadLine();

            //Collecting data from user that will be saved as an int
            Console.WriteLine("What page number?:");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //Collecting data from user that will be saved as a bool
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Collecting string so no need to convert here
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();

            //Collecting another string to be saved
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            //Colecting data that will be saved as an int
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //An extra section I added to make sure that my variables worked
            Console.WriteLine("Just to recap. Here is what you've told me:\nName:" + name + "\nCurrent Course:" + course + 
                "\nPage Number:" + pageNumber + "\nNeed help?:" + needHelp + "\nPositive experiences:" + posExperiences +
                "\nOther Feedback:" + otherFeedback + "\nHours studied:" + hoursStudied);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers an Instructor will respond to this shortly. Have a great day! This is the end of the program.");
            Console.ReadLine();


            
        }
    }
}
