namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (reader)
            {
                using (writer)
                {
                    int row = 1;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();


                        writer.WriteLine($"{row}. {line}");

                        row++;
                    }
                }
            }
        }
    }
}