using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class NewClass
    {
        public void AddTen(int i)
        {
            int firstNum = 10;
            Console.WriteLine("Your number plus ten is " + (firstNum + i));
        }

        public void MinusTwo(int i)
        {
            int subtractBy = 2;
            Console.WriteLine("Your number minus two is " + (i - subtractBy));
        }

        public void TimesTwo(int i)
        {
            int multiplyBy = 2;
            Console.WriteLine("Your number times two is " + (i * multiplyBy));
        }
        
    }
}
