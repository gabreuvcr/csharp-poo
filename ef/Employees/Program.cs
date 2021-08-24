using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered: ");
            int numEmployees = Int32.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numEmployees; i++)
            {   
                Console.WriteLine($"\nEmployee #{i + 1}:");
                Console.Write("Id: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = Double.Parse(Console.ReadLine());
                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idIncrease = Int32.Parse(Console.ReadLine());

            Employee employeeIncrease = employees.Find(employee => employee.Id == idIncrease);
            
            if (employeeIncrease == null) 
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = Double.Parse(Console.ReadLine());
                employeeIncrease.Increase(percentage);
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
