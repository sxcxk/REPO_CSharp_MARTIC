namespace TramControl.Client.UI
{
    partial class ClientUI
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
            this.lblIP = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblProtocoll = new System.Windows.Forms.Label();
            this.cbxTcp = new System.Windows.Forms.CheckBox();
            this.cbxUdp = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbxBit4 = new System.Windows.Forms.CheckBox();
            this.cbxBit1 = new System.Windows.Forms.CheckBox();
            this.cbxBit2 = new System.Windows.Forms.CheckBox();
            this.cbxBit3 = new System.Windows.Forms.CheckBox();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(45, 30);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP-Address:";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(112, 27);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 1;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(31, 133);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(112, 65);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 3;
            this.tbxPort.Text = "4711";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(77, 68);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // lblProtocoll
            // 
            this.lblProtocoll.AutoSize = true;
            this.lblProtocoll.Location = new System.Drawing.Point(77, 102);
            this.lblProtocoll.Name = "lblProtocoll";
            this.lblProtocoll.Size = new System.Drawing.Size(48, 13);
            this.lblProtocoll.TabIndex = 5;
            this.lblProtocoll.Text = "Protocoll";
            // 
            // cbxTcp
            // 
            this.cbxTcp.AutoSize = true;
            this.cbxTcp.Location = new System.Drawing.Point(146, 102);
            this.cbxTcp.Name = "cbxTcp";
            this.cbxTcp.Size = new System.Drawing.Size(47, 17);
            this.cbxTcp.TabIndex = 6;
            this.cbxTcp.Text = "TCP";
            this.cbxTcp.UseVisualStyleBackColor = true;
            // 
            // cbxUdp
            // 
            this.cbxUdp.AutoSize = true;
            this.cbxUdp.Enabled = false;
            this.cbxUdp.Location = new System.Drawing.Point(199, 101);
            this.cbxUdp.Name = "cbxUdp";
            this.cbxUdp.Size = new System.Drawing.Size(49, 17);
            this.cbxUdp.TabIndex = 7;
            this.cbxUdp.Text = "UDP";
            this.cbxUdp.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(146, 133);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // cbxBit4
            // 
            this.cbxBit4.AutoSize = true;
            this.cbxBit4.Location = new System.Drawing.Point(31, 196);
            this.cbxBit4.Name = "cbxBit4";
            this.cbxBit4.Size = new System.Drawing.Size(47, 17);
            this.cbxBit4.TabIndex = 9;
            this.cbxBit4.Text = "Bit 4";
            this.cbxBit4.UseVisualStyleBackColor = true;
            // 
            // cbxBit1
            // 
            this.cbxBit1.AutoSize = true;
            this.cbxBit1.Location = new System.Drawing.Point(150, 240);
            this.cbxBit1.Name = "cbxBit1";
            this.cbxBit1.Size = new System.Drawing.Size(47, 17);
            this.cbxBit1.TabIndex = 10;
            this.cbxBit1.Text = "Bit 1";
            this.cbxBit1.UseVisualStyleBackColor = true;
            // 
            // cbxBit2
            // 
            this.cbxBit2.AutoSize = true;
            this.cbxBit2.Location = new System.Drawing.Point(296, 196);
            this.cbxBit2.Name = "cbxBit2";
            this.cbxBit2.Size = new System.Drawing.Size(47, 17);
            this.cbxBit2.TabIndex = 11;
            this.cbxBit2.Text = "Bit 2";
            this.cbxBit2.UseVisualStyleBackColor = true;
            // 
            // cbxBit3
            // 
            this.cbxBit3.AutoSize = true;
            this.cbxBit3.Location = new System.Drawing.Point(148, 196);
            this.cbxBit3.Name = "cbxBit3";
            this.cbxBit3.Size = new System.Drawing.Size(47, 17);
            this.cbxBit3.TabIndex = 12;
            this.cbxBit3.Text = "Bit 3";
            this.cbxBit3.UseVisualStyleBackColor = true;
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(24, 322);
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(283, 20);
            this.tbxData.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(21, 306);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(174, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Protocol data for selected test case";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(112, 348);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(112, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.cbxBit3);
            this.Controls.Add(this.cbxBit2);
            this.Controls.Add(this.cbxBit1);
            this.Controls.Add(this.cbxBit4);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.cbxUdp);
            this.Controls.Add(this.cbxTcp);
            this.Controls.Add(this.lblProtocoll);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblIP);
            this.Name = "ClientUI";
            this.Text = "Tram Way Light Signal Service  Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblProtocoll;
        private System.Windows.Forms.CheckBox cbxTcp;
        private System.Windows.Forms.CheckBox cbxUdp;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.CheckBox cbxBit4;
        private System.Windows.Forms.CheckBox cbxBit1;
        private System.Windows.Forms.CheckBox cbxBit2;
        private System.Windows.Forms.CheckBox cbxBit3;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
    }
}

