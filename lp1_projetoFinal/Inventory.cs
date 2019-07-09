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

        internal void WriteInfo(Player player)
        {
            foreach (Items item in itemsInInventory)
            {
                Console.WriteLine(item.Info + $"{item.Effect}     {item.Index}");
            }

            Console.WriteLine("Which item do you wish to use?");
            string answer = Console.ReadLine();

            if (Convert.ToInt32(answer) == itemsInInventory[Convert.ToInt32(answer)].Index)
            {
                player.HealthChange(+itemsInInventory[Convert.ToInt32(answer)].Effect);
                itemsInInventory.RemoveAt(Convert.ToInt32(answer));
                
            }

           
        }

    internal void DropItem(Items item)
        {
            itemsInInventory.Remove(item);
            currentWeight -= item.Weight;
        }
    }
}
