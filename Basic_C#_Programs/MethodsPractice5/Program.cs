using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName();
            Console.ReadLine();

            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();





        }
    }
}
