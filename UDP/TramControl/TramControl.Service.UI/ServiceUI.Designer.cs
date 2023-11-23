namespace TramControl.Service.UI
{
    partial class ServiceUI
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
            this.btnStop = new System.Windows.Forms.Button();
            this.cbxUdp = new System.Windows.Forms.CheckBox();
            this.cbxTcp = new System.Windows.Forms.CheckBox();
            this.lblProtocoll = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblReceivedData = new System.Windows.Forms.Label();
            this.lbxSysLog = new System.Windows.Forms.ListBox();
            this.lblCmd = new System.Windows.Forms.Label();
            this.tbxCmd = new System.Windows.Forms.TextBox();
            this.lblSysInfoImpExp = new System.Windows.Forms.Label();
            this.rbtnTxt = new System.Windows.Forms.RadioButton();
            this.rbtnCsv = new System.Windows.Forms.RadioButton();
            this.rbtnXml = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxTrafficLightWhite = new System.Windows.Forms.CheckBox();
            this.cbxTrafficLightYellow2 = new System.Windows.Forms.CheckBox();
            this.cbxTrafficLightYellow3 = new System.Windows.Forms.CheckBox();
            this.cbxTrafficLightYellow1 = new System.Windows.Forms.CheckBox();
            this.combxLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(123, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // cbxUdp
            // 
            this.cbxUdp.AutoSize = true;
            this.cbxUdp.Enabled = false;
            this.cbxUdp.Location = new System.Drawing.Point(176, 86);
            this.cbxUdp.Name = "cbxUdp";
            this.cbxUdp.Size = new System.Drawing.Size(49, 17);
            this.cbxUdp.TabIndex = 16;
            this.cbxUdp.Text = "UDP";
            this.cbxUdp.UseVisualStyleBackColor = true;
            // 
            // cbxTcp
            // 
            this.cbxTcp.AutoSize = true;
            this.cbxTcp.Location = new System.Drawing.Point(123, 87);
            this.cbxTcp.Name = "cbxTcp";
            this.cbxTcp.Size = new System.Drawing.Size(47, 17);
            this.cbxTcp.TabIndex = 15;
            this.cbxTcp.Text = "TCP";
            this.cbxTcp.UseVisualStyleBackColor = true;
            // 
            // lblProtocoll
            // 
            this.lblProtocoll.AutoSize = true;
            this.lblProtocoll.Location = new System.Drawing.Point(54, 87);
            this.lblProtocoll.Name = "lblProtocoll";
            this.lblProtocoll.Size = new System.Drawing.Size(48, 13);
            this.lblProtocoll.TabIndex = 14;
            this.lblProtocoll.Text = "Protocoll";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(54, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "Port:";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(89, 50);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 12;
            this.tbxPort.Text = "4711";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(89, 12);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 10;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(22, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "IP-Address:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 18;
            // 
            // lblReceivedData
            // 
            this.lblReceivedData.AutoSize = true;
            this.lblReceivedData.Location = new System.Drawing.Point(27, 166);
            this.lblReceivedData.Name = "lblReceivedData";
            this.lblReceivedData.Size = new System.Drawing.Size(118, 13);
            this.lblReceivedData.TabIndex = 19;
            this.lblReceivedData.Text = "Received protocol data";
            // 
            // lbxSysLog
            // 
            this.lbxSysLog.FormattingEnabled = true;
            this.lbxSysLog.Location = new System.Drawing.Point(282, 15);
            this.lbxSysLog.Name = "lbxSysLog";
            this.lbxSysLog.Size = new System.Drawing.Size(588, 381);
            this.lbxSysLog.TabIndex = 20;
            // 
            // lblCmd
            // 
            this.lblCmd.AutoSize = true;
            this.lblCmd.Location = new System.Drawing.Point(27, 569);
            this.lblCmd.Name = "lblCmd";
            this.lblCmd.Size = new System.Drawing.Size(81, 13);
            this.lblCmd.TabIndex = 22;
            this.lblCmd.Text = "Tram Command";
            // 
            // tbxCmd
            // 
            this.tbxCmd.Location = new System.Drawing.Point(30, 585);
            this.tbxCmd.Name = "tbxCmd";
            this.tbxCmd.Size = new System.Drawing.Size(168, 20);
            this.tbxCmd.TabIndex = 21;
            // 
            // lblSysInfoImpExp
            // 
            this.lblSysInfoImpExp.AutoSize = true;
            this.lblSysInfoImpExp.Location = new System.Drawing.Point(452, 482);
            this.lblSysInfoImpExp.Name = "lblSysInfoImpExp";
            this.lblSysInfoImpExp.Size = new System.Drawing.Size(184, 13);
            this.lblSysInfoImpExp.TabIndex = 23;
            this.lblSysInfoImpExp.Text = "System Information Log Import/Eyport";
            // 
            // rbtnTxt
            // 
            this.rbtnTxt.AutoSize = true;
            this.rbtnTxt.Location = new System.Drawing.Point(476, 515);
            this.rbtnTxt.Name = "rbtnTxt";
            this.rbtnTxt.Size = new System.Drawing.Size(46, 17);
            this.rbtnTxt.TabIndex = 24;
            this.rbtnTxt.TabStop = true;
            this.rbtnTxt.Text = "TXT";
            this.rbtnTxt.UseVisualStyleBackColor = true;
            // 
            // rbtnCsv
            // 
            this.rbtnCsv.AutoSize = true;
            this.rbtnCsv.Location = new System.Drawing.Point(476, 538);
            this.rbtnCsv.Name = "rbtnCsv";
            this.rbtnCsv.Size = new System.Drawing.Size(46, 17);
            this.rbtnCsv.TabIndex = 25;
            this.rbtnCsv.TabStop = true;
            this.rbtnCsv.Text = "CSV";
            this.rbtnCsv.UseVisualStyleBackColor = true;
            // 
            // rbtnXml
            // 
            this.rbtnXml.AutoSize = true;
            this.rbtnXml.Location = new System.Drawing.Point(476, 565);
            this.rbtnXml.Name = "rbtnXml";
            this.rbtnXml.Size = new System.Drawing.Size(47, 17);
            this.rbtnXml.TabIndex = 26;
            this.rbtnXml.TabStop = true;
            this.rbtnXml.Text = "XML";
            this.rbtnXml.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(685, 509);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(685, 544);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 28;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(685, 582);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(353, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // cbxTrafficLightWhite
            // 
            this.cbxTrafficLightWhite.AutoSize = true;
            this.cbxTrafficLightWhite.Location = new System.Drawing.Point(142, 466);
            this.cbxTrafficLightWhite.Name = "cbxTrafficLightWhite";
            this.cbxTrafficLightWhite.Size = new System.Drawing.Size(105, 17);
            this.cbxTrafficLightWhite.TabIndex = 34;
            this.cbxTrafficLightWhite.Text = "White traffic light";
            this.cbxTrafficLightWhite.UseVisualStyleBackColor = true;
            // 
            // cbxTrafficLightYellow2
            // 
            this.cbxTrafficLightYellow2.AutoSize = true;
            this.cbxTrafficLightYellow2.Location = new System.Drawing.Point(273, 466);
            this.cbxTrafficLightYellow2.Name = "cbxTrafficLightYellow2";
            this.cbxTrafficLightYellow2.Size = new System.Drawing.Size(120, 17);
            this.cbxTrafficLightYellow2.TabIndex = 33;
            this.cbxTrafficLightYellow2.Text = "Yellow traffic light(2)";
            this.cbxTrafficLightYellow2.UseVisualStyleBackColor = true;
            // 
            // cbxTrafficLightYellow3
            // 
            this.cbxTrafficLightYellow3.AutoSize = true;
            this.cbxTrafficLightYellow3.Location = new System.Drawing.Point(127, 510);
            this.cbxTrafficLightYellow3.Name = "cbxTrafficLightYellow3";
            this.cbxTrafficLightYellow3.Size = new System.Drawing.Size(120, 17);
            this.cbxTrafficLightYellow3.TabIndex = 32;
            this.cbxTrafficLightYellow3.Text = "Yellow traffic light(3)";
            this.cbxTrafficLightYellow3.UseVisualStyleBackColor = true;
            // 
            // cbxTrafficLightYellow1
            // 
            this.cbxTrafficLightYellow1.AutoSize = true;
            this.cbxTrafficLightYellow1.Location = new System.Drawing.Point(8, 466);
            this.cbxTrafficLightYellow1.Name = "cbxTrafficLightYellow1";
            this.cbxTrafficLightYellow1.Size = new System.Drawing.Size(123, 17);
            this.cbxTrafficLightYellow1.TabIndex = 31;
            this.cbxTrafficLightYellow1.Text = "Yellow traffic light (1)";
            this.cbxTrafficLightYellow1.UseVisualStyleBackColor = true;
            // 
            // combxLanguage
            // 
            this.combxLanguage.FormattingEnabled = true;
            this.combxLanguage.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.combxLanguage.Location = new System.Drawing.Point(89, 253);
            this.combxLanguage.Name = "combxLanguage";
            this.combxLanguage.Size = new System.Drawing.Size(121, 21);
            this.combxLanguage.TabIndex = 35;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(28, 256);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 36;
            this.lblLanguage.Text = "Language";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ServiceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 702);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.combxLanguage);
            this.Controls.Add(this.cbxTrafficLightWhite);
            this.Controls.Add(this.cbxTrafficLightYellow2);
            this.Controls.Add(this.cbxTrafficLightYellow3);
            this.Controls.Add(this.cbxTrafficLightYellow1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbtnXml);
            this.Controls.Add(this.rbtnCsv);
            this.Controls.Add(this.rbtnTxt);
            this.Controls.Add(this.lblSysInfoImpExp);
            this.Controls.Add(this.lblCmd);
            this.Controls.Add(this.tbxCmd);
            this.Controls.Add(this.lbxSysLog);
            this.Controls.Add(this.lblReceivedData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.cbxUdp);
            this.Controls.Add(this.cbxTcp);
            this.Controls.Add(this.lblProtocoll);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblIP);
            this.Name = "ServiceUI";
            this.Text = "Tram Way Signal Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbxUdp;
        private System.Windows.Forms.CheckBox cbxTcp;
        private System.Windows.Forms.Label lblProtocoll;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblReceivedData;
        private System.Windows.Forms.ListBox lbxSysLog;
        private System.Windows.Forms.Label lblCmd;
        private System.Windows.Forms.TextBox tbxCmd;
        private System.Windows.Forms.Label lblSysInfoImpExp;
        private System.Windows.Forms.RadioButton rbtnTxt;
        private System.Windows.Forms.RadioButton rbtnCsv;
        private System.Windows.Forms.RadioButton rbtnXml;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbxTrafficLightWhite;
        private System.Windows.Forms.CheckBox cbxTrafficLightYellow2;
        private System.Windows.Forms.CheckBox cbxTrafficLightYellow3;
        private System.Windows.Forms.CheckBox cbxTrafficLightYellow1;
        private System.Windows.Forms.ComboBox combxLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

