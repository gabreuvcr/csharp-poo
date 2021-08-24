using System;

namespace PlanoCartesiano 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string[] coords = Console.ReadLine().Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            while (x != 0 && y != 0) 
            {
                if (x > 0 && y > 0) 
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) 
                {
                    Console.WriteLine("segundo");
                } 
                else if (x < 0 && y < 0) 
                {
                    Console.WriteLine("terceiro");
                }
                else 
                {
                    Console.WriteLine("quarto");
                }
                coords = Console.ReadLine().Split(' ');
                x = int.Parse(coords[0]);
                y = int.Parse(coords[1]);
            }
        }
    }
}
