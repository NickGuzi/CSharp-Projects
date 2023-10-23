using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice5
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employees: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Enter name of Employee who quit here: ");
        }
    }
}
