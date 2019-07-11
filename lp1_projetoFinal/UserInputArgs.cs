using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class UserInputArgs
    {
        internal static int levelDiff;

        public static void UserArgs(Dictionary<string, int> argsAccepter,string[] args, int levelDiff)
        {
            UserInputArgs.levelDiff = 0;
            
            switch (args[0])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = int.Parse(args[1]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = int.Parse(args[1]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = int.Parse(args[1]);
                    break;
            }

            switch (args[2])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = int.Parse(args[3]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = int.Parse(args[3]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = int.Parse(args[3]);
                    break;
            }

            switch (args[4])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = int.Parse(args[5]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = int.Parse(args[5]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = int.Parse(args[5]);
                    break;
            }
        }
    }
}
