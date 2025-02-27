using Day4_Assignment1.Model;

namespace Day4_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Sakshi");
            User.DisplayTotalLogins();

            User user2 = new User("Dashrath");
            User.DisplayTotalLogins();

            
        }
    }
}
