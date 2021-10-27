using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting user input to be used in the method in the try
                Console.WriteLine("Enter the first integer:");
                int first = Convert.ToInt32(Console.ReadLine());
            //getting second optional user input. The try block will determine what to do with it if its blank or not correct
                Console.WriteLine("Enter in second integer(optional. Default=1):");
            try
            { 
                //try block will work fine if two ints are given by user. if not it tries the method in the catch
                int optional = Convert.ToInt32(Console.ReadLine());

                int banana = MathOperations.firstMethod(first, optional);

                Console.WriteLine("First integer plus the second integer is " + (banana));
            }
            catch
            {
                int apple = MathOperations.firstMethod(first);
                Console.WriteLine("First integer plus one " + apple);
            }
            
            Console.ReadLine();
        }
    }
}
