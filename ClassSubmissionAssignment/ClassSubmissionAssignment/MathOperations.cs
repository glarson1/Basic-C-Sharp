using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class MathOperations
    {
        //created a method to divide input by 2
        public void doingMath(int i)
        {
            
            Console.WriteLine("Your number divided by 2 is " + i / 2);
        }
        //created a method that adds ten to input while using out keyword
        public void doingMath(int a, out int b )
        {
            b = a + 10;
        }

        

    }
}
