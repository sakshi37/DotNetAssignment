using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rating:");
            int rating = Convert.ToInt32(Console.ReadLine());

            double newSal = salary;  
            double finalSal = salary; 

            if (rating >= 8)
            {
                newSal = salary + (salary * 0.20); 
                finalSal = newSal - (newSal * 0.10); 
                Console.WriteLine("After adding 20% bonus: " + newSal);
                Console.WriteLine("Final Salary after 10% deduction: " + finalSal);
            }
            else if (rating >= 5 && rating < 8)
            {
                newSal = salary + (salary * 0.10); 
                finalSal = newSal - (newSal * 0.10); 
                Console.WriteLine("After adding 10% bonus: " + newSal);
                Console.WriteLine("Final Salary after 10% deduction: " + finalSal);
            }
            else
            {
                Console.WriteLine("No bonus. Original Salary: " + salary);
            }
        }
    }
}
