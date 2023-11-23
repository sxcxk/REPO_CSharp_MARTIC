namespace MinesweeperGUI
{
    partial class FrmLoginTab2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScoredate = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tbxHighscore = new System.Windows.Forms.TextBox();
            this.tbxScoredate = new System.Windows.Forms.TextBox();
            this.tbxPlayer = new System.Windows.Forms.TextBox();
            this.tbxLevel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(86, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 39);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScoredate
            // 
            this.lblScoredate.AutoSize = true;
            this.lblScoredate.Location = new System.Drawing.Point(649, 94);
            this.lblScoredate.Name = "lblScoredate";
            this.lblScoredate.Size = new System.Drawing.Size(56, 13);
            this.lblScoredate.TabIndex = 16;
            this.lblScoredate.Text = "Scoredate";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Location = new System.Drawing.Point(533, 94);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(55, 13);
            this.lblHighscore.TabIndex = 15;
            this.lblHighscore.Text = "Highscore";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(427, 94);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "Level";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(313, 94);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "Spieler";
            // 
            // tbxHighscore
            // 
            this.tbxHighscore.Location = new System.Drawing.Point(508, 113);
            this.tbxHighscore.Name = "tbxHighscore";
            this.tbxHighscore.Size = new System.Drawing.Size(100, 20);
            this.tbxHighscore.TabIndex = 12;
            // 
            // tbxScoredate
            // 
            this.tbxScoredate.Location = new System.Drawing.Point(624, 113);
            this.tbxScoredate.Name = "tbxScoredate";
            this.tbxScoredate.Size = new System.Drawing.Size(100, 20);
            this.tbxScoredate.TabIndex = 11;
            // 
            // tbxPlayer
            // 
            this.tbxPlayer.Location = new System.Drawing.Point(276, 113);
            this.tbxPlayer.Name = "tbxPlayer";
            this.tbxPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayer.TabIndex = 10;
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(392, 113);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(100, 20);
            this.tbxLevel.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.endeToolStripMenuItem.Text = "Ende";
            // 
            // FrmLoginTab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScoredate);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.tbxHighscore);
            this.Controls.Add(this.tbxScoredate);
            this.Controls.Add(this.tbxPlayer);
            this.Controls.Add(this.tbxLevel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLoginTab2";
            this.Text = "AnmeldungsdetailsGUI";
            this.Load += new System.EventHandler(this.FrmLoginTab2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScoredate;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox tbxHighscore;
        private System.Windows.Forms.TextBox tbxScoredate;
        private System.Windows.Forms.TextBox tbxPlayer;
        private System.Windows.Forms.TextBox tbxLevel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endeToolStripMenuItem;
    }
}