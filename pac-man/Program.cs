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
            Console.WriteLine(maze.DrawMaze());
     
            while (Maze.endGame != true)
            {
                Movement(player, maze, GetKey());
                Console.WriteLine(maze.DrawMaze());
            }
        }
        static ConsoleKeyInfo GetKey()
        {
            var keyInfo = Console.ReadKey();
            return keyInfo;
        }
        public static void Movement(Player player, Maze maze,  ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow:                                                 //Checks the players input to see if it is the right arrow
                    player.updatePlayer(maze, keyInfo);
                    Console.Clear();
                    break;
                case ConsoleKey.LeftArrow:                                                  //Checks the player input to see if it is the left arrow
                    player.updatePlayer(maze, keyInfo);                                      
                    Console.Clear();
                    break;
                case ConsoleKey.UpArrow:                                                    //Checks the player input to see if it is the up arrow
                    player.updatePlayer(maze, keyInfo);                                      
                    Console.Clear();
                    break;
                case ConsoleKey.DownArrow:                                                  //Checks the player input to see if it is the down arrow
                    player.updatePlayer(maze, keyInfo);                                  
                    Console.Clear();
                    break;
            }
        }
    }
}
