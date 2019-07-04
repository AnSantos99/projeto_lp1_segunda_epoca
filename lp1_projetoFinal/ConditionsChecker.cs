﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class ConditionsChecker
    {
        
        public static void ArgsCheck(string argKey1, int argVal1, string argKey2, int argVal2 )
        {
            
        }

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
        /// <param name="row"> Get number from args[1]</param>
        /// <param name="col"> Get number from args[3]</param>
        public static void CheckUserInvalidArgNumbs(int row, int col)
        {
            // If user input is smaller or equal to 6
            if (row <= 6 && col <= 6)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please choose number for" +
                    "row and column equal or above 6 for a better " +
                    "game experience.");

                Environment.Exit(0);
            }

            // Check if user input is above 10
            if (row > 10)
            {
                Console.WriteLine("Size out of range. Please choose number " +
                    "between 6 and 10 for row.");

                Environment.Exit(0);
            }

            else if (col > 10)
            {
                Console.WriteLine("Size out of range. Please choose number " +
                    "between 6 and 10 for column.");

                Environment.Exit(0);
            }
        }

        /*
        /// <summary>
        /// Check user valid arguments
        /// </summary>
        /// <param name="row"> Get row</param>
        /// <param name="col"> Get column</param>
        public static int CheckValidUserArgs(string input1, string input2, string )
        {
            if (input1 == "-r")
            {
                return GameBoard.RowSize = Convert.ToInt32();
            }
            if (input2 == "-c")
            {
                return GameBoard.ColSize = Convert.ToInt32(args[3]);
            }

            if (input2 == "-r")
            {
                return GameBoard.RowSize = Convert.ToInt32(args[3]);
            }
            if (input1 == "-c")
            {
                return GameBoard.ColSize = Convert.ToInt32(args[1]);
            }

            return 0;
        }*/
    }
}
