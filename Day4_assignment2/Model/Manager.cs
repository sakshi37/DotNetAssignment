﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo.Model
{
     class Manager:Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public override void Display() 
        {
            base.Display();
            Console.WriteLine($"Bonus{Bonus}");
        }


    }
}
