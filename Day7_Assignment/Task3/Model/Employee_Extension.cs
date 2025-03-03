using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    static class Employee_Extension
    {
        public static void Calculate(this Employee emp){
            double timeSpan =Math.Round( (DateTime.Now - emp.JoiningDate).Days / 360.0, 2) ;
            Console.WriteLine($"Experice for this employee is: {timeSpan}");



        }
    }
}
