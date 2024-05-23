namespace Game
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konfiguracijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokreniKonfiguracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokreniSacuvanuIgruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajTrenutnuIgruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prekiniTrenutnuIgruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDugmica
            // 
            this.PanelDugmica.AutoScroll = true;
            this.PanelDugmica.Location = new System.Drawing.Point(13, 32);
            this.PanelDugmica.Name = "PanelDugmica";
            this.PanelDugmica.Size = new System.Drawing.Size(775, 406);
            this.PanelDugmica.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracijeToolStripMenuItem,
            this.igraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konfiguracijeToolStripMenuItem
            // 
            this.konfiguracijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem});
            this.konfiguracijeToolStripMenuItem.Name = "konfiguracijeToolStripMenuItem";
            this.konfiguracijeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.konfiguracijeToolStripMenuItem.Text = "Konfiguracije";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaToolStripMenuItem.Text = "Nova";
            this.novaToolStripMenuItem.Click += new System.EventHandler(this.novaToolStripMenuItem_Click);
            // 
            // igraToolStripMenuItem
            // 
            this.igraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokreniKonfiguracijuToolStripMenuItem,
            this.pokreniSacuvanuIgruToolStripMenuItem,
            this.sacuvajTrenutnuIgruToolStripMenuItem,
            this.prekiniTrenutnuIgruToolStripMenuItem});
            this.igraToolStripMenuItem.Name = "igraToolStripMenuItem";
            this.igraToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.igraToolStripMenuItem.Text = "Igra";
            // 
            // pokreniKonfiguracijuToolStripMenuItem
            // 
            this.pokreniKonfiguracijuToolStripMenuItem.Name = "pokreniKonfiguracijuToolStripMenuItem";
            this.pokreniKonfiguracijuToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pokreniKonfiguracijuToolStripMenuItem.Text = "Pokreni konfiguraciju";
            this.pokreniKonfiguracijuToolStripMenuItem.Click += new System.EventHandler(this.pokreniKonfiguracijuToolStripMenuItem_Click);
            // 
            // pokreniSacuvanuIgruToolStripMenuItem
            // 
            this.pokreniSacuvanuIgruToolStripMenuItem.Name = "pokreniSacuvanuIgruToolStripMenuItem";
            this.pokreniSacuvanuIgruToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pokreniSacuvanuIgruToolStripMenuItem.Text = "Pokreni sacuvanu igru";
            this.pokreniSacuvanuIgruToolStripMenuItem.Click += new System.EventHandler(this.pokreniSacuvanuIgruToolStripMenuItem_Click);
            // 
            // sacuvajTrenutnuIgruToolStripMenuItem
            // 
            this.sacuvajTrenutnuIgruToolStripMenuItem.Name = "sacuvajTrenutnuIgruToolStripMenuItem";
            this.sacuvajTrenutnuIgruToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sacuvajTrenutnuIgruToolStripMenuItem.Text = "Sacuvaj trenutnu igru";
            this.sacuvajTrenutnuIgruToolStripMenuItem.Click += new System.EventHandler(this.sacuvajTrenutnuIgruToolStripMenuItem_Click);
            // 
            // prekiniTrenutnuIgruToolStripMenuItem
            // 
            this.prekiniTrenutnuIgruToolStripMenuItem.Name = "prekiniTrenutnuIgruToolStripMenuItem";
            this.prekiniTrenutnuIgruToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.prekiniTrenutnuIgruToolStripMenuItem.Text = "Prekini trenutnu igru";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDugmica);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Memory Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDugmica;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfiguracijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokreniKonfiguracijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokreniSacuvanuIgruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajTrenutnuIgruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prekiniTrenutnuIgruToolStripMenuItem;
    }
}