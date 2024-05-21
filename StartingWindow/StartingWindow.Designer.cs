namespace StartingWindow
{
    partial class StartingWindow
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
            this.ColsLabel = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.NumericColumns = new System.Windows.Forms.NumericUpDown();
            this.NumericRows = new System.Windows.Forms.NumericUpDown();
            this.NumericEmptys = new System.Windows.Forms.NumericUpDown();
            this.EmptySlotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmptys)).BeginInit();
            this.SuspendLayout();
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(66, 105);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(50, 13);
            this.ColsLabel.TabIndex = 0;
            this.ColsLabel.Text = "Columns:";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Location = new System.Drawing.Point(79, 60);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(37, 13);
            this.RowLabel.TabIndex = 1;
            this.RowLabel.Text = "Rows:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(122, 182);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NumericColumns
            // 
            this.NumericColumns.Location = new System.Drawing.Point(122, 105);
            this.NumericColumns.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericColumns.Name = "NumericColumns";
            this.NumericColumns.ReadOnly = true;
            this.NumericColumns.Size = new System.Drawing.Size(120, 20);
            this.NumericColumns.TabIndex = 3;
            this.NumericColumns.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NumericRows
            // 
            this.NumericRows.Location = new System.Drawing.Point(122, 58);
            this.NumericRows.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericRows.Name = "NumericRows";
            this.NumericRows.ReadOnly = true;
            this.NumericRows.Size = new System.Drawing.Size(120, 20);
            this.NumericRows.TabIndex = 4;
            this.NumericRows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // NumericEmptys
            // 
            this.NumericEmptys.Location = new System.Drawing.Point(122, 144);
            this.NumericEmptys.Name = "NumericEmptys";
            this.NumericEmptys.ReadOnly = true;
            this.NumericEmptys.Size = new System.Drawing.Size(120, 20);
            this.NumericEmptys.TabIndex = 6;
            this.NumericEmptys.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EmptySlotLabel
            // 
            this.EmptySlotLabel.AutoSize = true;
            this.EmptySlotLabel.Location = new System.Drawing.Point(53, 146);
            this.EmptySlotLabel.Name = "EmptySlotLabel";
            this.EmptySlotLabel.Size = new System.Drawing.Size(63, 13);
            this.EmptySlotLabel.TabIndex = 5;
            this.EmptySlotLabel.Text = "Empty slots:";
            // 
            // StartingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 231);
            this.Controls.Add(this.NumericEmptys);
            this.Controls.Add(this.EmptySlotLabel);
            this.Controls.Add(this.NumericRows);
            this.Controls.Add(this.NumericColumns);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RowLabel);
            this.Controls.Add(this.ColsLabel);
            this.Name = "StartingWindow";
            this.Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmptys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown NumericColumns;
        private System.Windows.Forms.NumericUpDown NumericRows;
        private System.Windows.Forms.NumericUpDown NumericEmptys;
        private System.Windows.Forms.Label EmptySlotLabel;
    }
}