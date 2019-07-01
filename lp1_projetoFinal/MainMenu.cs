using System;

namespace lp1_projetoFinal
{
    class MainMenu
    {
        public void Menu()
        {
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
                    Console.WriteLine("game");
                    Console.WriteLine();
                    break;

                case "b":
                    Console.WriteLine("scores");
                    Console.WriteLine();
                    break;

                case "c":
                    Console.WriteLine("Game developed by:");
                    Console.WriteLine();
                    Console.WriteLine("Ana dos Santos - a21801899");
                    Console.WriteLine("Diana Levay - a21801515");
                    Console.WriteLine();
                    break;

                case "d":
                    Console.WriteLine("Thank you for playing!");
                    Environment.Exit(0);
                    break;
            }
        }
    }

}