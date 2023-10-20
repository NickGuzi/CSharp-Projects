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

            Console.WriteLine("Please enter a whole number: ");
            var input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second whole number: ");
            var input2 = int.Parse(Console.ReadLine());

            func.funcOne(input1, input2, out answer);
            Console.WriteLine(input1 + " times 2 equals: " + answer);
            Console.ReadLine();

        }
    }
}
