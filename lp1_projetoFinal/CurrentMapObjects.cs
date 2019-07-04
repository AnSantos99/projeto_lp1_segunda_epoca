using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class CurrentMapObjects
    {
        internal Position Position { set; get; }
        internal Chars Name { set; get; }


        internal CurrentMapObjects(Position position, Chars name)
        {
            Position = position;
            Name = name;

        }

    }
}