using System;
using System.IO;
using System.Collections.Generic;

namespace Voting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            Console.Write("Enter path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = Int32.Parse(line[1]);
                        if (dict.ContainsKey(name))
                        {
                            dict[name] += votes;
                        }
                        else
                        {
                            dict[name] = votes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in dict)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
