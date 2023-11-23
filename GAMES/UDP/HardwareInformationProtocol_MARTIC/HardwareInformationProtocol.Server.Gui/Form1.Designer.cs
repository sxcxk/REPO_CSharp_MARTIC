
namespace HardwareInformationProtocol.Server.Gui
{
    partial class Form1
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
            this.btnStop = new System.Windows.Forms.Button();
            this.lbxLogSysInfo = new System.Windows.Forms.ListBox();
            this.lbxLogRequest = new System.Windows.Forms.ListBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPValue = new System.Windows.Forms.Label();
            this.tbxPortValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(264, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(264, 46);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbxLogSysInfo
            // 
            this.lbxLogSysInfo.FormattingEnabled = true;
            this.lbxLogSysInfo.Location = new System.Drawing.Point(59, 110);
            this.lbxLogSysInfo.Name = "lbxLogSysInfo";
            this.lbxLogSysInfo.Size = new System.Drawing.Size(254, 290);
            this.lbxLogSysInfo.TabIndex = 3;
            // 
            // lbxLogRequest
            // 
            this.lbxLogRequest.FormattingEnabled = true;
            this.lbxLogRequest.Location = new System.Drawing.Point(457, 45);
            this.lbxLogRequest.Name = "lbxLogRequest";
            this.lbxLogRequest.Size = new System.Drawing.Size(254, 355);
            this.lbxLogRequest.TabIndex = 4;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(46, 21);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(20, 13);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(46, 51);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port";
            // 
            // lblIPValue
            // 
            this.lblIPValue.AutoSize = true;
            this.lblIPValue.Location = new System.Drawing.Point(101, 22);
            this.lblIPValue.Name = "lblIPValue";
            this.lblIPValue.Size = new System.Drawing.Size(52, 13);
            this.lblIPValue.TabIndex = 7;
            this.lblIPValue.Text = "127.0.0.1";
            // 
            // tbxPortValue
            // 
            this.tbxPortValue.Location = new System.Drawing.Point(104, 48);
            this.tbxPortValue.Name = "tbxPortValue";
            this.tbxPortValue.Size = new System.Drawing.Size(100, 20);
            this.tbxPortValue.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPortValue);
            this.Controls.Add(this.lblIPValue);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lbxLogRequest);
            this.Controls.Add(this.lbxLogSysInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbxLogSysInfo;
        private System.Windows.Forms.ListBox lbxLogRequest;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPValue;
        private System.Windows.Forms.TextBox tbxPortValue;
    }
}

