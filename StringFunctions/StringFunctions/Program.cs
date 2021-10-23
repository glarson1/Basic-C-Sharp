using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man said, \"Hello, Jesse.\"";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("e");

            int length = name.Length;

            name = name.ToUpper();

            name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
            
        }
    }
}
