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
            maze.MazeArray[6, 12] = sprite;
        }
        public void Movement()
        {

        }
    }
}
