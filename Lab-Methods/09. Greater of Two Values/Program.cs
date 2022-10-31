using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "char":
                    char input1 = char.Parse(Console.ReadLine());
                    char input2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(input1, input2));
                    return;
                case "string":
                    string stringInput1 = Console.ReadLine();
                    string stringInput2 = Console.ReadLine();
                    Console.WriteLine(GetMax(stringInput1, stringInput2));
                    return;
                    
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            int result = 0;
            if (firstValue > secondValue)
            {
                result = firstValue;
            }
            else
            {
                result = secondValue;
            }

            return result;
        }

        static char GetMax(char firstValue, char secondValue)
        {
            char result = '/';
            if (firstValue > secondValue)
            {
                result = firstValue;
            }
            else
            {
                result = secondValue;
            }

            return result;
        }

        static string GetMax(string firstValue, string secondValue)
        {
            string result = String.Empty;
            if (String.Compare(firstValue, secondValue) > 0)
            {
                result = firstValue;
            }
            else
            {
                result = secondValue;
            }

            return result;
        }
    }
}
