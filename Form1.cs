using Minesweeper.Engine;
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
            throw new NotImplementedException();
        }

        private void RemainingMines_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Button, new Rectangle(0, 0, 20, 19),
                new Rectangle(0, 5 * 16, 16, 16), GraphicsUnit.Pixel);
        }
    }
}
