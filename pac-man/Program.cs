using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Maze maze = new Maze();
            maze.DrawMaze(maze.ReadMaze());
            Console.Clear();
            player.createPlayer(maze);
            maze.DrawMaze(maze.ReadMaze());
        }
    }
}
