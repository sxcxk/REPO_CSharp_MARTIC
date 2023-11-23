namespace BlackjackGUI
{
    partial class FrmEinsatz
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
            this.tbxEinsatz = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEinsatz = new System.Windows.Forms.Label();
            this.lblWallet = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEinsatz
            // 
            this.tbxEinsatz.Location = new System.Drawing.Point(84, 51);
            this.tbxEinsatz.Name = "tbxEinsatz";
            this.tbxEinsatz.Size = new System.Drawing.Size(100, 20);
            this.tbxEinsatz.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(23, 106);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Bestätigen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(109, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEinsatz
            // 
            this.lblEinsatz.AutoSize = true;
            this.lblEinsatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEinsatz.Location = new System.Drawing.Point(20, 52);
            this.lblEinsatz.Name = "lblEinsatz";
            this.lblEinsatz.Size = new System.Drawing.Size(58, 16);
            this.lblEinsatz.TabIndex = 3;
            this.lblEinsatz.Text = "Einsatz";
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(20, 18);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(56, 16);
            this.lblWallet.TabIndex = 4;
            this.lblWallet.Text = "Wallet:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(81, 18);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(16, 16);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "0";
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // FrmEinsatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 158);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblWallet);
            this.Controls.Add(this.lblEinsatz);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbxEinsatz);
            this.Name = "FrmEinsatz";
            this.Text = "Einsatzfeld";
            this.Load += new System.EventHandler(this.FrmEinsatz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEinsatz;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEinsatz;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Label lblValue;
    }
}