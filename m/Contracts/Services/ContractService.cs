using System;
using Contracts.Entities;

namespace Contracts.Services
{
    public class ContractService
    {
        private readonly IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double rawInstallment = contract.TotalValue / months;
            
            for (int month = 1; month <= months; month++)
            {
                DateTime date = contract.Date.AddMonths(month);
                double amount = _paymentService.Payment(rawInstallment, month);
                contract.Installments.Add(new Installment(date, amount));
            }
        }
    }
}