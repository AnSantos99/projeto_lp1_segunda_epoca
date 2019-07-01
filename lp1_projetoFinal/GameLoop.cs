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

                gameInfo.gameText();

                answer = Console.ReadKey().Key;
                hp--;

                Console.Clear();
            }
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}