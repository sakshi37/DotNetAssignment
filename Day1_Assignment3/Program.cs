namespace Day1_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patient1 = "John Doe";
            DateTime? dischargeDate1 = new DateTime(2025, 2, 25);

            
            string patient2 = "Jane Smith";
            DateTime? dischargeDate2 = null; 

            
            string patient3 = "Alice Brown";
            DateTime? dischargeDate3 = new DateTime(2025, 3, 10);

            if (dischargeDate1.HasValue)
            {
                Console.WriteLine($"Patient {patient1} was discharged on: {dischargeDate1.Value:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine($"Patient {patient1} - Not Discharged");
            }

            
            if (dischargeDate2.HasValue)
            {
                Console.WriteLine($"Patient {patient2} was discharged on: {dischargeDate2.Value:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine($"Patient {patient2} - Not Discharged");
            }

            
            if (dischargeDate3.HasValue)
            {
                Console.WriteLine($"Patient {patient3} was discharged on: {dischargeDate3.Value:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine($"Patient {patient3} - Not Discharged");
            }
        }
    }
}
