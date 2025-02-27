using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo.Model
{
     class Employee
    {
        public String Name { get; set; }    
        public Double Salary { get; set; }

        public Employee(String name , Double salary) { 
            Name = name;
            Salary = salary;

        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}\n Salary: {Salary}");
        }
    }
}
