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
        public string sprite = "<";
        public void createPlayer(Maze maze)
        {
            maze.mazeArray[12, 0] = sprite;
        }
        public void Movement()
        {

        }
    }
}
