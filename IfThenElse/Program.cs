using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThenElse
{
    /// <summary>
    /// This is the main program
    /// </summary>
    /// <remarks>
    /// This is a lengthly description fo the program
    /// It is an example of how IF and Else work.
    /// </remarks>

    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 15;
            if (x < 10)
            {
                //Print X is less than 10
                Console.WriteLine("X is less than 10");
            }
            else
            {
                // Print X is greater than 10
                Console.WriteLine("X is greater than 10");
            }
            Console.WriteLine("This happens no matter what");

            x = 15;
            // If x is less than 10 and greater than 5
            if ((x < 10) && (x > 5))
                Console.WriteLine("You're above 50% there!");

            string message = null;

            if (message != null && message.Length > 5)
                Console.WriteLine(message);

            DaysOfTheWeek today = DaysOfTheWeek.Wednesday;
            var something = Console.ReadLine();
            int value = int.Parse(something);
            today = (value > -1 && value < 7) ? 
                (DaysOfTheWeek)value :
                DaysOfTheWeek.Wednesday;

            switch (today)
            {
                case DaysOfTheWeek.Sunday:
                    break;
                case DaysOfTheWeek.Monday:
                    break;
                case DaysOfTheWeek.Tuesday:
                    break;
                case DaysOfTheWeek.Wednesday:
                    Console.WriteLine("Guess what day it is?");
                    break;
                case DaysOfTheWeek.Thursday:
                    break;
                case DaysOfTheWeek.Friday:
                case DaysOfTheWeek.Saturday:
                    Console.WriteLine("It's date night!");
                    break;
                default:
                    Console.WriteLine("We don't have a message for this day. Whaaaa!");
                    break;

            }


            Console.ReadLine();

        }

        enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }


    }
}
