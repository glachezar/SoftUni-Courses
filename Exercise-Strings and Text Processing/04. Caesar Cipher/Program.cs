using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (var ch in text)
            {
                char encryptedChar = (char)(ch + 3);
                result.Append(encryptedChar);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
