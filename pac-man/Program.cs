using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Maze maze = new Maze();
            Player player = new Player(maze);
            Ooga ooga = new Ooga(maze);
            Booga booga = new Booga(maze);
            while (Maze.endGame != true)
            {
                Console.WriteLine(maze.DrawMaze());
                player.Movement(maze, player.sprite, GetKey());
                Maze.endGame = true;
            }
           
        }
        static ConsoleKeyInfo GetKey()
        {
            var keyInfo = new ConsoleKeyInfo();
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
            return keyInfo;
        }
    }
}
