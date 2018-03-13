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
            var playerOne = new SimpleAgent();
            var playerTwo = new SimpleAgent();
            while (!board.IsGameOver())
            {
                board.Print();
                board.Move(playerOne.GetNextMove(board));

                if (board.IsGameOver()) break;
                
                board.Print();
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
