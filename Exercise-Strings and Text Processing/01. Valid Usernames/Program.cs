using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValidUsername = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        char currChar = username[i];

                        if (!(currChar == '-' || currChar == '_' || char.IsDigit(currChar) || char.IsLetter(currChar)))
                        {
                            isValidUsername = false;
                            break;
                        }
                    }

                    if (isValidUsername == true)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
