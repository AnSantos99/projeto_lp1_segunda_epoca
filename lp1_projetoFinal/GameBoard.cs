using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {

    //    internal List<Trap> traps = new List<Trap>();
    
        internal static int RowSize;
        internal static int ColSize;

        internal Player player;

        internal CurrentMapObjects map;
        internal CurrentMapObjects exit;

        internal RandomGenerator random;

        internal BoardCells[,] cells = new BoardCells[RowSize, ColSize];

        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        public void DefineBoard()
        {

            Position exitPosition = random.RandomPosition(RowSize, ColSize, Chars.exit);

            Position mapPosition = random.RandomPosition(RowSize, ColSize, Chars.map);

            exit = new CurrentMapObjects(exitPosition, Chars.exit, "reach the exit!");

            map = new CurrentMapObjects(mapPosition, Chars.map, "reveals level info");


            itemList.Add(exit);
            itemList.Add(map);

            foreach (CurrentMapObjects item in itemList)
            {

                cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
            }

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    cells[i, j] = new BoardCells((char)Chars.empty);
                }
            }
            /*
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
            */

            // Declare Variables BOARD

            Position playerStart = new Position(3,4);//random.RandomPosition(RowSize, ColSize);

            player = new Player((char)Chars.player, 100, playerStart);

            cells[player.position.Row, player.position.Col] = new BoardCells(player.name);               

        }

        public void RenderBoard(Levels lvl)
        {

            Console.WriteLine($"Level {lvl.Current} : Difficulty {lvl.Diff} : Size {RowSize}x{ColSize}");

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