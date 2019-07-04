using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class Levels
    {
        
        internal int Current { get;  set; }
        internal int Diff { get;  set; }

        internal Levels(int current, int diff)
        {
            Current = current;
            Diff = diff;
        }

        internal void Setup()
        {

        }

    }
}
