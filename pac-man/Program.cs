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
            //Console.WriteLine(maze.DrawMaze());
     
            while (Maze.endGame != true)
            {
                Console.WriteLine("8b,dPPYba,  ,adPPYYba,  ,adPPYba, 88,dPYba,,adPYba,  ,adPPYYba, 8b,dPPYba,   \r\n88P'    \"8a \"\"     `Y8 a8\"     \"\" 88P'   \"88\"    \"8a \"\"     `Y8 88P'   `\"8a  \r\n88       d8 ,adPPPPP88 8b         88      88      88 ,adPPPPP88 88       88  \r\n88b,   ,a8\" 88,    ,88 \"8a,   ,aa 88      88      88 88,    ,88 88       88  \r\n88`YbbdP\"'  `\"8bbdP\"Y8  `\"Ybbd8\"' 88      88      88 `\"8bbdP\"Y8 88       88  \r\n88                                                                           \r\n88                 ");
                loadingScreen(GetKey());
                Console.Write($"SCORE : {player.score}\n");
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
        public static void loadingScreen(ConsoleKeyInfo keyInfo)
        {
            while (keyInfo.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("<......");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" <.....");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("B <....");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" B <...");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("O B <..");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" O B <.");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("  O B <");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("   O B ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("    O B");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("     O ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("      O");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("       ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("      >");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("     > ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("    > B");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("   > B ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("  > B O");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" > B O ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("> B O  ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" B O   ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("B O    ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine(" O     ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("O      ");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("      ");
                Thread.Sleep(400);
                Console.Clear();
            }
        }
    }
}
