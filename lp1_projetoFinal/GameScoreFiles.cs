using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScoreFiles
    {
        // Original file name
        const string FILENAME = "Highscores.txt";

        // To create a new file with name of choosen format
        string newFile = string.Format("Highscores_{0}x{1}.txt", GameBoard.RowSize, GameBoard.ColSize);

        // To store file contents
        StreamWriter fileContent = new StreamWriter(FILENAME);
        
        // List to store all scores
        List<GameScore> scoreList = new List<GameScore>();

        
        //Player player;
        
        // GameScore variable to call class members
        GameScore sc;

        /*
        /// <summary>
        /// Get player score according to enemies killed and level difficulty
        /// and get score 
        /// </summary>
        /// <returns> return current score </returns>
        public int GetScore()
        {
            int score;
            score= 0;
            if (player.health == 0) score++;
            return score;  
        }*/


        /// <summary>
        /// Function to save scores on file
        /// </summary>
        public void SaveScoreOnFile()
        {
            string textTest = "Hello";
            int scrTest = 100;

            sc = new GameScore("hi", scrTest);
            scoreList.Add(sc);

            if (File.Exists(FILENAME))
            {
                //File.Create(newFile);
                fileContent.WriteLine(textTest + sc.Frase + sc.Score);
            }
            fileContent.Close();
        }


        /// <summary>
        /// Read The current file
        /// </summary>
        public void LoadScoreFromFile()
        {
            SaveScoreOnFile();

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

