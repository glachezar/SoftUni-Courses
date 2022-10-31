using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done") break;

                string[] tokens = input.Split(" ").ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Change":
                        char oldCahr = char.Parse(tokens[1]);
                        char newCahr = char.Parse(tokens[2]);
                        myString = myString.Replace(oldCahr, newCahr);
                        Console.WriteLine(myString);
                        break;

                    case "Includes":
                        string substringToChek = tokens[1];
                        bool IsContaining = myString.Contains(substringToChek);
                        Console.WriteLine(IsContaining);
                        break;

                    case "End":
                        substringToChek = tokens[1];
                        IfContains(substringToChek, myString);
                        break;

                    case "Uppercase":
                        myString = myString.ToUpper();
                        Console.WriteLine(myString);
                        break;

                    case "FindIndex":
                        char charToFind = char.Parse(tokens[1]);
                        int index = myString.IndexOf(charToFind);
                        Console.WriteLine(index);
                        break;

                    case "Cut":
                        int startIndexx = int.Parse(tokens[1]);
                        int countIndex = int.Parse(tokens[2]);
                        myString = Cut(startIndexx, countIndex, myString);
                        Console.WriteLine(myString);
                        
                        break;
                }

            }
        }

        static void IfContains(string substringToChek, string myString)
        {
            int startIndex = myString.Length - substringToChek.Length;
            StringBuilder sb = new StringBuilder();
            bool isEqual = false;
            for (int i = startIndex; i < myString.Length; i++)
            {
                sb.Append(myString[i]);
            }
            string endOfMyString = sb.ToString();
            if (endOfMyString == substringToChek)
            {
                isEqual = true;
            }
            
            Console.WriteLine(isEqual);
        }

        static string Cut(int startIndexx, int countIndex, string myString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = countIndex; i > 0; i--)
            {
                sb.Append(myString[startIndexx]);
                startIndexx++;
            }
            string result = sb.ToString();
            return result;
        }
    }
}
