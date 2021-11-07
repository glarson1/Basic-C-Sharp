using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for their age
            Console.WriteLine("How many years old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            DateTime datetime = DateTime.Now;

            DateTime yearBorn = new datetime.AddYears(-userAge));

            Console.ReadLine();

            //Display th
        }
    }
}
