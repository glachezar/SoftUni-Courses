using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = String.Empty;
                int count = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string revercedWords = ReverseWords(replacedSymbols);
                        sb.AppendLine(revercedWords);
                    }

                    count++;
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReverseWords(string replacedSymbols)
        {
            string[] reversedWords = replacedSymbols.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            
            return String.Join(" ", reversedWords);
        }

        private static string ReplaceSymbols(string line)
        {
            string[] symbolsToReplace = { "-", ", ", ". ", "! ", "? " };

            foreach (var symbol in symbolsToReplace)
            {
                line = line.Replace(symbol, "@");
            }

            return line;
        }
    }
}
