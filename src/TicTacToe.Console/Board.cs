using static System.Console;
namespace TicTacToe
{
    public class Board
    {

        char[] board = new char[9];

        public Board()
        {
            initBoard();
        }

        private void initBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
            }
        }
        public bool checkIfCellAvailable(int coordinate, char flag)
        {
            if (board[coordinate] != ' ')
            {
                return false;
            }
            switch (coordinate)
            {
                case 1:
                    board[coordinate - 1] = flag;
                    break;
                case 2:
                    board[coordinate - 1] = flag;
                    break;
                case 3:
                    board[coordinate - 1] = flag;
                    break;
                case 4:
                    board[coordinate - 1] = flag;
                    break;
                case 5:
                    board[coordinate - 1] = flag;
                    break;
                case 6:
                    board[coordinate - 1] = flag;
                    break;
                case 7:
                    board[coordinate - 1] = flag;
                    break;
                case 8:
                    board[coordinate - 1] = flag;
                    break;
                case 9:
                    board[coordinate - 1] = flag;
                    break;
                default:
                    return false;
            }
            return true;

        }

        public void printBoard()
        {

            WriteLine("\n    \t\t\t\t {0} | {1} | {2}", board[0], board[1], board[2]);
            WriteLine("    \t\t\t\t------------ ");
            WriteLine("    \t\t\t\t {0} | {1} | {2} ", board[3], board[4], board[5]);
            WriteLine("    \t\t\t\t------------ ");
            WriteLine("    \t\t\t\t {0} | {1} | {2} ", board[6], board[7], board[8]);
        }



    }
}

