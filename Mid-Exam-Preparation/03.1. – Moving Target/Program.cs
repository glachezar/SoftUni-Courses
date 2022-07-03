using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _03._1.___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] tokens = Console.ReadLine().Split().ToArray();

            while (tokens[0] != "End")
            {
                
                int index = int.Parse(tokens[1]);
                int power;
                int value;
                int radius;
                if (tokens[0] == "Shoot")
                {
                    power = int.Parse(tokens[2]);
                    ShootTheTarget(targetSequence, index, power);
                }
                else if (tokens[0] == "Add")
                {
                    value = int.Parse(tokens[2]);
                    Add(targetSequence, index, value);
                }
                else if (tokens[0] == "Strike")
                {
                    radius = int.Parse(tokens[2]);
                    Strike(targetSequence, index, radius);
                }
                tokens = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join("|", targetSequence));
        }

        private static void Strike(List<int> targetSequence, int index, int radius)
        {
            if (index + radius > targetSequence.Count || index - radius < 0)
            {
                Console.WriteLine("Strike missed!");
            }
            else
            {
                int start = index - radius;
                int count = (radius * 2) + 1;
                targetSequence.RemoveRange(start, count);
            }
        }

        private static void Add(List<int> targetSequence, int index, int value)
        {
            if (index >= targetSequence.Count || index < 0)
            {
                Console.WriteLine("Invalid placement!");
            }
            else
            {
                targetSequence.Insert(index, value);
            }
        }


        private static void ShootTheTarget(List<int> targetSequence, int index, int power)
        {
            if (index<0 || index > targetSequence.Count-1)
            {
                return;
            }
            else
            {

                if (targetSequence[index] - power <= 0 )
                {
                    targetSequence.RemoveAt(index);
                }
                else if (targetSequence[index] - power > 0)
                {
                    targetSequence[index] -= power;
                }
                
            }
        }
    }
}
