using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop Practice 
            Console.WriteLine("Please continually press enter to count to ten...");
            Console.ReadLine();
            
            int x = 0;
            while(x <= 10)
            {
                Console.WriteLine(x.ToString());
                Console.ReadLine();
                x++;
            }

            //doWhile practice 
            bool correct = false;
            do
            {
                Console.WriteLine("Please guess a number between 1 and 5");
                var guess = int.Parse(Console.ReadLine());

                switch (guess)
                {
                    case 1:
                        Console.WriteLine("Wrong Number");
                        break;
                    case 2:
                        Console.WriteLine("Wrong Number");
                        break;
                    case 3:
                        Console.WriteLine("Wrong Number");
                        break;
                    case 4:
                        Console.WriteLine("Correct Number!");
                        Console.ReadLine();
                        correct = true;
                        break;
                    case 5:
                        Console.WriteLine("Wrong Number");
                        break;
                    default:
                        Console.WriteLine("Please guess a number between 1 and 5");
                        break;
                }
            }
            while(!correct);
        }
    }
}
