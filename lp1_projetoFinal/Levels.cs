using System.Collections.Generic;
using System;

namespace lp1_projetoFinal
{
    internal class Levels
    {
        
        internal int Current { get;  set; }
        internal int Diff { get;  set; }

        internal Random rnd = new Random();

        internal List<Trap> traps = new List<Trap>();

        internal double score;


        internal Levels(int current, int diff)
        {
            Current = current;
            Diff = diff; 
        }


        internal void Setup(Player player, CurrentMapObjects exit, CurrentMapObjects map, List<CurrentMapObjects> items, List<Trap> traps, List<Items> grabItems, int RowSize, int ColSize, BoardCells[,] cells)
        {
            
            int maxTrapsInLvl = Linear(Current, Diff, 2);
            int maxItemsInLvl = Linear(Current, Diff, 2);

            

            items.Add(exit);
            items.Add(map);

            int numberOfTraps = rnd.Next(maxTrapsInLvl);

            int numberOfItems = rnd.Next(maxItemsInLvl);

            for (int i = 0; i < numberOfTraps; i++)
            {

                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);

                Trap trap = new Trap((new Position(row, col)), Chars.trap, "this trap takes 2hp", rnd.Next(RowSize), rnd.Next(RowSize));

                traps.Add(trap);
                items.Add(trap);  

            }

            for (int i = 0; i < numberOfItems; i++)
            {

                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);

                Items item = new Items((new Position(row, col)), Chars.food, "an apple a day keeps god astray", rnd.Next(RowSize), rnd.Next(RowSize));
                
                items.Add(item);
                grabItems.Add(item);

            }

            foreach (CurrentMapObjects item in items)
            {
                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);

                cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
            }


            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    cells[i, j] = new BoardCells((char)Chars.empty);
                }
            }

            cells[player.Position.Row, player.Position.Col] = new BoardCells((char)player.name);

        }

        internal void ScoreSetter()
        {
            score = (1 + 0.4 * Diff); // * (level + 0.1 * enemiesKilledInGame);
        }

        /// <summary>
        /// Linear function
        /// </summary>
        /// <param name="x">Input variable x</param>
        /// <param name="m">Slope</param>
        /// <param name="b">Intercept value at yy</param>
        /// <returns>The y output variable</returns>
        internal static int Linear(int x, int m, int b)
        {
            return m * x + b;
        }

    }
}
