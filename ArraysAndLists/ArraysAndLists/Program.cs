using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an array saying it will have a length of 5. cannot leave blank
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;


            //easier example making a different array
            int[] numArray1 = new int[] { 5, 4, 33, 44, 44434 };

            //an even easier way than the easy way
            int[] numArray2 = { 3, 4, 5, 44, 3443 };

            //say i wanted to change the 5 to a 7
            numArray2[2] = 7;

            Console.WriteLine(numArray[3]);
            Console.ReadLine();

            //creating a list now....can also do List<string> or any other data type
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);
            Console.WriteLine(intList[0]);
            Console.ReadLine();
        }
    }
}
