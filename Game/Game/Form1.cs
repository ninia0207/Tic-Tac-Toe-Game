using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Implementations;

namespace Game
{
    public partial class Form1 : Form
    {

        Player player1 = new Player('X');
        Player player2 = new Player('O');
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
            PlaySound("background_music.wav");
            PlayerButton.Font = new System.Drawing.Font(DefaultFont.FontFamily, 50, FontStyle.Bold);
            PlayerButton.FlatStyle = FlatStyle.Flat;
            PlayerButton.Text = player1.XorO.ToString();

        }

        Button[,] GameBoard = new Button[3, 3];
        public void InitializeGameBoard()
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    var butWidth = panel1.Width / 3;
                    var butLength = panel1.Width / 3;
                    GameBoard[i, j] = new Button();
                    GameBoard[i, j].Size = new Size(butWidth, butLength);
                    GameBoard[i, j].Location = new Point(i * butWidth, j * butLength);
                    GameBoard[i, j].FlatStyle = FlatStyle.Flat;
                    GameBoard[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 50, FontStyle.Bold);

                    GameBoard[i, j].Click += new EventHandler(Button_isClicked);
                    
                    panel1.Controls.Add(GameBoard[i, j]);

                }
            }
        }

        public void DisplayWinCount()
        {
            WinCount.Text = $"{player1.XorO}: {player1.WinCount} \n{player2.XorO}: {player2.WinCount}";
        }
        
        private void Win()
        {
            var playerXorO = PlayerButton.Text;
            List<Button> winnerButs = new List<Button>();

            //Vertical Win
            for (int i = 0; i < 3; i++)
            {
                winnerButs = new List<Button>();
                if (GameBoard[i, 0].Text == playerXorO && GameBoard[i, 1].Text == playerXorO && GameBoard[i, 2].Text == playerXorO)
                {
                    winnerButs.Add(GameBoard[i, 0]);
                    winnerButs.Add(GameBoard[i, 1]);
                    winnerButs.Add(GameBoard[i, 2]);
                    DisplayWinner(winnerButs, PlayerButton.Text == "X" ? player1 : player2);
                }
            }

            //Horizontal Win
            for (int j = 0; j < 3; j++)
            {
                winnerButs = new List<Button>();
                if (GameBoard[0, j].Text == playerXorO && GameBoard[1, j].Text == playerXorO && GameBoard[2, j].Text == playerXorO)
                {
                    winnerButs.Add(GameBoard[0, j]);
                    winnerButs.Add(GameBoard[1, j]);
                    winnerButs.Add(GameBoard[2, j]);
                    DisplayWinner(winnerButs, PlayerButton.Text == "X" ? player1 : player2);
                }
            }

            //Diagonal Win #1
            winnerButs = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (GameBoard[i, j].Text != PlayerButton.Text) break;

                winnerButs.Add(GameBoard[i, j]);
                if (j == 2) DisplayWinner(winnerButs, PlayerButton.Text == "X" ? player1 : player2);
            }

            //Diagonal Win #2
            winnerButs = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (GameBoard[i, j].Text != PlayerButton.Text) break;

                winnerButs.Add(GameBoard[i, j]);
                if (j == 2) DisplayWinner(winnerButs, PlayerButton.Text == "X" ? player1 : player2);
            }

            IsGameDraw();
            
        }

        private void IsGameDraw()
        {
            foreach (var button in GameBoard)
            {
                if (button.Text == "") return;
            }

            label1.Text = $"Game is draw! \nReset the game";
        }
        private void DisplayWinner(List<Button> winnerButs, Player player)
        {
            foreach (var item in winnerButs)
            {
                item.BackColor = Color.Green;
            }
            player.WinCount++;
            label1.Text = $"Player {player.XorO} wins \nWinCount {player.XorO}: {player.WinCount}";
            DisplayWinCount();
        }

        private void Button_isClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text != "") return;

            
            button.Text = PlayerButton.Text;
            TogglePlayer();
            PlaySound("button_click.wav");
        }

        private void TogglePlayer()
        {
            Win();
            
            if (PlayerButton.Text == "X") PlayerButton.Text = "O";
            else PlayerButton.Text = "X";
        }
        private void PlaySound(string path)
        {
            SoundPlayer sound = new SoundPlayer($@"C:\Users\ninia\OneDrive\Documents\GitHub\Tic-Tac-Toe-Game\Media\{path}");
            sound.Play();
        }

        private void newgamebtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (var item in GameBoard)
            {
                item.BackColor = default;
                item.Text = "";

            }
            label1.Text = "";
            PlayerButton.Text = "X";
        }

    }
}
