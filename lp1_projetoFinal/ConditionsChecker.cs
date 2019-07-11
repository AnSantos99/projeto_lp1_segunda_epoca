using System;

namespace lp1_projetoFinal
{
    /// <summary>
    /// A class that checks if specific arguments in specific given array 
    /// indexes are valid or not.
    /// </summary>
    internal class ConditionsChecker
    {
        /// <summary>
        /// Function to check for invalid strings inputs by the user in each 
        /// specific array index.
        /// </summary>
        /// <param name="args"> Get Main method args from class Program</param>
        internal static void CheckUserINvalidArgs(string [] args)
        {
           // Check if the input in the specific array index is not equal to
           // the valid accepting arguments
            if (args[0] != "-r" && args[0] != "-c" && args[0] != "-d")
            { 
                Console.WriteLine("The first input is invalid. " +
                    "Please use valid arguments: '-c', '-r' or '-d'");

                // End the program
                Environment.Exit(0);
            }

            // Check if the input in the specific array index is not equal to
            // the valid accepting arguments
            if (args[2] != "-r" && args[2] != "-c" && args[2] != "-d")
            {
                Console.WriteLine("The second input is invalid. " +
                    "Please use valid arguments: '-c', '-r' or '-d'");

                // End the program
                Environment.Exit(0);
            }

            // Check if the input in the specific array index is not equal to
            // the valid accepting arguments
            if (args[4] != "-r" && args[4] != "-c" && args[4] != "-d")
            {
                Console.WriteLine("The third input is invalid. " +
                    "Please use valid arguments: '-c', '-r' or '-d'");

                // End the program
                Environment.Exit(0);
            }   
        }

        /// <summary>
        /// Function to check for invalid value inputs by the user in each 
        /// specific array index.
        /// </summary>
        /// <param name="args"> Get Main method args from class Program</param>
        internal static void CheckUserInvalidArgNumbs(string[] args)
        {
            // Check if user input is under 6 in column and row
            if (int.Parse(args[1]) < 6 || int.Parse(args[3]) < 6 || 
                int.Parse(args[5]) < 6)
            {
                Console.WriteLine("Invalid input. Please choose number for " +
                    "row and column equal or above 6 for a better " +
                    "game experience.");

                // End the program
                Environment.Exit(0);
            }

            // Check if user input is above 10 in column and row
            else if (int.Parse(args[1]) > 10 || int.Parse(args[3]) > 10 || 
                int.Parse(args[5]) > 10)
            {
                Console.WriteLine("Invalid input. Please choose number for " +
                    "row and column under 10 for a better game experience.");

                // End the program
                Environment.Exit(0);
            }     
        }


        /// <summary>
        /// Function to check for invalid value inputs for difficulty level 
        /// by the user in each specific array index.
        /// </summary>
        /// <param name="args"> Get Main method args from class Program</param>
        internal static void CheckDifficultyLevel(string[] args)
        {
            // Check the arguments on array index 0 if input -d
            switch (args[0])
            {
                case "-d":
                    if(int.Parse(args[1]) <  1 || int.Parse(args[1]) > 10)
                        Console.WriteLine("Please choose a difficulty number "+
                        "between 1 and 10");
                    break;
            }

            // Check the arguments on array index 2 if input -d
            switch (args[2])
            {
                case "-d":
                    if (int.Parse(args[3]) < 1 || int.Parse(args[3]) > 10)
                        Console.WriteLine("Please choose a difficulty number "+
                        "between 1 and 10");
                    break;
            }

            // Check the arguments on array index 4 if input -d
            switch (args[4])
            {
                case "-d":
                    if (int.Parse(args[5]) < 1 || int.Parse(args[3]) > 10)
                        Console.WriteLine("Please choose a difficulty number "+
                        "between 1 and 10");
                    break;
            }
        }

        /// <summary>
        /// Function that contains other functions to check valid arguments
        /// given by the user on the console
        /// </summary>
        /// <param name="args"> Get Main method args from class Program</param>
        internal static void Conditions(string[] args)
        {
            CheckDifficultyLevel(args);
            CheckUserINvalidArgs(args);
            CheckUserInvalidArgNumbs(args);
        }
    }
}
