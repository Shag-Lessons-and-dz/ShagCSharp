using System;
using System.Globalization;
using System.Linq;

namespace dz21_12._06._2023
{
    
    class Enterprise
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public int NWorkers { get; set; }

        public Enterprise(string name, DateTime foundationDate, int nWorkers)
        {
            Name = name;
            FoundationDate = foundationDate;
            NWorkers = nWorkers;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Foundation Date: {Convert.ToString(FoundationDate, CultureInfo.InvariantCulture)}, Number of Workers: {Convert.ToString(NWorkers)}";
        }
    }

    class ProcessEnterprise
    {
        public string[] GetInfo(Enterprise[] enterprises)
        {
            return enterprises.Select(e => e.ToString()).ToArray();
        }

        public string[] GetCountWorkers(Enterprise[] enterprises)
        {
            return enterprises.Where(e => e.NWorkers > 100).Select(e => e.Name).ToArray();
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            Enterprise[] enterprises = {
                new Enterprise("Enterprise 1", new DateTime(2000, 1, 1), 50),
                new Enterprise("Enterprise 2", new DateTime(1995, 5, 15), 200),
                new Enterprise("Enterprise 3", new DateTime(2010, 10, 10), 80),
                new Enterprise("Enterprise 4", new DateTime(2005, 3, 20), 150)
            };

            ProcessEnterprise processEnterprise = new ProcessEnterprise();
            
            string[] info = processEnterprise.GetInfo(enterprises);
            Console.WriteLine("Information about Enterprises:");
            foreach (string item in info)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            string[] countWorkers = processEnterprise.GetCountWorkers(enterprises);
            Console.WriteLine("Enterprises with more than 100 workers:");
            foreach (string item in countWorkers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}