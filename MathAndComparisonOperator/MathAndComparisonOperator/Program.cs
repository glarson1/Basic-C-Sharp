using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //A title to be print to the screen
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Prints person 1. User presses enter to continue on
            Console.WriteLine("Person 1");
            Console.ReadLine();

            //Gets input from user then converts and saves as int
            Console.WriteLine("Hourly Rate?:");
            int Person1Rate = Convert.ToInt32(Console.ReadLine());

            //Gets input from user then converts and saves as int
            Console.WriteLine("Hours worked per week?:");
            int Person1WeeklyHours = Convert.ToInt32(Console.ReadLine());


            //Repeat the process for a second person



            //Prints person 2. User presses enter to continue on
            Console.WriteLine("Person 2");
            Console.ReadLine();

            //Gets input from user then converts and saves as int
            Console.WriteLine("Hourly Rate?:");
            int Person2Rate = Convert.ToInt32(Console.ReadLine());

            //Gets input from user then converts and saves as int
            Console.WriteLine("Hours worked per week?:");
            int Person1Week2yHours = Convert.ToInt32(Console.ReadLine());

            //Creating equation to determine annual salary for both people...52 weeks in a year
            int annualSalaryP1 = (Person1Rate * Person1WeeklyHours) * 52;
            int annualSalaryP2 = (Person2Rate * Person1Week2yHours) * 52;

            //Displaying the annual salary for person 1
            Console.WriteLine("Annual salary of Person 1:\n" + annualSalaryP1);
            Console.ReadLine();

            //Displaying the annual salary for person 2
            Console.WriteLine("Annual salary of Person 2:\n" + annualSalaryP2);
            Console.ReadLine();

            //Displaying question before setting up comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            //Checking if person 1 makes more than person 2 and then will print to console
            bool compareSalary = annualSalaryP1 > annualSalaryP2;
            Console.Write(compareSalary);
            Console.ReadLine();




        }
    }
}
