using System;

namespace lp1_projetoFinal
{
    internal class GameLoop
    {
        public void Loop()
        {
            // GameBoard instance to call board func in Class GameBoard
            GameBoard drawBoard = new GameBoard();
           
            ConsoleKey answer;
            int hp = 2;
            do
            {

                Console.WriteLine();
                Console.WriteLine("ingame wow!");

                PrintText gameInfo = new PrintText();

                gameInfo.GameText();

                // Call board function from class GameBoard
                drawBoard.Board();

                answer = Console.ReadKey().Key;
                hp--;

                Console.Clear();

                if (answer == ConsoleKey.L)
                    gameInfo.LookAroundText();
                if (answer == ConsoleKey.F)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.H)
                    gameInfo.HelpText();
            }
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}