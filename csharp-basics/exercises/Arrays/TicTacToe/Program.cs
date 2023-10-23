using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];
        private static char _currentPlayer = 'X';
        private static bool _isGameOver = false;

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();

            while (!_isGameOver)
            {
                PlayMove();
                DisplayBoard();
                CheckGameOver();
                TogglePlayer();
            }
        }

        private static void InitBoard()
        {
            //blank
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static void PlayMove()
        {
            Console.Write($"'{_currentPlayer}', choose your location (row, column): ");
            var input = Console.ReadLine();
            var parts = input.Split(' ');

            if (parts.Length != 2 || !int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col)
                || row < 0 || row > 2 || col < 0 || col > 2 || _board[row, col] != ' ')
            {
                Console.WriteLine("Invalid move. Try again.");
                PlayMove();
            }
            else
            {
                _board[row, col] = _currentPlayer;
            }
        }

        private static void TogglePlayer()
        {
            _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
        }

        private static void CheckGameOver()
        {
            if (CheckWin('X'))
            {
                DisplayBoard();
                Console.WriteLine("'X' wins!");
                _isGameOver = true;
            }
            else if (CheckWin('O'))
            {
                DisplayBoard();
                Console.WriteLine("'O' wins!");
                _isGameOver = true;
            }
            else if (CheckTie())
            {
                DisplayBoard();
                Console.WriteLine("The game is a tie.");
                _isGameOver = true;
            }
        }

        private static bool CheckWin(char player)
        {
            //Win condition
            for (int i = 0; i < 3; i++)
            {
                if ((_board[i, 0] == player && _board[i, 1] == player && _board[i, 2] == player) ||
                    (_board[0, i] == player && _board[1, i] == player && _board[2, i] == player))
                {
                    return true;
                }
            }

            if ((_board[0, 0] == player && _board[1, 1] == player && _board[2, 2] == player) ||
                (_board[0, 2] == player && _board[1, 1] == player && _board[2, 0] == player))
            {
                return true;
            }

            return false;
        }

        private static bool CheckTie()
        {
            //Check filled cells
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
