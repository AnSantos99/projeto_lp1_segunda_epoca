using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScoreFiles
    {
        //string fileName = string.Format(@"Score_{0}x{1}.txt", GameBoard.RowSize, GameBoard.ColSize);
        const string FILENAME = "Highscores.txt";
        string newFile = string.Format("Highscores_{0}x{1}.txt", GameBoard.RowSize, GameBoard.ColSize);
        StreamWriter fileContent = new StreamWriter(FILENAME);
        
        // List for score
        List<GameScore> scoreList = new List<GameScore>();

        Player player;
        int score;
        GameScore sc;

        /// <summary>
        /// Get player score according to enemies killed and level difficulty
        /// and get score 
        /// </summary>
        /// <returns> return current score </returns>
        public int GetScore()
        {
            score= 0;
            if (player.health == 0) score++;

            //scoreList.Add(score);

            return score;  
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
            string textTest = "Hello";
            string frs = sc.Frase = "Hi";
            int scr = sc.Score = 100;

            scoreList.Add();

            if (File.Exists(FILENAME))
            {
                File.Create(newFile);
                fileContent.WriteLine(textTest, scoreList[1]);
            }

            fileContent.Close();



            /*
            foreach (GameScore score in scoreList)
            {
                fileContent.WriteLine(textTest + score.Score);
                File.Delete(FILENAME);
            }*/

            //File.WriteAllLines(fileName);
        }

        /// <summary>
        /// Read The current file
        /// </summary>
        public void LoadScoreFromFile()
        {
            SaveScoreOnFile();

            using (StreamReader file = new StreamReader(newFile))
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

