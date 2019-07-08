using System;

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
        
        // define player's health so we can manipulate it
        internal int health;

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
            this.health = health;
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
        public int Health(int healthChange)
        {
            health += healthChange;
            return health;
        }

        public void Weight()
        {
            throw new NotImplementedException();
        }
    }
}
