using System;
using System.Globalization;
using Rental.Entities;
using Rental.Services;

namespace Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime start = DateTime.ParseExact(Console.ReadLine() ?? String.Empty, "dd/MM/yyyy HH:mm", provider);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine() ?? String.Empty, "dd/MM/yyyy HH:mm", provider);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double pricePerHour = Double.Parse(Console.ReadLine() ?? String.Empty);
            Console.Write("Enter price per day: ");
            double pricePerDay = Double.Parse(Console.ReadLine() ?? String.Empty);

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
