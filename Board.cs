using System;
using System.Collections.Generic;
using System.Linq;

namespace tic_tac_toe
{
    class Board
    {
        private readonly int[][] idxWins = new int[][] {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },

            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },

            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 }
        };
        private int[] _board;
        private bool _isOTurn;
        public const int X = 1;
        public const int O = 2;
        public const int EMPTY = 0;

        public Board()
        {
            _board = new int[9];
            for (int i = 0; i < _board.Length; i++)
            {
                _board[i] = EMPTY;
            }
        }

        public IEnumerable<int> GetLegalMoves()
        {
            return Enumerable.Range(0, _board.Length).Where(i => _board[i] == EMPTY);
        }

        public bool IsLegalMove(int move)
        {
            return GetLegalMoves().Contains(move);
        }

        public bool IsCats()
        {
            return GetWinner() == EMPTY;
        }

        public bool DidXWin()
        {
            return GetWinner() == X;
        }

        public bool DidYWin()
        {
            return GetWinner() == O;
        }

        public bool IsGameOver()
        {
            return GetWinner() >= 0;
        }

        public int GetWinner()
        {
            foreach (int[] combo in idxWins)
            {
                int player = _board[combo[0]];
                if (player != EMPTY && player == _board[combo[1]] && player == _board[combo[2]])
                {
                    return player;
                }
            }
            if (GetLegalMoves().Count() == 0)
            {
                return EMPTY;
            }
            return -1;
        }

        public void Move(int move)
        {
            Move(move, false);
        }

        private void Move(int move, bool force)
        {
            if (force || IsLegalMove(move))
            {
                if (_isOTurn)
                {
                    _board[move] = O;
                }
                else
                {
                    _board[move] = X;
                }
                _isOTurn = !_isOTurn;
            }
        }

        public void Print()
        {
            System.Console.WriteLine();
            for (int i = 0; i < _board.Length; i++)
            {
                if (i != 0 && i % 3 == 0)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("-----");
                }
                if (i % 3 == 1)
                {
                    Console.Write('|');
                }
                if (_board[i] == EMPTY)
                {
                    Console.Write(' ');
                }
                else if (_board[i] == X)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write('O');
                }
                if (i % 3 == 1)
                {
                    Console.Write('|');
                }
            }
            System.Console.WriteLine();
        }
    }
}