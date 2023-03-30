﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public int positionX = 8;
        public int positionY = 14;
        public char sprite = '<';

        public void initializePlayer(Maze maze)         
        {
            maze.MazeArray[positionX, positionY] = sprite;                                  //Adds the players sprite on to the maze in the default position
        }
        public void updatePlayer(Maze maze, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.RightArrow)                                       //Checks the players input to see if it is the right arrow
            {
                if (positionY % 2 == 1)
                {
                    maze.MazeArray[positionX, positionY] = ' ';
                    positionY++;
                    maze.MazeArray[positionX, positionY] = sprite;
                }
                else
                {
                    maze.MazeArray[positionX, positionY] = ' ';
                    positionY += 2;
                    maze.MazeArray[positionX, positionY] = sprite;
                }
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)                                   //Checks the player input to see if it is the left arrow
            {
                if (positionY % 2 == 1)
                {
                    maze.MazeArray[positionX, positionY] = ' ';
                    positionY--;
                    maze.MazeArray[positionX, positionY] = sprite;
                }
                else
                {
                    maze.MazeArray[positionX, positionY] = ' ';
                    positionY-=2;
                    maze.MazeArray[positionX, positionY] = sprite;
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)                                     //Checks the player input to see if it is the up arrow
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionX--;
                maze.MazeArray[positionX, positionY] = sprite;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)                                   //Checks the player input to see if it is the down arrow
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionX++;
                maze.MazeArray[positionX, positionY] = sprite;
            }
        }
            
    }
}
