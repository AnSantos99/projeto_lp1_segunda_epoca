using System.Collections.Generic;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to accept keys as argument values in array index
            Dictionary<string, int> argsAccepter = new Dictionary<string, int>();

            // Get arguments given by main func to create a specific gameboard
            UserInputArgs.UserArgs(argsAccepter, args, UserInputArgs.levelDiff);
            
            // Check if all arguments given in the console are valid
            ConditionsChecker.Conditions(args);

            // Initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // Call the Loop function to begin new game loop
            loop.Loop(UserInputArgs.levelDiff);
        }
    }
}
