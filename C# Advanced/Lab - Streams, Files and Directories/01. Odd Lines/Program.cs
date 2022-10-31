using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"../../../Files/input.txt";
            string outputFilePath = @"../../../Files/output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…

            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (reader)
            {
                using (writer)
                {
                    int row = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (row  % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        row++;
                    }
                }
            }
        }
    }
}
