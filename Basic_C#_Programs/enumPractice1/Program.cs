using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week (Mon-Sun): ");
                string input = Console.ReadLine();

                daysWeek Day;

                Day = (daysWeek)Enum.Parse(typeof(daysWeek), input);
                Console.WriteLine("Today is " + Day);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public enum daysWeek
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
