using System;
using Contracts.Entities;
using Contracts.Services;

namespace Contracts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int contractNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = Double.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);
            
            Console.Write("Enter number of installments: ");
            int numberInstallments = Int32.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(myContract, numberInstallments);
            
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
