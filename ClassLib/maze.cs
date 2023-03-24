﻿namespace ClassLib
{
    public class Maze
    {
        public static bool endGame;
        public static int score;
        public string[] lines = File.ReadAllLines(@"C:\Users\enoch.whitaker\source\repos\pac-man\pacmanmaze.txt");
        public string[,] ReadMaze()
        {
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;
            string[,] mazeArray = new string[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                string[] values = lines[i].Split(',');
                for (int j = 0; j < numCols; j++)
                {
                    mazeArray[i, j] = values[j];
                }
            }
            return mazeArray;
        }
        public string DrawMaze(string[,] mazeArray)
        {
            string drawing = "";
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    drawing += mazeArray[i, j] + " ";
                }
                drawing += "\n";
            }
            return drawing;
        }
    }
}