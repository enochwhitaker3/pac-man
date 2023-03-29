﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib                                                                          
{
    public class Ooga : IGhost
    {
        public Ooga(Maze maze)                                                              //Calls the initializeGhost method to set player as soon as a player object is created
        {
            initializeGhost(maze);                                                          
        }
        public char sprite = 'O';
        public int positionX {  get; set; } 
        public int positionY { get; set; }
        public void initializeGhost(Maze maze)
        {
            maze.MazeArray[6, 12] = sprite;                                                 //Adds the ghosts sprite on to the maze in the default position
        }
        public void Movement()
        {

        }
    }
}
