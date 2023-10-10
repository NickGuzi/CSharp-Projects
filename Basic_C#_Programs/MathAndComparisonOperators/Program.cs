using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Intro
            Console.WriteLine("Press enter to continue through steps...");
            Console.ReadLine();

            Console.WriteLine("Person 1 Enter Info..."); //Person 1 Prompt
            Console.ReadLine();
            Console.WriteLine("Hourly Wage Rate");
            var person1Rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week");
            var person1Weekly = float.Parse(Console.ReadLine());

            Console.WriteLine("Person 2 Enter Info..."); //Person 2 Prompt
            Console.ReadLine();
            Console.WriteLine("Hourly Wage Rate");
            var person2Rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week");
            var person2Weekly = float.Parse(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:"); //Person 1 Salary calc
            float salary1 = (person1Rate * person1Weekly) * 52;
            Console.WriteLine(salary1.ToString());
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:"); //Person 2 Salary calc
            float salary2 = (person2Rate * person2Weekly) * 52;
            Console.WriteLine(salary2.ToString());
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more than person 2?"); // Salary comparison
            bool mostMoney = salary1 > salary2;
            Console.WriteLine(mostMoney.ToString());
            Console.ReadLine();
        }
    }
}
