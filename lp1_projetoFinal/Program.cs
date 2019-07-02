using System;

namespace lp1_projetoFinal
{
    class Program : GameBoard
    {
        
        static void Main(string[] args)
        {

            GameLoop loop = new GameLoop();

            loop.Loop();


        }
    }
}
