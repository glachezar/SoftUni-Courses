using System;
using System.Linq;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] beach = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                beach[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            }
            Player player = new Player();
            Opponent opponent = new Opponent();

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "Gong") break;
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries); 

                switch (tokens[0])
                {
                    case "Find":
                        player.Row = int.Parse(tokens[1]);
                        player.Col = int.Parse(tokens[2]);
                        player.Move(beach);
                        break;
                    case "Opponent":
                        opponent.Row = int.Parse(tokens[1]);
                        opponent.Col = int.Parse(tokens[2]);
                        opponent.Direction = tokens[3];
                        opponent.Move(beach);
                        break;
                }
            }

            for (int row = 0; row < beach.Length; row++)
            {
                Console.WriteLine(string.Join(" ", beach[row]));
            }

            Console.WriteLine($"Collected tokens: {player.TokensColected}");
            Console.WriteLine($"Opponent's tokens: {opponent.TokensColected}");
        }

    }

    public class Player
    {

        public int TokensColected { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public void Move(char[][] beach)
        {
            if (IsValidIndex(Row, Col, beach) )
            {
                if (beach[Row][Col] == 'T')
                {
                    TokensColected ++;
                    beach[Row][Col] = '-';
                }
            }
            static bool IsValidIndex(int row, int col, char[][] beach)
            {

                return row >= 0
                       && row < beach.Length
                       && col >= 0
                       && col < beach[row].Length;
            }

        }
        
    }

    public class Opponent
    {
        public int TokensColected { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public string Direction { get; set; }

        public void Move(char[][] beach)
        {
            if (IsValidIndex(Row, Col, beach))
            {
                if (beach[Row][Col] == 'T')
                {
                    TokensColected++;
                    beach[Row][Col] = '-';
                }

                for (int i = 1; i < 4; i++)
                {
                    switch (Direction)
                    {
                        case "up": Row--; break;
                        case "down": Row++; break;
                        case "left": Col--; break;
                        case "right": Col++; break;
                    }

                    if (IsValidIndex(Row, Col, beach))
                    {
                        if (beach[Row][Col] == 'T')
                        {
                            TokensColected++;
                            beach[Row][Col] = '-';
                        }
                    }
                }
            }
        }
        static bool IsValidIndex(int row, int col, char[][] beach)
        {

            return row >= 0
                   && row < beach.Length
                   && col >= 0
                   && col < beach[row].Length;
        }

    }
    

}
