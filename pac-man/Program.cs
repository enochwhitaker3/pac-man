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
            Ooga ooga = new Ooga();
            Booga booga = new Booga();
            player.initializePlayer(maze);
            ooga.initializeGhost(maze);
            booga.initializeGhost(maze);
            Console.WriteLine(maze.DrawMaze());
            
        }
    }
}
