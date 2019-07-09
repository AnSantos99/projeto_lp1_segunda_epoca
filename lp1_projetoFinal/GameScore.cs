﻿using System;
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

        
        public GameScore(){}

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
            StreamWriter fileContent = File.AppendText(FILENAME);

            // Add scores to scorelist
            scoreList.Add(score);
<<<<<<< HEAD
            
            // For every score  wirte the name and the score
            foreach (GameScore scoreo in scoreList)
=======

            foreach(GameScore scoreo in scoreList)
>>>>>>> upstream/master
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
            string FILENAME = string.Format("Highscores_{0}x{1}.txt",
            GameBoard.RowSize, GameBoard.ColSize);

            using (StreamReader file = new StreamReader(FILENAME, true))
            { 
                string reader;
                while ((reader = file.ReadLine()) != null)
                {
                    //File.AppendAllTextAsync(FILENAME, reader);
                    // Check if file exists and read every line of it
                    Console.WriteLine(reader);
                }
                file.Close();
            }
        }
    }
}
