namespace TicTacToe.Abstractions
{
    public interface IPlayer
    {
        public void SetPlayerName(string name);
        public void SetPlayerWinCount(int winCount);
    }
}
