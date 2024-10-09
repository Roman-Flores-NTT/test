using System;

namespace TicTacToe
{
    public class Game
    {
        private Board board;
        private bool isPlayer1Turn;

        public Game()
        {
            board = new Board();
            isPlayer1Turn = true;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            while (!board.IsGameOver())
            {
                Console.Clear();
                board.Display();

                int row, col;
                if (isPlayer1Turn)
                {
                    Console.WriteLine("Player 1's turn (X)");
                }
                else
                {
                    Console.WriteLine("Player 2's turn (O)");
                }

                Console.Write("Enter the row (0-2): ");
                row = int.Parse(Console.ReadLine());

                Console.Write("Enter the column (0-2): ");
                col = int.Parse(Console.ReadLine());

                if (board.PlaceMark(row, col, isPlayer1Turn ? 'X' : 'O'))
                {
                    isPlayer1Turn = !isPlayer1Turn;
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                    Console.ReadLine();
                }
            }

            Console.Clear();
            board.Display();

            if (board.IsWin('X'))
            {
                Console.WriteLine("Player 1 (X) wins!");
            }
            else if (board.IsWin('O'))
            {
                Console.WriteLine("Player 2 (O) wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}