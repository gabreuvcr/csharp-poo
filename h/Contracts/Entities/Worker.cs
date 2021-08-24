using System.Collections.Generic;
using Contracts.Entities.Enums;

namespace Contracts.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double incomeValue = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    incomeValue += contract.TotalValue();
                }
            }
            return incomeValue;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDepartment: {Department.Name}";
        }
    }
}