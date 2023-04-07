using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;                                                                 //Allows special Unicode charecters to be printed to the console without error
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
        public static void Movement(Player player, Maze maze,  ConsoleKeyInfo keyInfo)                                          //Gets the key pressed by the user and uses the data to update players position 
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow:                  
                    player.updatePlayer(maze, keyInfo);
                    Console.Clear();
                    break;
                case ConsoleKey.LeftArrow: 
                    player.updatePlayer(maze, keyInfo);                                      
                    Console.Clear();
                    break;
                case ConsoleKey.UpArrow:
                    player.updatePlayer(maze, keyInfo);                                      
                    Console.Clear();
                    break;
                case ConsoleKey.DownArrow: 
                    player.updatePlayer(maze, keyInfo);                                  
                    Console.Clear();
                    break;
            }
        }
    }
}
