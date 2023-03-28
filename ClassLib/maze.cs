namespace ClassLib
{
    public class Maze
    {
        public static bool endGame;
        public static int score;
        public string[] lines = File.ReadAllLines(@"C:\Users\enoch.whitaker\source\repos\pac-man\pacmanmaze.txt");
        public char[,] MazeArray;
        public void ReadMaze()
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
        public string DrawMaze()
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