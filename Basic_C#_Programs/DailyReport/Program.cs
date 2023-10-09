using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.Read();

            Console.WriteLine("Student Daily Report");
            Console.Read();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            var pageNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'");
            string answer = Console.ReadLine().Trim().ToLower();
            if(answer != "true" && answer != "false")
            {
                Console.WriteLine("Please enter either 'True' or 'False'");
                Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'");
                string newAnswer = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            var studyTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}
