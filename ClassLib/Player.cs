using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Player
    {
        public Player(Maze maze)
        {
            initializePlayer(maze);
        }
        public int positionX;
        public int positionY;
        public char sprite = '<';
        public void initializePlayer(Maze maze)
        {
            maze.MazeArray[8, 14] = sprite;
        }
        public void Movement(Maze maze, char sprite, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    maze.MazeArray[6, 13] = sprite;
                }
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
        }
    }
}
