using System;
using TicTacToe.Abstractions;

namespace TicTacToe.Implementations
{
    public class Game : IGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public char[,] GameBoard {get; set;}
        public Game(Player player1, Player player2)
        {
            GameBoard = new char[3, 3];
            Player1 = player1;
            Player2 = player2;
        }

        

        public Player WhoWins(Player player)
        {
            //Vertical Win
            for (int i = 0; i < 3; i++)
            {
                if (GameBoard[i, 0] == player.X_Or_O && GameBoard[i, 1] == player.X_Or_O && GameBoard[i, 2] == player.X_Or_O)
                {
                    return player;
                }
            }

            //Horizontal Win
            for (int j = 0; j < 3; j++)
            {
                if (GameBoard[0, j] == player.X_Or_O && GameBoard[1, j] == player.X_Or_O && GameBoard[2, j] == player.X_Or_O)
                {
                    return player;
                }
            }

            //Diagonal Win
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {

                if (GameBoard[i, i] != player.X_Or_O) {
                    break; 
                }
                if (i == GameBoard.GetLength(0) - 1) {
                    return player; 
                }
            }

            return null;

        }

        public bool PlayerMove(Player player, int x, int y)
        {

            GameBoard[x, y] = player.X_Or_O;
            var win = WhoWins(player);
            return win != null;
        }

        public bool IsGameDraw(int count)
        {
            if (count >= 9) return true;
            else return false;
        }



    }
}
