using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string command = tokens[0];
                string userName = tokens[1];
                //string licensePlateNumber = tokens[2];

                if (command == "register")
                {
                    string licensePlateNumber = tokens[2];
                    if (!register.ContainsKey(userName))
                    {
                        register.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else if (register.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[userName]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (register.ContainsKey(userName))
                    {
                        register.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else if (!register.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    
                }
            }

            foreach (var user in register)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
