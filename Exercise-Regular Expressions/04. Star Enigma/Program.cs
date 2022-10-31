using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables needed.
            string decryptKey = @"[star]";
            //Regex decryption = new Regex(decryptKey);

            // Receiving input.
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, decryptKey, RegexOptions.IgnoreCase);
                int decryptionIndex = matches.Count;

                // Subtracting decryption Index.

                char[] inputInToCharArr = input.ToCharArray();

                for (int j = 0; j < inputInToCharArr.Length; j++)
                {
                    inputInToCharArr[j] = (char)(inputInToCharArr[j] - decryptionIndex);
                }
                // Decrypted message to string.
                string result = string.Join("", inputInToCharArr);
                //Console.WriteLine(result);
                // Validating messages. 
                string patern =
                    @"@(?<planet>[A-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->(?<soldiers>\d+)";
                Regex regex = new Regex(patern);
                bool isValid = regex.IsMatch(result);
                if (isValid)
                {
                   Match match = regex.Match(result);
                  
                   if (match.Groups["attack"].Value == "A")
                   {
                        attackedPlanets.Add(match.Groups["planet"].Value);
                   }
                   else
                   {
                        destroyedPlanets.Add(match.Groups["planet"].Value);
                   }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets.OrderBy(x => x).ToList().ForEach(planet => Console.WriteLine($"-> {planet}"));
            
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            destroyedPlanets.OrderBy(x => x).ToList().ForEach(planet => Console.WriteLine($"-> {planet}"));
            
        }
    }
}
