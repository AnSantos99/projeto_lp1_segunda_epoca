using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class ConditionsChecker
    {
        /// <summary>
        /// Check for invalid user inputs
        /// </summary>
        /// <param name="row"> check the row key input</param>
        /// <param name="col"> check the col key input</param>
        public static void CheckUserINvalidArgs(string row, string col)
        {
            // If user input is smaller or equal to 0
            if (row.Length <= 0)
                Console.WriteLine("No input detected"); Environment.Exit(0);

            if (col.Length <= 0)
                Console.WriteLine("No input detected"); Environment.Exit(0);

            // If user input is not equal to the wished arguments
            if (row != "-r")
                Console.WriteLine("Invalid input"); Environment.Exit(0);

            if (col != "-c")
                Console.WriteLine("-c"); Environment.Exit(0);

            // If user key input is bigger than 2 
            if (row.Length > 2 && col.Length > 2)
                Console.WriteLine("Invalid input"); Environment.Exit(0);
        }


        /// <summary>
        /// Check user valid arguments
        /// </summary>
        /// <param name="row"> Get row</param>
        /// <param name="col"> Get column</param>
        public static void CheckValidUserArgs(string row, string col)
        {
            GameBoard drawBoard = new GameBoard();
            
            if (row == "-r" && col == "-c")
            {
                
            }
        }


        // --------------------------TEMPORARY-------------------------------//

        /*
        //Console.WriteLine("Please choose your own Game Board size");

        // Get key pairs
        string row = Convert.ToString(args[0]);
        string col = Convert.ToString(args[2]);

        // Get value
        uint rowArgNum = Convert.ToUInt32(args[1]);
        uint colArgNum = Convert.ToUInt32(args[3]);

            // Save it to dic
           // Dictionary<string, uint> getUserArgsDic = new Dictionary<string, uint>();

            //ConditionsChecker.CheckUserINvalidArgs(row, col);
            //ConditionsChecker.CheckValidUserArgs(row, col);

            //getUserArgsDic.Add(row, rowArgNum);
            //getUserArgsDic.Add(col, colArgNum);

            for (int i = 0; i<rowArgNum; i++)
            {
                Console.WriteLine("HHHHHHH");
            }

            for (int j = 0; j<colArgNum; j++)
            {
                Console.WriteLine("EEEEEEE");
            }

        */

        
    }
}
