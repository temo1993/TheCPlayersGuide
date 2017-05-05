using System;
using System.IO;

namespace TheCPlayersGuide
{
    public class ReadWriteTest
    {
        public static void Main_(string[] args)
        {
            // Write text in a file all at once
            string informationToWrite = "Hello persistent file storage world!";
            File.WriteAllText("../../files/Here.txt", informationToWrite);


            // Write text in a file line by line from array
            string[] arrayOfInformation = new string[2];
            arrayOfInformation[0] = "This is line 1";
            arrayOfInformation[1] = "This is line 2";
            File.WriteAllLines("../../files/Here2.txt", arrayOfInformation);

            // Read text from a file line by line and save in array
            string fileContents = File.ReadAllText("../../files/Here.txt");
            string[] fileContentsByLine = File.ReadAllLines("../../files/Here2.txt");
            Console.WriteLine(fileContents);
            foreach (var s in fileContentsByLine)
            {
                Console.Write(s);
                Console.WriteLine();
            }
            Console.WriteLine();


            // Creating an new object that will read file(.csv) and save its data in properties (Name,Score)
            HighScore highScoreTest = new HighScore();
            var loadHighScores = highScoreTest.LoadHighScores("../../files/highScores.csv");
            foreach (var loadHighScore in loadHighScores)
            {
                Console.WriteLine(loadHighScore.Name + ": " + loadHighScore.Score);
            }
            Console.WriteLine();
        }
        
    }

    public class HighScore
    {
        public string Name { get; set; }
        public int Score { get; set; }


        // Saving highScores array data in .csv file
        public void SaveHighScores(HighScore[] highScores)
        {
            string allHighScoresText = "";
            foreach (HighScore score in highScores) allHighScoresText += $"{score.Name},{score.Score}\n";
            // string interpolation again.

            File.WriteAllText("../../files/highScores.csv", allHighScoresText);
        }


        // Reading from .csv file and returning data to fill in properties
        public HighScore[] LoadHighScores(string fileName)
        {
            string[] highScoresText = File.ReadAllLines(fileName);
            HighScore[] highScores = new HighScore[highScoresText.Length];
            for (int index = 0; index < highScoresText.Length; index++)
            {
                string[] tokens = highScoresText[index].Split(',');
                string name = tokens[0];
                int score = Convert.ToInt32(tokens[1]);
                highScores[index] = new HighScore() { Name = name, Score = score };
            }
            return highScores;
        }
    }
}