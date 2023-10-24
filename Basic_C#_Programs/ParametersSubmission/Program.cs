using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>(1, "Nick", "Guzi");
            employee1.things = new List<string>() { "Nick", "Guzi", "was", "hired." };
            employee1.things.ForEach(i => Console.Write("{0} ", i));
            Console.ReadLine();

            Employee<int> employee2 = new Employee<int>(2, "Sam", "Dow");
            employee2.things = new List<int>() { 08, 30, 2000 };
            employee2.things.ForEach(i => Console.Write("{0} ", i));
            Console.ReadLine();
        }
    }
}
