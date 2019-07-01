using System;

namespace lp1_projetoFinal
{
    class PrintText
    {

        public void menuText()
        {

            Console.WriteLine("Welcome to the game!");
            Console.WriteLine();
            Console.WriteLine("please select an option:");
            Console.WriteLine("A. New Game");
            Console.WriteLine("B. High Scores");
            Console.WriteLine("C. Credits");
            Console.WriteLine("D. Quit");
        }

        public void gameText()
        {

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

        public void enemyAttackText()
        {
            Console.WriteLine("Select enemy to Attack:");
            Console.WriteLine("------------");
            Console.WriteLine("Go Back");
            Console.WriteLine("Enemies");
            
        }


        }
}