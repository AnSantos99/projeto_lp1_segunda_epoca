using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {

        internal  int exit;

        internal Position exitPosition;

        internal Position mapPosition;

        internal List<Trap> traps = new List<Trap>();
    

        internal static int RowSize;
        internal static int ColSize;

        internal BoardCells[,] cells = new BoardCells[RowSize, ColSize];
    
        public void DefineBoard(Player player)
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    cells[i, j] = new BoardCells((char)Chars.empty);
                }
            }

            Trap trap1 = new Trap(2, new Position(4, 4), 5, "hello", ((char)Chars.trap));
            Trap trap2 = new Trap(1, new Position(4, 3), 5, "hello", ((char)Chars.trap));
            Trap trap3 = new Trap(3, new Position(5, 4), 5, "hello", ((char)Chars.trap));

            traps.Add(trap1);
            traps.Add(trap2);
            traps.Add(trap3);

            foreach (Trap trap in traps)
            {
                cells[trap.Position.Row, trap.Position.Col] = new BoardCells((char)Chars.trap);
            }

            // Declare Variables BOARD
            Random random = new Random();

            exit = random.Next(0, RowSize);

            int playerStart = random.Next(0, RowSize);

            cells[RowSize - 1, exit] = new BoardCells((char)Chars.empty);

            exitPosition = new Position(RowSize - 1, exit);

            mapPosition = new Position(2, 2);

            cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
            
        }

        public void RenderBoard()
        {
           
            // print the top row
            Console.Write($"   ");
            for (uint i = 0; i < ColSize; i++) Console.Write($"_[{i}]_|");

            Console.WriteLine();

            // begin cycle to set all the rows right
            for (uint y = 0; y < RowSize; y++)
            {
                Console.Write("  |");
                for (uint x = 0; x < ColSize; x++)
                {    
                    Console.Write("     |");
                }

                Console.WriteLine();
                Console.Write($"[{y + 1}] ");

                // check if there are pieces and place them
                for (uint x = 0; x < ColSize; x++)
                {
                    Console.Write("  ");
                    cells[y,x].Render();
                    Console.Write(" | ");
                }

                // new line to render bottom of row
                Console.WriteLine();
                Console.Write("  |");
                for (uint x = 0; x < ColSize; x++)
                {
                    Console.Write("__ __|");
                }

                Console.WriteLine();
            }
        }
    }
}