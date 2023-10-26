using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
    
            Employee emp1 = new Employee(1, "Joe", "Buck");
            employees.Add(emp1);
            Employee emp2 = new Employee(2, "Nick", "Guzi");
            employees.Add(emp2);
            Employee emp3 = new Employee(3, "Sam", "Dow");
            employees.Add(emp3);
            Employee emp4 = new Employee(4, "Jack", "Graham");
            employees.Add(emp4);
            Employee emp5 = new Employee(5, "Brad", "Hipsley");
            employees.Add(emp5);
            Employee emp6 = new Employee(6, "Joe", "Feliccichia");
            employees.Add(emp6);
            Employee emp7 = new Employee(7, "Sean", "Saydah");
            employees.Add(emp7);
            Employee emp8 = new Employee(8, "Luke", "Eckert");
            employees.Add(emp8);
            Employee emp9 = new Employee(9, "Erik", "Gospodarski");
            employees.Add(emp9);
            Employee emp10 = new Employee(10, "Denita", "Guimaraes");
            employees.Add(emp10);

            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();

            List<Employee> greater5 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee ids in greater5)
            {
                Console.WriteLine(ids.FirstName + " " + ids.LastName);
            }
            Console.ReadLine();
        }
    }
}
