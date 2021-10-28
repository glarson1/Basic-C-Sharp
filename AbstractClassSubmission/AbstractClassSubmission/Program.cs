using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling in the Employee class
            Employee employee = new Employee();

            //give values to the properties
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //call sayName() which will use the property values to do its job and display to the console
            employee.SayName();
            Console.ReadLine();
        }
    }
}
