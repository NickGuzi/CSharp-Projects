using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice4
{
    public class MathFunc
    {
        public void funcOne(int int1, out int answer)
        {
            answer = int1 / 2;
        }
        //THIS IS FOR CLASS SUBMISSION ASSIGNMENT
        public void funcOne(int int1, out int answer2, int int2)
        {
            Console.WriteLine("This is the second number you entered: " + int2);
            answer2 = int1 * int2;
        }
    }
}
