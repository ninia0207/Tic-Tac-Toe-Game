
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl1name = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pl2name = new System.Windows.Forms.TextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.newgamebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pl1name
            // 
            this.pl1name.Location = new System.Drawing.Point(364, 30);
            this.pl1name.Name = "pl1name";
            this.pl1name.Size = new System.Drawing.Size(200, 23);
            this.pl1name.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(364, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(132, 15);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Enter player 1(X) name: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(364, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(134, 15);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Enter player 2(O) name: ";
            // 
            // pl2name
            // 
            this.pl2name.Location = new System.Drawing.Point(364, 88);
            this.pl2name.Name = "pl2name";
            this.pl2name.Size = new System.Drawing.Size(200, 23);
            this.pl2name.TabIndex = 11;
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resetbtn.Location = new System.Drawing.Point(367, 129);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(196, 86);
            this.resetbtn.TabIndex = 13;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            // 
            // newgamebtn
            // 
            this.newgamebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newgamebtn.Location = new System.Drawing.Point(367, 224);
            this.newgamebtn.Name = "newgamebtn";
            this.newgamebtn.Size = new System.Drawing.Size(196, 95);
            this.newgamebtn.TabIndex = 14;
            this.newgamebtn.Text = "Strat A New Game";
            this.newgamebtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 312);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newgamebtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pl2name);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pl1name);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pl1name;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox pl2name;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button newgamebtn;
        private System.Windows.Forms.Panel panel1;
    }
}

