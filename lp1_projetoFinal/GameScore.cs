using System;
using System.Collections.Generic;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScore
    {
        public double Score { get; set; }
        public string Name { get; set; }

        /*
        // To create a new file with name of choosen format
        static string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

        // List to store all player scores
        internal List<GameScore> scoreList = new List<GameScore>();

        // To store contents into files
        StreamWriter fileContent = new StreamWriter(FILENAME);


        StreamReader file = new StreamReader(FILENAME);
        */

        internal List<GameScore> scoreList = new List<GameScore>();

        public GameScore()
        {

        }

        public GameScore(string name, double score)
        {
            Name = name;
            Score = score;
        }


        /// <summary>
        /// Function to save scores current file by adding scores from list
        /// </summary>
        public void SaveScoreOnFile(GameScore score)
        {
            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            StreamWriter fileContent = new StreamWriter(FILENAME);
            scoreList.Add(score);

            foreach(GameScore scoreo in scoreList)
            {
                fileContent.WriteLine(scoreo.Name + scoreo.Score);
            }
            
            fileContent.Close();
        }

        /// <summary>
        /// Function to read file created with specific game dimensions name
        /// and print out its content.
        /// </summary>
        public void LoadScoreFromFile(GameScore score)
        { 

            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            using (StreamReader file = new StreamReader(FILENAME))
            {
                string reader;
                while ((reader = file.ReadLine()) != null)
                {
                    // Check if file exists and read every line of it
                    if (File.Exists(FILENAME)) Console.WriteLine(reader);
                }

                file.Close();
            }

        }
    }
}
