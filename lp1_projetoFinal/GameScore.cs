using System;
using System.Collections.Generic;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScore
    {
        // Name and score properties
        public double Score { get; set; }
        public string Name { get; set; }

        // List of type gamescore to store scores
        internal List<GameScore> scoreList = new List<GameScore>();
        int count = 0;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public GameScore(){}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
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
            //scoreList.Capacity = MAXSIZE;

            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            // Append text to the file content
            StreamWriter fileContent = File.AppendText(FILENAME);

            scoreList.Add(score);

            // Add scores to scorelist
            foreach (GameScore scoreo in scoreList)
            {
                fileContent.WriteLine($"{scoreo.Name} = {scoreo.Score}");
            }
            fileContent.Close();
        }


        /// <summary>
        /// Function to read file created with specific game dimensions name
        /// and print out its content.
        /// </summary>
        public void LoadScoreFromFile(GameScore score)
        {
            //scoreList.Capacity = MAXSIZE;

            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            using (StreamReader file = new StreamReader(FILENAME))
            { 
                string reader;
                while ((reader = file.ReadLine()) != null)
                {
                    Console.WriteLine(reader);
                }
                file.Close();
            }
        }
    }
}
