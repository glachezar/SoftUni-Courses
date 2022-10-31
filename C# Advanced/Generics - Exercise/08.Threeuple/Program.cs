using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = $"{personTokens[0]} {personTokens[1]}";
            string address = personTokens[2];
            string city = personTokens[3];
            Threeuple<string, string, string> nameAddress = new Threeuple<string, string, string>
            {
                Item1 = name,
                Item2 = address,
                Item3 = city
            };

            string[] nameAndBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = nameAndBeer[0];
            double litersOfBeer = double.Parse(nameAndBeer[1]);
            string drunkOrNot = nameAndBeer[2];

            Threeuple<string, double, bool> nameAndBeerToDrink = new Threeuple<string, double, bool>
            {
                Item1 = personName,
                Item2 = litersOfBeer,
                Item3 = drunkOrNot == "drunk"
            };
            string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string nameOfAccountHolder = inputTokens[0];
            double accountBalance = double.Parse(inputTokens[1]);
            string bankName = inputTokens[2];

            Threeuple<string, double,string> intAndDouble = new Threeuple<string, double, string>
            {
                Item1 = nameOfAccountHolder,
                Item2 = accountBalance,
                Item3 = bankName
            };

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameAndBeerToDrink);
            Console.WriteLine(intAndDouble);
        }
    }
}
