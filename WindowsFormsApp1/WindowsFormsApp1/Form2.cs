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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Button[,] Buttons { get; set; }
        int counter = 0;
        bool isWin = false;
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        Game tictactoe;
        public Form2()
        {
            InitializeComponent();
            Buttons = new Button[,] {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };
            tictactoe = new Game(Player1, Player2);
            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    Buttons[i, j].Click += new EventHandler(Button_Is_Clicked);
                    
                    Buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 50, FontStyle.Bold);
                    
                }
            }
            tictactoe = new Game(Player1, Player2);

            bool isDraw = tictactoe.IsGameDraw(counter);
            if (isDraw)
            {
                isWin = false;
                MessageBox.Show("The game is draw.");
                counter = 0;
            }

            
        }

        private void Button_Is_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text != "") return;
            button.Text = counter % 2 == 1 ? Player2.X_Or_O.ToString() : Player1.X_Or_O.ToString();
            counter++;
            int row = 0;
            int col = 0;

            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    if (button.Name == Buttons[i, j].Name)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
            }
            isWin = tictactoe.PlayerMove(counter % 2 == 1 ? Player2 : Player1, row, col);

            if (isWin)
            {
                var winPlayer = (counter - 1) % 2 == 1 ? Player2 : Player1;

                MessageBox.Show("Name: " + winPlayer.Name + "X_Or_O: " + winPlayer.X_Or_O);

                winPlayer.SetPlayerWinCount(++winPlayer.WinCount);
                displayText.Text = "WinCount: " + winPlayer.WinCount;
            }
        }




        private void resetbtn_Click(object sender, EventArgs e)
        {
            counter = 0;
            isWin = false;
            foreach (var item in Buttons)
            {
                item.Text = "";
            }
        }

        private void newgamebtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }
    }
}
