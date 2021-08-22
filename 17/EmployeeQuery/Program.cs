using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using EmployeeQuery.Entities;

namespace EmployeeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "in.txt";
                Console.WriteLine($"Enter full file path: {path}");
                Console.Write("Enter salary: ");
                double salaryQuery = Double.Parse(Console.ReadLine());

                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = Double.Parse(fields[2]);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                var emails = employees.Where(emp => emp.Salary > salaryQuery)
                    .OrderBy(emp => emp.Email)
                    .Select(emp => emp.Email);

                var sumSalaryM = employees.Where(emp => emp.Name.StartsWith('M'))
                    .Sum(emp => emp.Salary);

                Console.WriteLine($"Email of people whose salary is  more than {salaryQuery:F2}:");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalaryM:F2}");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
