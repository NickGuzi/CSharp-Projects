using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date & time is: " + DateTime.Now);
            Console.WriteLine("Please enter a whole number: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be " + DateTime.Now.AddHours(input), input);
            Console.ReadLine();

        }
    }
}
