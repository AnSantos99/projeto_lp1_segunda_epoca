using System;

namespace lp1_projetoFinal
{
    internal class RandomGenerator
    {
        
        internal Position RandomPosition(int rows, int cols, char name)
        {
            Random random = new Random();

            int col;
            int row;
/*
            if (name == (char)Chars.exit)
            {
                row = rows;
                col = random.Next(0, cols);
            }

            else if (name == (char)Chars.player)
            {
                row = 0;
                col = random.Next(0, cols);
            }

            else
            {*/
                row = random.Next(0, (rows - 1));
                col = random.Next(0, (cols - 1));

          //  }

            return new Position(row, col);

        }

      

    }
}
