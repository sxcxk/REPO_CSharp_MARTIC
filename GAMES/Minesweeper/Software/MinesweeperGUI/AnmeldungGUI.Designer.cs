namespace MinesweeperGUI
{
    partial class frmLogin
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.listViewPlayer = new System.Windows.Forms.ListView();
            this.colHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderHighscore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abbrechenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(321, 362);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(139, 28);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Weiter zum Spiel";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // listViewPlayer
            // 
            this.listViewPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderName,
            this.colHeaderLevel,
            this.colHeaderHighscore,
            this.colHeaderDate,
            this.colHeaderID});
            this.listViewPlayer.HideSelection = false;
            this.listViewPlayer.Location = new System.Drawing.Point(106, 232);
            this.listViewPlayer.Name = "listViewPlayer";
            this.listViewPlayer.Size = new System.Drawing.Size(572, 111);
            this.listViewPlayer.TabIndex = 8;
            this.listViewPlayer.UseCompatibleStateImageBehavior = false;
            this.listViewPlayer.View = System.Windows.Forms.View.Details;
            this.listViewPlayer.SelectedIndexChanged += new System.EventHandler(this.listViewPlayer_SelectedIndexChanged);
            // 
            // colHeaderName
            // 
            this.colHeaderName.Text = "Name";
            // 
            // colHeaderLevel
            // 
            this.colHeaderLevel.Text = "Level";
            // 
            // colHeaderHighscore
            // 
            this.colHeaderHighscore.Text = "Highscore";
            // 
            // colHeaderDate
            // 
            this.colHeaderDate.Text = "Datum (Highscore)";
            this.colHeaderDate.Width = 161;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(223, 80);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(27, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(175, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Geben Sie Ihren Namen ein:";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(205, 35);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(135, 22);
            this.tbxUser.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem,
            this.abbrechenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielOhneAnmeldungFortsetzenToolStripMenuItem
            // 
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem.Name = "spielOhneAnmeldungFortsetzenToolStripMenuItem";
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem.Text = "Spiel ohne Anmeldung fortsetzen";
            this.spielOhneAnmeldungFortsetzenToolStripMenuItem.Click += new System.EventHandler(this.spielOhneAnmeldungFortsetzenToolStripMenuItem_Click);
            // 
            // abbrechenToolStripMenuItem
            // 
            this.abbrechenToolStripMenuItem.Name = "abbrechenToolStripMenuItem";
            this.abbrechenToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.abbrechenToolStripMenuItem.Text = "Abbrechen";
            this.abbrechenToolStripMenuItem.Click += new System.EventHandler(this.abbrechenToolStripMenuItem_Click);
            // 
            // colHeaderID
            // 
            this.colHeaderID.Text = "ID";
            this.colHeaderID.Width = 74;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.listViewPlayer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogin";
            this.Text = "AnmeldungGUI";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ListView listViewPlayer;
        private System.Windows.Forms.ColumnHeader colHeaderName;
        private System.Windows.Forms.ColumnHeader colHeaderLevel;
        private System.Windows.Forms.ColumnHeader colHeaderHighscore;
        private System.Windows.Forms.ColumnHeader colHeaderDate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielOhneAnmeldungFortsetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abbrechenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colHeaderID;
    }
}