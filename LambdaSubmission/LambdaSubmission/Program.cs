using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a list of 10 employees each with a firstname, lastname, and Id
            List<Employee> employees = new List<Employee>()
            {
                new Employee {firstName = "Joe", lastName = "Mama", Id = 1},
                new Employee {firstName = "Steve", lastName = "Irwin", Id = 2},
                new Employee {firstName = "Joe", lastName = "Smith", Id = 3},
                new Employee {firstName = "Irene", lastName = "Harrison", Id = 4},
                new Employee {firstName = "Bob", lastName = "Jones", Id = 5},
                new Employee {firstName = "Michael", lastName = "Jackson", Id = 6},
                new Employee {firstName = "Peter", lastName = "Parker", Id = 7},
                new Employee {firstName = "Luke", lastName = "Skywalker", Id = 8},
                new Employee {firstName = "Sally", lastName = "Johnson", Id = 9},
                new Employee {firstName = "Jack", lastName = "Daniels", Id = 10}
            };

            //Created a new list of all employees with the first name Joe using a foreach loop
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {

                if (employee.firstName == "Joe")
                {
                    newList.Add(employee);

                }
            }

            foreach (Employee i in newList)
            {
                Console.WriteLine(i.firstName);
            }
            Console.ReadLine();



            //Now to do that using a Lambda expression
            List<Employee> anotherList = employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee i in anotherList)
            {
                Console.WriteLine(i.firstName);
            }
            Console.ReadLine();


            //Using a lambda expression, make a list of all employees with an id number greater than 5
            List<Employee> theIdList = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee i in theIdList)
            {
                Console.WriteLine(i.firstName);
            }
            Console.ReadLine();





        }
    }
}
