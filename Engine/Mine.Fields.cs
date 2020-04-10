using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Engine
{
    partial class Mine
    {
        private bool _IsHidden;
        private bool _IsMarked;
        private bool _IsFlag;
        private bool _IsBomb;
        private bool _IsExploded;
        private int  _VicinityBombs;
    }
}
