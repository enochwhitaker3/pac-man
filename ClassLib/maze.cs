﻿namespace ClassLib
{
    public class Maze
    {
        public static bool endGame;
        public static int score;
        public string[] lines = File.ReadAllLines(@"C:\Users\enoch\source\repos\pac-man\pacmanmaze.txt");
        public string[,] mazeArray;
        public string[,] ReadMaze()
        {
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;
            mazeArray = new string[numRows, numCols];
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
        public void DrawMaze(string[,] mazeArray)
        {
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(mazeArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}