using System;

namespace Contracts.Entities
{
    public class Installment
    {
        private DateTime DueDate { get; }
        private double Amount { get; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        
        public override string ToString()
        {
            return $"{DueDate:dd/MM/yyyy} - {Amount:F2}";
        }
    }
}
