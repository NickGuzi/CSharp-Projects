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
            Console.WriteLine("Employee: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Enter name of Employee who quit here: ");
            string quitter = Console.ReadLine();
        }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
