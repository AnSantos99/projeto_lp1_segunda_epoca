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
        /// Constructor to set score when needed
        /// </summary>
        /// <param name="score"></param>
        /*
        public GameScoreFiles(int score)
        {
            this.score = score;

        }
        */

        /// <summary>
        /// Get player score according to enemies killed and level difficulty
        /// If player reaches level exit or if player dies
        /// </summary>
        /// <returns> return current score </returns>
        public int GetScore()
        {
            score = 0;

            if (board.cells[player.position.Row, player.position.Col] == board.cells[GameBoard.RowSize - 1, board.exit] ||
                player.health == 0)
            {
                //score = (1 + 0.4 * gameDifficulty) * (level + 0.1 * enemiesKilledInGame); ----> Formula do stor)
                score++;
            }
            return score;
        }

        /// <summary>
        /// Get results to show on score Page
        /// </summary>
        public void ShowScoreOnPage()
        {
            Stack<int> savedScore = new Stack<int>();
            savedScore.Push(GetScore());

            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine($"Place {i}: {savedScore}");
            }
        }

        /// <summary>
        /// Make a new file and save score Stack into it
        /// </summary>
        /// <param name="scoreList"> get score from list</param>
        public void SaveScoreOnFile(Stack<string> scoreList)
        {
            fileName = string.Format(@"GameScore_{0}x{1}", GameBoard.RowSize, GameBoard.ColSize);
            
            File.WriteAllLines(fileName, scoreList);
        }

        /// <summary>
        /// Read the score file
        /// </summary>
        public void LoadScoreFromFile()
        {
            File.ReadAllLines(fileName);
        }
    }
}
