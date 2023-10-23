using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunc func = new MathFunc();
            int answer;
            int answer2;

            Console.WriteLine("Please enter a whole number: ");
            var input1 = int.Parse(Console.ReadLine());

            func.funcOne(input1, out answer);
            Console.WriteLine(input1 + " divided by 2 equals: " + answer);

            Console.WriteLine("Please enter a second whole number: ");
            var input2 = int.Parse(Console.ReadLine());

            //THIS IS FOR CLASS SUBMISSION ASSIGNMENT
            func.funcOne(input1, out answer2, input2);
            Console.WriteLine(input1 + " times " + input2 + " equals: " + answer2);
            Console.ReadLine();

            //Static class call
            StaticClass.statMeth();


        }
    }
}
