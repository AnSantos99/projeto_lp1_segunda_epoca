using System.Collections.Generic;
using System;

namespace lp1_projetoFinal
{
    class Inventory
    {
        internal List<Items> itemsInInventory = new List<Items>();

        internal List<Food> foodInCell = new List<Food>();
        internal List<Weapons> weaponsInCell = new List<Weapons>();


        internal List<Food> foodInInventory = new List<Food>();
        internal List<Weapons> weaponsInInventory = new List<Weapons>();

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

        internal void Pickup(GameBoard board, Player player)
        {
            bool noWeapons = weaponsInCell.Count < 1;
            bool noFood = foodInCell.Count < 1;

            if (!noFood)
            {
                Console.WriteLine("Food name:                         Effect:");
                Console.WriteLine("__________________________________________");

                foreach (Food item in foodInCell)
                {
                    Console.WriteLine(item.Info + $"{item.HPIncrease}     ");
                }
            }

            if (!noWeapons)
            {
                Console.WriteLine("Weapon name:                 Attack Power:");
                Console.WriteLine("__________________________________________");

                foreach (Weapons item in weaponsInCell)
                {
                    Console.WriteLine(item.Info + $"{item.AttackPower}     ");
                }
            }

            Console.WriteLine("Choose:");
            if (!noFood)
                Console.WriteLine("0. for food");
            if(!noWeapons)
                Console.WriteLine("1. for weapons");
            Console.WriteLine("type C and press enter to go back");


            string answer = Console.ReadLine();

            if (answer == "0")
            {
                Console.WriteLine("Food name:                         Effect:");
                Console.WriteLine("__________________________________________");

                int counter = 0;
                foreach (Food item in foodInCell)
                {
                    Console.WriteLine(counter + "." + item.Info + $"{item.HPIncrease}     ");
                    counter++;
                }
                counter = 0;

                Console.WriteLine("Pick the number of the food you want");
                answer = Console.ReadLine();
                Food pickedFood = foodInCell[Convert.ToInt32(answer)];
                
                board.inventory.AddToInventory(new Food((pickedFood.Position), pickedFood.Name, pickedFood.Info, pickedFood.Weight ,pickedFood.HPIncrease));

                board.cells[pickedFood.Position.Row, pickedFood.Position.Col] = new BoardCells((char)Chars.path, true, new Position(pickedFood.Position.Row, pickedFood.Position.Col));

                foodInInventory.Add(pickedFood);

                board.pickItems.Remove(pickedFood);
                board.itemList.Remove(pickedFood);
                board.food.Remove(pickedFood);

            

            }

            if (answer == "1")
            {
                Console.WriteLine("Weapon name:                         Effect:        Attack Power:");
                Console.WriteLine("__________________________________________");

                int counter = 0;
                foreach (Weapons item in weaponsInCell)
                {
                    Console.WriteLine(counter + "." + item.Info + $"{item.AttackPower}  + ${item.Durability}");
                    counter++;
                }
                counter = 0;

                Console.WriteLine("Pick the number of the weapon you want");
                answer = Console.ReadLine();
                Weapons pickedWeapon = weaponsInCell[Convert.ToInt32(answer)];

                board.inventory.AddToInventory(new Weapons((pickedWeapon.Position), pickedWeapon.Name, pickedWeapon.Info, pickedWeapon.Weight, pickedWeapon.AttackPower, pickedWeapon.Durability));

                weaponsInInventory.Add(pickedWeapon);

                board.pickItems.Remove(pickedWeapon);
                board.itemList.Remove(pickedWeapon);
                board.weapons.Remove(pickedWeapon);
                

            }

            foodInCell.Clear();
            weaponsInCell.Clear();

            Console.Clear();



        }

        internal void Drop(GameBoard board, Player player)
        {
            currentRow = player.Position.Row;
            currentCol = player.Position.Col;

            bool noWeapons = weaponsInInventory.Count < 1;
            bool noFood = foodInInventory.Count < 1;

            if (!noFood)
            {
                Console.WriteLine("Food name:                         Effect:");
                Console.WriteLine("__________________________________________");
                foreach (Food item in foodInInventory)
                {
                    Console.WriteLine(item.Info + $"{item.HPIncrease}     ");
                }
            }

            if (!noWeapons)
            {
                Console.WriteLine("Weapon name:                         Effect:           Durability:");
                Console.WriteLine("__________________________________________");

                foreach (Weapons item in weaponsInInventory)
                {
                    Console.WriteLine(item.Info + $"{item.AttackPower}     " + $"{item.Durability}");
                }
            }


            Console.WriteLine("Choose:");
            if (!noFood)
                Console.WriteLine("0. for food");
            if (!noWeapons)
                Console.WriteLine("1. for weapons");
            Console.WriteLine("type C and press enter to go back");


            string answer = Console.ReadLine();

            if (answer == "0")
            {
                Console.WriteLine("Food name:                         Effect:");
                Console.WriteLine("__________________________________________");

                int counter = 0;
                foreach (Food item in foodInInventory)
                {
                    Console.WriteLine(counter + "." + item.Info + $"{item.HPIncrease}     ");
                    counter++;
                }
                counter = 0;

                Console.WriteLine("Pick the number of the food you want");
                answer = Console.ReadLine();

                Food pickedFood = foodInInventory[Convert.ToInt32(answer)];

                board.inventory.AddToInventory(new Food((pickedFood.Position), pickedFood.Name, pickedFood.Info, pickedFood.Weight, pickedFood.HPIncrease));

                // CHANGE LISTS HERE 

                board.pickItems.Add(new Items(new Position(currentRow, currentCol), pickedFood.Name, pickedFood.Info, pickedFood.Weight));

                board.itemList.Add(new Items(new Position(currentRow, currentCol), pickedFood.Name, pickedFood.Info, pickedFood.Weight));

                board.food.Add(new Food(new Position(currentRow, currentCol), pickedFood.Name, pickedFood.Info, pickedFood.Weight, pickedFood.HPIncrease));

                board.cells[currentRow, currentCol] = new BoardCells((char)pickedFood.Name, true, new Position(currentRow, currentCol));

                itemsInInventory.Remove(pickedFood);



            }

            if (answer == "1")
            {

                Console.WriteLine("Weapon name:                         Effect:      Durability:");
                Console.WriteLine("__________________________________________");

                int counter = 0;
                foreach (Weapons item in weaponsInInventory)
                {
                    Console.WriteLine(counter + "." + item.Info + $"{item.AttackPower}" + $"{item.Durability}");
                    counter++;
                }
                counter = 0;

                Console.WriteLine("Pick the number of the weapon you want");
                answer = Console.ReadLine();

                Weapons pickedWeapon = weaponsInInventory[Convert.ToInt32(answer)];

                board.inventory.AddToInventory(new Weapons((pickedWeapon.Position), pickedWeapon.Name, pickedWeapon.Info, pickedWeapon.Weight, pickedWeapon.AttackPower, pickedWeapon.Durability));


                board.pickItems.Add(new Items(new Position(currentRow, currentCol), pickedWeapon.Name, pickedWeapon.Info, pickedWeapon.Weight));

                board.itemList.Add(new Items(new Position(currentRow, currentCol), pickedWeapon.Name, pickedWeapon.Info, pickedWeapon.Weight));

                board.weapons.Add(new Weapons(new Position(currentRow, currentCol), pickedWeapon.Name, pickedWeapon.Info, pickedWeapon.Weight, pickedWeapon.AttackPower, pickedWeapon.Durability));

                board.cells[currentRow, currentCol] = new BoardCells((char)pickedWeapon.Name, true, new Position(currentRow, currentCol));

                itemsInInventory.Remove(pickedWeapon);

                Console.Clear(); 
            }
        }

            internal void consumeFood(GameBoard board, Player player)
        {
            
                Console.WriteLine("Food name:                         Effect:");
                Console.WriteLine("__________________________________________");

                foreach (Food item in foodInInventory)
                {

                    Console.WriteLine(item.Info + $"{item.HPIncrease}     ");

                }

                
                string answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.Clear();
                }

                Food chosenFood = foodInInventory[Convert.ToInt32(answer)];

                player.HealthChange(chosenFood.HPIncrease);

                itemsInInventory.Remove(chosenFood);
                
        }

        internal void equipWeapon(Player player)
        {
            Console.WriteLine("Weapon name:                         Effect:          Durability");
            Console.WriteLine("__________________________________________");

            foreach (Weapons item in weaponsInInventory)
            {

                Console.WriteLine(item.Info + $"{item.AttackPower}     " + $"{ item.Durability}");

            }


            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.Clear();
            }

            Weapons chosenWeapon = weaponsInInventory[Convert.ToInt32(answer)];

            player.SelectedWeapon = chosenWeapon;

            itemsInInventory.Remove(chosenWeapon);

        }

        internal void WriteInfo(GameBoard board, Player player, string choice)
        {
            

            Console.WriteLine($"Which type of item do you wish to {choice}?");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("(ESC) Go back");
            
            if (choice == "pickup")
            { 
                Pickup(board, player);
            } 
            
            if (choice == "drop")
            {
                Drop(board, player);
            }
            
            if (choice == "use")
            {
                bool noWeapons = weaponsInInventory.Count < 1;
                bool noFood = foodInInventory.Count < 1;

                if (!noFood)
                {
                    Console.WriteLine("Food name:                         Effect:");
                    Console.WriteLine("__________________________________________");
                    foreach (Food item in foodInInventory)
                    {
                        Console.WriteLine(item.Info + $"{item.HPIncrease}     ");
                    }
                }

                if (!noWeapons)
                {
                    Console.WriteLine("Weapon name:                         Effect:           Durability:");
                    Console.WriteLine("__________________________________________");

                    foreach (Weapons item in weaponsInInventory)
                    {
                        Console.WriteLine(item.Info + $"{item.AttackPower}     " + $"{item.Durability}");
                    }
                }


                Console.WriteLine("Choose:");
                if (!noFood)
                    Console.WriteLine("0. for food");
                if (!noWeapons)
                    Console.WriteLine("1. for weapons");
                Console.WriteLine("type C and press enter to go back");


                string answer = Console.ReadLine();

                if (answer == "0")
                {
                    consumeFood(board, player);
                }

                if (answer == "1")
                {
                    equipWeapon(player);
                }

                

                Console.Clear();
               

            }

        }

    }
}

          