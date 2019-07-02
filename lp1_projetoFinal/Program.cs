using System;
using System.Collections.Generic;
using System.Text;

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
