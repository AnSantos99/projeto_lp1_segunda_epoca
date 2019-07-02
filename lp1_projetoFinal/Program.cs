using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class Program : GameBoard
    {
        static void Main(string[] args)
        {
            // Get key pairs
            string row = args[0];
            string col = args[2];

            // Get value
            GameBoard.RowSize = Convert.ToInt32(args[1]);
            GameBoard.ColSize = Convert.ToInt32(args[3]);

            GameLoop loop = new GameLoop();

            loop.Loop();
        }
    }
}
