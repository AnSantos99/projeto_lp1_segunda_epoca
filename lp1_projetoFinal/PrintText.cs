using System;
using System.Text;

namespace lp1_projetoFinal
{
    /// <summary>
    /// this class contains 5 methods and has the purpose to store all the 
    /// different texts that will be printed for each menu within the game 
    /// it returns nothing
    /// </summary>
    class PrintText
    {

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
        public void GameText(Player player)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("last actions:              ");
            Console.WriteLine("Player Stats:");
            Console.WriteLine("------------------------------------------------");
           
            
            Console.WriteLine("Current Level:");
            Console.WriteLine($"HP: {player.health}");
            Console.WriteLine("Selected Weapon:");
            Console.WriteLine("Inventory occupation:");

            Console.WriteLine("Caption:");
            Console.WriteLine("------------");
            Console.WriteLine("SYMBOL - player");
            Console.WriteLine("SYMBOL - enemies");
            Console.WriteLine("SYMBOL - empty");
            Console.WriteLine("SYMBOL - unexplored");
            Console.WriteLine("SYMBOL - map");
            Console.WriteLine("SYMBOL - food");
            Console.WriteLine("SYMBOL - weapon");
            Console.WriteLine("SYMBOL - trap");
            Console.WriteLine("SYMBOL - exit");
   

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
        public void HelpText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Food          HPIncrease        Weight");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Name             +5              +4");

            Console.WriteLine();

            Console.WriteLine("Weapon          AttackPower        Weight       Durability");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Name              10.0              3.0             0.90");


            Console.WriteLine();

            Console.WriteLine("Trap            MaxDamage");
            Console.WriteLine("--------------------------");
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
        public void LookAroundText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("HERE:");
            Console.WriteLine("<- W:");
            Console.WriteLine("<- NW:");
            Console.WriteLine("<- N:");
            Console.WriteLine("<- NE:");
            Console.WriteLine("<- E:");
            Console.WriteLine("<- SE:");
            Console.WriteLine("<- S:");
            Console.WriteLine("<- SW:");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }

        /// <summary>
        /// this menu shows what the player currently owns and offers the 
        /// options of picking, dropping and using items
        /// </summary>
        public void InventoryText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Select item to XXXX");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Weapon (Name)");
            Console.WriteLine("Food (Name)");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }

    }
}