using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class so we can use the method
            MathOperation mathOperation = new MathOperation();

            //Getting user input to be saved as an int/first parameter
            Console.WriteLine("Give a number: ");
            int firstPar = Convert.ToInt32(Console.ReadLine());

            //Getting user input to be saved as an int/second parameter
            Console.WriteLine("Give another number: ");
            int secondPar = Convert.ToInt32(Console.ReadLine());

            //added parameters to method called. There is a math operation done on the first parameter
            //and the second parameter is displayed
            mathOperation.theMethod(firstPar, secondPar);
            Console.ReadLine();
        }
    }
}
