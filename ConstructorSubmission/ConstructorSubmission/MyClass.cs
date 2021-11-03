using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    //created two constructors in this class. This will assign a value to a variable that will be displayed on program.cs
    public class MyClass
    {
        public string nameOfSchool;
        public MyClass() : this("The Tech Academy")
        {

        }

        public MyClass(string schoolName)
        {
            nameOfSchool = schoolName;
        }
    }

    
}
