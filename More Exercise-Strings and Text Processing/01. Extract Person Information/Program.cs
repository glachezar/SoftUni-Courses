using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: "Hello my name is @Peter| and I am #20* years old."

            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {

                string input = Console.ReadLine();

                int nameStartIndex = input.IndexOf('@') + 1;
                int nameLength = input.IndexOf('|') - nameStartIndex;

                int ageStartIndex = input.IndexOf('#') + 1;
                int ageLength = input.IndexOf('*') - ageStartIndex;

                string name = input.Substring(nameStartIndex, nameLength);
                string age = input.Substring(ageStartIndex, ageLength);

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
