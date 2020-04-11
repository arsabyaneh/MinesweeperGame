using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Forms
{
    public partial class OptionsDialog : Form
    {
        public static int Level = 1;

        public OptionsDialog()
        {
            InitializeComponent();
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            switch (Level)
            {
                case 1:
                    this.Beginner.Checked = true;
                    this.Intermediate.Checked = false;
                    this.Advanced.Checked = false;
                    break;

                case 2:
                    this.Beginner.Checked = false;
                    this.Intermediate.Checked = true;
                    this.Advanced.Checked = false;
                    break;

                case 3:
                    this.Beginner.Checked = false;
                    this.Intermediate.Checked = false;
                    this.Advanced.Checked = true;
                    break;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.Beginner.Checked == true)
                Level = 1;
            else if (this.Intermediate.Checked == true)
                Level = 2;
            else
                Level = 3;

            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
