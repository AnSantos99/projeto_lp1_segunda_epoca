using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get key pairs
            string row = args[0];
            string col = args[2];

            // Get value of map
            GameBoard.RowSize = Convert.ToInt32(args[1]);
            GameBoard.ColSize = Convert.ToInt32(args[3]);

            ConditionsChecker.CheckUserINvalidArgs(row, col);
            ConditionsChecker.CheckUserInvalidArgNumbs(RowSize, ColSize);

            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop();
        }
    }
}
