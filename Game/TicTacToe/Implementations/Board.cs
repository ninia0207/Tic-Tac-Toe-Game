using System;
using TicTacToe.Abstractions;

namespace TicTacToe.Implementations
{
    public class Board : IBoard
    {
        
        //Drawing Game Board
        public void DrawGameBoard(char[,] GameBoard)
        {
            Console.WriteLine($"  | 0 | 1 | 2 |");
            Console.WriteLine("---------------");
            Console.WriteLine($"0 | {GameBoard[0, 0]} | {GameBoard[0, 1]} | {GameBoard[0, 2]} |");
            Console.WriteLine("---------------");
            Console.WriteLine($"1 | {GameBoard[1, 0]} | {GameBoard[1, 1]} | {GameBoard[1, 2]} |");
            Console.WriteLine("---------------");
            Console.WriteLine($"2 | {GameBoard[2, 0]} | {GameBoard[2, 1]} | {GameBoard[2, 2]} |");
        }

        
    }
}
