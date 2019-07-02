using System;
using System.Text;

namespace lp1_projetoFinal
{
    class GameLoop
    {
        internal static GameBoard board;
        internal static Player player;

        internal MainMenu menu = new MainMenu();

        bool start = false;

        public void Loop()
        {

            if (!start) { menu.Menu(); }

            start = true;


            Console.OutputEncoding = Encoding.UTF8;

            ConsoleKey answer;
            int hp = 2;

       
            do
            {
                PrintText gameInfo = new PrintText();

              //  gameInfo.GameText();

                board = new GameBoard();

                board.RenderBoard();

                Position position = Player.GetPosition(board);

                answer = Console.ReadKey().Key;
                hp--;

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
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}