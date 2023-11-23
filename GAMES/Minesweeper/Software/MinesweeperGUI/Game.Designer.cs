namespace MinesweeperGUI
{
    partial class frmGame
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
            this.flpGamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReveal = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbxTimer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxHighscore = new System.Windows.Forms.TextBox();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.tbxTagsCount = new System.Windows.Forms.TextBox();
            this.lblTagsCount = new System.Windows.Forms.Label();
            this.tbxDiff = new System.Windows.Forms.TextBox();
            this.lblDiff = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGamePanel
            // 
            this.flpGamePanel.Location = new System.Drawing.Point(53, 44);
            this.flpGamePanel.Name = "flpGamePanel";
            this.flpGamePanel.Size = new System.Drawing.Size(594, 560);
            this.flpGamePanel.TabIndex = 0;
            this.flpGamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpGamePanel_Paint);
            // 
            // btnReveal
            // 
            this.btnReveal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReveal.Location = new System.Drawing.Point(396, 0);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(114, 0);
            this.btnReveal.TabIndex = 1;
            this.btnReveal.Text = "Aufdecken";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbxTimer
            // 
            this.tbxTimer.BackColor = System.Drawing.Color.Red;
            this.tbxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTimer.ForeColor = System.Drawing.Color.White;
            this.tbxTimer.Location = new System.Drawing.Point(137, 0);
            this.tbxTimer.Name = "tbxTimer";
            this.tbxTimer.Size = new System.Drawing.Size(183, 38);
            this.tbxTimer.TabIndex = 2;
            this.tbxTimer.TextChanged += new System.EventHandler(this.tbxTimer_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem,
            this.schwierigkeitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // schwierigkeitToolStripMenuItem
            // 
            this.schwierigkeitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.schwierigkeitToolStripMenuItem.Name = "schwierigkeitToolStripMenuItem";
            this.schwierigkeitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.schwierigkeitToolStripMenuItem.Text = "Schwierigkeit";
            this.schwierigkeitToolStripMenuItem.Click += new System.EventHandler(this.schwierigkeitToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // tbxHighscore
            // 
            this.tbxHighscore.BackColor = System.Drawing.Color.Black;
            this.tbxHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHighscore.ForeColor = System.Drawing.Color.White;
            this.tbxHighscore.Location = new System.Drawing.Point(490, 0);
            this.tbxHighscore.Name = "tbxHighscore";
            this.tbxHighscore.Size = new System.Drawing.Size(95, 38);
            this.tbxHighscore.TabIndex = 4;
            this.tbxHighscore.TextChanged += new System.EventHandler(this.tbxHighscore_TextChanged);
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(366, 6);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(118, 25);
            this.lblHighscore.TabIndex = 5;
            this.lblHighscore.Text = "Highscore";
            // 
            // tbxTagsCount
            // 
            this.tbxTagsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTagsCount.Location = new System.Drawing.Point(699, 0);
            this.tbxTagsCount.Name = "tbxTagsCount";
            this.tbxTagsCount.Size = new System.Drawing.Size(40, 29);
            this.tbxTagsCount.TabIndex = 6;
            // 
            // lblTagsCount
            // 
            this.lblTagsCount.AutoSize = true;
            this.lblTagsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsCount.Location = new System.Drawing.Point(641, 3);
            this.lblTagsCount.Name = "lblTagsCount";
            this.lblTagsCount.Size = new System.Drawing.Size(52, 24);
            this.lblTagsCount.TabIndex = 7;
            this.lblTagsCount.Text = "Tags";
            // 
            // tbxDiff
            // 
            this.tbxDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiff.Location = new System.Drawing.Point(851, 2);
            this.tbxDiff.Name = "tbxDiff";
            this.tbxDiff.Size = new System.Drawing.Size(94, 29);
            this.tbxDiff.TabIndex = 8;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(768, 3);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(77, 24);
            this.lblDiff.TabIndex = 9;
            this.lblDiff.Text = "Difficulty";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 1061);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.tbxDiff);
            this.Controls.Add(this.lblTagsCount);
            this.Controls.Add(this.tbxTagsCount);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.tbxHighscore);
            this.Controls.Add(this.tbxTimer);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.flpGamePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.Text = "Spiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGamePanel;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbxTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxHighscore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.TextBox tbxTagsCount;
        private System.Windows.Forms.Label lblTagsCount;
        private System.Windows.Forms.TextBox tbxDiff;
        private System.Windows.Forms.Label lblDiff;
    }
}

