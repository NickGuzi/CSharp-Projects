using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("Press Enter to continue through steps...");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("Please explicitly enter either true or false...");
            var dui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            var tickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Qualified?");
            if (age > 15 && dui != true && tickets <= 3)
            {
                Console.WriteLine("You are qualified for insurance.");
            } else
            {
                Console.WriteLine("You are not qualified for insurance.");
            }
            Console.ReadLine();


        }
    }
}
