using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads the path to a file and subtracts the file name and its extension.
            //C:\Internal\training -internal\Template.pptx

            string pathInput = Console.ReadLine();
            string[] pathInArr = pathInput.Split('\\').ToArray();
            int endIndex = pathInArr.Length - 1;
            string[] fileNameAndExtention = pathInArr[endIndex].Split('.').ToArray();

            Console.WriteLine($"File name: {fileNameAndExtention[0]}");
            Console.WriteLine($"File extension: {fileNameAndExtention[1]}");

        }
    }
}
