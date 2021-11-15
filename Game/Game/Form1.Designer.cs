
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
            this.resetbtn = new System.Windows.Forms.Button();
            this.newgamebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resetbtn.Location = new System.Drawing.Point(367, 194);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(197, 60);
            this.resetbtn.TabIndex = 13;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            // 
            // newgamebtn
            // 
            this.newgamebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newgamebtn.Location = new System.Drawing.Point(367, 260);
            this.newgamebtn.Name = "newgamebtn";
            this.newgamebtn.Size = new System.Drawing.Size(196, 60);
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(367, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 15);
            this.label.TabIndex = 16;
            this.label.Text = "label1";
            // 
            // PlayerButton
            // 
            this.PlayerButton.Location = new System.Drawing.Point(369, 12);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(195, 110);
            this.PlayerButton.TabIndex = 18;
            this.PlayerButton.Text = "X";
            this.PlayerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.PlayerButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newgamebtn);
            this.Controls.Add(this.resetbtn);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button newgamebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button PlayerButton;
    }
}

