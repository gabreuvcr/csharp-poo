namespace Contracts.Services
{
    public interface IPaymentService
    {
        double Payment(double amount, int month);
    }
}
