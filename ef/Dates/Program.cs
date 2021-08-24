using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBirthday = new DateTime(1999, 6, 8);
            DateTime herBirthday = new DateTime(2001, 2, 27);
            
            int allDays = (herBirthday - myBirthday).Days;
            int years = allDays / 365;
            int months = (allDays % 365) / 30;
            int days = (allDays % 365) % 30;
            int totalDays = (herBirthday - myBirthday).Days;

            Console.WriteLine($"Diferença: {years} years, {months} months, {days} days ({totalDays} dias total)");

            DateTime d1 = new DateTime(2021, 04, 18, 0, 38, 30, DateTimeKind.Local);
            DateTime d2 = new DateTime(2021, 04, 18, 0, 38, 30, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2021, 04, 18, 0, 38, 30);

            Console.WriteLine($"\nd1: {d1}");
            Console.WriteLine($"d1 utc: {d1.ToUniversalTime()}");
            Console.WriteLine($"d1 local: {d1.ToLocalTime()}");

            Console.WriteLine($"\nd2: {d2}");
            Console.WriteLine($"d2 utc: {d2.ToUniversalTime()}");
            Console.WriteLine($"d2 local: {d2.ToLocalTime()}");
            
            Console.WriteLine($"\nd3: {d3}");
            Console.WriteLine($"d3 utc: {d3.ToUniversalTime()}");
            Console.WriteLine($"d3 local: {d3.ToLocalTime()}");
        }
    }
}
