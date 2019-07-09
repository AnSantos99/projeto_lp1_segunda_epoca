using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class Position
    {
        internal int Row { set; get; }
        internal int Col { set; get; }

        internal Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        internal static bool IsValidPosition(Position position, int rowNum, int colNum)
        {
            if (position.Row >= 0 && position.Row <= rowNum && position.Col >= 0 && position.Col <= colNum)
                return true;

            return false;
        }
    }
}