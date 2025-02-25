﻿//

using System;
using static System.Console;
namespace TicTacToe
{
    public class Game
    {
        //Declaring Instances//
        Player user = new Player();
        Player pc = new Player();
        Board board = new Board();
        char flagTurn = ' ';

        public Game()
        {
            initGame();
        }

        private void initGame() //Updates game screen 
        {
            Console.Clear();
            WriteLine("(¯`·._.·(¯`·._.·(¯`·._.·(¯`·._.· Tic Tac Toe ·._.·´¯)·._.·´¯)·._.·´¯)·._.·´¯)");
            board.printBoard();
            WriteLine("\n\t\t\t\t\t User: {0} \t System: {1}", user.getSymbol(), pc.getSymbol());
            WriteLine("\n(¯`·._.·(¯`·._.·(¯`·._.·(¯`·._.· Tic Tac Toe ·._.·´¯)·._.·´¯)·._.·´¯)·._.·´¯)");

        }
        private void checkIfUserFirst() //Check if user wants to go first
        {
            bool correctOption; //validates key against Y or N
            do
            {
                WriteLine("Would you like to go first? (Y/N) ");
                ConsoleKeyInfo keyRead = Console.ReadKey();

                switch (keyRead.Key)
                {
                    case ConsoleKey.Y: // User chooses Y
                        WriteLine("\nUser has chosen to go first!");
                        correctOption = true;
                        flagTurn = user.getSymbol();
                        break;
                    case ConsoleKey.N: // User chooses N
                        WriteLine("\nUser has chosen to go after System!");
                        correctOption = true;
                        flagTurn = pc.getSymbol();
                        break;
                    default: // User doesnt enter Y or N
                        WriteLine("\nChoice is unavailable! Please try again.");
                        correctOption = false;
                        break;
                }

            } while (!correctOption);
        }

        private void userChooseSymbol()  //Gets users symbol X or O
        {

            bool correctOption; // Validates user input
            do
            {
                WriteLine("Would you like to play as 'X' or 'O'' ?");
                ConsoleKeyInfo keyRead = Console.ReadKey();

                switch (keyRead.Key)
                {
                    case ConsoleKey.O:  //user chooses O
                        WriteLine("\nUser has chosen 'O'");
                        correctOption = true;
                        user.setPlayerSymbol('O');
                        pc.setPlayerSymbol('X');
                        break;
                    case ConsoleKey.X: //User chooses X
                        WriteLine("\nUser has chosen 'X'");
                        correctOption = true;
                        user.setPlayerSymbol('X');
                        pc.setPlayerSymbol('O');
                        break;
                    default: //User doesnt enter X or O
                        WriteLine("\nChoice is unavailable! Please try again.");
                        correctOption = false;
                        break;
                }

            } while (!correctOption);
        }


        private void startUpCycle() //start up cycle
        {
            userChooseSymbol();
            checkIfUserFirst();
        }
        private void gameMenu() //game menu
        {

            bool correctOption;
            int keyEntered;
            do
            {
                WriteLine("-----------------------------------");

                WriteLine("Enter '0' to exit game");

                WriteLine("Enter Coordinate to place token (1-9)");

                WriteLine("-----------------------------------");

                keyEntered = Convert.ToInt32(ReadLine());
                if (keyEntered == 0)
                {
                    Environment.Exit(0);
                }
                correctOption = board.checkIfCellAvailable(keyEntered - 1, flagTurn);
            } while (!correctOption);
        }

        private void RunCycle()
        {
            do
            {
                if (flagTurn == pc.getSymbol())
                {

                    board.systemChoose(flagTurn);
                    flagTurn = user.getSymbol();
                    initGame();

                }

                if (flagTurn == user.getSymbol())
                {
                    initGame();
                    gameMenu();
                    flagTurn = pc.getSymbol();
                }
            }  while (!board.endCondition(flagTurn));

        }

    public void startGame()
        {
            initGame();
            startUpCycle();
            RunCycle();
            initGame();
            
          
           
        }

    }
}


