using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] {"Gabriel", "Amanda", "Dimmy", "Elisabeth"};

            Array.ForEach(names, Console.WriteLine);

            foreach(string name in names) 
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
