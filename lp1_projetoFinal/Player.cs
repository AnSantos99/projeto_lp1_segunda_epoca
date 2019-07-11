using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    /// <summary>
    /// this class' purpose is to define and identify our player as well as to 
    /// set and move them on the board
    /// </summary>
    internal class Player
    {
        // define player's name so we can identify them
        internal char name;

        internal int maxHealth = 100;

        // define player's health so we can manipulate it
        internal int Health;

        internal Position Position;

       // internal Weapon selectedWeapon;

        internal Inventory Inventory;
        
        //internal Position position;

        /// <summary>
        /// this constructor's purpose is to allow us to set the player's name
        /// and health points according to need
        /// </summary>
        /// <param name="name">to identify on other parts of code</param>
        /// <param name="health">default to 100</param>
        internal Player(char name, int health, Position position, Inventory inventory)
        {
            this.name = name;
            this.Health = health;
            this.Position = position;
            this.Inventory = inventory;
        }

        internal Player(int score)
        {
            Score = score;
        }

        public int Score { get; set; }

        /// <summary>
        /// this method works to obtain the player's current position and know
        /// what coordinate they can be found in at any needed time
        /// </summary>
        /// <param name="board">obtain current board player is in</param>
        /// <returns>the target coordinate to place player on</returns>
        /*internal static Position GetPosition(GameBoard board)
        {
            string position = Console.ReadLine();

            position = position.ToLower();

            Position targetCoordinate = PositionForNumber(position);

            return targetCoordinate;
        }*/

        /// <summary>
        /// this method receives the player's health and lowers it after each
        /// movement
        /// </summary>
        public int HealthChange(int changeAmount)
        {

            if (Health <= maxHealth)
                Health += changeAmount;

            return Health;
        }

        public void Weight()
        {
            throw new NotImplementedException();
        }

        // Map surroundings 
        internal void Surroundings(List<CurrentMapObjects> nearObjects, CurrentMapObjects item, GameBoard board)
        {

            if (item.Position.Row == this.Position.Row && item.Position.Col == this.Position.Col)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position,item.Name,item.Info, "on your current position:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
  
            }

            if (item.Position.Row == this.Position.Row - 1 && item.Position.Col == this.Position.Col)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "N:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
            }

            if (item.Position.Row == this.Position.Row + 1  && item.Position.Col == this.Position.Col)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "S:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
   
            }

            if (item.Position.Row == this.Position.Row && item.Position.Col == this.Position.Col - 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "W:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
           
            }

            if (item.Position.Row == this.Position.Row && item.Position.Col == this.Position.Col + 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "E:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));

            }

            if (item.Position.Row == this.Position.Row - 1 && item.Position.Col == this.Position.Col - 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "NW:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
     
            }

            if (item.Position.Row == this.Position.Row - 1 && item.Position.Col == this.Position.Col + 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "NE:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));

            }

            if (item.Position.Row == this.Position.Row + 1 && item.Position.Col == this.Position.Col - 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "SW:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));
         
            }

            if (item.Position.Row == this.Position.Row + 1 && item.Position.Col == this.Position.Col + 1)
            {
                nearObjects.Add(new CurrentMapObjects(item.Position, item.Name, item.Info, "SE:"));
                board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name, false, new Position(item.Position.Row, item.Position.Col));

            }


        }
    }
}
