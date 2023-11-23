namespace SysLogServer.Gui
{
    partial class FormSelectionTCPUDP
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtnUDP = new System.Windows.Forms.RadioButton();
            this.rbtnTCP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(308, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select a server type:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(335, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 54);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtnUDP
            // 
            this.rbtnUDP.AutoSize = true;
            this.rbtnUDP.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUDP.Location = new System.Drawing.Point(390, 174);
            this.rbtnUDP.Name = "rbtnUDP";
            this.rbtnUDP.Size = new System.Drawing.Size(85, 37);
            this.rbtnUDP.TabIndex = 5;
            this.rbtnUDP.Text = "UDP";
            this.rbtnUDP.UseVisualStyleBackColor = true;
            this.rbtnUDP.CheckedChanged += new System.EventHandler(this.rbtnUDP_CheckedChanged);
            // 
            // rbtnTCP
            // 
            this.rbtnTCP.AutoSize = true;
            this.rbtnTCP.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTCP.Location = new System.Drawing.Point(390, 217);
            this.rbtnTCP.Name = "rbtnTCP";
            this.rbtnTCP.Size = new System.Drawing.Size(82, 37);
            this.rbtnTCP.TabIndex = 6;
            this.rbtnTCP.TabStop = true;
            this.rbtnTCP.Text = "TCP";
            this.rbtnTCP.UseVisualStyleBackColor = true;
            this.rbtnTCP.CheckedChanged += new System.EventHandler(this.rbtnTCP_CheckedChanged_1);
            // 
            // SelectionTCPUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 582);
            this.Controls.Add(this.rbtnTCP);
            this.Controls.Add(this.rbtnUDP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Name = "SelectionTCPUDP";
            this.Text = "FormSelectionTCPUDP";
            this.Load += new System.EventHandler(this.SelectionTCPUDP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbtnUDP;
        private System.Windows.Forms.RadioButton rbtnTCP;
    }
}