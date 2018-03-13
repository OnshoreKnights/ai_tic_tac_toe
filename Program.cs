using System;
using System.Linq;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();
            var board = new Board();
            var playerOne = new PersonAgent();
            var playerTwo = new MiniMaxAgent(Board.O);
            while (!board.IsGameOver())
            {
                board.Move(playerOne.GetNextMove(board));

                if (board.IsGameOver()) break;

                board.Move(playerTwo.GetNextMove(board));
            }
            if (board.GetWinner() == Board.X)
            {
                System.Console.WriteLine("X (Player One) wins!");
            }
            else if (board.GetWinner() == Board.O)
            {
                System.Console.WriteLine("O (Player Two) wins!");
            }
            else
            {
                System.Console.WriteLine("Cat's Game");
            }
            System.Console.WriteLine("Final board:");
            board.Print();
        }
    }
}
