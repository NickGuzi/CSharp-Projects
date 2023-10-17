using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };

                Console.WriteLine("Please enter a whole number...");
                var input = int.Parse(Console.ReadLine());

                int result = 0;

                foreach(int i in intList)
                {
                    result = i / input;
                    Console.WriteLine(i + " divided by " + input + " equals " + result + "\n");
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
