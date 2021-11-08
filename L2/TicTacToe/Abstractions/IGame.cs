using TicTacToe.Implementations;

namespace TicTacToe.Abstractions
{
    public interface IGame
    {
        public bool PlayerMove(Player player, int x, int y);
        public Player WhoWins(Player player);

        public bool IsGameDraw(int count);
    }
}
