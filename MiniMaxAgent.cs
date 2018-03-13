using System;

namespace tic_tac_toe
{
    public class MiniMaxAgent
    {
        public MiniMaxAgent(int character)
        {
            _character = character;
        }
        private int _character;
        public int GetNextMove(Board board)
        {
            int move = -1;
            float maxUtility = float.MinValue;
            foreach (int action in /* TODO */)
            {
                if (MinValue(Transition(board, action)) > maxUtility)
                {
                    /* TODO */
                }
            }
            return move;
        }

        private float MaxValue(Board board)
        {
            /* TODO */
        }

        private float MinValue(Board board)
        {
            if (board.IsGameOver())
            {
                return GetPoints(board);
            }
            float minUtility = float.MinValue;
            foreach(int action in board.GetLegalMoves())
            {
                minUtility = Math.Min(minUtility, MaxValue(Transition(board, action)));
            }
            return minUtility;
        }

        private float GetPoints(Board board)
        {
            if (board.GetWinner() == this._character)
            {
                return 1f;
            }
            else if (board.IsCats())
            {
                return .5f;
            }
            return 0;
        }

        public Board Transition(Board board, int move)
        {
            /* TODO */
        }
    }
}