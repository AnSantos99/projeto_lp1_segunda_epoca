using System;
using System.Text;

namespace lp1_projetoFinal
{
    class GameLoop
    {
        /// create a new gameboard for this level
        internal static GameBoard board = new GameBoard();
        // initiate a new player for the level with max HP
        Player player = new Player((char) Chars.player, 100);

        // initiate the main menu class
        internal MainMenu menu = new MainMenu();

        // start of game is set to false until menu start toggles it to be true
        bool start = false;
       
        /// <summary>
        /// this method contains the main loop cycle for the game, showing the
        /// start menu and registering player input for each action every turn,
        /// finishing whenever someone wins, loses or quits
        /// it returns nothing
        /// </summary>
        public void Loop()
        {
            // initialise the PrintText class so different texts can be printed
            PrintText gameInfo = new PrintText();

            // only show the menu and create board at startup
            if (!start) { menu.Menu(); board.DefineBoard(); }

            // set start to true to hide menu and set the board
            start = true;

            // to use unicode characters on the console's output
            Console.OutputEncoding = Encoding.UTF8;

            // for reading the player's input
            ConsoleKey answer;
     
            do
            {       
                // render the board anew each time the cycle loops    
                board.RenderBoard();

                // showcase player's current stats through level progression
                gameInfo.GameText(player);

                // read user's single key input
                answer = Console.ReadKey().Key;

                //PLACEHOLDER FOR CONDITION
                //player.health--;

                // clear console for ease of view
                Console.Clear();

                // check the answer given by the player
                // BELOW ALL PLACEHOLDER MAYBE NOT USE IF
                if (answer == ConsoleKey.DownArrow)
                    player.Health(-2);
                 if (answer == ConsoleKey.L)
                    gameInfo.LookAroundText();
                if (answer == ConsoleKey.E || answer == ConsoleKey.U || answer == ConsoleKey.D)
                    gameInfo.InventoryText();
                if (answer == ConsoleKey.F)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.H)
                    gameInfo.HelpText();
                
            }
            // run the loop while the player hasn't won, lost or quit
            while (answer != ConsoleKey.Q && player.health > 0);
            
        }
    }

}