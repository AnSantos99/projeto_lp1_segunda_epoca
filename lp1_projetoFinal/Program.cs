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
            //string row = args[0];
            //string col = args[2];

            // Get value of map
            string keyInput1 = args[0];
            string keyInput2 = args[2];

            //int valInput = Convert.ToInt32(args[1]);
            //int valInput2 = Convert.ToInt32(args[3]);


            //GameBoard.RowSize = Convert.ToInt32(args[1]);

            
            Dictionary<string, int> userArgsDictio = new Dictionary<string, int>();
            userArgsDictio["-r"] = GameBoard.RowSize;
            userArgsDictio["-c"] = GameBoard.ColSize;
            //userArgsDictio.Add("-r", GameBoard.RowSize);
            //userArgsDictio.Add("-c", GameBoard.ColSize);
            if (keyInput1) { }


            if (keyInput1 == "-r")
            {
                userArgsDictio["-r"] = GameBoard.RowSize;
                GameBoard.RowSize = Convert.ToInt32(args[1]);
            }
            else if (keyInput1 == "-r")
            {
                userArgsDictio["-r"] = GameBoard.RowSize;
                GameBoard.RowSize = Convert.ToInt32(args[3]);
            }

            if (keyInput2 == "-c")
            {
                userArgsDictio["-c"] = GameBoard.ColSize;
                GameBoard.ColSize = Convert.ToInt32(args[1]);
            }

            else if (keyInput2 == "-c")
            {
                userArgsDictio["-c"] = GameBoard.ColSize;
                GameBoard.ColSize = Convert.ToInt32(args[3]);
            }

            

            //ConditionsChecker.ArgsInput(args, userArgsDictio);




            // Check for invalid input
            //ConditionsChecker.CheckUserINvalidArgs(row, col);

            //ConditionsChecker.CheckUserInvalidArgNumbs(GameBoard.RowSize, GameBoard.ColSize);

            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop();
        }
    }
}
