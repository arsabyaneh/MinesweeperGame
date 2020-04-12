using Minesweeper.Engine;
using Minesweeper.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        Timer Timer;
        Game Game;
        bool IsFirst = true;
        long TimeSeconds = 1;

        public Form1()
        {
            InitializeComponent();

            this.Clock.Location = new Point(20, 265);
            this.RemainingMines.Location = new Point(225, 270);
            this.ClockLabel.Location = new Point(50, 270);
            this.RemainingMinesLabel.Location = new Point(190, 270);

            Game = new Game()
            {
                Rows = 10,
                Columns = 10,
                Bombs = 10
            };

            Game.Location = new Point(15, 25);
            Game.RemainingItems = 100;
            Game.RemainingBombs = 10;
            Game.Size = new Size(240, 240);

            this.Size = new Size(285, 335);
            this.RemainingMinesLabel.Text = "10";
            this.ClockLabel.Text = "0";
            this.Controls.Add(Game);

            Game.MouseClick += new MouseEventHandler(Game_MouseClick);
            Game.PropertyChanged += new PropertyChangedEventHandler(Game_PropertyChanged);

            Timer = new Timer();
            Timer.Tick += new EventHandler(Time_Tick);
            Timer.Interval = 1000;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
           if (Game.GameOver || Game.Finished)
            {
                Timer.Stop();
                Timer.Dispose();
            }

            this.ClockLabel.Text = (TimeSeconds++).ToString();
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsFirst)
            {
                Timer.Enabled = true;
                Timer.Start();
                IsFirst = false;
            }
        }

        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "RemainingBombs":
                    this.RemainingMinesLabel.Text = Game.RemainingBombs.ToString();
                    if(Game.RemainingBombs == 0)
                    {
                        Game.RemainingItems++;
                        Game.RemainingItems--;
                    }
                    break;

                case "GameOver":
                    ResultDialog result = new ResultDialog();
                    result.Controls[result.Controls.IndexOf(result.ResultLabel)].Text = "Sorry, you lost the game!";
                    result.Controls[result.Controls.IndexOf(result.Time)].Text = TimeSeconds.ToString() + " seconds";
                    result.Controls[result.Controls.IndexOf(result.Date)].Text = DateTime.Now.ToString();
                    result.ShowDialog();

                    if (result.PlayGameAgain)
                    {
                        this.NewGame.PerformClick();
                    }
                    break;

                case "Finished":
                    switch (OptionsDialog.Level)
                    {
                        case 1:
                            if (Minesweeper.Statistics.Current.BeginnerTime > TimeSeconds)
                            {
                                Minesweeper.Statistics.Current.BeginnerTime = TimeSeconds;
                                Minesweeper.Statistics.Current.BeginnerDate = DateTime.Now;
                            }
                            break;

                        case 2:
                            if (Minesweeper.Statistics.Current.IntermediateTime > TimeSeconds)
                            {
                                Minesweeper.Statistics.Current.IntermediateTime = TimeSeconds;
                                Minesweeper.Statistics.Current.IntermediateDate = DateTime.Now;
                            }
                            break;

                        case 3:
                            if (Minesweeper.Statistics.Current.AdvancedTime > TimeSeconds)
                            {
                                Minesweeper.Statistics.Current.AdvancedTime = TimeSeconds;
                                Minesweeper.Statistics.Current.AdvancedDate = DateTime.Now;
                            }
                            break;
                    }

                    Minesweeper.Statistics.Current.Save();

                    result = new ResultDialog();
                    result.Controls[result.Controls.IndexOf(result.ResultLabel)].Text = "Congradulations, you won the game!";
                    result.Controls[result.Controls.IndexOf(result.Time)].Text = TimeSeconds.ToString() + " seconds";
                    result.Controls[result.Controls.IndexOf(result.Date)].Text = DateTime.Now.ToString();
                    result.ShowDialog();

                    if (result.PlayGameAgain)
                        this.NewGame.PerformClick();

                    break;
            }
        }

        private void RemainingMines_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Button, new Rectangle(0, 0, 20, 19),
                new Rectangle(0, 5 * 16, 16, 16), GraphicsUnit.Pixel);
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptionsDialog options = new OptionsDialog();

            if ((ToolStripMenuItem)sender == this.Options)
            {
                options.ShowDialog();

                if (options.DialogResult == DialogResult.Cancel)
                    return;
            }
            if (!Game.GameOver & !Game.Finished & !IsFirst)
                return;

            switch (OptionsDialog.Level)
            {
                case 1:
                    {
                        this.Clock.Location = new Point(20, 265);
                        this.RemainingMines.Location = new Point(225, 270);
                        this.ClockLabel.Location = new Point(50, 270);
                        this.RemainingMinesLabel.Location = new Point(190, 270);

                        Game = new Game()
                        {
                            Rows = 10,
                            Columns = 10,
                            Bombs = 10
                        };

                        Game.Location = new Point(15, 25);
                        Game.RemainingItems = 100;
                        Game.RemainingBombs = 10;
                        Game.Size = new Size(240, 240);

                        this.Size = new Size(285, 335);
                        this.RemainingMinesLabel.Text = "10";
                        this.ClockLabel.Text = "0";
                        this.Controls.RemoveAt(5);
                        this.Controls.Add(Game);

                        Game.MouseClick += new MouseEventHandler(Game_MouseClick);
                        Game.PropertyChanged += new PropertyChangedEventHandler(Game_PropertyChanged);

                        Timer = new Timer();
                        Timer.Tick += new EventHandler(Time_Tick);
                        Timer.Interval = 1000;
                        IsFirst = true;
                        TimeSeconds = 1;
                        break;
                    }

                case 2:
                    {
                        this.Clock.Location = new Point(20, 385);
                        this.RemainingMines.Location = new Point(350, 390);
                        this.ClockLabel.Location = new Point(50, 390);
                        this.RemainingMinesLabel.Location = new Point(315, 390);

                        Game = new Game()
                        {
                            Rows = 15,
                            Columns = 15,
                            Bombs = 30
                        };

                        Game.Location = new Point(15, 25);
                        Game.RemainingItems = 15 * 15;
                        Game.RemainingBombs = 30;
                        Game.Size = new Size(24*15, 24*15);

                        this.Size = new Size(410, 460);
                        this.RemainingMinesLabel.Text = "30";
                        this.ClockLabel.Text = "0";
                        this.Controls.RemoveAt(5);
                        this.Controls.Add(Game);

                        Game.MouseClick += new MouseEventHandler(Game_MouseClick);
                        Game.PropertyChanged += new PropertyChangedEventHandler(Game_PropertyChanged);

                        Timer = new Timer();
                        Timer.Tick += new EventHandler(Time_Tick);
                        Timer.Interval = 1000;
                        IsFirst = true;
                        TimeSeconds = 1;
                        break;
                    }

                case 3:
                    {
                        this.Clock.Location = new Point(20, 505);
                        this.RemainingMines.Location = new Point(465, 510);
                        this.ClockLabel.Location = new Point(50, 510);
                        this.RemainingMinesLabel.Location = new Point(430, 510);

                        Game = new Game()
                        {
                            Rows = 20,
                            Columns = 20,
                            Bombs = 50
                        };

                        Game.Location = new Point(15, 25);
                        Game.RemainingItems = 20 * 20;
                        Game.RemainingBombs = 50;
                        Game.Size = new Size(24 * 20, 24 * 20);

                        this.Size = new Size(527, 575);
                        this.UpdateBounds();
                        this.RemainingMinesLabel.Text = "50";
                        this.ClockLabel.Text = "0";
                        this.Controls.RemoveAt(5);
                        this.Controls.Add(Game);

                        Game.MouseClick += new MouseEventHandler(Game_MouseClick);
                        Game.PropertyChanged += new PropertyChangedEventHandler(Game_PropertyChanged);

                        Timer = new Timer();
                        Timer.Tick += new EventHandler(Time_Tick);
                        Timer.Interval = 1000;
                        IsFirst = true;
                        TimeSeconds = 1;
                        break;
                    }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Game.GameOver & !Game.Finished)
            {
                Timer.Stop();
                Timer.Dispose();
            }
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            StatisticsDialog statistics = new StatisticsDialog();
            statistics.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {
            HelpAbout about = new HelpAbout();
            about.ShowDialog();
        }
    }
}
