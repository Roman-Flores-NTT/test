using System;

namespace TicTacToe
{
    public class Board
    {
        private char[,] board;

        public Board()
        {
            board = new char[3, 3];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        public void PlaceMark(int row, int col, char mark)
        {
            if (row < 0 || row >= 3 || col < 0 || col >= 3)
            {
                throw new ArgumentException("Invalid board position.");
            }

            if (board[row, col] != ' ')
            {
                throw new ArgumentException("Board position already occupied.");
            }

            board[row, col] = mark;
        }

        public bool CheckWin(char mark)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == mark && board[row, 1] == mark && board[row, 2] == mark)
                {
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == mark && board[1, col] == mark && board[2, col] == mark)
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[0, 0] == mark && board[1, 1] == mark && board[2, 2] == mark)
            {
                return true;
            }

            if (board[0, 2] == mark && board[1, 1] == mark && board[2, 0] == mark)
            {
                return true;
            }

            return false;
        }
    }
}