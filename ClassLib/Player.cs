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
            initializePlayer(maze);                                                         //Calls the initializePlayer method to set player as soon as a player object is created
        }

        public int positionX;
        public int positionY;
        public char sprite = '<';

        public void initializePlayer(Maze maze)         
        {
            maze.MazeArray[8, 14] = sprite;                                                 //Adds the players sprite on to the maze in the default position
        }
        public void Movement(Maze maze, char sprite, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.RightArrow)                                       //Checks the players input to see if it is the right arrow
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);                                        //This line is used to keep on reading the user input, but then stop as soon it is released
                    maze.MazeArray[6, 13] = sprite;
                }
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)                                   //Checks the player input to see if it is the left arrow
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)                                     //Checks the player input to see if it is the up arrow
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)                                   //Checks the player input to see if it is the down arrow
            {
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
        }
    }
}
