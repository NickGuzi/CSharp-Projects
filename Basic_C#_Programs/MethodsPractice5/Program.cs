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
            name.Id = 1;
            name.SayName();

            Employee name2 = new Employee();
            name2.FirstName = "Nick";
            name2.LastName = "Guzi";
            name2.Id = 2;
            name2.SayName();
            Console.ReadLine();

            Console.WriteLine("Are employee 1 and employee 2 the same person? \n" + (name == name2));
            Console.ReadLine();

            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();

        }
    }
}
