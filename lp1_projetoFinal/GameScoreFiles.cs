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
        string fileName = string.Format(@"Score_{0}x{1}.txt", GameBoard.RowSize, GameBoard.ColSize);

        // initiate player and position
        //Stack<string> scoreList;

        Player player;
        Position position;
        GameBoard board;
        PrintText scoreText;
        Levels currentLevel;
        Enemy enemiesKilled;

        public int Score { get; set; }


        /// <summary>
        /// Get player score according to enemies killed and level difficulty
        /// and get score 
        /// </summary>
        /// <returns> return current score </returns>
        public int GetScore()
        {
            Score = 0;
            if (player.health == 0) Score++;
            return Score;  
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        public void SaveScoreToStack()
        {
            scoreList.Push(Convert.ToString(Score));
        }*/


        /// <summary>
        /// Prints out the Score on score menu
        /// </summary>
        public void SaveScoreOnFile()
        {
            GetScore();
            

            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"Place {i} = {Score}");
            }

            //File.WriteAllLines(fileName);
        }



        /// <summary>
        /// Read the score file
        /// </summary>
        public void LoadScoreFromFile()
        {
            SaveScoreOnFile();

            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    //List<string> scoreFiles = new List<string>();
                    //File.ReadAllLines(fileName);
                }
            }
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



    }
}

