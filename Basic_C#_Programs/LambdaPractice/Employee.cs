using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public List<Employee> employees;

        public Employee (int id, string fn, string ln)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
        }
    }
}
