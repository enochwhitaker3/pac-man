using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            Console.WriteLine(maze.DrawMaze(maze.ReadMaze()));
            
        }
    }
}
