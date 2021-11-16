
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
            this.newgamebtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.DisplayText = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.WinCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // newgamebtn
            // 
            this.newgamebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newgamebtn.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newgamebtn.Location = new System.Drawing.Point(367, 280);
            this.newgamebtn.Name = "newgamebtn";
            this.newgamebtn.Size = new System.Drawing.Size(196, 40);
            this.newgamebtn.TabIndex = 14;
            this.newgamebtn.Text = "Strat A New Game";
            this.newgamebtn.UseVisualStyleBackColor = false;
            this.newgamebtn.Click += new System.EventHandler(this.newgamebtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(367, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 16;
            // 
            // PlayerButton
            // 
            this.PlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerButton.Location = new System.Drawing.Point(369, 12);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(195, 110);
            this.PlayerButton.TabIndex = 18;
            this.PlayerButton.Text = "X";
            this.PlayerButton.UseVisualStyleBackColor = true;
            // 
            // DisplayText
            // 
            this.DisplayText.AutoSize = true;
            this.DisplayText.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayText.Location = new System.Drawing.Point(372, 137);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(0, 22);
            this.DisplayText.TabIndex = 20;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reset.Location = new System.Drawing.Point(367, 236);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(198, 40);
            this.Reset.TabIndex = 21;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // WinCount
            // 
            this.WinCount.AutoSize = true;
            this.WinCount.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinCount.Location = new System.Drawing.Point(372, 189);
            this.WinCount.Name = "WinCount";
            this.WinCount.Size = new System.Drawing.Size(0, 20);
            this.WinCount.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 8);
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
            this.Controls.Add(this.WinCount);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.PlayerButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newgamebtn);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newgamebtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Label DisplayText;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label WinCount;
        private System.Windows.Forms.Panel panel1;
    }
}

