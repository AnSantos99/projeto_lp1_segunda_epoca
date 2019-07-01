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

                // Call board function from class GameBoard
                drawBoard.Board();

                hp--;

                answer = Console.ReadKey().Key;
            }
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}