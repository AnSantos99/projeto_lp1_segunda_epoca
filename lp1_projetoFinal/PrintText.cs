using System;
using System.Text;

namespace lp1_projetoFinal
{
    class PrintText
    {

       
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
            Console.Write("     Attack Enemy(F)  ");
            Console.Write("Pick up Item(E)   ");
            Console.Write("Use Item(U)   ");
            Console.WriteLine("Drop Item(D)   ");

            Console.Write("\u2190 \u2192 Move   ");
            Console.Write("Look Around(L)   ");
            Console.WriteLine("Help(H)");

            Console.Write("\u2199\u2193\u2198   "); 
            
            
            Console.Write("     Save Game(S)     ");
           
            Console.WriteLine("Quit Game(Q)");
   

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
         
        }

    }
}