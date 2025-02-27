using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignment1.Model
{
    class User
    {
        
        private static int totalUsersLoggedIn = 0;

        public string UserName { get; }

        
        public User(string userName)
        {
            UserName = userName;
            totalUsersLoggedIn++;
            Console.WriteLine($"{UserName} has logged in.");
        }

       
        public static void DisplayTotalLogins()
        {
            Console.WriteLine($"Total users logged in: {totalUsersLoggedIn}");
        }
    }
}
