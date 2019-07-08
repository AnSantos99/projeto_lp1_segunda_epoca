using System;

namespace lp1_projetoFinal
{
    internal class GameLoop
    {

        // counter to raise the level each time 
        internal int lvlCount = 1;

        internal static GameBoard board = new GameBoard();

        internal char key;

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
        public void Loop(int chosenDiff)
        {

            newLevel = new Levels(lvlCount, chosenDiff*lvlCount);
            // initialise the PrintText class so different texts can be printed
            PrintText gameInfo = new PrintText();

            // only show the menu and create board at startup
            if (!start)
            {
                menu.Menu();

                board.DefineBoard(newLevel);

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
                gameInfo.GameText(newLevel, board.player, board.inventory, key);

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
                        if (board.cells[board.player.Position.Row, board.player.Position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                            board.cells[board.player.Position.Row - 1, board.player.Position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row + 1, board.player.Position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row, board.player.Position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row, board.player.Position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row - 1, board.player.Position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row + 1, board.player.Position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row - 1, board.player.Position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[board.player.Position.Row + 1, board.player.Position.Col - 1] == board.cells[item.Position.Row, item.Position.Col])


                        {
                            board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
                        }
                        }
                }

                
                if (answer == ConsoleKey.S)
                {
                    key = 'S';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.W)
                {
                    key = 'W';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.A)
                {

                    key = 'A';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.D)
                {
                    key = 'D';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.Q)
                {
                    key = 'Q';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col--;
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.E)
                {
                    key = 'E';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col++;
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.Z)
                {
                    key = 'Z';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col--;
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }

                if (answer == ConsoleKey.X)
                {
                    key = 'X';
                    board.player.Health(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path);
                    board.player.Position.Col++;
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name);
                }
               
                // NOT WORKING SEE WHY
                if (answer == ConsoleKey.D2)
                {
                    foreach (Items item in board.pickItems)
                    {
                        if (board.cells[board.player.Position.Row, board.player.Position.Col] == board.cells[item.Position.Row, item.Position.Col])

                        {

                            board.inventory.AddToInventory(item);
                            board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
                        }
                    }
                }
               

                if (answer == ConsoleKey.D3 || answer == ConsoleKey.D4)
                 {

                    gameInfo.InventoryText(board.player.Inventory.itemsInInventory);

                    foreach (CurrentMapObjects item in board.itemList)
                    {
                        if (board.cells[board.player.Position.Row, board.player.Position.Col] == board.cells[item.Position.Row, item.Position.Col])

                        {
                            foreach (CurrentMapObjects items in board.itemList)
                            {

                                board.cells[items.Position.Row, items.Position.Col] = new BoardCells((char)items.Name);
                                board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.player);

                            }
     
                        }
                    }
                       
                 }
                
                if (answer == ConsoleKey.D1)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.D6)
                    gameInfo.HelpText(board.traps, board.inventory);

                if (answer == ConsoleKey.D8)
                {
                    Console.Clear();
                    
                    Console.WriteLine("are you sure you wish to quit? y/n");
                    ConsoleKey quit = Console.ReadKey().Key;


                    if (quit == ConsoleKey.Y)
                    {  //insert score stuff
                        Console.WriteLine("thank you for playing!");
                        board.player.health = 0;

       
                    }
                }
                


                foreach (Trap trap in board.traps)
                {
                    if (trap.FallenInto(board.player))
                    {
                        board.player.Health(-trap.DamageLevel);
                        key = 'D';
                    }
                 }
                 
                
                if (board.cells[board.player.Position.Row, board.player.Position.Col] == board.cells[board.exit.Position.Row, board.exit.Position.Col])
                {
                    Console.WriteLine("Congratulations! you've reached the exit!");              
                    Console.WriteLine("Press any key to continue to the next level");
                    Console.ReadKey();
                    Console.Clear();
                    start = true;
                    board.ResetBoard();
                    board.DefineBoard(newLevel);
                    lvlCount++;
                    Loop(chosenDiff);
            
                }
            }

            // run the loop while the player hasn't won, lost or quit
            while (board.player.health > 0);


            GameScoreFiles score = new GameScoreFiles();
            score.SaveScoreOnFile();
            Environment.Exit(0);
    
        }
    }

}