using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRating = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int entryPoint = int.Parse(Console.ReadLine());

            string typeOfItemsToBreack = Console.ReadLine();

            int entryPointItem = priceRating[entryPoint];


            //bool lefrSide = false;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            SeparateToLeftAndRight(priceRating, left, right, entryPoint);
            int sumOfItemsLeft = 0;
            int sumOfItemsRight = 0;
            if (typeOfItemsToBreack == "cheap")
            {
                foreach (var item in left)
                {
                    if (item < entryPointItem)
                    {
                        sumOfItemsLeft += item;
                    }
                }

                foreach (var item in right)
                {

                    if (item < entryPointItem)
                    {
                        sumOfItemsRight += item;
                    }
                }
            }
            else if (typeOfItemsToBreack == "expensive")
            {
                foreach (var item in left)
                {
                    if (item >= entryPointItem)
                    {
                        sumOfItemsLeft += item;
                    }
                }
                foreach (var item in right)
                {
                    if(item >= entryPointItem)
                    {
                        sumOfItemsRight += item;

                    }
                }
            }

            //TypeOfItemsToBreack(left, right, entryPointItem, typeOfItemsToBreack, sumOfItemsLeft, sumOfItemsRight);

            if (sumOfItemsLeft >= sumOfItemsRight)
            {
                Console.WriteLine($"Left - {sumOfItemsLeft}");
            }
            else
            {
                
                Console.WriteLine($"Right - {sumOfItemsRight}");
            }
            

            

        }
        private static void SeparateToLeftAndRight(List<int> priceRating, List<int> left, List<int> right, int entryPoint)
        {
            for (int i = entryPoint + 1; i < priceRating.Count; i++)
            {
                right.Add(priceRating[i]);
            }

            for (int i = entryPoint - 1; i >= 0; i--)
            {
                left.Add(priceRating[i]);
            }
        }

        

    }
}
