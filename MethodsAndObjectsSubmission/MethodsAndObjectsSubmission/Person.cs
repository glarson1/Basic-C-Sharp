using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    public class Person
    {
        //Give class Person two string properties, FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method that writes the person's full name to the console w/out taking parameters
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
