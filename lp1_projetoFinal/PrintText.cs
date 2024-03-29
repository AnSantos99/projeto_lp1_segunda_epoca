using System;
using System.Text;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    
    /// <summary>
    /// this class contains 5 methods and has the purpose to store all the 
    /// different texts that will be printed for each menu within the game 
    /// it returns nothing
    /// </summary>
    internal class PrintText
    {
        protected static Stack<string> actions = new Stack<string>();

        /// <summary>
        /// this method's purpose is to store the initial game menu text, where
        /// the user will be shown each option they can choose in the gameloop
        /// </summary>
        public void MenuText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine();
            Console.WriteLine("please select an option:");
            Console.WriteLine("A. New Game");
            Console.WriteLine("B. High Scores");
            Console.WriteLine("C. Credits");
            Console.WriteLine("D. Quit");
        }
  
        /// <summary>
        /// this method's use is to constantly print the information available
        /// to the player at all times during a level, returning nothing
        /// </summary>
        /// <param name="player"> receives the current player's info</param>
        public void GameText(Levels level, Player player, Inventory inventory, char key)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (key == 'W') actions.Push("Moved to the North");
            if (key == 'S') actions.Push("Moved to the South");
            if (key == 'D') actions.Push("Moved to the East");
            if (key == 'A') actions.Push("Moved to the West");

            if (key == 'Q') actions.Push("Moved to the NorthWest");
            if (key == 'E') actions.Push("Moved to the NorthEast");
            if (key == 'Z') actions.Push("Moved to the SouthWest");
            if (key == 'X') actions.Push("Moved to the SouthEast");

            if (key == 'M') actions.Push("Picked up map!");

            if (key == 'T') actions.Push("Fallen into a trap!!");

            if (key == 'P') actions.Push("Picked up item");

            if (key == 'M') actions.Push("Enemy attack!");
      
            Console.Write("last actions:");
            
            Console.WriteLine("------------------------------------------------");

            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }

            if (actions.Count >= 3)
            {
                for(int i = 0; i < 3; i++)
                    actions.Pop();
            }

            Console.WriteLine("Player Stats:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Current Level:{level.Current}");
            Console.WriteLine($"HP: {player.Health}");
            if(player.SelectedWeapon != null)
            Console.WriteLine($"Selected Weapon: {player.SelectedWeapon.Name}");
            Console.WriteLine($"Inventory occupation: {inventory.currentWeight}");

            Console.WriteLine("Caption:");
            Console.WriteLine("------------");
            Console.Write($"SYMBOL - {(char)Chars.player}");
            Console.Write($"SYMBOL - {(char)Chars.enemy}");
            Console.WriteLine($"SYMBOL - {(char)Chars.empty}");

            Console.Write($"SYMBOL - {(char)Chars.path}");
            Console.Write($"SYMBOL - {(char)Chars.map}");
            Console.WriteLine($"SYMBOL - {(char)Chars.food}");

            Console.Write($"SYMBOL - {(char)Chars.weapon}");
            Console.Write($"SYMBOL - {(char)Chars.trap}");
            Console.WriteLine($"SYMBOL - {(char)Chars.exit}");



            Console.WriteLine("Messages:");
            Console.WriteLine("------------");
          

            Console.WriteLine("Options:");
            Console.WriteLine("------------");
            Console.Write("\u2196\u2191\u2197   ");
            Console.Write("     Attack Enemy(1)  ");
            Console.Write("Pick up Item(2)   ");
            Console.Write("Use Item(3)   ");
            Console.WriteLine("Drop Item(4)   ");

            Console.Write("\u2190 \u2192 Move   ");
            Console.Write("Look Around(5)   ");
            Console.WriteLine("Help(6)");

            Console.Write("\u2199\u2193\u2198   "); 
            
            
            Console.Write("     Save Game(7)     ");
           
            Console.WriteLine("Quit Game(8)");
   

        }

        /// <summary>
        /// this method showcases the enemies around the player and allows them
        /// to select one to attack when present
        /// </summary>
        public void EnemyAttackText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Select enemy to Attack:");
            Console.WriteLine("------------");
            Console.WriteLine("Go Back");
            Console.WriteLine("Enemies");
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
    

        }

        /// <summary>
        /// this method shows information useful for the player that is extra
        /// to the one they have on the main screen, depending on the items
        /// they have found, weapons and their effects
        /// </summary>
        public void HelpText(List<Food> food, List<Weapons> weapons, List<Trap> traps, Inventory inventory, Player player)
        {
            

            Console.WriteLine("--------------------------");
            Console.WriteLine("Food          HPIncrease        Weight");
            Console.WriteLine("----------------------------------------");
            foreach(Food foodz in food)
                Console.WriteLine(foodz.Name + "                 " + foodz.HPIncrease);

            Console.WriteLine();

            Console.WriteLine("Weapon          AttackPower        Weight       Durability");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (Weapons weapon in weapons)
                Console.WriteLine(weapon.Name + "      " + weapon.AttackPower + "     " + weapon.Weight + "      " + weapon.Durability);



            Console.WriteLine();

            Console.WriteLine("Trap            MaxDamage");
            Console.WriteLine("--------------------------");

            foreach (Trap trap in traps)
            {
                Console.WriteLine(trap.TrapInfo + "              " + trap.MaxDamage);
            }
            
            Console.WriteLine("Name              10.0");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();


        }

        /// <summary>
        /// this menu shows the player the information pertraining their direct
        /// surroundings in a moore view
        /// </summary>
        public void LookAroundText(List<CurrentMapObjects> list)
        {

            Console.WriteLine("--------------------------");

            if (list.Count > 0)
            {
                foreach (CurrentMapObjects objects in list)
                {
                    Console.WriteLine(objects.Direction + objects.Name + objects.Info);
                }
            }
            else
                Console.WriteLine("There's nothing around you!");
                

       
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            

        }

        /// <summary>
        /// this menu shows what the player currently owns and offers the 
        /// options of picking, dropping and using items
        /// </summary>
       
        public void ScoreText()
        {
            Console.WriteLine("<-------------------------->");
            Console.WriteLine(@"Your Current Score on map {0}x{1} will be shown here:", GameBoard.RowSize, GameBoard.ColSize);

        }

       

    }
}