using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiPart
{
    class Program
    {
        static void Main(string[] args)
        {
            //.......PART ONE........


            ////created an array of strings
            //string[] stringArray = { "monkey", "tiger", "lizard", "bird", "gorilla" };

            ////get user input to save as variable and eventually add to end of each item in the array
            //Console.WriteLine("Type anything here:");
            //string userString = Console.ReadLine();

            ////iteration with adding new strings to the end of the original strings 
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = (stringArray[i] + userString);

            //    Console.WriteLine(stringArray[i]);
            //}
            //Console.ReadLine();


            ////.........PART TWO........

            ////was infinite at first but no longer infinite
            //for (int g = 0; g < stringArray.Length; g++)
            //{
            //    Console.WriteLine(stringArray[g]);
            //}
            //Console.ReadLine();

            ////.....PART THREE..........

            ////created a list 
            //List<int> numbers = new List<int>() { 22, 3, 4, 64, 34, 544, 2, };
            ////iterates through the list and displays numbers that meet the if statement
            //foreach (int number in numbers)
            //{
            //    if (number < 300)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}
            //Console.ReadLine();
            ////iterates through the list and displays numbers that meet the if statement
            //foreach (int number in numbers)
            //{
            //    if (number <= 64)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}
            //Console.ReadLine();

            ////.......PART FOUR......

            ////create a list
            //List<string> stringList = new List<string>() { "Gabe", "Apple", "Yellow", "Candle" };

            ////getting a user input to save
            //Console.WriteLine("Enter an item in the list:");
            //string userEntry = Console.ReadLine();

            ////finding the index of the user input if it exists
            //int r = stringList.IndexOf(userEntry);

            //foreach (string item in stringList)
            //{
            //    if (userEntry == item)
            //    {
            //        Console.WriteLine("the index of that input is " + r);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry this is not a valid input");
            //    }

            //}
            //Console.ReadLine();

            //......PART FIVE......

            //created a list with duplicates
            List<string> listOfStrings = new List<string>() { "Gabe", "Gabe", "Lizard", "Lizard", "Tree", "Orange" };

            //gets user input and saves
            Console.WriteLine("Enter an item in the list:");
            string userSearch = Console.ReadLine();

            //iteration
            for (int p = 0; p < listOfStrings.Count; p++)
            {
                if (listOfStrings[p] == userSearch)
                {
                    Console.WriteLine(userSearch + " is in the list at index number " + p);
                }
            }
            Console.ReadLine();


            ////.....PART SIX........

            ////created a list with duplicates
            //List<string> partSixList = new List<string>() { "Gabe", "Gabe", "Lizard", "Lizard", "Tree", "Orange" };
            ////created another list that will have values from the first list added to help with determining duplicates
            //List<string> backup = new List<string>();
            ////iteration
            //foreach (string thing in partSixList)
            //{
            //    //iteration in the other list
            //    foreach (string thing2 in backup)
            //    {
            //        //if there is a duplicate
            //        if (thing == thing2)
            //        {
            //            Console.WriteLine(thing + " has appeared before");
            //        }

            //    }
            //    //if there is not a duplicate
            //    if (backup.Contains(thing ) == false)
            //    {
            //        Console.WriteLine(thing + " has not occured before");
            //    }
            //    backup.Add(thing);
            //}
            Console.ReadLine();

        }
        
    }
}
