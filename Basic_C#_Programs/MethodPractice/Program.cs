using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            Console.WriteLine("Enter a whole number of your choice: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a whole second number of your choice: ");
            var input2 = int.Parse(Console.ReadLine());

            int Result;
            //Calling class
            MathFunc func = new MathFunc();
            //Addition func
            Result = func.addition(input1, input2);
            Console.WriteLine("The sum of " + input1 + " plus " + input2 + " equals:" + Result);
            //Subtraction func
            Result = func.subtract(input1, input2);
            Console.WriteLine("The sum of " + input1 + " minus " + input2 + " equals:" + Result);
            //Multiplication func
            Result = func.multiply(input1, input2);
            Console.WriteLine("The sum of " + input1 + " times " + input2 + " equals:" + Result);
            Console.ReadLine();

        }
    }
}
