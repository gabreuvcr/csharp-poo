using System;
using System.Collections.Generic;
using System.IO;
using InternetLog.Model;

namespace InternetLog
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashSet<LogRecord> set = new HashSet<LogRecord>();
            SortedSet<LogRecord> set = new SortedSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(username, instant));
                    }
                }

                Console.WriteLine($"Total users: {set.Count}");
                foreach (var user in set)
                {
                    Console.WriteLine(user.Username);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
