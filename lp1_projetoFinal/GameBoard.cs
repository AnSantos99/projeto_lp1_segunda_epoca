using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {

        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        internal Inventory inventory = new Inventory();
    
        internal static int RowSize;
        internal static int ColSize;

        internal CurrentMapObjects exit, map;

        internal Player player;

        internal List<Trap> traps =  new List<Trap>();

        internal RandomGenerator random  = new RandomGenerator();

        internal BoardCells[,] cells;

        public void DefineBoard(Levels lvl)
        {
            player = new Player((char)Chars.player, 100, random.RandomPosition(RowSize, ColSize, ((char)Chars.player)));

            exit = new CurrentMapObjects(random.RandomPosition(RowSize, ColSize, ((char)Chars.exit)), Chars.exit, "reach the exit!");

            map = new CurrentMapObjects(random.RandomPosition(RowSize, ColSize, ((char)Chars.map)), Chars.map, "reveals level info");

            cells = new BoardCells[RowSize, ColSize];

            lvl.Setup(player, exit, map, itemList, traps, RowSize, ColSize, cells);



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