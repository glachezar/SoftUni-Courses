using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (true)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = "";

                if (encryptedMessage == "find")
                {
                    break;
                }

                int count = 0;
                foreach (var ch in encryptedMessage)
                {
                    int charAsInt = (int)ch;
                    int decryptedCharAsInt = charAsInt - key[count];
                    char decryptedChar = (char)decryptedCharAsInt;
                    decryptedMessage += decryptedChar;

                    if (count < key.Length - 1)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                //The type will be between the symbol '&' and the coordinates will be between the symbols '<' and '>'.
                //For each line, print the type and the coordinates in format "Found {type} at {coordinates}"


                int typeStartIndex = decryptedMessage.IndexOf('&') + 1;
                int typeLength = decryptedMessage.LastIndexOf('&') - typeStartIndex;

                int coordinatesStartIndex = decryptedMessage.IndexOf('<') + 1;
                int coordinatesLength = decryptedMessage.IndexOf('>') - coordinatesStartIndex;

                string type = decryptedMessage.Substring(typeStartIndex, typeLength);
                string coordinates = decryptedMessage.Substring(coordinatesStartIndex, coordinatesLength);

                Console.WriteLine($"Found {type} at {coordinates}");
            }

        }
    }
}
