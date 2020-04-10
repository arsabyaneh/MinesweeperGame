using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Engine
{
    public partial class Mine : System.Windows.Forms.Control
    {
        public int Row;
        public int Column;

        public Mine()
        {
            this.Width  = 24;
            this.Height = 24;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int top = 0;

            if (this.IsHidden & this.IsFlag & !this.IsMarked)
                top = 1;
            if (this.IsHidden & !this.IsFlag & this.IsMarked)
                top = 2;
            if (this.IsExploded)
                top = 3;
            if (!this.IsHidden & this.IsFlag & this.IsBomb & !this.IsExploded)
                top = 4;
            if (!this.IsHidden & !this.IsFlag & this.IsBomb & !this.IsExploded)
                top = 5;
            if (!this.IsHidden & this.IsMarked)
                top = 6;
            if (top == 0 & !this.IsHidden)
                top = 15 - this.VicinityBombs;

            e.Graphics.DrawImage(Properties.Resources.Button, new Rectangle(0, 0, this.Width, this.Height),
                new Rectangle(0, top * 16, 16, 16), GraphicsUnit.Pixel);

            base.OnPaint(e);
        }

        public void PerformClick()
        {
            this.OnMouseUp(new MouseEventArgs(MouseButtons.Left, 1, (Column * 24) + 1, (Row * 24) + 1, 1));
        }
    }
}
