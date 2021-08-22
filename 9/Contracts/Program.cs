using System;
using Contracts.Entities;
using Contracts.Entities.Enums;

namespace Contracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string levelString = Console.ReadLine();
            WorkerLevel level = Enum.Parse<WorkerLevel>(levelString);

            Console.Write("Base salary: ");
            double baseSalary = Double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker: ");
            int numContracts = Int32.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, baseSalary, department);

            for (int i = 0; i < numContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                
                Console.Write("Date (DD/MM/YYYY): ");
                string dateString = Console.ReadLine();
                DateTime date = DateTime.Parse(dateString);

                Console.Write("Value per hour: ");
                double valuePerHour = Double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = Int32.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string[] dateIncome = Console.ReadLine().Split('/');
            int month = Int32.Parse(dateIncome[0]);
            int year = Int32.Parse(dateIncome[1]);

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month).ToString("F2")}");
        }
    }
}
