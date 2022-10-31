using System;
using System.ComponentModel;

namespace _01._02.Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Generate")
                {
                    break;
                }

                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string instruction = tokens[0];
                if (instruction == "Contains")
                {
                    Contain(tokens[1], key);
                }
                else if (instruction == "Flip")
                {
                    string upperOrLower = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    key = Flip(upperOrLower, startIndex, endIndex, key);
                    Console.WriteLine(key);
                }
                else if (instruction == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    key = Slice(startIndex, endIndex, key);
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        static string Slice(int startIndex, int endIndex, string key)
        {
            // Deletes the characters between the start and end indices(the end index is exclusive) and prints the activation key.
            int count = endIndex - startIndex;
            key = key.Remove(startIndex, count);
            return key;
        }

        static string Flip(string upperOrLower, int startIndex, int endIndex, string key)
        {
            string result = key;
            if (upperOrLower == "Upper")
            {
                int length = endIndex - startIndex;
                string substring = key.Substring(startIndex, length);
                substring = substring.ToUpper();
                key = key.Remove(startIndex, length);
                result = key.Insert(startIndex, substring);
                
            }
            else if (upperOrLower == "Lower")
            {
                int length = endIndex - startIndex;
                string substring = key.Substring(startIndex, length);
                substring = substring.ToLower();
                key = key.Remove(startIndex, length);
                result = key.Insert(startIndex, substring);
            }

            return result;
        }

        static void Contain(string substring, string key)
        {
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
