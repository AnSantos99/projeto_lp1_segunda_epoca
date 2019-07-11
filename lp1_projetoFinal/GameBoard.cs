using System;
using System.Collections.Generic;
using System.Linq;

namespace lp1_projetoFinal
{
    internal class GameBoard
    {
        // Instanciate a list of type CurrentMapObjects to store items
        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        // Instanciate class inventory
        internal Inventory inventory = new Inventory();

        // Player start health is currentHealth
        internal int currentHealth = 100;

        internal List<Position> mapPositions = new List<Position>();
    
        // Static variables of Row and columns for gameboard
        internal static int RowSize;
        internal static int ColSize;

        // Variables of type CurrentMapObjects
        internal CurrentMapObjects exit, map;

        // Variable of type player
        internal Player player;

        // Instance of List of type Trap to store traps
        internal List<Trap> traps =  new List<Trap>();

        // Instanciate a list of type Items 
        internal List<Items> pickItems = new List<Items>();

        // Instanciate a list of type Enemy
        internal List<Enemy> enemies = new List<Enemy>();

        // Instanciate class Random
        internal Random rnd  = new Random();

        // Variable of type Boardcells array to create Board
        internal BoardCells[,] cells;


        public void DefineBoard(Levels lvl)
        {
            player = new Player((char)Chars.player, currentHealth, new Position(rnd.Next(RowSize), 0), inventory);

            exit = new CurrentMapObjects(new Position(rnd.Next(RowSize), (ColSize-1)), Chars.exit, "reach the exit!");

            map = new CurrentMapObjects(new Position(rnd.Next(RowSize), rnd.Next(ColSize)), Chars.map, "reveals level info");

            cells = new BoardCells[RowSize, ColSize];

            lvl.Setup(player, exit, map, itemList, traps, pickItems, enemies, RowSize, ColSize, cells);

        }

        public void RenderBoard(Levels lvl)
        {
            foreach(BoardCells item in cells)
                Console.Write(item.ToString());
            if (player.Health > player.maxHealth)
                player.Health = player.maxHealth;

            Console.WriteLine($"Level {lvl.Current} : Difficulty {lvl.Diff} : Size {RowSize}x{ColSize}");

            // print the top row
            Console.Write($"   ");
            for (uint i = 0; i < ColSize; i++) Console.Write($"_[{i}]_|");

            Console.WriteLine();

            // begin cycle to set all the rows right
            for (int y = 0; y < RowSize; y++)
            {
                Console.Write("  |");
                for (int x = 0; x < ColSize; x++)
                {    
                    Console.Write("     |");
                }

                Console.WriteLine();
                Console.Write($"[{y}] ");

                // check if there are pieces and place them
                for (int x = 0; x < ColSize; x++)
                {
                    List<char> charsInCell = new List<char> { cells[y, x].name, cells[y, x].name, cells[y, x].name, cells[y, x].name, cells[y, x].name };

                    Console.Write(" ");

                    cells[y, x].Render();

                    Console.Write("  | ");
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