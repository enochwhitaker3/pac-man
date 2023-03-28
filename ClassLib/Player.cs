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
        public void Movement()
        {

        }
    }
}
