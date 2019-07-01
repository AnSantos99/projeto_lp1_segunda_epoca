using System;

namespace lp1_projetoFinal
{
    class GameLoop
    {
        public void Loop()
        {
            ConsoleKey answer;
            int hp = 2;
            do
            {
                PrintText gameInfo = new PrintText();

                gameInfo.GameText();

                answer = Console.ReadKey().Key;
                hp--;

                Console.Clear();

                if (answer == ConsoleKey.L)
                    gameInfo.LookAroundText();
                if (answer == ConsoleKey.E || answer == ConsoleKey.U || answer == ConsoleKey.D)
                    gameInfo.InventoryText();
                if (answer == ConsoleKey.F)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.H)
                    gameInfo.HelpText();
            }
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}