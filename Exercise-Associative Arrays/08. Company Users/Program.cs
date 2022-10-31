using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] tokens = command.Split(" -> ").ToArray();
                string companyName = tokens[0];
                string employeeId = tokens[1];
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                    companyUsers[companyName].Add(employeeId);
                }
                else if (companyUsers.ContainsKey(companyName) && !companyUsers[companyName].Contains(employeeId))
                {
                    companyUsers[companyName].Add(employeeId);
                }
            }

            foreach (var company in companyUsers)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
