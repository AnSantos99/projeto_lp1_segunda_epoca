using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    /// <summary>
    /// this enum serves the sole purpose of having a different char available
    /// for each item present in the map for ease of printing
    /// </summary>
    internal enum Chars
    {
        player = 'c',
        enemy = 'e',
        empty = '~',
        path = '.',
        trap = 't',
        map = 'm',
        exit = 'E',
        food = 'f',
        weapon = 'w'

    }
}