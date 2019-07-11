using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> argsAccepter = new Dictionary<string, int>();
            
            UserInputArgs.UserArgs(argsAccepter, args, UserInputArgs.levelDiff);
 
 
            //ConditionsChecker.CheckUserInvalidArgNumbs(Convert.ToInt32(args[1]), Convert.ToInt32(args[3]));
            //ConditionsChecker.CheckDifficultyLevel(levelDiff)

            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop(UserInputArgs.levelDiff);
        }
    }
}
