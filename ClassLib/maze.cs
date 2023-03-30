using System.Runtime.CompilerServices;

namespace ClassLib                                                                                          
{
    public class Maze
    {
        public Maze()
        {
            ReadMaze();
        }
        public string[] lines = File.ReadAllLines(@"C:\Users\enoch\source\repos\pac-man\pacmanmaze.txt");   //Placeholder array used to hold the context of the read file
        public static bool endGame = false;                                                                 //Bool used to check if the game loop should be running or not
        public static int score;                                                                            //Integer used to display current score of the running game
        public char[,] MazeArray;                                                                           //The 2D char array used to hold and update the maze
        public void ReadMaze()                                                                              //Method used to take 'lines' array and convert it into the 2D char array 'mazeArray'
        {
            int numRows = lines.Length;
            int numCols = lines[0].Length;
            MazeArray = new char[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    MazeArray[i, j] = lines[i][j];
                }
            }
        }
        public string DrawMaze()                                                                            //Method used to print out the contents of mazeArray by returning 'drawing'
        {
            string drawing = "";
            int numRows = lines.Length;
            int numCols = lines[0].Length;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    drawing += MazeArray[i, j];
                }
                drawing += "\n";
            }
            return drawing;
        }
    }
}