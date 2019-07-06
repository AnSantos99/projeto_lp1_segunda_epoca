using System;

namespace lp1_projetoFinal
{
    internal class GameLoop
    {

        internal int lvlCount = 0;

        internal int chosenDiff = 2;

        internal static GameBoard board = new GameBoard();


        // initiate the main menu class
        internal MainMenu menu = new MainMenu();

        // start of game is set to false until menu start toggles it to be true
        private bool start = false;

        internal Levels newLevel;

        /// <summary>
        /// this method contains the main loop cycle for the game, showing the
        /// start menu and registering player input for each action every turn,
        /// finishing whenever someone wins, loses or quits
        /// it returns nothing
        /// </summary>
        public void Loop()
        {

            newLevel = new Levels(lvlCount, chosenDiff);
            // initialise the PrintText class so different texts can be printed
            PrintText gameInfo = new PrintText();

            // only show the menu and create board at startup
            if (!start)
            {
                menu.Menu();

                board.DefineBoard();

            }
            

            // set start to true to hide menu and set the board
            start = true;

            // for reading the player's input
            ConsoleKey answer;

            do
            {
                // render the board anew each time the cycle loops    
                board.RenderBoard(newLevel);

                // showcase player's current stats through level progression
                gameInfo.GameText(board.player);

                // read user's single key input
                answer = Console.ReadKey().Key;

                // clear console for ease of view
                Console.Clear();

                // check the answer given by the player
                // BELOW ALL PLACEHOLDER MAYBE NOT USE IF

                if (answer == ConsoleKey.D5)
                {
                    foreach (CurrentMapObjects item in board.itemList)
                    {
                        if (board.cells[board.player.position.Row - 1, board.player.position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row + 1, board.player.position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row, board.player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row, board.player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row - 1, board.player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row + 1, board.player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row - 1, board.player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.position.Row + 1, board.player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col])

                        {
                            board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
                        }
                        }
                }

                
                if (answer == ConsoleKey.S)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Row++;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.W)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Row--;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.A)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col--;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.D)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col++;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.Q)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col--;
                    board.player.position.Row--;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.E)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col++;
                    board.player.position.Row--;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.Z)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col--;
                    board.player.position.Row++;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.X)
                {
                    board.player.Health(-1);
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.path);
                    board.player.position.Col++;
                    board.player.position.Row++;
                    board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)board.player.name);
                }


                if (answer == ConsoleKey.D2 || answer == ConsoleKey.D3 || answer == ConsoleKey.D4)
                 {
                    foreach (CurrentMapObjects item in board.itemList)
                    {
                        if (board.cells[board.player.position.Row, board.player.position.Col] == board.cells[item.Position.Row, item.Position.Col])

                        {
                            foreach (CurrentMapObjects items in board.itemList)
                            {

                                board.cells[items.Position.Row, items.Position.Col] = new BoardCells((char)items.Name);
                                board.cells[board.player.position.Row, board.player.position.Col] = new BoardCells((char)Chars.player);

                            }

                        }
                    }
                       
                 }
                //gameInfo.InventoryText();
                if (answer == ConsoleKey.D1)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.D6)
                    gameInfo.HelpText(board.traps);

                // NOT WORKING SEE WHY
          
                foreach(Trap trap in board.traps)
                {
                    if (trap.FallenInto(board.player))
                    {
                        board.player.Health(-2);
                    }
                 }
                 
                
                if (board.cells[board.player.position.Row, board.player.position.Col] == board.cells[board.exit.Position.Row, board.exit.Position.Col])
                {
                    Console.WriteLine("Congratulations! you've reached the exit!");
                    Console.WriteLine("Press any key to continue to the next level");
                    Console.ReadKey();
                    Console.Clear();
                    start = true;
                    board.DefineBoard();
                    lvlCount++;
                    Loop();
            
                }
            }

            // run the loop while the player hasn't won, lost or quit
            while (answer != ConsoleKey.D8 && board.player.health > 0);

            Console.WriteLine("Too bad!!you lost the game!");
            Environment.Exit(0);
    
        }
    }

}