﻿namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < ; i++)
            {

            
                
                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player2[0] > player1[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                    player1.RemoveAt(0);
                }
                else if (player1 == player2)
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
            }
            if (player1.Count > 0)
            {
                
                Console.WriteLine($"First player wins!Sum: {player1.Sum()}");
            }
            else if (player2.Count > 0)
            {
                Console.WriteLine($"Second player wins!Sum: {player2.Sum()}");
            }
        }
    }
}