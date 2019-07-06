using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class RandomGenerator
    {

        internal RandomGenerator()
        {


        }

        internal Position RandomPosition(int rows, int cols)
        {
            Random random = new Random();

            int aux = random.Next(0, cols);

            int aux2 = random.Next(0, rows);

            Position newPosition = new Position(aux2, aux);

            return newPosition;

        }
/*
        internal int RandomPosition(CurrentMapObjects exit)
        {
            Random random = new Random();

            exit = random.Next(0, RowSize);

            int playerStart = random.Next(0, RowSize);

            cells[RowSize - 1, exit] = new BoardCells((char)Chars.empty);

            exitPosition = new Position(RowSize - 1, exit);

            mapPosition = new Position(2, 2);

            cells[player.position.Row, player.position.Col] = new BoardCells(player.name);

            return newPosition;

        }

        internal Position RandomPosition(List<CurrentMapObjects> list)
        {
            foreach (CurrentMapObjects item in list)
            {
                return itemPosition;

                return newPosition;
            }
        }

    */

    }
}
