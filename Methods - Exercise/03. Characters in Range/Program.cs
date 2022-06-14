using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            CharactersBetween(char1, char2);
        }

        static void CharactersBetween(char char1, char char2)
        {
            if (char1 < char2)
            {
                for (int i = char1 +1; i < char2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = char2 +1; i < char1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }

    }
}
