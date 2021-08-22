using System;
using System.Collections.Generic;
using Bank.Entities;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1004, "Ana", 500.00, 500));
            
            double sum = 0.0;

            foreach (Account acc in accounts)
            {
                sum += acc.Balance;
            }

            Console.WriteLine(sum);

            foreach (Account acc in accounts)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in accounts)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: "
                    + $"{acc.Balance.ToString("F2")}");
            }
        }
    }
}
