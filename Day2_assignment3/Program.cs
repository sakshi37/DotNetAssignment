namespace Day2_assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userIds = { 101, 102, 103, 104 };
            decimal[] walletBalances = { 5000.75M, 2500.50M, 10000.00M, 780.30M };

            int userId;
            bool isValidUser = false;

            while (!isValidUser)
            {
                Console.Write("Enter your User ID to check wallet balance: ");

                
                if (int.TryParse(Console.ReadLine(), out userId))
                {
                    
                    for (int i = 0; i < userIds.Length; i++)
                    {
                        if (userIds[i] == userId)
                        {
                            Console.WriteLine($"Wallet Balance: ₹{walletBalances[i]:F2}");
                            isValidUser = true; 
                            break;
                        }
                    }

                    
                    if (!isValidUser)
                    {
                        Console.WriteLine("Invalid User ID. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a numeric User ID.");
                }
            }
        }
    }
}
