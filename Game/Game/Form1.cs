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
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
            if (EnterNewNames)
            {
                EnterNewNames = false;
                Player1.SetPlayerName(pl1name.Text);
                Player1.SetPlayerName(pl1name.Text);
            }
            bool isWin = false;
            var tictactoe = new TicTacToe.Implementations.Game(Player1, Player2);
            do
            {
                if (Counter % 2 == 1)
                {
                    playerMove.Text = $"{Player1.Name}'s move";

                }
                else
                {
                    playerMove.Text = $"{Player2.Name}'s move";
                }


                //var row = 
                //isWin = tictactoe.PlayerMove(Counter % 2 == 1 ? Player1 : Player1, row, col);
            } while (!isWin);

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
                    GameBoard[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    GameBoard[i, j].Click += new EventHandler(button_isClicked);

                    panel1.Controls.Add(GameBoard[i, j]);

                }
            }
        }

        private void button_isClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Text = Player1.Name;
        }
        
    }
}
