using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string string1 = input[0];
            string string2 = input[1];
            Console.WriteLine(MultiplyMyStrings(string1, string2));
        }
        public static int MultiplyMyStrings(string string1, string string2)
        {
            int result = 0;

            if (string1.Length != string2.Length)
            {
                string shortString = "";
                string longString = "";

                if (string1.Length > string2.Length)
                {
                    shortString = string2;
                    longString = string1;
                }
                else
                {
                    shortString = string1;
                    longString = string2;
                }

                for (int i = 0; i < shortString.Length; i++)
                {
                    result += string1[i] * string2[i];
                }

                for (int i = shortString.Length; i < longString.Length; i++)
                {
                    result += longString[i];
                }
            }
            else
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    result += string1[i] * string2[i];
                }
            }
            return result;
        }
    }
}
