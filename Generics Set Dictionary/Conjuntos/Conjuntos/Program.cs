using System;
using System.Collections.Generic;
using System.IO;
using Conjuntos.Entities;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logica para le arquivo de texto

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { UserName = name, Instant = instant });                        
                    }
                    Console.WriteLine("Total user: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
