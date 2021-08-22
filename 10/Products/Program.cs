using System;
using System.Collections.Generic;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProducts = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = Char.Parse(Console.ReadLine().Trim().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = Double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
