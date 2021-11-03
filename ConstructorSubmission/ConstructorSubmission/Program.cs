using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const int G = 44;

            //create a variable using "var"
            var lizard = "reptile";

            //This showing to the console shows that I chained two constructors together
            MyClass mc = new MyClass();
            Console.WriteLine(mc.nameOfSchool);
            Console.ReadLine();

        }
    }
}
