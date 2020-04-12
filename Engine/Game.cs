using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Engine
{
    public class Game : System.Windows.Forms.Panel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged == null)
                return;

            this.PropertyChanged(this, e);
        }

        Mine[,] Mines;

        private int _Rows;
        private int _Columns;
        private int _Bombs;
        private int _RemainingBombs;
        private int _RemainingItems;
        private bool _GameOver;
        private bool _Finished;

        public int Rows
        {
            get
            {
                return _Rows;
            }
            set
            {
                _Rows = value;
            }
        }

        public int Columns
        {
            get
            {
                return _Columns;
            }
            set
            {
                _Columns = value;
            }
        }

        public int Bombs
        {
            get
            {
                return _Bombs;
            }
            set
            {
                _Bombs = value;
            }
        }

        public int RemainingItems
        {
            get
            {
                return _RemainingItems;
            }
            set
            {
                _RemainingItems = value;
            }
        }

        public int RemainingBombs
        {
            get
            {
                return _RemainingBombs;
            }
            set
            {
                int old = _RemainingBombs;

                _RemainingBombs = value;

                if (old != _RemainingBombs)
                    this.OnPropertyChanged(new PropertyChangedEventArgs("RemainingBombs"));
            }
        }

        public bool GameOver
        {
            get
            {
                return _GameOver;
            }
            set
            {
                bool old = _GameOver;

                _GameOver = value;

                if (old != _GameOver)
                    this.OnPropertyChanged(new PropertyChangedEventArgs("GameOver"));
            }
        }

        public bool Finished
        {
            get
            {
                return _Finished;
            }
            set
            {
                bool old = _Finished;

                _Finished = value;

                if (old != _Finished)
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Finished"));
            }
        }

        protected override void OnCreateControl()
        {
            if (this.DesignMode)
                return;

            this.Width  = Rows    * 24;
            this.Height = Columns * 24;

            Mines = new Mine[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Mines[i, j] = new Mine()
                    {
                        IsHidden = true,
                        Location = new System.Drawing.Point(j * 24, i * 24),
                        Row = i,
                        Column = j
                    };

                    Mines[i, j].MouseUp += new System.Windows.Forms.MouseEventHandler(DoMouseUp);

                    this.Controls.Add(Mines[i, j]);
                }
            }

            Random random = new Random();
            int counter = 0, x, y;

            while (counter < Bombs)
            {
                x = random.Next(0, Columns - 1);
                y = random.Next(0, Rows - 1);

                if (Mines[y, x].IsBomb == true)
                    continue;

                counter++;
                Mines[y, x].IsBomb = true;
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Mines[i, j].IsBomb == false)
                        continue;

                    foreach (Mine m in GetVicinityCells(i, j))
                    {
                        Mines[m.Row, m.Column].VicinityBombs++;
                    }
                }
            }

            base.OnCreateControl();
        }

        public List<Mine> GetVicinityCells(int Row, int Column)
        {
            List<Mine> result = new List<Mine>();

            if (Row > 0 && Column > 0)
                result.Add(Mines[Row - 1, Column - 1]);
            if (Row > 0)
                result.Add(Mines[Row - 1, Column]);
            if (Row > 0 && Column < Columns - 1)
                result.Add(Mines[Row - 1, Column + 1]);
            if (Column > 0)
                result.Add(Mines[Row, Column - 1]);
            if (Column < Columns - 1)
                result.Add(Mines[Row, Column + 1]);
            if (Column > 0 && Row < Rows - 1)
                result.Add(Mines[Row + 1, Column - 1]);
            if (Row < Rows - 1)
                result.Add(Mines[Row + 1, Column]);
            if (Row < Rows - 1 && Column < Columns - 1)
                result.Add(Mines[Row + 1, Column + 1]);

            return result;
        }

        void DoMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.OnMouseClick(new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, this.Left + 1,
                this.Top + 1, 1));

            Mine mine = sender as Mine;
            if (!mine.IsHidden)
                return;

            RemainingItems--;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!mine.IsMarked & !mine.IsFlag)
                {
                    mine.IsFlag = true;
                    RemainingBombs--;
                }
                else if (mine.IsFlag & !mine.IsMarked)
                {
                    mine.IsMarked = true;
                    mine.IsFlag = false;
                    this.RemainingBombs++;
                    this.RemainingItems++;
                    this.RemainingItems++;
                }
                else if (!mine.IsFlag & mine.IsMarked)
                {
                    mine.IsMarked = false;
                    mine.IsFlag = false;
                    this.RemainingItems++;
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (!mine.IsMarked & !mine.IsFlag)
                {
                    mine.IsHidden = false;
                }
                if (mine.IsBomb)
                {
                    mine.IsExploded = true;

                    foreach (Mine m in Mines)
                    {
                        m.IsHidden = false;
                    }
                    GameOver = true;
                    return;
                }
                if (mine.VicinityBombs == 0)
                {
                    foreach (Mine m in GetVicinityCells(mine.Row, mine.Column))
                    {
                        m.PerformClick();
                    }
                }
            }

            if (this.RemainingItems <= 0)
                Finished = true;
        }
    }
}
