using _03_properties_indexers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Examples
{
    public static class PropertyAccessExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Private setter: controlled mutation ---");
            var account = new BankAccount("John", 100);
            Console.WriteLine($"Initial balance: {account.Balance}");

            account.Deposit(50);
            Console.WriteLine($"After deposit: {account.Balance}");

            // account.Balance = 1000; // <-- would NOT compile: setter is private

            Console.WriteLine();
            Console.WriteLine("--- init-only property ---");
            Console.WriteLine($"Owner: {account.Owner}");
            // account.Owner = "Someone else"; // <-- would NOT compile: init-only after construction
        }
    }
}
