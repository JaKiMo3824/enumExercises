using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace enumExercises
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please type in the current day of the week.");
                string userInput = Console.ReadLine();
                foreach (string day in Enum.GetNames(typeof(daysOfTheWeek)))
                {
                    if (userInput == day)
                    {
                        Console.WriteLine("It is {0}.", day);
                        
                    }
                   
                }
            }
            catch (FormatException) //?? not sure which prewritten exception would handle for non-string input or string input not equal to  day in enum daysOfTheWeek
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }
            Console.ReadLine();

        }
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday


        }

        
    }
}
