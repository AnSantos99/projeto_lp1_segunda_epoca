﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Name
            Console.Title = "";

            // Get value of map
            string keyInput1 = args[0];
            string keyInput2 = args[2];

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
            //(needs to be checked) ConditionsChecker.CheckUserINvalidArgs(args[0], args[2]);

            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop();
        }
    }
}
