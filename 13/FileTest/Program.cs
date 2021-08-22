using System;
using System.IO;

namespace FileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"file1.txt";

            StreamReader streamReader = null;
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                streamReader = File.OpenText(sourcePath);
                while (streamReader.EndOfStream is false)
                {
                    string oneLine = streamReader.ReadLine();
                    Console.WriteLine(oneLine);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }

        }
    }
}
