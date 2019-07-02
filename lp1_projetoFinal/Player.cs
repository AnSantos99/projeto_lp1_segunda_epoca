using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class Player : IHealthPoints, IItems
    {
        internal char name;
        internal int health;
        //internal Position position;

        internal Player(char name, int health /*Position position*/)
        {
            this.name = name;
            this.health = health;
           // this.position = position;
        }

        internal static Position GetPosition(GameBoard board)
        {
            string position = Console.ReadLine();

            position = position.ToLower();

            Position targetCoordinate = PositionForNumber(position);

            return targetCoordinate;
        }

        private static Position PositionForNumber(string position)
        {
            switch(position)
            {
                case "a1": return new Position(0, 0);
                default: return null;
            }
        }

        public void Health()
        {
            throw new NotImplementedException();
        }

        public void Weight()
        {
            throw new NotImplementedException();
        }
    }
}
