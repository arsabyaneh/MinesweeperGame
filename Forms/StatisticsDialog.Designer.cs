namespace Minesweeper.Forms
{
    partial class StatisticsDialog
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.BestTimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BestTime = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.ListBox.Location = new System.Drawing.Point(12, 21);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(104, 79);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // BestTimeLabel
            // 
            this.BestTimeLabel.AutoSize = true;
            this.BestTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestTimeLabel.Location = new System.Drawing.Point(139, 34);
            this.BestTimeLabel.Name = "BestTimeLabel";
            this.BestTimeLabel.Size = new System.Drawing.Size(61, 15);
            this.BestTimeLabel.TabIndex = 1;
            this.BestTimeLabel.Text = "Best time:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(139, 66);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 15);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date:";
            // 
            // BestTime
            // 
            this.BestTime.Location = new System.Drawing.Point(215, 34);
            this.BestTime.Name = "BestTime";
            this.BestTime.Size = new System.Drawing.Size(120, 20);
            this.BestTime.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(215, 66);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(120, 20);
            this.Date.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(238, 114);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 25);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StatisticsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 153);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BestTime);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.BestTimeLabel);
            this.Controls.Add(this.ListBox);
            this.MaximizeBox = false;
            this.Name = "StatisticsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatisticsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label BestTimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label BestTime;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button Exit;
    }
}