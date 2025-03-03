using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    internal class Employee
    {
        public int Id { get;  }
        public string Name { get;  }    
        public DateTime JoiningDate { get; }

        public Employee(int id , string name, DateTime joinDate) { 
            Id = id;
            Name = name;
            JoiningDate = joinDate;


            
        }
    }
}
