using TicTacToe.Abstractions;

namespace TicTacToe.Implementations
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int WinCount { get; set; }
        public char XorO { get; set; }

        public void SetPlayerName(string name)
        {
            Name = name;
        }

        public void SetPlayerWinCount(int winCount)
        {
            WinCount = winCount;
        }
        public Player(char X_Or_O)
        {
            this.XorO = X_Or_O;
        }

    }
}
