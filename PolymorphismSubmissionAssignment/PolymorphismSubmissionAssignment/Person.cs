using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    //created an abstract class called Person with the properties string firstName and string lastName
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //gave it an abstract method named SayName()
        public abstract void SayName();
    }
}
