namespace Minesweeper.Forms
{
    partial class HelpAbout
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
            this.Exit = new System.Windows.Forms.Button();
            this.MinesweeperGame = new System.Windows.Forms.Label();
            this.Rights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(242, 130);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 25);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MinesweeperGame
            // 
            this.MinesweeperGame.AutoSize = true;
            this.MinesweeperGame.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesweeperGame.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinesweeperGame.Location = new System.Drawing.Point(71, 28);
            this.MinesweeperGame.Name = "MinesweeperGame";
            this.MinesweeperGame.Size = new System.Drawing.Size(223, 27);
            this.MinesweeperGame.TabIndex = 1;
            this.MinesweeperGame.Text = "Minesweeper Game";
            this.MinesweeperGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rights
            // 
            this.Rights.AutoSize = true;
            this.Rights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights.Location = new System.Drawing.Point(126, 73);
            this.Rights.Name = "Rights";
            this.Rights.Size = new System.Drawing.Size(113, 30);
            this.Rights.TabIndex = 2;
            this.Rights.Text = "All Rights Reserved\r\n2020";
            this.Rights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 167);
            this.Controls.Add(this.Rights);
            this.Controls.Add(this.MinesweeperGame);
            this.Controls.Add(this.Exit);
            this.MaximizeBox = false;
            this.Name = "HelpAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label MinesweeperGame;
        private System.Windows.Forms.Label Rights;
    }
}