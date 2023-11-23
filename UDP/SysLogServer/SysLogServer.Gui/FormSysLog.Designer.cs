namespace SysLogServer.Gui
{
    partial class FormSysLog
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnImportBin = new System.Windows.Forms.Button();
            this.btnExportBin = new System.Windows.Forms.Button();
            this.btnImportCsv = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.cbxDescending = new System.Windows.Forms.CheckBox();
            this.cbxBubbleSort = new System.Windows.Forms.CheckBox();
            this.drpBtnSearchIn = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnResetLogs = new System.Windows.Forms.Button();
            this.drpBtnSortBy = new System.Windows.Forms.ComboBox();
            this.lbxInfoStatus = new System.Windows.Forms.ListBox();
            this.listViewSysLog = new System.Windows.Forms.ListView();
            this.ViewColumnPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewColumnSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewColumnFacility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewColumnTimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewColumnSourceIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewColumnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(84, 203);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.AutoSize = true;
            this.btnStop.Location = new System.Drawing.Point(252, 203);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(163, 48);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.AutoSize = true;
            this.btnRestart.Location = new System.Drawing.Point(425, 203);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 48);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnImportBin
            // 
            this.btnImportBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportBin.AutoSize = true;
            this.btnImportBin.Location = new System.Drawing.Point(959, 203);
            this.btnImportBin.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportBin.Name = "btnImportBin";
            this.btnImportBin.Size = new System.Drawing.Size(149, 48);
            this.btnImportBin.TabIndex = 3;
            this.btnImportBin.Text = "Import BIN";
            this.btnImportBin.UseVisualStyleBackColor = true;
            // 
            // btnExportBin
            // 
            this.btnExportBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportBin.AutoSize = true;
            this.btnExportBin.Location = new System.Drawing.Point(1119, 203);
            this.btnExportBin.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportBin.Name = "btnExportBin";
            this.btnExportBin.Size = new System.Drawing.Size(149, 48);
            this.btnExportBin.TabIndex = 4;
            this.btnExportBin.Text = "Export BIN";
            this.btnExportBin.UseVisualStyleBackColor = true;
            // 
            // btnImportCsv
            // 
            this.btnImportCsv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportCsv.AutoSize = true;
            this.btnImportCsv.Location = new System.Drawing.Point(1276, 203);
            this.btnImportCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportCsv.Name = "btnImportCsv";
            this.btnImportCsv.Size = new System.Drawing.Size(149, 48);
            this.btnImportCsv.TabIndex = 5;
            this.btnImportCsv.Text = "Import CSV";
            this.btnImportCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportCsv.AutoSize = true;
            this.btnExportCsv.Location = new System.Drawing.Point(816, 203);
            this.btnExportCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(135, 48);
            this.btnExportCsv.TabIndex = 6;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // cbxDescending
            // 
            this.cbxDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDescending.AutoSize = true;
            this.cbxDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDescending.Location = new System.Drawing.Point(236, 282);
            this.cbxDescending.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDescending.Name = "cbxDescending";
            this.cbxDescending.Size = new System.Drawing.Size(138, 29);
            this.cbxDescending.TabIndex = 8;
            this.cbxDescending.Text = "Descending";
            this.cbxDescending.UseVisualStyleBackColor = true;
            // 
            // cbxBubbleSort
            // 
            this.cbxBubbleSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBubbleSort.AutoSize = true;
            this.cbxBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBubbleSort.Location = new System.Drawing.Point(400, 282);
            this.cbxBubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBubbleSort.Name = "cbxBubbleSort";
            this.cbxBubbleSort.Size = new System.Drawing.Size(131, 29);
            this.cbxBubbleSort.TabIndex = 9;
            this.cbxBubbleSort.Text = "BubbleSort";
            this.cbxBubbleSort.UseVisualStyleBackColor = true;
            // 
            // drpBtnSearchIn
            // 
            this.drpBtnSearchIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drpBtnSearchIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpBtnSearchIn.FormattingEnabled = true;
            this.drpBtnSearchIn.Location = new System.Drawing.Point(749, 288);
            this.drpBtnSearchIn.Margin = new System.Windows.Forms.Padding(4);
            this.drpBtnSearchIn.Name = "drpBtnSearchIn";
            this.drpBtnSearchIn.Size = new System.Drawing.Size(260, 33);
            this.drpBtnSearchIn.TabIndex = 12;
            this.drpBtnSearchIn.Text = "Search in ...";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(1080, 284);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(233, 37);
            this.tbxSearch.TabIndex = 13;
            this.tbxSearch.Text = "Search ...";
            // 
            // btnResetLogs
            // 
            this.btnResetLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetLogs.AutoSize = true;
            this.btnResetLogs.Location = new System.Drawing.Point(1331, 266);
            this.btnResetLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetLogs.Name = "btnResetLogs";
            this.btnResetLogs.Size = new System.Drawing.Size(95, 63);
            this.btnResetLogs.TabIndex = 14;
            this.btnResetLogs.Text = "Reset Logs";
            this.btnResetLogs.UseVisualStyleBackColor = true;
            this.btnResetLogs.Click += new System.EventHandler(this.btnResetLogs_Click);
            // 
            // drpBtnSortBy
            // 
            this.drpBtnSortBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drpBtnSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpBtnSortBy.FormattingEnabled = true;
            this.drpBtnSortBy.Location = new System.Drawing.Point(69, 279);
            this.drpBtnSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.drpBtnSortBy.Name = "drpBtnSortBy";
            this.drpBtnSortBy.Size = new System.Drawing.Size(147, 33);
            this.drpBtnSortBy.TabIndex = 15;
            this.drpBtnSortBy.Text = "Sort By ...";
            // 
            // lbxInfoStatus
            // 
            this.lbxInfoStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxInfoStatus.FormattingEnabled = true;
            this.lbxInfoStatus.ItemHeight = 16;
            this.lbxInfoStatus.Location = new System.Drawing.Point(45, 651);
            this.lbxInfoStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lbxInfoStatus.Name = "lbxInfoStatus";
            this.lbxInfoStatus.Size = new System.Drawing.Size(1379, 196);
            this.lbxInfoStatus.TabIndex = 18;
            // 
            // listViewSysLog
            // 
            this.listViewSysLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewSysLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewColumnPriority,
            this.ViewColumnSeverity,
            this.ViewColumnFacility,
            this.ViewColumnTimeStamp,
            this.ViewColumnSourceIP,
            this.ViewColumnMessage});
            this.listViewSysLog.HideSelection = false;
            this.listViewSysLog.Location = new System.Drawing.Point(45, 332);
            this.listViewSysLog.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSysLog.Name = "listViewSysLog";
            this.listViewSysLog.Size = new System.Drawing.Size(1408, 258);
            this.listViewSysLog.TabIndex = 19;
            this.listViewSysLog.UseCompatibleStateImageBehavior = false;
            this.listViewSysLog.View = System.Windows.Forms.View.Details;
            // 
            // ViewColumnPriority
            // 
            this.ViewColumnPriority.Text = "Priority";
            this.ViewColumnPriority.Width = 69;
            // 
            // ViewColumnSeverity
            // 
            this.ViewColumnSeverity.Text = "Severity";
            this.ViewColumnSeverity.Width = 131;
            // 
            // ViewColumnFacility
            // 
            this.ViewColumnFacility.Text = "Facility";
            this.ViewColumnFacility.Width = 182;
            // 
            // ViewColumnTimeStamp
            // 
            this.ViewColumnTimeStamp.Text = "TimeStamp";
            this.ViewColumnTimeStamp.Width = 270;
            // 
            // ViewColumnSourceIP
            // 
            this.ViewColumnSourceIP.Text = "SourceIP";
            this.ViewColumnSourceIP.Width = 218;
            // 
            // ViewColumnMessage
            // 
            this.ViewColumnMessage.Text = "Message";
            this.ViewColumnMessage.Width = 262;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.AutoSize = true;
            this.btnShowAll.Location = new System.Drawing.Point(603, 266);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 63);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1515, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuOptions
            // 
            this.stripMenuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuSelection});
            this.stripMenuOptions.Name = "stripMenuOptions";
            this.stripMenuOptions.Size = new System.Drawing.Size(75, 24);
            this.stripMenuOptions.Text = "Options";
            // 
            // stripMenuSelection
            // 
            this.stripMenuSelection.Name = "stripMenuSelection";
            this.stripMenuSelection.Size = new System.Drawing.Size(224, 26);
            this.stripMenuSelection.Text = "Selection-Screen";
            this.stripMenuSelection.Click += new System.EventHandler(this.stripMenuSelection_Click);
            // 
            // FormSysLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1515, 1055);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.listViewSysLog);
            this.Controls.Add(this.lbxInfoStatus);
            this.Controls.Add(this.drpBtnSortBy);
            this.Controls.Add(this.btnResetLogs);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.drpBtnSearchIn);
            this.Controls.Add(this.cbxBubbleSort);
            this.Controls.Add(this.cbxDescending);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnImportCsv);
            this.Controls.Add(this.btnExportBin);
            this.Controls.Add(this.btnImportBin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSysLog";
            this.Text = "SysLogForm";
            this.Load += new System.EventHandler(this.FormSysLogTCP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnImportBin;
        private System.Windows.Forms.Button btnExportBin;
        private System.Windows.Forms.Button btnImportCsv;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.CheckBox cbxDescending;
        private System.Windows.Forms.CheckBox cbxBubbleSort;
        private System.Windows.Forms.ComboBox drpBtnSearchIn;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnResetLogs;
        private System.Windows.Forms.ComboBox drpBtnSortBy;
        private System.Windows.Forms.ListBox lbxInfoStatus;
        private System.Windows.Forms.ListView listViewSysLog;
        private System.Windows.Forms.ColumnHeader ViewColumnPriority;
        private System.Windows.Forms.ColumnHeader ViewColumnSeverity;
        private System.Windows.Forms.ColumnHeader ViewColumnFacility;
        private System.Windows.Forms.ColumnHeader ViewColumnTimeStamp;
        private System.Windows.Forms.ColumnHeader ViewColumnSourceIP;
        private System.Windows.Forms.ColumnHeader ViewColumnMessage;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem stripMenuSelection;
    }
}

