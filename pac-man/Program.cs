﻿using System;
using ClassLib;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program a = new();
            Maze maze = new Maze();
            Player player = new Player(maze);
            Ooga ooga = new Ooga(maze);
            Booga booga = new Booga(maze);
            Console.WriteLine(maze.DrawMaze());
     

            while (Maze.endGame != true)
            {
                Movement(player, maze, player.sprite, GetKey());
                Console.WriteLine(maze.DrawMaze());
                //Maze.endGame = true;
            }

        }
        static ConsoleKeyInfo GetKey()
        {
            var keyInfo = Console.ReadKey();
            return keyInfo;
        }
        public static void Movement(Player player, Maze maze, char sprite, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.RightArrow)                                       //Checks the players input to see if it is the right arrow
            {
                maze.MazeArray[player.positionX, player.positionY] = ' ';
                player.positionY++;                                                         
                maze.MazeArray[player.positionX, player.positionY] = sprite;
                Console.Clear();
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)                                   //Checks the player input to see if it is the left arrow
            {
                maze.MazeArray[player.positionX, player.positionY] = ' ';
                player.positionY--;
                maze.MazeArray[player.positionX, player.positionY] = sprite;
                Console.Clear();
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)                                     //Checks the player input to see if it is the up arrow
            {
                maze.MazeArray[player.positionX, player.positionY] = ' ';
                player.positionX--;
                maze.MazeArray[player.positionX, player.positionY] = sprite;
                Console.Clear();
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)                                   //Checks the player input to see if it is the down arrow
            {
                maze.MazeArray[player.positionX, player.positionY] = ' ';
                player.positionX++;
                maze.MazeArray[player.positionX, player.positionY] = sprite;
                Console.Clear();
            }
        }
    }
}
