using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsoleAppAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //created an array of strings
            String[] stringArray = { "apple", "baseball", "jumping", "spider", "yellow" };

            //getting user input and saving it as an int
            Console.WriteLine("Select an index of the array you can't see yet to display the value at that index. (Ex: 2)");
            int userIndex = Convert.ToInt32(Console.ReadLine());

            //displaying the users index on the screen
            Console.WriteLine(stringArray[userIndex]);
            Console.ReadLine();

            //created an array of integers
            int[] numArray = { 21, 33, 44, 55, 66, 333 };

            //getting user input and saving it as an int
            Console.WriteLine("Select an index of the array you can't see yet to display the value at that index. (Ex: 2)");
            int userIndex2 = Convert.ToInt32(Console.ReadLine());

            //adding this to allow a message if user selects an index that doesn't exist
            if (userIndex2 > 5)
            {
                Console.WriteLine("That index doesn't exist");
                Console.ReadLine();
            }
            else
            {
                //displaying the users index on the screen
                Console.WriteLine(numArray[userIndex]);
                Console.ReadLine();
            }


            //Created a list of strings
            List<string> stringList = new List<string>{ "bear", "cat", "balloon", "car" };

            //getting user input and saving it as an int
            Console.WriteLine("Select an index of the list you can't see yet to display the value at that index. (Ex: 2)");
            int userIndex3 = Convert.ToInt32(Console.ReadLine());

            //displaying the index
            Console.WriteLine(stringList[userIndex]);
            Console.ReadLine();
        }
    }
}
