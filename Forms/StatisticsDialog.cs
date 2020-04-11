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
    public partial class StatisticsDialog : Form
    {
        public StatisticsDialog()
        {
            InitializeComponent();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BestTime.Text = "-";
            this.Date.Text = "-";

            switch (this.ListBox.SelectedIndex)
            {
                case 0:
                    if (Statistics.Current.BeginnerTime != long.MaxValue)
                    {
                        this.BestTime.Text = Statistics.Current.BeginnerTime.ToString();
                        this.Date.Text = Statistics.Current.BeginnerDate.ToString();
                    }
                    break;

                case 1:
                    if (Statistics.Current.IntermediateTime != long.MaxValue)
                    {
                        this.BestTime.Text = Statistics.Current.IntermediateTime.ToString();
                        this.Date.Text = Statistics.Current.IntermediateDate.ToString();
                    }
                    break;

                case 2:
                    if (Statistics.Current.AdvancedTime != long.MaxValue)
                    {
                        this.BestTime.Text = Statistics.Current.AdvancedTime.ToString();
                        this.Date.Text = Statistics.Current.AdvancedDate.ToString();
                    }
                    break;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
