using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class ConditionsChecker
    {
        /*
        public static void ArgsCheck(Dictionary<string, int> argsDic, string[] args)
        {
            new argsDic
            
        }*/

        /// <summary>
        /// Function to check for invalid user input
        /// </summary>
        /// <param name="row"> check the row KEY input</param>
        /// <param name="col"> check the col KEY input</param>
        public static void CheckUserINvalidArgs(string row, string col)
        {
            
            // If user input is not equal to the wished arguments
            if (row != "-r")
            {
                Console.WriteLine("Invalid input. Please write: '-r (number)' ");

                Environment.Exit(0);
            }

            // Check if user input is diferent than wished argument
            if (col != "-c")
            {
                Console.WriteLine("Invalid input. Please write: '-c (number)' ");

                Environment.Exit(0);
            }    
        }

        /// <summary>
        /// Check user Invalid number arguments
        /// </summary>
        /// <param name="row"> Get number from args in position[1]/[3]/[5]</param>
        /// <param name="col"> Get number from args in position[3]/[1]/[5]</param>
        public static void CheckUserInvalidArgNumbs(int row, int col)
        {
            // Check if user input is under 6 in column and row
            if (row < 6 && col < 6)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please choose number for " +
                    "row and column equal or above 6 for a better " +
                    "game experience.");

                Environment.Exit(0);
            }

            // Check if user input is above 10 in column and row
            else if (row > 10 && col > 10)
            {
                Console.WriteLine("Size out of range. Please choose number " +
                    "between 6 and 10 for row and col.");

                Environment.Exit(0);
            }     
        }

        /// <summary>
        /// functin to check invalid difficulty number
        /// </summary>
        /// <param name="diff"> Get number from args position [1]/[3]/[5] </param>
        public static void CheckDifficultyLevel(int diff)
        {
            if (diff == 0 || diff > 10)
            {
                Console.WriteLine("Please choose a difficulty number between " +
                    "1 and 10");

                Environment.Exit(0);
            }
        }

        public static void CheckScoreList(List<GameScore> scoreChecker)
        {

        }


        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="a3"></param>
        /// <returns></returns>
        public static int CheckValidUserArgs(string input1, string input2, string input3, int a1, int a2, int a3 )
        {
            if (input1 == "-r" || input2 == "-r" || input3 == "-r")
            {
                return GameBoard.RowSize = Convert.ToInt32(a1);
            }

            if (input1 == "-c" || input2 == "-c" || input3 == "-c")
            {
                return GameBoard.ColSize = Convert.ToInt32(a2);
            }


            if (input1 == "-d" || input2 == "-d" || input3 == "-d")
            {
                return a3;
            }

            return 0;
        }*/
    }
}
