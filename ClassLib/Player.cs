using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Player
    {
        public int positionX;
        public int positionY;
        public char sprite = '<';
        public void initializePlayer(Maze maze)
        {
            maze.MazeArray[8, 14] = sprite;
        }
        public void Movement(Maze maze, char sprite, ConsoleKeyInfo keyInfo)
        {
            ConsoleKey keyInfo = new ConsoleKey();
            if (keyInfo == ConsoleKey.RightArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true).Key;
                    maze.MazeArray[6, 13] = sprite;
                }
            }
            else if (keyInfo == ConsoleKey.LeftArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true).Key;
                }
            }
            else if (keyInfo == ConsoleKey.UpArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true).Key;
                }
            }
            else if (keyInfo == ConsoleKey.DownArrow)
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true).Key;
                }
            }
        }
    }
}
