namespace Minesweeper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Clock = new System.Windows.Forms.PictureBox();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.RemainingMines = new System.Windows.Forms.PictureBox();
            this.RemainingMinesLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainingMines)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.Options,
            this.Statistics,
            this.Exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "&Game";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(180, 22);
            this.NewGame.Text = "&New Game";
            this.NewGame.Click += new System.EventHandler(this.Options_Click);
            // 
            // Options
            // 
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(180, 22);
            this.Options.Text = "&Options";
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Statistics
            // 
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(180, 22);
            this.Statistics.Text = "&Statistics";
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem.Text = "&Help";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(180, 22);
            this.About.Text = "&About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Clock
            // 
            this.Clock.Image = global::Minesweeper.Properties.Resources.Chronometer;
            this.Clock.Location = new System.Drawing.Point(48, 248);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(25, 25);
            this.Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Clock.TabIndex = 1;
            this.Clock.TabStop = false;
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClockLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClockLabel.Location = new System.Drawing.Point(83, 251);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(30, 20);
            this.ClockLabel.TabIndex = 2;
            // 
            // RemainingMines
            // 
            this.RemainingMines.Location = new System.Drawing.Point(247, 248);
            this.RemainingMines.Name = "RemainingMines";
            this.RemainingMines.Size = new System.Drawing.Size(25, 25);
            this.RemainingMines.TabIndex = 3;
            this.RemainingMines.TabStop = false;
            this.RemainingMines.Paint += new System.Windows.Forms.PaintEventHandler(this.RemainingMines_Paint);
            // 
            // RemainingMinesLabel
            // 
            this.RemainingMinesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RemainingMinesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemainingMinesLabel.Location = new System.Drawing.Point(211, 251);
            this.RemainingMinesLabel.Name = "RemainingMinesLabel";
            this.RemainingMinesLabel.Size = new System.Drawing.Size(30, 20);
            this.RemainingMinesLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.RemainingMinesLabel);
            this.Controls.Add(this.RemainingMines);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainingMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem Options;
        private System.Windows.Forms.ToolStripMenuItem Statistics;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox Clock;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.PictureBox RemainingMines;
        private System.Windows.Forms.Label RemainingMinesLabel;
        private System.Windows.Forms.ToolStripMenuItem About;
    }
}

