using System;
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
            if (keyInfo.Key == ConsoleKey.RightArrow)                                       //Checks the players input to see if it is the right arrow and updates players position
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionY += 2;
                if (canMove(maze) == false)
                    positionY -= 2; 
                maze.MazeArray[positionX, positionY] = sprite;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)                                   //Checks the player input to see if it is the left arrow and updates players position
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionY -= 2;
                if (canMove(maze) == false)
                    positionY += 2;
                maze.MazeArray[positionX, positionY] = sprite;
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)                                     //Checks the player input to see if it is the up arrow and updates players position
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionX--;
                if (canMove(maze) == false)
                    positionX++;
                maze.MazeArray[positionX, positionY] = sprite;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)                                   //Checks the player input to see if it is the down arrow and updates players position
            {
                maze.MazeArray[positionX, positionY] = ' ';
                positionX++;
                if (canMove(maze) == false)                                              
                    positionX--;
                maze.MazeArray[positionX, positionY] = sprite;
            }
        }
        public bool canMove(Maze maze)                                                  //canMove checks if the player is able to move in the key pressed direction. False = no, True = yes
        {
            switch(maze.MazeArray[positionX, positionY])
            {
                case '║':
                    return false;
                case '═':
                    return false;
                case '╔':
                    return false;
                case '╗':
                    return false;
                case '╚':
                    return false;
                case '╝':
                    return false;
                case '╣':
                    return false; 
                case '╠':
                    return false;
                case '╦':
                    return false;     
            }
            return true;
        }
    }
}
