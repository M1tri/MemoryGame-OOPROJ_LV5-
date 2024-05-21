namespace Game
{
    partial class GameWindow
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
            this.PanelDugmica = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelDugmica
            // 
            this.PanelDugmica.AutoScroll = true;
            this.PanelDugmica.Location = new System.Drawing.Point(13, 13);
            this.PanelDugmica.Name = "PanelDugmica";
            this.PanelDugmica.Size = new System.Drawing.Size(775, 425);
            this.PanelDugmica.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDugmica);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDugmica;
    }
}