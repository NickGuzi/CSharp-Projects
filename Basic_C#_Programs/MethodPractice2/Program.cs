using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Int equation
            int Result;
            MathFunc func = new MathFunc();
            Console.WriteLine("Please enter a whole number");
            var input1 = int.Parse(Console.ReadLine());

            Result = func.funcOne(input1);

            Console.WriteLine("The total of the first equation is: " + Result);
            Console.ReadLine();

            //Decimal Equation
            int Total;
            MathFunc func2 = new MathFunc();
            Console.WriteLine("Please enter a decimal number");
            var input2 = decimal.Parse(Console.ReadLine());

            Total = func2.funcOne(input2);

            Console.WriteLine("The total of the second equation is: " + Total);
            Console.ReadLine();

            //String Equation
            int Conclusion;
            MathFunc func3 = new MathFunc();
            Console.WriteLine("Please enter a number");
            string input3 = Console.ReadLine();

            Conclusion = func3.funcOne(input3);

            Console.WriteLine("The total of the third equation is: " + Conclusion);
            Console.ReadLine();
        }
    }
}
