using System;

namespace _01.Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCitys = int.Parse(Console.ReadLine());
            string nameOfTheCity = "";
            double income = 0;
            double expenses = 0;
            double totalProfit = 0;
            double cityProft = 0;

            for (int i = 1; i <= numberOfCitys; i++)
            {
                nameOfTheCity = Console.ReadLine();
                income = double.Parse(Console.ReadLine());
                expenses = double.Parse(Console.ReadLine());


                cityProft = income - expenses;
                totalProfit += cityProft;

                if (i % 3 == 0 && i % 5 != 0 )
                {
                    double specialEventCost = expenses * 0.5;
                    cityProft -= specialEventCost;
                    totalProfit -= specialEventCost;
                }
                else if (i % 5 == 0)
                {
                    cityProft -= income * 0.1;
                    totalProfit -= income * 0.1;
                }

                Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {cityProft:f2} leva.");

            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
