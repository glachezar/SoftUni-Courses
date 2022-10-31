using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservations = new HashSet<string>();

            HashSet<string> reservationNums = new HashSet<string>();
            string cmdArgs = Console.ReadLine();
            while (cmdArgs != "PARTY")
            {
                reservationNums.Add(cmdArgs);
                cmdArgs = Console.ReadLine();
            }
            cmdArgs = Console.ReadLine();

            while (cmdArgs != "END")
            {
                reservationNums.Remove(cmdArgs);
                cmdArgs = Console.ReadLine();
            }

            Console.WriteLine(reservationNums.Count);
            // HashSet<string> vips = reservationNums.Where(x => char.IsDigit(x.First())).ToHashSet();
            reservationNums = reservationNums.OrderByDescending(x => char.IsDigit(x.First())).ToHashSet();

            Console.WriteLine(string.Join("\n", reservationNums));
        }
    }
}
