using System;
using System.IO;

namespace FileUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
