using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(list);

            string command; 

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(listyIterator.HashNext());
                        break;

                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception exeption)
                        {

                            Console.WriteLine(exeption.Message);
                        }
                        break;

                }
            }
        }
    }
}
