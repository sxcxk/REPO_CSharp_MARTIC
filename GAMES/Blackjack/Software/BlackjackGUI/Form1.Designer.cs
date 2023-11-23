namespace BlackjackGUI
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
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbxPlayer4 = new System.Windows.Forms.PictureBox();
            this.pbxStack = new System.Windows.Forms.PictureBox();
            this.pbxPlayer3 = new System.Windows.Forms.PictureBox();
            this.pbxPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblStack = new System.Windows.Forms.Label();
            this.lblStackCount = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblHand1 = new System.Windows.Forms.Label();
            this.lblHand4 = new System.Windows.Forms.Label();
            this.lblHand3 = new System.Windows.Forms.Label();
            this.lblHand2 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.Location = new System.Drawing.Point(82, 25);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(120, 150);
            this.pbxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlayer1.TabIndex = 0;
            this.pbxPlayer1.TabStop = false;
            this.pbxPlayer1.Click += new System.EventHandler(this.pbxPlayer1_Click);
            // 
            // pbxPlayer4
            // 
            this.pbxPlayer4.Location = new System.Drawing.Point(586, 25);
            this.pbxPlayer4.Name = "pbxPlayer4";
            this.pbxPlayer4.Size = new System.Drawing.Size(120, 150);
            this.pbxPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlayer4.TabIndex = 1;
            this.pbxPlayer4.TabStop = false;
            // 
            // pbxStack
            // 
            this.pbxStack.Location = new System.Drawing.Point(305, 267);
            this.pbxStack.Name = "pbxStack";
            this.pbxStack.Size = new System.Drawing.Size(120, 150);
            this.pbxStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStack.TabIndex = 2;
            this.pbxStack.TabStop = false;
            this.pbxStack.Click += new System.EventHandler(this.pbxStack_Click);
            // 
            // pbxPlayer3
            // 
            this.pbxPlayer3.Location = new System.Drawing.Point(424, 25);
            this.pbxPlayer3.Name = "pbxPlayer3";
            this.pbxPlayer3.Size = new System.Drawing.Size(120, 150);
            this.pbxPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlayer3.TabIndex = 3;
            this.pbxPlayer3.TabStop = false;
            // 
            // pbxPlayer2
            // 
            this.pbxPlayer2.Location = new System.Drawing.Point(245, 25);
            this.pbxPlayer2.Name = "pbxPlayer2";
            this.pbxPlayer2.Size = new System.Drawing.Size(120, 150);
            this.pbxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlayer2.TabIndex = 4;
            this.pbxPlayer2.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(123, 11);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(49, 13);
            this.lblPlayer1.TabIndex = 5;
            this.lblPlayer1.Text = "Player1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(288, 9);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(49, 13);
            this.lblPlayer2.TabIndex = 6;
            this.lblPlayer2.Text = "Player2";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.Location = new System.Drawing.Point(462, 9);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(49, 13);
            this.lblPlayer3.TabIndex = 7;
            this.lblPlayer3.Text = "Player3";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4.Location = new System.Drawing.Point(627, 9);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(49, 13);
            this.lblPlayer4.TabIndex = 8;
            this.lblPlayer4.Text = "Player4";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStack.Location = new System.Drawing.Point(483, 306);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(105, 13);
            this.lblStack.TabIndex = 9;
            this.lblStack.Text = "Karten am Stack:";
            // 
            // lblStackCount
            // 
            this.lblStackCount.AutoSize = true;
            this.lblStackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStackCount.Location = new System.Drawing.Point(500, 329);
            this.lblStackCount.Name = "lblStackCount";
            this.lblStackCount.Size = new System.Drawing.Size(14, 13);
            this.lblStackCount.TabIndex = 10;
            this.lblStackCount.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(149, 287);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblHand1
            // 
            this.lblHand1.AutoSize = true;
            this.lblHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand1.Location = new System.Drawing.Point(102, 178);
            this.lblHand1.Name = "lblHand1";
            this.lblHand1.Size = new System.Drawing.Size(41, 13);
            this.lblHand1.TabIndex = 15;
            this.lblHand1.Text = "Hand:";
            // 
            // lblHand4
            // 
            this.lblHand4.AutoSize = true;
            this.lblHand4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand4.Location = new System.Drawing.Point(596, 178);
            this.lblHand4.Name = "lblHand4";
            this.lblHand4.Size = new System.Drawing.Size(41, 13);
            this.lblHand4.TabIndex = 17;
            this.lblHand4.Text = "Hand:";
            // 
            // lblHand3
            // 
            this.lblHand3.AutoSize = true;
            this.lblHand3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand3.Location = new System.Drawing.Point(434, 178);
            this.lblHand3.Name = "lblHand3";
            this.lblHand3.Size = new System.Drawing.Size(41, 13);
            this.lblHand3.TabIndex = 18;
            this.lblHand3.Text = "Hand:";
            // 
            // lblHand2
            // 
            this.lblHand2.AutoSize = true;
            this.lblHand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand2.Location = new System.Drawing.Point(263, 178);
            this.lblHand2.Name = "lblHand2";
            this.lblHand2.Size = new System.Drawing.Size(41, 13);
            this.lblHand2.TabIndex = 19;
            this.lblHand2.Text = "Hand:";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(305, 178);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(14, 13);
            this.lblValue2.TabIndex = 20;
            this.lblValue2.Text = "0";
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue3.Location = new System.Drawing.Point(476, 178);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(14, 13);
            this.lblValue3.TabIndex = 21;
            this.lblValue3.Text = "0";
            // 
            // lblValue4
            // 
            this.lblValue4.AutoSize = true;
            this.lblValue4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue4.Location = new System.Drawing.Point(638, 178);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(14, 13);
            this.lblValue4.TabIndex = 22;
            this.lblValue4.Text = "0";
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(146, 178);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(14, 13);
            this.lblValue1.TabIndex = 23;
            this.lblValue1.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.lblValue4);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblHand2);
            this.Controls.Add(this.lblHand3);
            this.Controls.Add(this.lblHand4);
            this.Controls.Add(this.lblHand1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblStackCount);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pbxPlayer2);
            this.Controls.Add(this.pbxPlayer3);
            this.Controls.Add(this.pbxStack);
            this.Controls.Add(this.pbxPlayer4);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlayer1;
        private System.Windows.Forms.PictureBox pbxPlayer4;
        private System.Windows.Forms.PictureBox pbxStack;
        private System.Windows.Forms.PictureBox pbxPlayer3;
        private System.Windows.Forms.PictureBox pbxPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.Label lblStackCount;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblHand1;
        private System.Windows.Forms.Label lblHand4;
        private System.Windows.Forms.Label lblHand3;
        private System.Windows.Forms.Label lblHand2;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.Label lblValue4;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

