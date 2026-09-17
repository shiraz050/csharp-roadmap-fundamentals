using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Models
{
    public class BankAccount
    {
        // Auto-property with a public getter but private setter -
        // outside code can read the balance but not directly set it
        public decimal Balance { get; private set; }

        public string Owner { get; init; } = string.Empty; // init-only: settable only at creation

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
        }
    }
}
