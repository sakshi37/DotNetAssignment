namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Password");


            retry:
            String pass = Console.ReadLine();



            if (pass.Any(Char.IsUpper) && pass.Any(char.IsDigit) && pass.Any(ch => "!@#$*><()".Contains(ch)) && pass.Length>=6)

            {
                Console.WriteLine("Your Password is correct");

            }
            else
            {
                Console.WriteLine("Not Correct Password");
                goto retry;
            }
        }
    }
}
