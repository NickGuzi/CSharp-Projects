using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please press enter to continue through steps...");
            Console.ReadLine();

            Console.WriteLine("Please enter package weight (in lbs.):");
            var weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter package width (in inches):");
            var width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter package height (in inches):");
            var height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter package length (in inches):");
            var length = float.Parse(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            float quote = ((width * height * length) * weight) / 100;

            Console.WriteLine("Total cost for this package is: " + "$" + quote);
            Console.ReadLine();
        }
    }
}
