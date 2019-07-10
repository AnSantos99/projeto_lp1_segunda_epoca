using System.Collections.Generic;
using System;

namespace lp1_projetoFinal
{
    class Inventory
    {
        internal List<Items> itemsInInventory = new List<Items>();
        internal int currentWeight;
        internal int maxWeight = 10;

        internal void AddToInventory(Items item)
        {
            if (item.Weight <= (maxWeight - currentWeight))
            {
                itemsInInventory.Add(item);
                currentWeight += item.Weight;

            }

            else
            {
                // print message abt not having space
            }
        }

        private int currentRow;
        private int currentCol;

        internal void WriteInfo(GameBoard board, Player player, string choice)
        {

            

            Console.WriteLine($"Which item do you wish to {choice}?");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("(ESC) Go back");
            
            if (choice == "pickup")
            {
                foreach (Items item in board.pickItems)
                {
                    if (item.FallenInto(board.player))
                    {
                        Console.WriteLine(item.Info + $"{item.Effect}     ");
                    }
                }

                string answer = Console.ReadLine();

               
                Items testo = board.pickItems[Convert.ToInt32(answer)];
                   
                board.inventory.AddToInventory(new Items((testo.Position), testo.Name, testo.Info, testo.Weight, testo.Effect));

                board.pickItems.Remove(testo);
                board.itemList.Remove(testo);
            
            }
            

            if (choice == "drop")
            {
                foreach (Items item in itemsInInventory)
                {
                    Console.WriteLine(item.Info + $"{item.Effect}     ");
                }

                string answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.Clear();
                }

                Items testo = itemsInInventory[Convert.ToInt32(answer)];

                currentRow = player.Position.Row;
                currentCol = player.Position.Col;

                board.pickItems.Add(new Items(new Position(currentRow, currentCol), testo.Name, testo.Info, testo.Weight, testo.Effect));

                board.itemList.Add(new Items(new Position(currentRow, currentCol), testo.Name, testo.Info, testo.Weight, testo.Effect));

                board.cells[currentRow, currentCol] = new BoardCells((char)testo.Name, true);

                itemsInInventory.Remove(testo);

                Console.Clear();

            }

            if (choice == "use")
            {
                foreach (Items item in itemsInInventory)
                {
                    Console.WriteLine(item.Info + $"{item.Effect}     ");
                }

                string answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.Clear();
                }

                Items testo = itemsInInventory[Convert.ToInt32(answer)];

                player.HealthChange(testo.Effect);

                itemsInInventory.Remove(testo);

                Console.Clear();

            }

            if (choice == "drop")
            {
                string answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.Clear();
                }

               Items testo = itemsInInventory[Convert.ToInt32(answer)];

                currentRow = player.Position.Row;
                currentCol = player.Position.Col;

                board.pickItems.Add(new Items(new Position(currentRow, currentCol), testo.Name, testo.Info, testo.Weight, testo.Effect));

                board.itemList.Add(new Items(new Position(currentRow, currentCol), testo.Name, testo.Info, testo.Weight, testo.Effect));

                board.cells[currentRow, currentCol] = new BoardCells((char)testo.Name, true);

                itemsInInventory.Remove(testo);

                Console.Clear();

            }


        }

    }
}

          