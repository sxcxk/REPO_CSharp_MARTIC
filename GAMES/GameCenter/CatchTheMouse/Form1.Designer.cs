namespace CatchTheMouse
{
    partial class frmCTM
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGame = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.schwierigkeitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // schwierigkeitToolStripMenuItem
            // 
            this.schwierigkeitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leichtToolStripMenuItem,
            this.mittelToolStripMenuItem,
            this.schwerToolStripMenuItem});
            this.schwierigkeitToolStripMenuItem.Name = "schwierigkeitToolStripMenuItem";
            this.schwierigkeitToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.schwierigkeitToolStripMenuItem.Text = "Schwierigkeit";
            // 
            // leichtToolStripMenuItem
            // 
            this.leichtToolStripMenuItem.Name = "leichtToolStripMenuItem";
            this.leichtToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.leichtToolStripMenuItem.Text = "Leicht";
            // 
            // mittelToolStripMenuItem
            // 
            this.mittelToolStripMenuItem.Name = "mittelToolStripMenuItem";
            this.mittelToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.mittelToolStripMenuItem.Text = "Mittel";
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.schwerToolStripMenuItem.Text = "Schwer";
            // 
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(131, 27);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(464, 465);
            this.pnlGame.TabIndex = 1;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmCTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCTM";
            this.Text = "CatchTheMouse";
            this.Load += new System.EventHandler(this.frmCTM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel pnlGame;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

