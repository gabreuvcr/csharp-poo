using System;
using Bank.Entities;
using Bank.Entities.Exception;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = Int32.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = Double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = Double.Parse(Console.ReadLine());

                Account ac = new Account(number, holder, balance, limit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = Double.Parse(Console.ReadLine());
                ac.Withdraw(amount);
                Console.WriteLine($"New balance: {ac.Balance:F2}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
