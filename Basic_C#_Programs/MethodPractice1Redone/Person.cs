﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1Redone
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
            Console.ReadLine();

        }
    }
}
