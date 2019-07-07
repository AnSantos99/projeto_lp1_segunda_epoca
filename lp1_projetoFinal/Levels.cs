using System.Collections.Generic;

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

        internal void Setup(GameBoard board, Player player, List<CurrentMapObjects> items)
        {
            /*
            board = new GameBoard();
            player = new Player(name, 100, position);
            items = new List<CurrentMapObjects>();
            */
        }

    }
}
