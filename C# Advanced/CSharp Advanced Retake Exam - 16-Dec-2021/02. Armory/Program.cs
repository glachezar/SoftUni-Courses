using System;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] armory = new char[size, size];
            Officer officer = new Officer();
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    armory[row, col] = input[col];

                    if (armory[row, col] == 'A')
                    {
                        officer.Row = row;
                        officer.Col = col;
                    }
                }
            }

            bool go = true;

            while (go == true)
            {
                string command = Console.ReadLine();
                go = officer.Move(command, armory);

                if (officer.Swords >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    go = false;
                }
            }

            Console.WriteLine($"The king paid {officer.Swords} gold coins.");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(armory[row, col]);
                }

                Console.WriteLine();
            }
        }
    }

    class Officer
    {

        public int Swords { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public bool Move(string direction, char[,] armory)
        {
            int size = armory.GetLength(0);
            armory[Row, Col] = '-';
            int newRow = Row;
            int newCol = Col;

            switch (direction)
            {
                case "up": newRow--; break;
                case "down": newRow++; break;
                case "left": newCol--; break;
                case "right": newCol++; break;
            }
            if (newRow < 0 || newRow >= size || newCol < 0 || newCol >= size)
            {

                Console.WriteLine("I do not need more swords!");
                return false;
            }
            //else if (Swords > 65)
            //{
            //    Console.WriteLine("Very nice swords, I will come back for more!");
            //    return false;
            //}
            if (char.IsDigit(armory[newRow, newCol]))
            {
                char digit = armory[newRow, newCol];
                Swords += int.Parse(digit.ToString());
            }
            else if (armory[newRow, newCol] == 'M')
            {
                armory[newRow, newCol] = '-';
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (armory[row, col] == 'M')
                        {
                            newRow = row;
                            newCol = col;
                        }
                    }
                }
            }
            armory[newRow, newCol] = 'A';
            Row = newRow;
            Col = newCol;
            return true;
        }
    }
}
