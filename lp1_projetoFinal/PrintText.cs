using System;

namespace lp1_projetoFinal
{
    class PrintText
    {
        GameLoop loop = new GameLoop();

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
  
        public void GameText()
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("Player Stats:");
            Console.WriteLine("------------");
            Console.WriteLine("Current Level:");
            Console.WriteLine("HP:");
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
            Console.WriteLine("last action");

            Console.WriteLine("Options:");
            Console.WriteLine("------------");
            Console.WriteLine("Move");
            Console.WriteLine("Attack Enemy");
            Console.WriteLine("Look Around");
            Console.WriteLine("Save Game");
            Console.WriteLine("Pick up Item");
            Console.WriteLine("Use Item");
            Console.WriteLine("Drop Item");
            Console.WriteLine("Help");
            Console.WriteLine("Quit Game");
        
            

        }

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
            loop.Loop();

        }

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
            loop.Loop();

        }

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
            loop.Loop();
        }

        public void InventoryText()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Select item to XXXX");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Weapon (Name)");
            Console.WriteLine("Food (Name)");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            loop.Loop();
        }

    }
}