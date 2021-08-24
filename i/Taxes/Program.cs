using System;
using System.Collections.Generic;
using Taxes.Entities;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int numPayers = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1}:");
                Console.Write("Individual or company (i/c)? ");
                char kindPayer = Char.Parse(Console.ReadLine().Trim().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine().Trim();
                Console.Write("Annual income: ");
                double annualIncome = Double.Parse(Console.ReadLine());
                
                if (kindPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Double.Parse(Console.ReadLine());
                    payers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = Int32.Parse(Console.ReadLine());
                    payers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0;
            foreach (Payer payer in payers)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax():F2}");
                totalTaxes += payer.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes:F2}");

        }
    }
}
