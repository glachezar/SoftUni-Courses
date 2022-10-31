using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Rally_Racing
{
    class RaceCar
    {
        public RaceCar()
        {
            Row = 0;
            Col = 0;
            DistanceCovered = 0;
            HasFinished = false;
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public int DistanceCovered { get; set; }
        public bool HasFinished { get; set; }

        public void Drive(string direction, char[,] track)
        {

            int newCarRow = Row;
            int newCarCol = Col;

            switch (direction)
            {
                case "up": newCarRow--; break;
                case "down": newCarRow++; break;
                case "left": newCarCol--; break;
                case "right": newCarCol++; break;
            }

            char currChar = track[newCarRow, newCarCol];

            if (currChar == 'T')
            {
                track[newCarRow, newCarCol] = '.';
                Row = newCarRow;
                Col = newCarCol;
                for (int row = 0; row < track.GetLength(0); row++)
                {
                    for (int col = 0; col < track.GetLength(1); col++)
                    {
                        if (track[row, col] == 'T')
                        {
                            track[row, col] = '.';
                            Row = row;
                            Col = col;
                        }
                    }
                }

                DistanceCovered += 30;
            }
            else if (currChar == 'F')
            {
                DistanceCovered += 10;
                Row = newCarRow;
                Col = newCarCol;
                HasFinished = true;
            }
            else
            {
                DistanceCovered += 10;
                Row = newCarRow;
                Col = newCarCol;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string racingNumber = Console.ReadLine();

            char[,] raceTrack = new char[size, size];
            RaceCar car = new RaceCar();
            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    raceTrack[row, col] = input[col];

                }
            }

            bool hasReachEndCommand = false;
            string command = "";
            while (true)
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    hasReachEndCommand = true;
                    raceTrack[car.Row, car.Col] = 'C';
                    break;
                }

                if (car.HasFinished)
                {
                    raceTrack[car.Row, car.Col] = 'C';
                    break;
                }

                car.Drive(command, raceTrack);
            }

            if (hasReachEndCommand && car.HasFinished == false) Console.WriteLine($"Racing car {racingNumber} DNF.");
            else if (car.HasFinished && hasReachEndCommand == false) Console.WriteLine($"Racing car {racingNumber} finished the stage!");

            Console.WriteLine($"Distance covered {car.DistanceCovered} km.");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(raceTrack[row, col]);
                }
                Console.WriteLine();
            }
            
                
            
            
        }
    }
}
