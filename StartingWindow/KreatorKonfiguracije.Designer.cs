namespace StartingWindow
{
    partial class KreatorKonfiguracije
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
            this.NumericColumns = new System.Windows.Forms.NumericUpDown();
            this.NumericRows = new System.Windows.Forms.NumericUpDown();
            this.NumericEmptys = new System.Windows.Forms.NumericUpDown();
            this.EmptySlotLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NumericBrSlika = new System.Windows.Forms.NumericUpDown();
            this.labelaBrSlika = new System.Windows.Forms.Label();
            this.SacuvajConfigDugme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmptys)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBrSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColsLabel.Location = new System.Drawing.Point(97, 53);
            this.ColsLabel.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(43, 17);
            this.ColsLabel.TabIndex = 0;
            this.ColsLabel.Text = "Kolone:";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RowLabel.Location = new System.Drawing.Point(106, 12);
            this.RowLabel.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(34, 17);
            this.RowLabel.TabIndex = 1;
            this.RowLabel.Text = "Vrste:";
            // 
            // NumericColumns
            // 
            this.NumericColumns.Location = new System.Drawing.Point(162, 53);
            this.NumericColumns.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.NumericColumns.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericColumns.Name = "NumericColumns";
            this.NumericColumns.ReadOnly = true;
            this.NumericColumns.Size = new System.Drawing.Size(130, 20);
            this.NumericColumns.TabIndex = 3;
            this.NumericColumns.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // NumericRows
            // 
            this.NumericRows.Location = new System.Drawing.Point(162, 12);
            this.NumericRows.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.NumericRows.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericRows.Name = "NumericRows";
            this.NumericRows.ReadOnly = true;
            this.NumericRows.Size = new System.Drawing.Size(130, 20);
            this.NumericRows.TabIndex = 4;
            this.NumericRows.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // NumericEmptys
            // 
            this.NumericEmptys.Location = new System.Drawing.Point(162, 94);
            this.NumericEmptys.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.NumericEmptys.Name = "NumericEmptys";
            this.NumericEmptys.ReadOnly = true;
            this.NumericEmptys.Size = new System.Drawing.Size(130, 20);
            this.NumericEmptys.TabIndex = 6;
            this.NumericEmptys.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericEmptys.ValueChanged += new System.EventHandler(this.NumericEmptys_ValueChanged_1);
            // 
            // EmptySlotLabel
            // 
            this.EmptySlotLabel.AutoSize = true;
            this.EmptySlotLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmptySlotLabel.Location = new System.Drawing.Point(72, 94);
            this.EmptySlotLabel.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.EmptySlotLabel.Name = "EmptySlotLabel";
            this.EmptySlotLabel.Size = new System.Drawing.Size(68, 17);
            this.EmptySlotLabel.TabIndex = 5;
            this.EmptySlotLabel.Text = "Prazna polja:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NumericBrSlika, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RowLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumericRows, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ColsLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumericEmptys, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumericColumns, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EmptySlotLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelaBrSlika, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SacuvajConfigDugme, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 209);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // NumericBrSlika
            // 
            this.NumericBrSlika.Location = new System.Drawing.Point(162, 135);
            this.NumericBrSlika.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.NumericBrSlika.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NumericBrSlika.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumericBrSlika.Name = "NumericBrSlika";
            this.NumericBrSlika.ReadOnly = true;
            this.NumericBrSlika.Size = new System.Drawing.Size(130, 20);
            this.NumericBrSlika.TabIndex = 8;
            this.NumericBrSlika.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // labelaBrSlika
            // 
            this.labelaBrSlika.AutoSize = true;
            this.labelaBrSlika.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelaBrSlika.Location = new System.Drawing.Point(88, 135);
            this.labelaBrSlika.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.labelaBrSlika.Name = "labelaBrSlika";
            this.labelaBrSlika.Size = new System.Drawing.Size(52, 17);
            this.labelaBrSlika.TabIndex = 7;
            this.labelaBrSlika.Text = "Broj slika:";
            // 
            // SacuvajConfigDugme
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SacuvajConfigDugme, 2);
            this.SacuvajConfigDugme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SacuvajConfigDugme.Location = new System.Drawing.Point(100, 174);
            this.SacuvajConfigDugme.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.SacuvajConfigDugme.Name = "SacuvajConfigDugme";
            this.SacuvajConfigDugme.Size = new System.Drawing.Size(103, 25);
            this.SacuvajConfigDugme.TabIndex = 9;
            this.SacuvajConfigDugme.Text = "Sacuvaj konfiguraciju";
            this.SacuvajConfigDugme.UseVisualStyleBackColor = true;
            this.SacuvajConfigDugme.Click += new System.EventHandler(this.SacuvajConfigDugme_Click);
            // 
            // KreatorKonfiguracije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KreatorKonfiguracije";
            this.Text = "Konfiguracija";
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmptys)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBrSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.NumericUpDown NumericColumns;
        private System.Windows.Forms.NumericUpDown NumericRows;
        private System.Windows.Forms.NumericUpDown NumericEmptys;
        private System.Windows.Forms.Label EmptySlotLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelaBrSlika;
        private System.Windows.Forms.NumericUpDown NumericBrSlika;
        private System.Windows.Forms.Button SacuvajConfigDugme;
    }
}