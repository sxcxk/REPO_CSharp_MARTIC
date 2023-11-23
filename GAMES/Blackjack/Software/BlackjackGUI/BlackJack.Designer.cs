namespace BlackjackGUI
{
     partial class BlackJack
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
            this.flpPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblMoneyPlayer = new System.Windows.Forms.Label();
            this.lblHandValuePlayer = new System.Windows.Forms.Label();
            this.lblHandPlayer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.tbxMoneyStake = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlaced = new System.Windows.Forms.Label();
            this.lblWallet = new System.Windows.Forms.Label();
            this.lblValueWallet = new System.Windows.Forms.Label();
            this.flpDealer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHandD = new System.Windows.Forms.Label();
            this.lblHandValueD = new System.Windows.Forms.Label();
            this.spielSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPlayer
            // 
            this.flpPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpPlayer.AutoSize = true;
            this.flpPlayer.Location = new System.Drawing.Point(26, 73);
            this.flpPlayer.Name = "flpPlayer";
            this.flpPlayer.Size = new System.Drawing.Size(641, 125);
            this.flpPlayer.TabIndex = 0;
            this.flpPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.flpPlayer_Paint);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(-2, 51);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(671, 19);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDealer
            // 
            this.lblDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(-76, 319);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(872, 20);
            this.lblDealer.TabIndex = 2;
            this.lblDealer.Text = "Dealer";
            this.lblDealer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDealer.Click += new System.EventHandler(this.lblDealer_Click);
            // 
            // lblMoneyPlayer
            // 
            this.lblMoneyPlayer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoneyPlayer.AutoSize = true;
            this.lblMoneyPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyPlayer.ForeColor = System.Drawing.Color.Green;
            this.lblMoneyPlayer.Location = new System.Drawing.Point(548, 27);
            this.lblMoneyPlayer.Name = "lblMoneyPlayer";
            this.lblMoneyPlayer.Size = new System.Drawing.Size(90, 18);
            this.lblMoneyPlayer.TabIndex = 4;
            this.lblMoneyPlayer.Text = "Einsatz($):";
            this.lblMoneyPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHandValuePlayer
            // 
            this.lblHandValuePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHandValuePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValuePlayer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHandValuePlayer.Location = new System.Drawing.Point(81, 203);
            this.lblHandValuePlayer.Name = "lblHandValuePlayer";
            this.lblHandValuePlayer.Size = new System.Drawing.Size(52, 16);
            this.lblHandValuePlayer.TabIndex = 6;
            this.lblHandValuePlayer.Text = "0";
            this.lblHandValuePlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHandPlayer
            // 
            this.lblHandPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHandPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandPlayer.Location = new System.Drawing.Point(23, 201);
            this.lblHandPlayer.Name = "lblHandPlayer";
            this.lblHandPlayer.Size = new System.Drawing.Size(59, 18);
            this.lblHandPlayer.TabIndex = 7;
            this.lblHandPlayer.Text = "HAND:";
            this.lblHandPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHit
            // 
            this.btnHit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(266, 204);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(57, 23);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStay.Enabled = false;
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(345, 204);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(66, 23);
            this.btnStay.TabIndex = 9;
            this.btnStay.Text = "STAY";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // tbxMoneyStake
            // 
            this.tbxMoneyStake.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxMoneyStake.Enabled = false;
            this.tbxMoneyStake.Location = new System.Drawing.Point(644, 27);
            this.tbxMoneyStake.Name = "tbxMoneyStake";
            this.tbxMoneyStake.Size = new System.Drawing.Size(85, 20);
            this.tbxMoneyStake.TabIndex = 12;
            this.tbxMoneyStake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem,
            this.spielSpeichernToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.startToolStripMenuItem.Text = "Spiel";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // lblPlaced
            // 
            this.lblPlaced.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlaced.AutoSize = true;
            this.lblPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaced.Location = new System.Drawing.Point(647, 50);
            this.lblPlaced.Name = "lblPlaced";
            this.lblPlaced.Size = new System.Drawing.Size(82, 15);
            this.lblPlaced.TabIndex = 15;
            this.lblPlaced.Text = "(GETÄTIGT)";
            this.lblPlaced.Visible = false;
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Location = new System.Drawing.Point(414, 30);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(43, 13);
            this.lblWallet.TabIndex = 16;
            this.lblWallet.Text = "Wallet: ";
            this.lblWallet.Visible = false;
            // 
            // lblValueWallet
            // 
            this.lblValueWallet.AutoSize = true;
            this.lblValueWallet.Location = new System.Drawing.Point(453, 30);
            this.lblValueWallet.Name = "lblValueWallet";
            this.lblValueWallet.Size = new System.Drawing.Size(13, 13);
            this.lblValueWallet.TabIndex = 17;
            this.lblValueWallet.Text = "0";
            this.lblValueWallet.Visible = false;
            // 
            // flpDealer
            // 
            this.flpDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpDealer.AutoSize = true;
            this.flpDealer.Location = new System.Drawing.Point(38, 342);
            this.flpDealer.Name = "flpDealer";
            this.flpDealer.Size = new System.Drawing.Size(640, 125);
            this.flpDealer.TabIndex = 13;
            // 
            // lblHandD
            // 
            this.lblHandD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHandD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandD.Location = new System.Drawing.Point(44, 321);
            this.lblHandD.Name = "lblHandD";
            this.lblHandD.Size = new System.Drawing.Size(59, 18);
            this.lblHandD.TabIndex = 18;
            this.lblHandD.Text = "HAND:";
            this.lblHandD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHandValueD
            // 
            this.lblHandValueD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHandValueD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValueD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHandValueD.Location = new System.Drawing.Point(98, 323);
            this.lblHandValueD.Name = "lblHandValueD";
            this.lblHandValueD.Size = new System.Drawing.Size(53, 18);
            this.lblHandValueD.TabIndex = 19;
            this.lblHandValueD.Text = "0";
            this.lblHandValueD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spielSpeichernToolStripMenuItem
            // 
            this.spielSpeichernToolStripMenuItem.Name = "spielSpeichernToolStripMenuItem";
            this.spielSpeichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spielSpeichernToolStripMenuItem.Text = "Spiel speichern";
            this.spielSpeichernToolStripMenuItem.Click += new System.EventHandler(this.spielSpeichernToolStripMenuItem_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 618);
            this.Controls.Add(this.lblHandValueD);
            this.Controls.Add(this.lblHandD);
            this.Controls.Add(this.lblValueWallet);
            this.Controls.Add(this.lblWallet);
            this.Controls.Add(this.lblPlaced);
            this.Controls.Add(this.flpDealer);
            this.Controls.Add(this.tbxMoneyStake);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblHandPlayer);
            this.Controls.Add(this.lblHandValuePlayer);
            this.Controls.Add(this.lblMoneyPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.flpPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblMoneyPlayer;
        private System.Windows.Forms.Label lblHandValuePlayer;
        private System.Windows.Forms.Label lblHandPlayer;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.TextBox tbxMoneyStake;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label lblPlaced;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Label lblValueWallet;
        private System.Windows.Forms.FlowLayoutPanel flpDealer;
        private System.Windows.Forms.Label lblHandD;
        private System.Windows.Forms.Label lblHandValueD;
        private System.Windows.Forms.ToolStripMenuItem spielSpeichernToolStripMenuItem;
    }
}