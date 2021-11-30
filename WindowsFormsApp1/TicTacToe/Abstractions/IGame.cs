using TicTacToe.Implementations;

namespace TicTacToe.Abstractions
{
    public interface IGame
    {
        bool PlayerMove(Player player, int x, int y);
        Player WhoWins(Player player);

        bool IsGameDraw(int count);
    }
}
