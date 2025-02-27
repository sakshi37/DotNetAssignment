namespace Day2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Salary Calculation System
            Console.WriteLine("Enter Basic Salary");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Performance Rating (0-10)");
            double performanceRating = Convert.ToDouble(Console.ReadLine());


            double tax = 0.10 * basicSalary;


            double bonus;
            if (performanceRating >= 8)
            {
                bonus = 0.20 * basicSalary;
            }
            else if (performanceRating >= 5)
            {
                bonus = 0.10 * basicSalary;
            }
            else
            {
                bonus = 0;

            }

            double netSalary = basicSalary - tax + bonus;


            Console.WriteLine("\n--- Salary Details ---");
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"Tax Deduction (10%): {tax}");
            Console.WriteLine($"Bonus: {bonus}");
            Console.WriteLine($"Net Salary: {netSalary}");
            #endregion
        }

    }
}
