using System;
using System.Text;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class GameLoop
    {
        /// create a new gameboard for this level
        internal static GameBoard board = new GameBoard();

        internal List<CurrentMapObjects> itemList = new List<CurrentMapObjects>();

        internal CurrentMapObjects map;

        CurrentMapObjects objects;

        // initiate a new player for the level with max HP

        Player player;

        Position playerPosition;

        Position itemPosition;

        // initiate the main menu class
        internal MainMenu menu = new MainMenu();

        // start of game is set to false until menu start toggles it to be true
        private bool start = false;

        // initiate the player score
        internal GameScoreFiles score;
       
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
            if (!start)
            {
                menu.Menu();

                Random random = new Random();

                int playerStart = random.Next(1, 6);

                playerPosition = new Position(0, playerStart);

                player = new Player((char)Chars.player, 100, playerPosition);

                board.DefineBoard(player);

                CurrentMapObjects exit = new CurrentMapObjects(board.exitPosition, Chars.exit);

                 map = new CurrentMapObjects(board.mapPosition, Chars.map);

                itemList.Add(exit);
                itemList.Add(map);

            }

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

                // clear console for ease of view
                Console.Clear();

                // check the answer given by the player
                // BELOW ALL PLACEHOLDER MAYBE NOT USE IF

                if (answer == ConsoleKey.D5)
                {
                    foreach (CurrentMapObjects item in itemList)
                    {
                        if (board.cells[player.position.Row - 1, player.position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row + 1, player.position.Col] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row, player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row, player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row - 1, player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row + 1, player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row - 1, player.position.Col + 1] == board.cells[item.Position.Row, item.Position.Col] ||
                        board.cells[player.position.Row + 1, player.position.Col - 1] == board.cells[item.Position.Row, item.Position.Col])

                       // board.cells[board.exitPosition.Row, board.exitPosition.Col] = new BoardCells((char)Chars.exit);

                        board.cells[item.Position.Row, item.Position.Col] = new BoardCells((char)item.Name);
                    }
                         


                }



                if (answer == ConsoleKey.S)
                {
                    player.Health(-1);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Row++;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.W)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Row--;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.A)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col--;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.D)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col++;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.Q)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col--;
                    player.position.Row--;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.E)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col++;
                    player.position.Row--;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.Z)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col--;
                    player.position.Row++;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }

                if (answer == ConsoleKey.X)
                {
                    player.Health(-2);
                    board.cells[player.position.Row, player.position.Col] = new BoardCells((char)Chars.path);
                    player.position.Col++;
                    player.position.Row++;
                    board.cells[player.position.Row, player.position.Col] = new BoardCells(player.name);
                }


                if (answer == ConsoleKey.L)
                    gameInfo.LookAroundText();
                if (answer == ConsoleKey.D2 || answer == ConsoleKey.D3 || answer == ConsoleKey.D4)
                   
                        foreach (CurrentMapObjects item in itemList)
                        {
                            if (board.cells[player.position.Row, player.position.Col] == board.cells[item.Position.Row, item.Position.Col])
                                
                                
                        foreach (CurrentMapObjects items in itemList)
                        {
                                
                                board.cells[items.Position.Row, items.Position.Col] = new BoardCells((char)items.Name);
                                board.cells[playerPosition.Row, playerPosition.Col] = new BoardCells((char)Chars.player);



                            }
                       
                    }
                //gameInfo.InventoryText();
                if (answer == ConsoleKey.D1)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.D6)
                    gameInfo.HelpText();

                if (board.cells[player.position.Row, player.position.Col] == board.cells[GameBoard.RowSize - 1, board.exit])
                {
                    Console.WriteLine("Congratulations! you've reached the exit!");
                    
                    Console.WriteLine("Press any key to continue to the next level");
                    Console.ReadKey();
                    Console.Clear();
                    start = true;
                    board.DefineBoard(player);
                    Loop();
                }
            }
            // run the loop while the player hasn't won, lost or quit
            while (answer != ConsoleKey.D8 && player.health > 0);

            Console.WriteLine("Too bad!!you lost the game!");
            Environment.Exit(0);


        }
    }

}