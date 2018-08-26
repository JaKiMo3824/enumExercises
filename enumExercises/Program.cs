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
                string userInput = Console.ReadLine().ToLower();
                daysOfTheWeek day = (daysOfTheWeek) Enum.Parse(typeof(daysOfTheWeek), userInput);
                              
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Please enter an actual day of the week. " + ex.Message);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. " + ex.Message);
            }
            finally
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
