using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._2.Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int countHitTargets = 0;
            while (command != "End")
            {
                int token = int.Parse(command);

                SootTheTarget(targets, token, countHitTargets);
                command = Console.ReadLine();
            }
            //HitTargetsCount(targets, countHitTargets);
            foreach (var target in targets)
            {
                if (target == -1)
                {
                    countHitTargets++;
                }
            }
            Console.WriteLine($"Shot targets: {countHitTargets} -> " + string.Join(" ", targets));
            
        }

        private static void SootTheTarget(List<int> targets, int token, int countHitTargets)
        {
            int currentTargetValue = 0;
            if (token < 0 || token > targets.Count-1)
            {
                return;
            }
            else
            {
                if (targets[token] == -1)
                {
                    return;
                }
                else if (targets[token] > -1)
                {
                    currentTargetValue = targets[token];
                    targets[token] = -1;
                    
                    SumOrSubtractTargetValue(targets, currentTargetValue);
                }
            }
        }

        //private static void HitTargetsCount(List<int> targets, int countHitTargets)
        //{
        //    foreach (var target in targets)
        //    {
        //        if (target == -1)
        //        {
        //            countHitTargets ++;
        //        }
        //    }
        //}

        private static void SumOrSubtractTargetValue(List<int> targets, int currentTargetValue)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] > -1 && targets[i] <= currentTargetValue)
                {
                    targets[i] += currentTargetValue;
                }
                else if (targets[i] > currentTargetValue)
                {
                    targets[i] -= currentTargetValue;
                }
            }
        }
    }
}
