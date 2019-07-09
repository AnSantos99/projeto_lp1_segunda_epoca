using System;
using System.Collections.Generic;

namespace lp1_projetoFinal
{
    internal class GameLoop
    {

        // counter to raise the level each time 
        internal int lvlCount = 1;

        internal Random rnd = new Random();

        internal static GameBoard board = new GameBoard();

        internal char key;

        internal GameScore score;

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
                    List<CurrentMapObjects> lookAroundItems = new List<CurrentMapObjects>();

                    foreach (CurrentMapObjects item in board.itemList)
                    {
                        board.player.Surroundings(lookAroundItems, item, board);
                    }

                    gameInfo.LookAroundText(lookAroundItems);
    
                    lookAroundItems.Clear();
                }
                
                if (answer == ConsoleKey.S && Position.IsValidPosition((new Position((board.player.Position.Row + 1), (board.player.Position.Col))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'S';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.W && Position.IsValidPosition((new Position((board.player.Position.Row - 1), (board.player.Position.Col))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'W';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.A && Position.IsValidPosition((new Position((board.player.Position.Row), (board.player.Position.Col - 1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {

                    key = 'A';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.D && Position.IsValidPosition((new Position((board.player.Position.Row), (board.player.Position.Col + 1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'D';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.Q && Position.IsValidPosition((new Position((board.player.Position.Row - 1), (board.player.Position.Col -1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'Q';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col--;
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.E && Position.IsValidPosition((new Position((board.player.Position.Row - 1), (board.player.Position.Col + 1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'E';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col++;
                    board.player.Position.Row--;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.Z && Position.IsValidPosition((new Position((board.player.Position.Row + 1), (board.player.Position.Col - 1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'Z';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col--;
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }

                if (answer == ConsoleKey.X && Position.IsValidPosition((new Position((board.player.Position.Row + 1), (board.player.Position.Col + 1))), (GameBoard.RowSize - 1), (GameBoard.ColSize - 1)))
                {
                    key = 'X';
                    board.player.HealthChange(-1);
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)Chars.path,true);
                    board.player.Position.Col++;
                    board.player.Position.Row++;
                    board.cells[board.player.Position.Row, board.player.Position.Col] = new BoardCells((char)board.player.name,false);
                }
               
                if (answer == ConsoleKey.D2)
                {
                    key = 'P';

                    int index = 0;

                    if (board.map.FallenInto(board.player))
                    {
                        board.itemList.Remove(board.map);
                        foreach (CurrentMapObjects items in board.itemList)
                            board.cells[items.Position.Row, items.Position.Col] = new BoardCells((char)items.Name, false);
                    }

                    foreach (Items item in board.pickItems)
                    {
                        if (item.FallenInto(board.player))
                        {
                            board.inventory.AddToInventory(new Items(item.Position, item.Name, item.Info, item.Weight, item.Effect, index));
                            index++;
                            key = 'D';

                        }
                    }
                   
                }
               

                if (answer == ConsoleKey.D3)
                 {
                    board.inventory.WriteInfo(board.player, 'p');
                 }

                if (answer == ConsoleKey.D4)
                {
                    board.inventory.WriteInfo(board.player, 'd');
                }

                if (answer == ConsoleKey.D1)
                    gameInfo.EnemyAttackText();
                if (answer == ConsoleKey.D6)
                    gameInfo.HelpText(board.traps, board.inventory, board.player);

                if (answer == ConsoleKey.D8)
                {
                    Console.Clear();
                    
                    Console.WriteLine("are you sure you wish to quit? y/n");
                    ConsoleKey quit = Console.ReadKey().Key;


                    if (quit == ConsoleKey.Y)
                    {  //insert score stuff
                        Console.WriteLine("thank you for playing!");
                        board.player.Health = 0;
                    }
                }
         

                foreach (Trap trap in board.traps)
                {
                    if (trap.FallenInto(board.player))
                    {
                        board.player.HealthChange(-rnd.Next(trap.DamageLevel, trap.MaxDamage));
                        key = 'D';
                        trap.Active = false;
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
            while (board.player.Health > 0);

            Console.WriteLine("please input your name for the score");
            string name = Console.ReadLine();
            score = new GameScore(name, newLevel.ScoreSetter(lvlCount));
            score.SaveScoreOnFile(score);
            Environment.Exit(0);
    
        }
    }

}