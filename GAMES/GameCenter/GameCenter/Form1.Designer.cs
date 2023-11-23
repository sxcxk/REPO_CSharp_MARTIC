namespace GameCenter
{
    partial class frmGameCenter
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
            this.btnMarvel = new System.Windows.Forms.Button();
            this.btnCTM = new System.Windows.Forms.Button();
            this.lblMarvel = new System.Windows.Forms.Label();
            this.lblCTM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarvel
            // 
            this.btnMarvel.BackgroundImage = global::GameCenter.Properties.Resources.marvel;
            this.btnMarvel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarvel.Location = new System.Drawing.Point(159, 48);
            this.btnMarvel.Name = "btnMarvel";
            this.btnMarvel.Size = new System.Drawing.Size(161, 123);
            this.btnMarvel.TabIndex = 0;
            this.btnMarvel.UseVisualStyleBackColor = true;
            this.btnMarvel.Click += new System.EventHandler(this.btnMarvel_Click);
            // 
            // btnCTM
            // 
            this.btnCTM.BackgroundImage = global::GameCenter.Properties.Resources.catchthemouse;
            this.btnCTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCTM.Location = new System.Drawing.Point(390, 48);
            this.btnCTM.Name = "btnCTM";
            this.btnCTM.Size = new System.Drawing.Size(171, 123);
            this.btnCTM.TabIndex = 1;
            this.btnCTM.UseVisualStyleBackColor = true;
            this.btnCTM.Click += new System.EventHandler(this.btnCTM_Click);
            // 
            // lblMarvel
            // 
            this.lblMarvel.AutoSize = true;
            this.lblMarvel.BackColor = System.Drawing.Color.Red;
            this.lblMarvel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarvel.ForeColor = System.Drawing.Color.White;
            this.lblMarvel.Location = new System.Drawing.Point(131, 174);
            this.lblMarvel.Name = "lblMarvel";
            this.lblMarvel.Size = new System.Drawing.Size(211, 29);
            this.lblMarvel.TabIndex = 2;
            this.lblMarvel.Text = "Marvel Clicker";
            // 
            // lblCTM
            // 
            this.lblCTM.AutoSize = true;
            this.lblCTM.BackColor = System.Drawing.Color.Black;
            this.lblCTM.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTM.ForeColor = System.Drawing.Color.Gold;
            this.lblCTM.Location = new System.Drawing.Point(367, 174);
            this.lblCTM.Name = "lblCTM";
            this.lblCTM.Size = new System.Drawing.Size(223, 29);
            this.lblCTM.TabIndex = 3;
            this.lblCTM.Text = "Catch The Mouse";
            // 
            // frmGameCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCTM);
            this.Controls.Add(this.lblMarvel);
            this.Controls.Add(this.btnCTM);
            this.Controls.Add(this.btnMarvel);
            this.Name = "frmGameCenter";
            this.Text = "GameCenter";
            this.Load += new System.EventHandler(this.frmGameCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarvel;
        private System.Windows.Forms.Button btnCTM;
        private System.Windows.Forms.Label lblMarvel;
        private System.Windows.Forms.Label lblCTM;
    }
}

