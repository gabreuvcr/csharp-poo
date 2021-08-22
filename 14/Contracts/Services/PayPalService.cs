namespace Contracts.Services
{
    public class PayPalService : IPaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        
        public double Payment(double amount, int month)
        {
            double value = amount * (1 + (MonthlyInterest * month));
            return value * (1 + FeePercentage);
        }
    }
}
