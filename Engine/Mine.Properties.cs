using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Engine
{
    partial class Mine
    {
        public bool IsHidden
        {
            get
            {
                return _IsHidden;
            }
            set
            {
                _IsHidden = value;
                this.Invalidate();
            }
        }

        public bool IsMarked
        {
            get
            {
                return _IsMarked;
            }
            set
            {
                _IsMarked = value;
                this.Invalidate();
            }
        }

        public bool IsFlag
        {
            get
            {
                return _IsFlag;
            }
            set
            {
                _IsFlag = value;
                this.Invalidate();
            }
        }

        public bool IsBomb
        {
            get
            {
                return _IsBomb;
            }
            set
            {
                _IsBomb = value;
                this.Invalidate();
            }
        }

        public bool IsExploded
        {
            get
            {
                return _IsExploded;
            }
            set
            {
                _IsExploded = value;
                this.Invalidate();
            }
        }

        public int VicinityBombs
        {
            get
            {
                return _VicinityBombs;
            }
            set
            {
                _VicinityBombs = value;
                this.Invalidate();
            }
        }
    }
}
