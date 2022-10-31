using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numberPlates = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];
                string numberPlate = input[1];

                if (command == "IN")
                {
                    numberPlates.Add(numberPlate);
                }
                else if (command == "OUT")
                {
                    numberPlates.Remove(numberPlate);
                }
            }

            if (numberPlates.Count > 0)
            {
                foreach (var plate in numberPlates)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
