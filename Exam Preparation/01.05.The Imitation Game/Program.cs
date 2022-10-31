using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _01._05.The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Decode")
                {
                    break;
                }
                string[] tokens = input.Split("|");
                string command = tokens[0];

                if (command == "Move")
                {
                    int numOfLetters = int.Parse(tokens[1]);
                    message = MoveLetters(numOfLetters, message);
                    
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];
                    message = message.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];
                    message = message.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string MoveLetters(int numOfLetters, string concealedMessage)
        {
            string substring = "";
            for (int i = 0; i < numOfLetters; i++)
            {
                substring += concealedMessage[i];
            }

            concealedMessage = concealedMessage.Remove(0, substring.Length);
            concealedMessage += substring;
            return concealedMessage;
        }

        
    }
}
