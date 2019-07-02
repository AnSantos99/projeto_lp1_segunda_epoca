using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class Player : IHealthPoints, IItems
    {
<<<<<<< HEAD
        double health = 100;

       
=======
        internal char name;

        internal Player(char name)
        {
            this.name = name;
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

>>>>>>> upstream/master
        public void Health()
        {
            
        }

        public void Weight()
        {
            throw new NotImplementedException();
        }
    }
}
