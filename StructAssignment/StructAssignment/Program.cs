using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the struct Number into Main()
            Number number = new Number();

            //Assigned an amount to number
            number.Amount = 3.33m;

            Console.WriteLine("The amount is " + number.Amount);
            Console.Read();
        }
        
    }
}
