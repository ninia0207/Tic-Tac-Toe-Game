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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Player Player1 = new Player('X');
        Player Player2 = new Player('O');
        private void continuebtn_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            bool open = false;
            if(string.IsNullOrEmpty(pl1Name.Text) || string.IsNullOrEmpty(pl2Name.Text) || string.IsNullOrWhiteSpace(pl1Name.Text) || string.IsNullOrWhiteSpace(pl2Name.Text))
            {
                MessageBox.Show("Enter the names for players");
            }
            else
            {
                open = true;
                Player1.SetPlayerName(pl1Name.Text);
                Player2.SetPlayerName(pl2Name.Text);
            }

            if (open)
            {
                
                form2.Show();
                this.Hide();
            }
            form2.Player1 = Player1;
            form2.Player2 = Player2;

        }
    }
}
