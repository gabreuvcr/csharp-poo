using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Path: ");
            string path = "in.txt";

            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = Double.Parse(fields[1]);

                        products.Add(new Product(name, price));
                    }
                }

                double averagePrice = products.Select(p => p.Price)
                    .DefaultIfEmpty(0.0)
                    .Average();

                Console.WriteLine($"Average price: {averagePrice:F2}");

                var namesBelowAvg = products.Where(p => p.Price < averagePrice)
                    .OrderByDescending(p => p.Name)
                    .Select(p => p.Name);
                
                foreach (string name in namesBelowAvg)
                {
                    Console.WriteLine(name);
                }
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
