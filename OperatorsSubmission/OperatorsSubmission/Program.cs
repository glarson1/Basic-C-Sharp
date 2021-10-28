using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //created an instance of Employee with firstname lastname and ID
            Employee obj1 = new Employee();

            obj1.firstName = "obj";
            obj1.lastName = "one";
            obj1.Id = 44;

            Employee obj2 = new Employee();

            obj2.firstName = "obj";
            obj2.lastName = "two";
            obj2.Id = 44;



            Console.WriteLine("is obj1's Id equal to obj2's? \n" + (obj1 == obj2));
            Console.ReadLine();


        }
    }
}
