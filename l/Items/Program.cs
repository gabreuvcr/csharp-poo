using System;
using System.IO;
using Items.Entities;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "in.csv";
            string targetPath = "out/summary.csv";
            if (!Directory.Exists("out")) Directory.CreateDirectory("out");

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    using (StreamWriter sw = File.CreateText(targetPath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] productFields = sr.ReadLine().Split(',');

                            string name = productFields[0];
                            double price = Double.Parse(productFields[1]);
                            int quantity = Int32.Parse(productFields[2]);

                            Product product = new Product(name, price, quantity);
                            sw.WriteLine(product);
                        }
                    }
                }   
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
