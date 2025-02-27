namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region :Student Mangement
            Console.WriteLine("Enter Studen name");
            String studName = Console.ReadLine();

            Console.WriteLine("Enter Studen Age");
            String studAge = Console.ReadLine();

            bool pass = int.TryParse(studAge, out int age);
            if (pass == false)
            {

                Console.WriteLine("You age should be numeric:" + age);
            }
            //else
            //{
            //    Console.WriteLine("You age should be numeric");

            //}

            Console.WriteLine("Enter Student Percentage");
            double studpercentage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Email");
            String email = Console.ReadLine();

            while (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Email cannot be emapty");
                email = Console.ReadLine();
            }
            Console.WriteLine("Email enterd successfully");



            Console.WriteLine($"Name:{studName}\nAge:{studAge}\nPercentage:{studpercentage}\nEmail:{email}");
            #endregion


            DateTime? dischargeDate = null;
            if (dischargeDate.HasValue)
            {
                Console.WriteLine($"Patient discharged on: {dischargeDate.Value.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Not Discharged");
            }

        }
    }
}
