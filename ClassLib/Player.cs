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
        public void createPlayer(Maze maze)
        {
            maze.MazeArray[0, 5] = sprite;
        }
        public void Movement()
        {

        }
    }
}
