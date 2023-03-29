using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Booga : IGhost
    {
        public char sprite = 'B';
        public int positionX {get; set;}
        public int positionY {get; set;}
        public void initializeGhost(Maze maze)
        {
            maze.MazeArray[6, 18] = sprite;
        }
        public static void Movement(Maze maze, char sprite)
        {
            ConsoleKey e = new ConsoleKey();
            if(e == ConsoleKey.RightArrow )
            {
                while(Console.KeyAvailable)
                {
                    e = Console.ReadKey(true).Key;
                    maze.MazeArray[6, 13] = sprite;
                }
            }
            else if (e == ConsoleKey.LeftArrow)
            {
                while (Console.KeyAvailable)
                {
                    e = Console.ReadKey(true).Key;
                }
            }
            else if (e == ConsoleKey.UpArrow)
            {
                while (Console.KeyAvailable)
                {
                    e = Console.ReadKey(true).Key;
                }
            }
            else if (e == ConsoleKey.DownArrow)
            {
                while (Console.KeyAvailable)
                {
                    e = Console.ReadKey(true).Key;
                }
            }
        }
    }
}
