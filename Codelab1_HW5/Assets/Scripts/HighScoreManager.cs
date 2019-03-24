using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScoreManager : MonoBehaviour
{
    public List<string> HighScoreNames; //declare the string of names-> create a list of names that get high scores
    public List<int> HighScores; //declare the string for high scores->record a list of highscores throughout the game
    
    // Start is called before the first frame update
    void Start()
    {
        string filePath = Application.dataPath + "/highScore.txt";
        if (!File.Exists(filePath))
        {
            string output = "";
            for (int i = 0; i < 5; i++)
            {
                output +="Mary:" +(10-i) +\n';
            }

            Debug.Log("output: " + output);
            File.WriteAllText(filePath, output);
        }

        HighScoreNames = new List<string>();
        HighScores = new List<string>();

        string[] inputLines = File.ReadAllLines(filePath);
        for (int i = 0; i < inputLines.Lenght; i++)
        {
            string line = inputLines[i];
            string[] splitLine = line.Split(':');
            string name = splitLine[0];
            int score = Int32.Parse(splitLine[1]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
