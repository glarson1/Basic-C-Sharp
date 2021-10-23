using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "One";
            string two = "Two";
            string three = "Three";

            string count = one + two + three;

            string name = "Gabe";

            name = name.ToUpper();

            StringBuilder yuh = new StringBuilder("Hello ");
            //Append puts it on the same line. AppendLine puts it on a new line
            yuh.Append("World");
            yuh.AppendLine("\nlskdjflksjflkdsjflkdsjkfjksljfsd");
            yuh.AppendLine("kkkkkkkkkkkkkkk");
            yuh.AppendLine("ssssssss");


            Console.WriteLine(yuh);
            Console.ReadLine();
        }
    }
}
