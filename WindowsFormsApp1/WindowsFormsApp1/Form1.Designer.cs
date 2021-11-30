namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl1Name = new System.Windows.Forms.TextBox();
            this.pl2Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.continuebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pl1Name
            // 
            this.pl1Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pl1Name.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1Name.Location = new System.Drawing.Point(12, 187);
            this.pl1Name.Multiline = true;
            this.pl1Name.Name = "pl1Name";
            this.pl1Name.Size = new System.Drawing.Size(287, 44);
            this.pl1Name.TabIndex = 0;
            // 
            // pl2Name
            // 
            this.pl2Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pl2Name.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2Name.Location = new System.Drawing.Point(444, 187);
            this.pl2Name.Multiline = true;
            this.pl2Name.Name = "pl2Name";
            this.pl2Name.Size = new System.Drawing.Size(287, 44);
            this.pl2Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter player 1(X) name: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter player 2(O) name: ";
            // 
            // continuebtn
            // 
            this.continuebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continuebtn.BackColor = System.Drawing.Color.SeaGreen;
            this.continuebtn.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebtn.Location = new System.Drawing.Point(512, 381);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(219, 53);
            this.continuebtn.TabIndex = 4;
            this.continuebtn.Text = "Continue";
            this.continuebtn.UseVisualStyleBackColor = false;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(743, 446);
            this.Controls.Add(this.continuebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl2Name);
            this.Controls.Add(this.pl1Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pl1Name;
        private System.Windows.Forms.TextBox pl2Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continuebtn;
    }
}

