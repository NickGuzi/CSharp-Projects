using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunc func = new MathFunc();
            int Total;

            Console.WriteLine("Please Enter a Whole Number: ");
            var input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter a Second Whole Number (Optional): ");
            string input2 = Console.ReadLine();

            if (string.IsNullOrEmpty(input2))
            {
                int funcNum = 0;
                Total = func.twoInts(input1, funcNum);

                Console.WriteLine(input1 + " plus 0 equals: " + Total);
            }else
            {
                int funcNum = Convert.ToInt32(input2);
                Total = func.twoInts(input1, funcNum);

                Console.WriteLine(input1 + " plus " + funcNum + " equals: " + Total);
            }
            Console.ReadLine();
        }
    }
}
