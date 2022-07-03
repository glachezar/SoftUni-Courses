using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._1.The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> liftCabinOcupancy = Console.ReadLine().Split().Select(int.Parse).ToList();
            const int maxCabinCapacity = 4;

            for (int i = 0; i < liftCabinOcupancy.Count; i++)
            {
                int cabinOcupancy = liftCabinOcupancy[i];

                for (int j = cabinOcupancy; j < maxCabinCapacity; j++)
                {
                    if (peopleWaiting > 0)
                    {
                        liftCabinOcupancy[i]++;
                        peopleWaiting--;
                        if (peopleWaiting == 0)
                        {
                            if (liftCabinOcupancy.Sum() < maxCabinCapacity * liftCabinOcupancy.Count)
                            {
                                Console.WriteLine($"The lift has empty spots!");
                            }
                            Console.WriteLine(string.Join(" ", liftCabinOcupancy));
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", liftCabinOcupancy));
            
            

        }
    }
}
