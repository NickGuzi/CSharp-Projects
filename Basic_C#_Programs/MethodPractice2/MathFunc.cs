using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
    public class MathFunc
    {
        public int funcOne(int num1)
        {
            int num2 = 6;
            var Result = num1 * num2;
            return Result;
        }

        public int funcOne(decimal num1)
        {
            decimal num2 = 3.00m;
            var Total = Convert.ToInt32(num1 / num2);
            return Total;
        }

        public int funcOne(string string1)
        {
            int num3 = 4;
           int num4 = Convert.ToInt32(string1);
            int Answer = num4 - num3;
            return Answer;
        }
    }
}
