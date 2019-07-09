using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {

        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        internal Inventory inventory = new Inventory();

        internal int currentHealth = 100;
    
        internal static int RowSize;
        internal static int ColSize;

        internal CurrentMapObjects exit, map;

        internal Player player;

        internal List<Trap> traps =  new List<Trap>();

        internal List<Items> pickItems = new List<Items>();

        internal Random rnd  = new Random();

        internal BoardCells[,] cells;

        public void DefineBoard(Levels lvl)
        {
            player = new Player((char)Chars.player, currentHealth, new Position(rnd.Next(RowSize), 0), inventory);

            exit = new CurrentMapObjects(new Position(rnd.Next(RowSize), (ColSize-1)), Chars.exit, "reach the exit!");

            map = new CurrentMapObjects(new Position(rnd.Next(RowSize), rnd.Next(ColSize)), Chars.map, "reveals level info");

            cells = new BoardCells[RowSize, ColSize];

            lvl.Setup(player, exit, map, itemList, traps, pickItems, RowSize, ColSize, cells);
        }

        public void RenderBoard(Levels lvl)
        {
            if (player.Health > player.maxHealth)
                player.Health = player.maxHealth;

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
                Console.Write($"[{y}] ");

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

        public void ResetBoard()
        {
            currentHealth = player.Health;
            itemList.Clear();
            pickItems.Clear();
        }
    }
}