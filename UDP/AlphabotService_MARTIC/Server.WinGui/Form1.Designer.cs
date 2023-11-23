namespace Server.WinGui
{
    partial class Form1
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
            this.btnStop = new System.Windows.Forms.Button();
            this.lblServiceEndPoint = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblSystemLog = new System.Windows.Forms.Label();
            this.lblReceivedComands = new System.Windows.Forms.Label();
            this.Time_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblValueIP = new System.Windows.Forms.Label();
            this.lblValuePort = new System.Windows.Forms.Label();
            this.lbxReceivedCmds = new System.Windows.Forms.ListBox();
            this.lbxSyslog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(393, 50);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(393, 112);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblServiceEndPoint
            // 
            this.lblServiceEndPoint.AutoSize = true;
            this.lblServiceEndPoint.Location = new System.Drawing.Point(73, 50);
            this.lblServiceEndPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceEndPoint.Name = "lblServiceEndPoint";
            this.lblServiceEndPoint.Size = new System.Drawing.Size(107, 16);
            this.lblServiceEndPoint.TabIndex = 2;
            this.lblServiceEndPoint.Text = "ServiceEndPoint";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(73, 112);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 16);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(73, 84);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(77, 16);
            this.lblIPAddress.TabIndex = 6;
            this.lblIPAddress.Text = "IP-Address:";
            // 
            // lblSystemLog
            // 
            this.lblSystemLog.AutoSize = true;
            this.lblSystemLog.Location = new System.Drawing.Point(53, 222);
            this.lblSystemLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemLog.Name = "lblSystemLog";
            this.lblSystemLog.Size = new System.Drawing.Size(75, 16);
            this.lblSystemLog.TabIndex = 7;
            this.lblSystemLog.Text = "Systrm-Log";
            // 
            // lblReceivedComands
            // 
            this.lblReceivedComands.AutoSize = true;
            this.lblReceivedComands.Location = new System.Drawing.Point(665, 30);
            this.lblReceivedComands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedComands.Name = "lblReceivedComands";
            this.lblReceivedComands.Size = new System.Drawing.Size(136, 16);
            this.lblReceivedComands.TabIndex = 8;
            this.lblReceivedComands.Text = "Received commands";
            // 
            // lblValueIP
            // 
            this.lblValueIP.AutoSize = true;
            this.lblValueIP.Location = new System.Drawing.Point(163, 84);
            this.lblValueIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueIP.Name = "lblValueIP";
            this.lblValueIP.Size = new System.Drawing.Size(30, 16);
            this.lblValueIP.TabIndex = 10;
            this.lblValueIP.Text = "N/A";
            // 
            // lblValuePort
            // 
            this.lblValuePort.AutoSize = true;
            this.lblValuePort.Location = new System.Drawing.Point(119, 112);
            this.lblValuePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValuePort.Name = "lblValuePort";
            this.lblValuePort.Size = new System.Drawing.Size(30, 16);
            this.lblValuePort.TabIndex = 11;
            this.lblValuePort.Text = "N/A";
            // 
            // lbxReceivedCmds
            // 
            this.lbxReceivedCmds.FormattingEnabled = true;
            this.lbxReceivedCmds.ItemHeight = 16;
            this.lbxReceivedCmds.Location = new System.Drawing.Point(668, 50);
            this.lbxReceivedCmds.Name = "lbxReceivedCmds";
            this.lbxReceivedCmds.Size = new System.Drawing.Size(569, 452);
            this.lbxReceivedCmds.TabIndex = 13;
            // 
            // lbxSyslog
            // 
            this.lbxSyslog.FormattingEnabled = true;
            this.lbxSyslog.ItemHeight = 16;
            this.lbxSyslog.Location = new System.Drawing.Point(56, 241);
            this.lbxSyslog.Name = "lbxSyslog";
            this.lbxSyslog.Size = new System.Drawing.Size(569, 276);
            this.lbxSyslog.TabIndex = 14;
            this.lbxSyslog.SelectedIndexChanged += new System.EventHandler(this.lbxSyslog_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 757);
            this.Controls.Add(this.lbxSyslog);
            this.Controls.Add(this.lbxReceivedCmds);
            this.Controls.Add(this.lblValuePort);
            this.Controls.Add(this.lblValueIP);
            this.Controls.Add(this.lblReceivedComands);
            this.Controls.Add(this.lblSystemLog);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblServiceEndPoint);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblServiceEndPoint;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblSystemLog;
        private System.Windows.Forms.Label lblReceivedComands;
        private System.Windows.Forms.ColumnHeader Time_IP;
        private System.Windows.Forms.ColumnHeader PortClient;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Label lblValueIP;
        private System.Windows.Forms.Label lblValuePort;
        private System.Windows.Forms.ListBox lbxReceivedCmds;
        private System.Windows.Forms.ListBox lbxSyslog;
    }
}

