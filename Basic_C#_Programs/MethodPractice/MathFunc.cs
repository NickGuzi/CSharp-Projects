using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class MathFunc
    {
        public int addition(int num1, int num2)
        {
            var Result = num1 + num2;
            return Result;
        }
        public int multiply(int num1, int num2)
        {
            var Result = num1 * num2;
            return Result;
        }
        public int subtract(int num1, int num2)
        {
            var Result = num1 - num2;
            return Result;
        }
    }
}
