using System.Collections.Generic;
using System;

namespace lp1_projetoFinal
{
    class Inventory
    {
        internal List<Items> itemsInInventory = new List<Items>();
        internal int currentWeight;
        internal int maxWeight = 6;

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

        internal void writeInfo()
        {
            foreach (Items item in itemsInInventory)
            {
                Console.WriteLine(item.Info + "              " + item.Effect);
            }
        }

    internal void DropItem(Items item)
        {
            itemsInInventory.Remove(item);
            currentWeight -= item.Weight;
        }
    }
}
