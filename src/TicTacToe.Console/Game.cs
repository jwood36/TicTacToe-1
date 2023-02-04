using System;
using static System.Console;
namespace TicTacToe {
    public class Game
    {
        Player user = new Player();
        Player pc = new Player();
        Board board = new Board();
        Cell cell = new Cell();

        public Game() {
            initGame();
        }

        private void initGame()
        {
            Console.Clear();
            WriteLine("(¯`·._.·(¯`·._.·(¯`·._.·(¯`·._.· Tic Tac Toe ·._.·´¯)·._.·´¯)·._.·´¯)·._.·´¯)");
            board.printBoard();
            WriteLine("\n\t\t\t\t\t User: {0} \t System: {1}", user.getSymbol(), pc.getSymbol());
            WriteLine("\n(¯`·._.·(¯`·._.·(¯`·._.·(¯`·._.· Tic Tac Toe ·._.·´¯)·._.·´¯)·._.·´¯)·._.·´¯)");


        }

        private bool checkIfValidToken(char choice) {

            if (char.ToUpper(choice) != 'O' || char.ToUpper(choice) != 'X')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void startGame()
        {
            initGame();
              
      
         
            
            
          }
              
        }
    }


