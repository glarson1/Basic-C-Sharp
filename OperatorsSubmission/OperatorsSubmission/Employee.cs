using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    //Created a class named Employee that will inherit from the Person Class
    public class Employee : Person, IQuittable
    {    //impliments the SayName() from the Person class but overrides and gives it functionality to be used in main()
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        //inherited quit method from IQuittable
        public void Quit(Person person)
        {
            Console.WriteLine("This program will soon end");
        }
        //gave Employee a property called id that is an int
        public int Id { get; set; }

        //Overloaded the "==" operator to check if obj's Id's are equal
        public static bool operator== (Employee obj1, Employee obj2)
        {
            bool answer = (obj1.Id == obj2.Id);
            return answer;
        }
        //have to include the overload of "!=" to continue on and use what we created for "=="
        public static bool operator!= (Employee obj1, Employee obj2)
        {
            bool answer = (obj1.Id != obj2.Id);
            return answer;
        }


    }
}
