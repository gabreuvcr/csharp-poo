using System;
using System.Collections.Generic;
using EmployeePolymorphism.Entities;

namespace EmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = Int32.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = Int32.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = Double.Parse(Console.ReadLine());
                
                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = Double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2")}");
            }
        }
    }
}
