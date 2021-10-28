using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    //Created a class named Employee that will inherit from the Person Class
    public class Employee : Person
    {    //impliments the SayName() from the Person class but overrides and gives it functionality to be used in main()
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
