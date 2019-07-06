using System;

namespace lp1_projetoFinal
{
    internal class MainMenu
    {
        public void Menu()
        {
            Console.Clear();
            GameLoop loop = new GameLoop();

            GameScoreFiles score = null;

            PrintText menuInfo = new PrintText();

            menuInfo.MenuText();

            ConsoleKey answer;
            answer = Console.ReadKey().Key;
            Console.WriteLine();

            switch (answer) {
                case ConsoleKey.A:
                 //   loop.Loop();
                    break;

                case ConsoleKey.B:
                    Console.WriteLine();
                    menuInfo.ScoreText();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return");
                    Console.ReadKey();
                    Menu();
                    break;

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

                case ConsoleKey.D:
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