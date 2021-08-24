using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimension: ");
            string[] dim = Console.ReadLine().Split(' ');
            int row = Int32.Parse(dim[0]);
            int col = Int32.Parse(dim[1]);

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Int32.Parse(values[j]);
                }
            }

            int wantedValue = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == wantedValue)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j != 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        }
                        if (j != col - 1)
                        {
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        }
                        if (i != 0)
                        {
                            Console.WriteLine($"Up: {matrix[i - 1, j]}");
                        }
                        if (i != row - 1)
                        {
                            Console.WriteLine($"Down: {matrix[i + 1, j]}");
                        }

                    }
                }
            }
        }
    }
}
