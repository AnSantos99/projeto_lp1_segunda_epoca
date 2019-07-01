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
                Console.WriteLine("ingame wow!");


                hp--;

                answer = Console.ReadKey().Key;
            }
            while (answer != ConsoleKey.Q && hp > 0);
        }
    }

}