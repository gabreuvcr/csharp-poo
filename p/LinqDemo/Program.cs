﻿using System;
using System.Collections.Generic;
using System.Linq;
using LinqDemo.Entities;

namespace LinqDemo
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        { 
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() {Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() {Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() {Id = 3, Name = "Electronics", Tier = 1};

            List<Product> products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() {Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() {Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() {Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() {Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };

            var r1 = products
                .Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            
            var s1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            
            Print("TIER 1 AND PRICE < 900:", s1);

            var r2 = products
                .Where(p => p.Category.Name == "Tools").Select(p => p.Name);

            var s2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            
            Print("NAMES OF PRODUCTS FROM TOOLS:", s2);

            var r3 = products
                .Where(p => p.Name.ToUpper().StartsWith('C'))
                .Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});

            var s3 =
                from p in products
                where p.Name.ToUpper().StartsWith('C')
                select new {p.Name, p.Price, CategoryName = p.Category.Name};

            Print("NAMES STARTED WITH C AND ANONYMOUS OBJECT:", s3);

            var r4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p=> p.Name); 
            
            var s4 = 
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
    
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", s4);

            var r5 = r4.Skip(2).Take(4);

            var s5 = 
                (from p in s4
                select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", s5);

            var r6 = products.FirstOrDefault();

            var s6 = 
                (from p in products
                select p).FirstOrDefault();

            Console.WriteLine($"FIRST OR DEFAULT TEST1:\n{s6}\n");

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine($"FIRST OR DEFAULT TEST2:\n{(r7 == null ? "null" : r7)}\n");

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"SINGLE OR DEFAULT TEST1:\n{(r8 == null ? "null" : r8)}\n");
            
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"SINGLE OR DEFAULT TEST1:\n{(r9 == null ? "null" : r9)}\n");

            var r10 = products.Max(p => p.Price);
            Console.WriteLine($"MAX PRICE:\n{r10:F2}\n");
            
            var r11 = products.Min(p => p.Price);
            Console.WriteLine($"MIN PRICE:\n{r11:F2}\n");

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"CATEGORY 1 SUM PRICE:\n{r12:F2}\n");
            
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"CATEGORY 1 AVERAGE PRICE:\n{r13:F2}\n");

            var r14 = products
                .Where(p => p.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average(); 
            Console.WriteLine($"CATEGORY 5 AVERAGE PRICE:\n{r14:F2}\n");

            var r15 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"CATEGORY 1 AGGREGATE SUM:\n{r15:F2}\n");

            var r16 = products.GroupBy(p => p.Category);

            var s16 = 
                from p in products
                group p by p.Category;

            foreach (IGrouping<Category, Product> group in s16)
            {
                Console.WriteLine($"Category {group.Key.Name}:");
                foreach (Product p in group)
                {
                    Console.WriteLine($"    {p}");
                }
                Console.WriteLine();
            }
            
        }
    }
}