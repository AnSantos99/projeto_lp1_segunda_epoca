using System;
using System.Collections.Generic;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScore
    {
        // Variables
        const char SEPARATOR = '\t';
        //int counter = 0;

        // Name and score properties
        public double Score { get; set; }
        public string Name { get; set; }

        internal double maxScore;

        // List of type gamescore to store scores
        internal List<GameScore> scoreList = new List<GameScore>();
        


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
            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            // Append text to the file content
          //  StreamWriter fileContent = new StreamWriter(FILENAME);
            StreamWriter fileContent = File.AppendText(FILENAME);
            
            // Add scores to scorelist
            scoreList.Add(score);
                
            //scoreList.Sort((x, y) => x.Score.CompareTo(y.Score));

            //for (int i = 0; i < scoreList.Count; i++)
            //
    
                fileContent.WriteLine(score.Name + SEPARATOR + score.Score);
            //}

            /*
            foreach (GameScore scoreo in scoreList)
            {
                fileContent.WriteLine(scoreo.Name + SEPARATOR + scoreo.Score);
            }*/

            fileContent.Close(); 
        }






        //StreamWriter fileContent = new StreamWriter(FILENAME);
        /// <summary>
        /// Function to read file created with specific game dimensions name
        /// and print out its content.
        /// </summary>
        public void LoadScoreFromFile(GameScore score)
        { 
            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            StreamReader file = new StreamReader(FILENAME);

            string reader = null;

            while ((reader = file.ReadLine()) != null)
            {
                string[] nameAndScore = reader.Split(SEPARATOR);
                string name = nameAndScore[0];
                double scores = Convert.ToSingle(nameAndScore[1]);

                GameScore newScore = new GameScore(name,scores);
                scoreList.Capacity = 8;

                scoreList.Sort((x, y) => x.Score.CompareTo(y.Score));

                if(scoreList.Count < scoreList.Capacity)
                    scoreList.Add(newScore);

                else 
                {
                    if (newScore.Score > scoreList[0].Score)
                    {
                        scoreList.RemoveAt(0);
                        scoreList.Add(newScore);
                    }
                    
                }


                scoreList.Sort((x, y) => x.Score.CompareTo(y.Score));








                //Console.WriteLine($"Player {name} has a score of {scores}");

                //counter++;
               // scoreList.Clear();
  
            }
            file.Close();
            foreach (GameScore scorerr in scoreList)
                Console.WriteLine($"Player {scorerr.Name} has a score of {scorerr.Score}");
            scoreList.Clear();
        }


        public void HighScores(GameScore score)
        {
            SaveScoreOnFile(score);
            LoadScoreFromFile(score);
        }
    }
}
