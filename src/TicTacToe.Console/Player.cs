namespace TicTacToe
{
    public class Player
    {
        char symbol;
        public Player()
        {
            symbol = ' ';
        }
        public void setPlayerSymbol(char playerSymbol)
        {
            symbol = playerSymbol;
        }
        public char getSymbol()
        {
            return symbol;
        }
    }
}

