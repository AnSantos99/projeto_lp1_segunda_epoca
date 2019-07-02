using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class GameBoard
    {

        // public  int ColSize { get; set; }
        //public  int RowSize { get; set; }  

        internal static int RowSize = 9;
        internal static int ColSize = 6;

        internal BoardCells[,] cells = new BoardCells[RowSize, ColSize];
    
            public void DefineBoard()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    cells[i, j] = new BoardCells((char)Chars.empty);
                }
            }

            // Declare Variables BOARD

            Random random = new Random();

            int exit = random.Next(1, 5);

            int playerStart = random.Next(1, 5);

            cells[0, exit] = new BoardCells((char)Chars.exit);

            cells[8, playerStart] = new BoardCells((char)Chars.player);
        }

        public void RenderBoard()
        {

            // print the top row
            Console.Write($"   ");
            for (uint i = 0; i < ColSize; i++) Console.Write($"_[{i}]_|");

            Console.WriteLine();

            // begin cycle to set all the rows right
            for (uint y = 0; y < RowSize; y++)
            {
                Console.Write("  |");
                for (uint x = 0; x < ColSize; x++)
                {    
                    Console.Write("     |");
                }

                Console.WriteLine();
                Console.Write($"[{y + 1}] ");

                // check if there are pieces and place them
                for (uint x = 0; x < ColSize; x++)
                {
                    Console.Write("  ");
                    cells[y,x].Render();
                    Console.Write(" | ");
                }

                // new line to render bottom of row
                Console.WriteLine();
                Console.Write("  |");
                for (uint x = 0; x < ColSize; x++)
                {
                    Console.Write("__ __|");
                }
                Console.WriteLine();

            }

 
        }

        internal BoardCells GetBoardCells(Position position)
        {
            return cells[position.Row, position.Col];
        }

        

    }
}