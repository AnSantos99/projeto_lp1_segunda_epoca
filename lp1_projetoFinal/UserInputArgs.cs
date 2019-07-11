using System.Collections.Generic;


namespace lp1_projetoFinal
{
    /// <summary>
    /// Class that accepts dictionary keys and its values as a argument on a
    /// specific array index and returns the correct value to create 
    /// the gameboard
    /// </summary>
    internal class UserInputArgs
    {
        // Variable to get the level difficulty 
        internal static int levelDiff;

        /// <summary>
        /// In each specific array index give the needed dictionary value for
        /// every condition
        /// </summary>
        /// <param name="argsAccepter"> Dictionary arguments</param>
        /// <param name="args"> Array indexer </param>
        /// <param name="levelDiff"> Get leveldifficulty </param>
        internal static void UserArgs(Dictionary<string, int> argsAccepter,
            string[] args, int levelDiff)
        {
            UserInputArgs.levelDiff = 0;

            // Switch in array position [0] between key's given by the user and
            // return the desired value
            switch (args[0])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = 
                        int.Parse(args[1]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = 
                        int.Parse(args[1]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = 
                        int.Parse(args[1]);
                    break;
            }

            // Switch in array position [2] between key's given by the user and
            // return the desired value
            switch (args[2])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = 
                        int.Parse(args[3]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = 
                        int.Parse(args[3]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = 
                        int.Parse(args[3]);
                    break;
            }

            // Switch in array position [4] between key's given by the user and
            // return the desired value
            switch (args[4])
            {
                case "-d":
                    argsAccepter["-d"] = UserInputArgs.levelDiff = 
                        int.Parse(args[5]);
                    break;
                case "-c":
                    argsAccepter["-c"] = GameBoard.ColSize = 
                        int.Parse(args[5]);
                    break;
                case "-r":
                    argsAccepter["-r"] = GameBoard.RowSize = 
                        int.Parse(args[5]);
                    break;
            }
        }
    }
}
