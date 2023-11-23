namespace MarvelClicker
{
    partial class frmMarvelClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarvelClicker));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblIronMan = new System.Windows.Forms.Label();
            this.lblHulk = new System.Windows.Forms.Label();
            this.lblSpidy = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.mtbxScore = new System.Windows.Forms.MaskedTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHulk = new System.Windows.Forms.Button();
            this.btnSpidy = new System.Windows.Forms.Button();
            this.btnCap = new System.Windows.Forms.Button();
            this.btnIronMan = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblGameOver2 = new System.Windows.Forms.Label();
            this.pnlThanos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlThanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIronMan
            // 
            this.lblIronMan.AutoSize = true;
            this.lblIronMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIronMan.Location = new System.Drawing.Point(46, 179);
            this.lblIronMan.Name = "lblIronMan";
            this.lblIronMan.Size = new System.Drawing.Size(128, 29);
            this.lblIronMan.TabIndex = 5;
            this.lblIronMan.Text = "10 Punkte";
            this.lblIronMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblHulk
            // 
            this.lblHulk.AutoSize = true;
            this.lblHulk.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHulk.Location = new System.Drawing.Point(218, 179);
            this.lblHulk.Name = "lblHulk";
            this.lblHulk.Size = new System.Drawing.Size(128, 29);
            this.lblHulk.TabIndex = 6;
            this.lblHulk.Text = "50 Punkte";
            this.lblHulk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSpidy
            // 
            this.lblSpidy.AutoSize = true;
            this.lblSpidy.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpidy.Location = new System.Drawing.Point(382, 179);
            this.lblSpidy.Name = "lblSpidy";
            this.lblSpidy.Size = new System.Drawing.Size(142, 29);
            this.lblSpidy.TabIndex = 7;
            this.lblSpidy.Text = "100 Punkte";
            this.lblSpidy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(554, 179);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(156, 29);
            this.lblCap.TabIndex = 8;
            this.lblCap.Text = "1000 Punkte";
            this.lblCap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mtbxScore
            // 
            this.mtbxScore.BackColor = System.Drawing.Color.LimeGreen;
            this.mtbxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mtbxScore.Location = new System.Drawing.Point(409, 302);
            this.mtbxScore.Name = "mtbxScore";
            this.mtbxScore.Size = new System.Drawing.Size(194, 53);
            this.mtbxScore.TabIndex = 10;
            this.mtbxScore.Text = "10000";
            this.mtbxScore.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbxScore_MaskInputRejected);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(843, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MarvelClicker.Properties.Resources.avengers;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(247, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 128);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnHulk
            // 
            this.btnHulk.BackColor = System.Drawing.Color.DarkRed;
            this.btnHulk.BackgroundImage = global::MarvelClicker.Properties.Resources.hulk;
            this.btnHulk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHulk.Enabled = false;
            this.btnHulk.Location = new System.Drawing.Point(218, 48);
            this.btnHulk.Name = "btnHulk";
            this.btnHulk.Size = new System.Drawing.Size(128, 128);
            this.btnHulk.TabIndex = 4;
            this.btnHulk.UseVisualStyleBackColor = false;
            this.btnHulk.Click += new System.EventHandler(this.btnHulk_Click);
            // 
            // btnSpidy
            // 
            this.btnSpidy.BackColor = System.Drawing.Color.DarkRed;
            this.btnSpidy.BackgroundImage = global::MarvelClicker.Properties.Resources.spidy;
            this.btnSpidy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpidy.Enabled = false;
            this.btnSpidy.Location = new System.Drawing.Point(382, 48);
            this.btnSpidy.Name = "btnSpidy";
            this.btnSpidy.Size = new System.Drawing.Size(128, 128);
            this.btnSpidy.TabIndex = 3;
            this.btnSpidy.UseVisualStyleBackColor = false;
            this.btnSpidy.Click += new System.EventHandler(this.btnSpidy_Click);
            // 
            // btnCap
            // 
            this.btnCap.BackColor = System.Drawing.Color.DarkRed;
            this.btnCap.BackgroundImage = global::MarvelClicker.Properties.Resources.cap;
            this.btnCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCap.Enabled = false;
            this.btnCap.Location = new System.Drawing.Point(554, 48);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(128, 128);
            this.btnCap.TabIndex = 2;
            this.btnCap.UseVisualStyleBackColor = false;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // btnIronMan
            // 
            this.btnIronMan.BackColor = System.Drawing.Color.DarkRed;
            this.btnIronMan.BackgroundImage = global::MarvelClicker.Properties.Resources.ironman;
            this.btnIronMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIronMan.Enabled = false;
            this.btnIronMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIronMan.Location = new System.Drawing.Point(51, 52);
            this.btnIronMan.Name = "btnIronMan";
            this.btnIronMan.Size = new System.Drawing.Size(128, 128);
            this.btnIronMan.TabIndex = 1;
            this.btnIronMan.UseVisualStyleBackColor = false;
            this.btnIronMan.Click += new System.EventHandler(this.btnIronMan_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(722, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(66, 22);
            this.btnBack2.TabIndex = 12;
            this.btnBack2.Text = "Back\r\n";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Visible = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.endeToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.NeuToolStripMenuItem_Click);
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.endeToolStripMenuItem.Text = "Ende";
            this.endeToolStripMenuItem.Click += new System.EventHandler(this.EndeToolStripMenuItem_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.DarkRed;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblGameOver.Location = new System.Drawing.Point(44, 79);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(191, 39);
            this.lblGameOver.TabIndex = 17;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // lblGameOver2
            // 
            this.lblGameOver2.AutoSize = true;
            this.lblGameOver2.BackColor = System.Drawing.Color.DarkRed;
            this.lblGameOver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblGameOver2.Location = new System.Drawing.Point(552, 79);
            this.lblGameOver2.Name = "lblGameOver2";
            this.lblGameOver2.Size = new System.Drawing.Size(191, 39);
            this.lblGameOver2.TabIndex = 18;
            this.lblGameOver2.Text = "Game Over";
            this.lblGameOver2.Visible = false;
            // 
            // pnlThanos
            // 
            this.pnlThanos.BackgroundImage = global::MarvelClicker.Properties.Resources.thanos;
            this.pnlThanos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlThanos.Controls.Add(this.lblGameOver);
            this.pnlThanos.Controls.Add(this.lblGameOver2);
            this.pnlThanos.Location = new System.Drawing.Point(0, 24);
            this.pnlThanos.Name = "pnlThanos";
            this.pnlThanos.Size = new System.Drawing.Size(843, 452);
            this.pnlThanos.TabIndex = 19;
            this.pnlThanos.Visible = false;
            this.pnlThanos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThanos_Paint);
            // 
            // frmMarvelClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 476);
            this.Controls.Add(this.pnlThanos);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mtbxScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblSpidy);
            this.Controls.Add(this.lblHulk);
            this.Controls.Add(this.lblIronMan);
            this.Controls.Add(this.btnHulk);
            this.Controls.Add(this.btnSpidy);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.btnIronMan);
            this.Controls.Add(this.btnBack);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMarvelClicker";
            this.Text = "MarvelClicker";
            this.Load += new System.EventHandler(this.frmMarvelClicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlThanos.ResumeLayout(false);
            this.pnlThanos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnIronMan;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.Button btnSpidy;
        private System.Windows.Forms.Button btnHulk;
        private System.Windows.Forms.Label lblIronMan;
        private System.Windows.Forms.Label lblHulk;
        private System.Windows.Forms.Label lblSpidy;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbxScore;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endeToolStripMenuItem;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblGameOver2;
        private System.Windows.Forms.Panel pnlThanos;
    }
}

