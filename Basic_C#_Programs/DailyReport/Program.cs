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
            Console.WriteLine("The Tech Academy"); // Intro
            Console.Read();

            Console.WriteLine("Student Daily Report"); // Second Intro
            Console.Read();

            Console.WriteLine("What is your name?"); // Name Question
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?"); // Course QUestion
            string course = Console.ReadLine();

            Console.WriteLine("What page number?"); // Page Num Question
            var pageNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'"); // Boolean Question
            string answer = Console.ReadLine().Trim().ToLower();
            if(answer != "true" && answer != "false") // Boolean Question Conditional Operator 
            {
                Console.WriteLine("Please enter either 'True' or 'False'");
                Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'");
                string newAnswer = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Is there any other feedback you'd like to provide?"); // Feedback question
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?"); // Hours Studied Question
            var studyTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); //Program exit
            Console.Read();



        }
    }
}
