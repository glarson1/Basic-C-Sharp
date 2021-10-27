using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a list of integers
            List<int> integerList = new List<int>() { 10, 22, 30, 43 };
            //try block containing the program
            try
            {
                //Getting user input to be saved as variable
                Console.WriteLine("Give a number to divide the integers in the list by:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //iteration through the list and dividing each int by user input
                for (int i = 0; i < integerList.Count; i++)
                {
                    Console.WriteLine(integerList[i] / userInput);
                }
                Console.ReadLine();
            }
            //catch exceptions
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot be zero");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Cannot be a string. Only an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        
    }
}
