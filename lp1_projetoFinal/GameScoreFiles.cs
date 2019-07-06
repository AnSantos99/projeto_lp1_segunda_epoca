using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScoreFiles
    {
        // declare variables
        int score;
        string fileName;

        // initiate player and position
        Player player;
        Position position;
        GameBoard board;
        PrintText scoreText;


        /// <summary>
        /// Get player score according to enemies killed and level difficulty
        /// If player reaches level exit or if player dies
        /// </summary>
        /// <returns> return current score </returns>
        public int GetScore()
        {
            score = 1;
            /*
            if (board.cells[board.player.position.Row, board.player.position.Col] == 
                board.cells[board.exit.Position.Row, board.exit.Position.Col] ||
                player.health == 0)
            {
                //score = (1 + 0.4 * gameDifficulty) * (level + 0.1 * enemiesKilledInGame); ----> Formula do stor)
                score++;
            }*/
            return score;  
        }
        

        /// <summary>
        /// Get results to show on score Page and save it to scoreList on stack
        /// </summary>
        public void ShowScoreOnPage()
        {
            Stack<int> scoreList = new Stack<int>();
            //scoreList.Push(GetScore());

            foreach (int element in scoreList)
            {
                scoreList.Push(score);
            }
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"Place {i}= {scoreList}");
            }

            SaveScoreOnFile(scoreList);
        }

        public void SaveScoreOnFile(Stack<int> scoreStack)
        {
            int.TryParse(scoreStack);
            fileName = string.Format(@"Score_{0}{1}.txt",GameBoard.RowSize, GameBoard.ColSize);

            File.WriteAllLines(fileName, scoreStack);
        }

        /*
        /// <summary>
        /// Make a new file and save score Stack into it
        /// </summary>
        /// <param name="scoreList"> get score from list</param>
        public void SaveScoreOnFile()
        {
            
            fileName = string.Format(@"Score_{0}x{1}", GameBoard.RowSize, GameBoard.ColSize);

            File.WriteAllLines(fileName, );
        }*/


        /// <summary>
        /// Read the score file
        /// </summary>
        public void LoadScoreFromFile()
        {
            List<string> scoreFiles = new List<string>();

            string answer = Console.ReadLine();

            foreach (int file in answer)
            {
                
            }
            
            File.ReadAllLines(fileName);
        }
    }
}

