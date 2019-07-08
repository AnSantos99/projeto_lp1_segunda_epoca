using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lp1_projetoFinal
{
    internal class GameScoreFiles
    {
        // To create a new file with name of choosen format
        static string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

        // List to store all player scores
        List<GameScore> scoreList = new List<GameScore>();

        // To store contents into files
        StreamWriter fileContent = new StreamWriter(FILENAME);
        
        // GameScore variable to call class members
        GameScore sc;


        /// <summary>
        /// Function to save scores current file by adding scores from list
        /// </summary>
        public void SaveScoreOnFile()
        {
            string textTest = "Hello";
            int scrTest = 100;

            sc = new GameScore("hi", scrTest);
            scoreList.Add(sc);

            fileContent.WriteLine(textTest + sc.Frase + sc.Score);
            fileContent.Close();
        }


        /// <summary>
        /// Function to read file created with specific game dimensions name
        /// and print out its content.
        /// </summary>
        public void LoadScoreFromFile()
        {
            // Call function to create file
            SaveScoreOnFile();

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

