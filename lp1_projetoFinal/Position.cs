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
    }
}