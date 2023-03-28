using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            Player player = new Player();
            maze.ReadMaze();
            //player.createPlayer(maze);
            Console.WriteLine(maze.DrawMaze());
            
        }
    }
}
