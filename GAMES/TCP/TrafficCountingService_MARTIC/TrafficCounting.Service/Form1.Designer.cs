namespace TrafficCounting.Service
{
    partial class TrafficCountingServiceGUI
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
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblServiceTitle = new System.Windows.Forms.Label();
            this.tbxPortValue = new System.Windows.Forms.TextBox();
            this.lbxSystemInformationLog = new System.Windows.Forms.ListBox();
            this.lbxRequestInformation = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblIpValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblServiceTitle
            // 
            this.lblServiceTitle.AutoSize = true;
            this.lblServiceTitle.Location = new System.Drawing.Point(44, 12);
            this.lblServiceTitle.Name = "lblServiceTitle";
            this.lblServiceTitle.Size = new System.Drawing.Size(85, 13);
            this.lblServiceTitle.TabIndex = 2;
            this.lblServiceTitle.Text = "ServiceEndpoint";
            // 
            // tbxPortValue
            // 
            this.tbxPortValue.Location = new System.Drawing.Point(85, 64);
            this.tbxPortValue.Name = "tbxPortValue";
            this.tbxPortValue.Size = new System.Drawing.Size(100, 20);
            this.tbxPortValue.TabIndex = 3;
            this.tbxPortValue.Text = "N/A";
            // 
            // lbxSystemInformationLog
            // 
            this.lbxSystemInformationLog.FormattingEnabled = true;
            this.lbxSystemInformationLog.Location = new System.Drawing.Point(47, 140);
            this.lbxSystemInformationLog.Name = "lbxSystemInformationLog";
            this.lbxSystemInformationLog.Size = new System.Drawing.Size(279, 342);
            this.lbxSystemInformationLog.TabIndex = 4;
            // 
            // lbxRequestInformation
            // 
            this.lbxRequestInformation.FormattingEnabled = true;
            this.lbxRequestInformation.Location = new System.Drawing.Point(447, 33);
            this.lbxRequestInformation.Name = "lbxRequestInformation";
            this.lbxRequestInformation.Size = new System.Drawing.Size(348, 459);
            this.lbxRequestInformation.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(233, 67);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(44, 43);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(61, 13);
            this.lblIp.TabIndex = 7;
            this.lblIp.Text = "IP-Adresse:";
            // 
            // lblIpValue
            // 
            this.lblIpValue.AutoSize = true;
            this.lblIpValue.Location = new System.Drawing.Point(111, 43);
            this.lblIpValue.Name = "lblIpValue";
            this.lblIpValue.Size = new System.Drawing.Size(27, 13);
            this.lblIpValue.TabIndex = 8;
            this.lblIpValue.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // TrafficCountingServiceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIpValue);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbxRequestInformation);
            this.Controls.Add(this.lbxSystemInformationLog);
            this.Controls.Add(this.tbxPortValue);
            this.Controls.Add(this.lblServiceTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Name = "TrafficCountingServiceGUI";
            this.Text = "TrafficCounting (Service)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblServiceTitle;
        private System.Windows.Forms.TextBox tbxPortValue;
        private System.Windows.Forms.ListBox lbxSystemInformationLog;
        private System.Windows.Forms.ListBox lbxRequestInformation;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblIpValue;
        private System.Windows.Forms.Label label4;
    }
}

