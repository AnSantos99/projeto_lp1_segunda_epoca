using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {

        internal List<Trap> traps = new List<Trap>();
    
        internal static int RowSize;
        internal static int ColSize;

        internal Player player;

        internal CurrentMapObjects map;
        internal CurrentMapObjects exit;

        internal Position exitPosition;
        internal Position mapPosition;
        internal Position playerStart;

        internal RandomGenerator random  = new RandomGenerator();

        internal BoardCells[,] cells = new BoardCells[RowSize, ColSize];

        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        public void DefineBoard()
        {
            exitPosition = random.RandomPosition(RowSize, ColSize, ((char)Chars.exit));

            mapPosition = random.RandomPosition(RowSize, ColSize, ((char)Chars.map));

            playerStart = random.RandomPosition(RowSize, ColSize, ((char)Chars.player));

            exit = new CurrentMapObjects(exitPosition, Chars.exit, "reach the exit!");

            map = new CurrentMapObjects(mapPosition, Chars.map, "reveals level info");


            Trap trap1 = new Trap((random.RandomPosition(RowSize, ColSize, ((char)Chars.trap))), (Chars.trap), "this trap takes 1hp", 1, 3);

            Trap trap2 = new Trap((random.RandomPosition(RowSize, ColSize, ((char)Chars.trap))), (Chars.trap), "this trap takes 2hp", 2, 3);

            Trap trap3 = new Trap((random.RandomPosition(RowSize, ColSize, ((char)Chars.trap))), (Chars.trap), "this trap takes 3hp", 3, 3);

            traps.Add(trap1);
            traps.Add(trap2);
            traps.Add(trap3);

            itemList.Add(exit);
            itemList.Add(map);

            foreach (Trap trap in traps)
            {
                itemList.Add(trap);
            }

            player = new Player((char)Chars.player, 100, playerStart);

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

           

            // Declare Variables BOARD


            cells[player.position.Row, player.position.Col] = new BoardCells((char)player.name);               

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