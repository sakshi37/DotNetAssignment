using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using Day5Assinment.model;

namespace Day5Assignment.Model
{
    internal class Employee
    {
        List<int> existingUsers = new List<int> { 101, 102, 103, 104 };

        public void CheckAccount()
        {
            
            Console.WriteLine("Enter account number:");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (!existingUsers.Contains(number))
                {
                    throw new AccountNotFoundException($"Account number {number} does not exist.");
                }
                else
                {
                    Console.WriteLine("Account found.");
                }
                
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
                
        }
    }

 
    
    
}
