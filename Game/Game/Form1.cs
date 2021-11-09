using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
        }

        Button[,] gameBoard = new Button[3, 3];
        public void InitializeGameBoard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    gameBoard[i, j] = new Button();
                    gameBoard[i, j].Size = new Size(99, 99);
                    gameBoard[i, j].Location = new Point(i * 99, i * 99);
                    gameBoard[i, j].FlatStyle = FlatStyle.Flat;
                    gameBoard[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
                    
                    panel1.Controls.Add(gameBoard[i, j]);

                }
            }
        }


    }
}
