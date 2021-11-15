using TicTacToe.Implementations;

namespace TicTacToe.Abstractions
{
    public interface IGame
    {
        public bool IsGameDraw(int count);
    }
}
