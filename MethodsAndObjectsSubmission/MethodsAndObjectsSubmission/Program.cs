using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the employee class so we can use it in this main()
            Employee employee = new Employee();

            //gave first name and last name to employee
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //call on sayName method to display the first and last name of employee
            employee.SayName();
            Console.ReadLine();
        }
    }
}
