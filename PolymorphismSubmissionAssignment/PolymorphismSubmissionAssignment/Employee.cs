using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
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
    }
}
