using System;

namespace lp1_projetoFinal
{
    class MainMenu
    {
        public void Menu()
        {
            GameLoop loop = new GameLoop();
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine();
            Console.WriteLine("please select an option:");
            Console.WriteLine("A. New Game");
            Console.WriteLine("B. High Scores");
            Console.WriteLine("C. Credits");
            Console.WriteLine("D. Quit");
            Console.WriteLine();

            string answer = Console.ReadLine().ToLower();

            switch (answer) {
                case "a":
                    loop.Loop();
                    break;

                case "b":
                    Console.WriteLine("scores");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;

                case "c":
                    Console.WriteLine("Game developed by:");
                    Console.WriteLine();
                    Console.WriteLine("Ana dos Santos - a21801899");
                    Console.WriteLine("Diana Levay - a21801515");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;

                case "d":
                    Console.WriteLine("Thank you for playing!");
                    Environment.Exit(0);
                    break;

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