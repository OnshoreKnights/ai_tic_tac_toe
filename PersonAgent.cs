using System;
using System.Linq;

namespace tic_tac_toe
{
    class PersonAgent
    {
        public int GetNextMove(Board board)
        {
            System.Console.WriteLine("=====Your turn=====");
            board.Print(true);
            System.Console.WriteLine("Legal Moves: { " + string.Join(", ", board.GetLegalMoves().Select(i => i + 1)) + " }");
            int move = -1;
            while (!board.GetLegalMoves().Contains(move - 1))
            {
                System.Console.WriteLine("Type your move and press enter: ");
                if (!int.TryParse(Console.ReadLine(), out move))
                {
                    System.Console.WriteLine("INVALID");
                }
            }
            return move - 1;
        }
    }
}