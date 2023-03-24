using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            maze.DrawMaze(maze.ReadMaze());
        }
    }
}
