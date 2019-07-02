using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class GameBoard
    {

<<<<<<< HEAD
        static int[] gameBoard;
=======
       // public  int ColSize { get; set; }
        //public  int RowSize { get; set; }
>>>>>>> upstream/master

        static int[,] gameBoard;

    
        /// <summary>
        /// Function to draw board
        /// </summary>
        public void RenderBoard()
        {
            int ColSize = 6;
            int RowSize = 9;

            // Declare Variables BOARD
<<<<<<< HEAD
                        
            //const string MAPXCOORD = ("      1     2    3    4    5  ");
            const string TOPLINE = "~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~";
            const string SIDELINE = "    |    |    |    |    |    |";
            string[] yCoordLetters = { "A", "B", "C", "D", "E" };

            //Console.WriteLine($"{MAPXCOORD}");
=======
            gameBoard = new int[ColSize, RowSize];

            // print the top row
            Console.Write($"   ");
            for (uint i = 0; i < RowSize; i++) Console.Write($"_[{i}]_|");

            Console.WriteLine();
>>>>>>> upstream/master

            // begin cycle to set all the rows right
            for (uint y = 0; y < ColSize; y++)
            {
                Console.Write("  |");
                for (uint x = 0; x < RowSize; x++)
                {
                    
                    Console.Write("     |");
                }

                Console.WriteLine();
                Console.Write($"[{y + 1}] ");

                // check if there are pieces and place them
                for (uint x = 0; x < RowSize; x++)
                {
                    Console.Write("    | ");
                }

                // new line to render bottom of row
                Console.WriteLine();
                Console.Write("  |");
                for (uint x = 0; x < RowSize; x++)
                {

                    Console.Write("__ __|");
                }
                Console.WriteLine();

            }

 
        }

    }
}
