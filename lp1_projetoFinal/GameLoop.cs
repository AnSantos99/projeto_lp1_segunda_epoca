using System;
using System.Text;

namespace lp1_projetoFinal
{
    class GameLoop
    {
        internal static GameBoard board = new GameBoard();
        Player player = new Player((char) Chars.player, 100);

        internal MainMenu menu = new MainMenu();

        bool start = false;
       
        public void Loop()
        {
            PrintText gameInfo = new PrintText();

            if (!start) { menu.Menu(); board.DefineBoard(); }

            start = true;

            Console.OutputEncoding = Encoding.UTF8;

            ConsoleKey answer;
           
     
            do
            {       
                   
                board.RenderBoard();

                gameInfo.GameText(player);

                answer = Console.ReadKey().Key;
                player.health--;

                Console.Clear();
                if (answer == ConsoleKey.DownArrow)

                 if (answer == ConsoleKey.L)
                    gameInfo.LookAroundText();
                if (answer == ConsoleKey.E || answer == ConsoleKey.U || answer == ConsoleKey.D)
                    gameInfo.InventoryText();
                if (answer == ConsoleKey.F)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.H)
                    gameInfo.HelpText();
                
            }
            while (answer != ConsoleKey.Q && player.health > 0);
        }
    }

}