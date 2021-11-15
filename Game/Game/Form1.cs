using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Implementations;

namespace Game
{
    public partial class Form1 : Form
    {
        bool EnterNewNames = true;
        Player Player1 = new Player('X');
        Player Player2 = new Player('O');
        int Counter = 0;
        string Player1Name;
        string Player2Name;
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
            //CheckWin();
        }

        Button[,] GameBoard = new Button[3, 3];
        public void InitializeGameBoard()
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    GameBoard[i, j] = new Button();
                    GameBoard[i, j].Size = new Size(99, 99);
                    GameBoard[i, j].Location = new Point(i * 99, j * 99);
                    GameBoard[i, j].FlatStyle = FlatStyle.Flat;
                    GameBoard[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 50, FontStyle.Bold);

                    GameBoard[i, j].Click += new EventHandler(Button_isClicked);

                    panel1.Controls.Add(GameBoard[i, j]);

                }
            }
        }

        //public void CheckWin()
        //{
        //    do
        //    {
                
        //        var tictactoe = new TicTacToe.Implementations.Game(Player1, Player2);
                
        //        WhoWins(Counter % 2 == 1 ? Player1 : Player1);
                
        //        Counter++;

        //        bool isDraw = tictactoe.IsGameDraw(Counter);
        //        if (isDraw)
        //         {
        //             label.Text = "Game is draw";
        //             Counter = 0;
        //             Application.Restart();
        //        }

        //        var winPlayer = (Counter - 1) % 2 == 1 ? Player2 : Player1;

        //        winPlayer.SetPlayerWinCount(++winPlayer.WinCount);
                
                
        //    } while (true);

        //}

        //public void WhoWins(Player player)
        //{
        //    var playerXorO = player.XorO.ToString();

        //    //Vertical Win
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (GameBoard[i, 0].Text == playerXorO && GameBoard[i, 1].Text == playerXorO && GameBoard[i, 2].Text == playerXorO)
        //        {
        //            MessageBox.Show($"Player {player.XorO} wins \n WinCount: {player.WinCount}");
        //        }
        //    }

        //    //Horizontal Win
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (GameBoard[0, j].Text == playerXorO && GameBoard[1, j].Text == playerXorO && GameBoard[2, j].Text == playerXorO)
        //        {
        //            MessageBox.Show($"Player {player.XorO} wins \n WinCount: {player.WinCount}");
        //        }
        //    }

        //    //Diagonal Win
        //    for (int i = 0; i < GameBoard.GetLength(0); i++)
        //    {

        //        if (GameBoard[i, i].Text != playerXorO)
        //        {
        //            break;
        //        }
        //        if (i == GameBoard.GetLength(0) - 1)
        //        {
        //            MessageBox.Show($"Player {player.XorO} wins \n WinCount: {player.WinCount}");
        //        }
        //    }

        //}


        private void Button_isClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var player = Counter % 2 == 1 ? Player1 : Player2;

            PlayerButton.Text = player.XorO.ToString();
            button.Text = PlayerButton.Text;
        }

        private void TogglePlayer()
        {
            if(PlayerButton.Text == "X")
            {
                PlayerButton.Text = "O";
            }
            else
            {
                PlayerButton.Text = "X";
            }
        }
    }
}
