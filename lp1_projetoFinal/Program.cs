﻿using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameLoop LevelDiff = new GameLoop();

            // Get value of map
            string keyInput1 = args[0];
            string keyInput2 = args[2];
            string keyInput3 = args[4];

            //int val1 = int.Parse(args[1]);
            int val2 = int.Parse(args[3]);
            int val3 = int.Parse(args[5]);

            int vals = int.Parse(args[1]);

            int levelDiff = int.Parse(args[5]);

            
            Dictionary<string, int> argsAccepter = new Dictionary<string, int>();
            //ConditionsChecker.ArgsCheck(argsAccepter, args);
            

            int row = GameBoard.RowSize;
            int col = GameBoard.ColSize;

            argsAccepter.Add("-c", col);
            argsAccepter.Add("-r", row);
            argsAccepter.Add("-d", levelDiff);
            
            if (keyInput1 == "-r")
            { 
                GameBoard.RowSize = Convert.ToInt32(args[1]);
            }
            if (keyInput2 == "-c")
            {
                GameBoard.ColSize = Convert.ToInt32(args[3]);
            }

            if (keyInput2 == "-r")
            {
                GameBoard.RowSize = Convert.ToInt32(args[3]);
            }
            if (keyInput1 == "-c")
            {
                GameBoard.ColSize = Convert.ToInt32(args[1]);
            }

            //ConditionsChecker.CheckUserInvalidArgNumbs(Convert.ToInt32(args[1]), Convert.ToInt32(args[3]));
            //ConditionsChecker.CheckDifficultyLevel(levelDiff)

            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop(levelDiff);
        }
    }
}
