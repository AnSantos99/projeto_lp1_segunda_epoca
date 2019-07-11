using System.Collections.Generic;
using System;

namespace lp1_projetoFinal
{
    internal class Levels
    {
        
        internal int Current { get;  set; }
        internal int Diff { get;  set; }

        internal Random rnd = new Random();

        internal double score;

        internal Levels(int current, int diff)
        {
            Current = current;
            Diff = diff; 
        }


        internal void Setup(Player player, CurrentMapObjects exit, 
            CurrentMapObjects map, List<CurrentMapObjects> items, List<Items> grabItems,
            List<Trap> traps, List<Food> foods, List<Weapons> weapons, List<Enemy> enemies, 
            int RowSize, int ColSize, BoardCells[,] cells)
        {
            // Max size of objects in Levels
            int maxTrapsInLvl = Linear(Current, Diff, 2);
            int maxItemsInLvl = Linear(Current, Diff, 2);
            int maxEnemiesInLvl = Linear(Current, Diff, 2);
            
            //Add objects to item list
            items.Add(exit);
            items.Add(map);
 

            // 
            int numberOfTraps = rnd.Next(maxTrapsInLvl);
            int numberOfItems = rnd.Next(maxItemsInLvl);
            int numberOfEnemies = rnd.Next(maxEnemiesInLvl);

            // Set random Traps around on map
            for (int i = 0; i < numberOfTraps; i++)
            {
                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);

                Trap trap = new Trap((new Position(row, col)), Chars.trap, $"this is a trap! watch out!", rnd.Next(100));

                traps.Add(trap);
                items.Add(trap);  

            }

            // Set random Items around the map
            for (int i = 0; i < numberOfItems; i++)
            {

                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);
                

                Food food = new Food((new Position(row, col)), Chars.food, " An apple a day keeps god astray", rnd.Next(10), rnd.Next(100));

                Weapons weapon = new Weapons((new Position(row, col)), Chars.weapon, "dagger", rnd.Next(10), rnd.Next(100), rnd.Next(10));


                items.Add(food);
                grabItems.Add(food);
                foods.Add(food);

                items.Add(weapon);
                grabItems.Add(weapon);
                weapons.Add(weapon);
            }

            // Set random enemies around the map
            for (int i = 0; i < numberOfEnemies; i++)
            {
                int row = rnd.Next(RowSize);
                int col = rnd.Next(ColSize);

                Enemy enemy = new Enemy((new Position(row, col)), Chars.enemy, " A wild enemy has appeared!", rnd.Next(100));

                enemies.Add(enemy);
                items.Add(enemy);
            }


            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    
                    cells[i, j] = new BoardCells((char)Chars.empty, false, new Position(i, j));
                }
            }


            cells[player.Position.Row, player.Position.Col] = new BoardCells(player.name,false, new Position (player.Position.Row, player.Position.Col));

        }

        internal double ScoreSetter(int lvl)
        {
            return score = (1 + 0.4 * Diff); // * (lvl + 0.1 * enemiesKilledInGame);
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
