using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class GameBoard
    {
        // 
        private const int CELLSIZE = 5;

        static int[] gameBoard;


        /// <summary>
        /// Function to draw board
        /// </summary>
        public void Board()
        {
            // Declare Variables BOARD
                        
            //const string MAPXCOORD = ("      1     2    3    4    5  ");
            const string TOPLINE = "~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~";
            const string SIDELINE = "    |    |    |    |    |    |";
            string[] yCoordLetters = { "A", "B", "C", "D", "E" };

            //Console.WriteLine($"{MAPXCOORD}");

            for (int i = 0; i < CELLSIZE; i++)
            {
                Console.WriteLine($"{TOPLINE}");
                Console.WriteLine("{0}{1}", yCoordLetters[i], SIDELINE);
            }
            Console.WriteLine($"{TOPLINE}");
            // BOARD ----------------------->
        }

    }
}
