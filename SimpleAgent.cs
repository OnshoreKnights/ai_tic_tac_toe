using System;
using System.Linq;

namespace tic_tac_toe
{
    class SimpleAgent
    {
        private Random _rng = new Random();
        public int GetNextMove(Board board)
        {
            return board.GetLegalMoves().OrderBy(_ => _rng.Next()).First();
        }
    }
}