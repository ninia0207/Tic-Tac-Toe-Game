using TicTacToe.Abstractions;

namespace TicTacToe.Implementations
{
    public class Game : IGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        
        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        
        public bool IsGameDraw(int count)
        {

            if(count == 9) return true;
            else return false;
        }



    }
}
