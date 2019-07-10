using System;

namespace lp1_projetoFinal
{
    /// <summary>
    /// Class to display the Main Menu of the game.
    /// </summary>
    internal class MainMenu
    {
        /// <summary>
        /// Method to store all information needed for the Main menu.
        /// This method returns nothing
        /// </summary>
        public void Menu()
        {
            // Clear console
            Console.Clear();

            // Creation of instance of gameloop 
            GameLoop loop = new GameLoop();

            // Creation of instance of GameScore
            GameScore score = new GameScore();

            // Creation of instance of PrintText
            PrintText menuInfo = new PrintText();

            // Get the text menu method 
            menuInfo.MenuText();

            // Variable
            ConsoleKey answer;
            answer = Console.ReadKey().Key;
            Console.WriteLine();

            // Depending on user key input switch to the respective case and
            // Perform according to its case body
            switch (answer)
            {
                // Start game
                case ConsoleKey.A:
                 //   loop.Loop();
                    break;

                // Load Score screen
                case ConsoleKey.B:
                    Console.WriteLine();
                    menuInfo.ScoreText();
                    score.LoadScoreFromFile(loop.score);
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;

                // Load credits screen
                case ConsoleKey.C:
                    Console.WriteLine("Game developed by:");
                    Console.WriteLine();
                    Console.WriteLine("Ana dos Santos - a21801899");
                    Console.WriteLine("Diana Levay - a21801515");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;

                // End game
                case ConsoleKey.D:
                    Console.WriteLine("Thank you for playing!");
                    Environment.Exit(0);
                    break;

                // In case other unknown key are typed by the user. Print the
                // message and go back to menu.
                default:
                    Console.WriteLine("Please select one of the letters in the menu!");
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
    }

}