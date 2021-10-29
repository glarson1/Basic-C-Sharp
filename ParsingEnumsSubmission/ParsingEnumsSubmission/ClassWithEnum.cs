using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class ClassWithEnum
    {
        //gave a property to the class
        public DaysOfTheWeek Day { get; set; }
    }
    //Created an enum for days of the week
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
