using System;

namespace Extension
{
    static class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2021, 5, 13, 8, 10, 45);
            Console.WriteLine(date.ElapsedTime());

            string text = "Good morning dear students!";
            Console.WriteLine(text.Cut(10));
        }
    }
}
