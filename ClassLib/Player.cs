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
    }
}
