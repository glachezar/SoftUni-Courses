using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = $"{personTokens[0]} {personTokens[1]}";
            string address = personTokens[2];
            Tuple<string, string> nameAddress = new Tuple<string, string>
            {
                Item1 = name,
                Item2 = address
            };

            string[] nameAndBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personName = nameAndBeer[0];
            double litersOfBeer = double.Parse(nameAndBeer[1]);

            Tuple<string, double> nameAndBeerToDrink = new Tuple<string, double>
            {
                Item1 = personName,
                Item2 = litersOfBeer,
            };
            string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int integer = int.Parse(inputTokens[0]);
            double double1 = double.Parse(inputTokens[1]);

            Tuple<int, double> intAndDouble = new Tuple<int, double>
            {
                Item1 = integer,
                Item2 = double1
            };

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameAndBeerToDrink);
            Console.WriteLine(intAndDouble);
        }
    }
}
