using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersSubmission
{
    class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public Employee(int id, string fn, string ln)
        {
            id = ID;
            fn = FirstName;
            ln = LastName;
        }
        public List<T> things { get; set; }
    }
}
