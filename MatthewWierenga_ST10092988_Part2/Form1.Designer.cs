namespace MatthewWierenga_ST10092988_Part2
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.gbxAttack = new System.Windows.Forms.GroupBox();
            this.rtbAttackLog = new System.Windows.Forms.RichTextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.rtbSelectedEnemy = new System.Windows.Forms.RichTextBox();
            this.cbxEnemies = new System.Windows.Forms.ComboBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.gbxAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(887, 527);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(31, 23);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(813, 527);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 23);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(850, 549);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(31, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(850, 507);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(31, 23);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // gbxAttack
            // 
            this.gbxAttack.Controls.Add(this.rtbAttackLog);
            this.gbxAttack.Controls.Add(this.btnAttack);
            this.gbxAttack.Controls.Add(this.rtbSelectedEnemy);
            this.gbxAttack.Controls.Add(this.cbxEnemies);
            this.gbxAttack.Location = new System.Drawing.Point(749, 221);
            this.gbxAttack.Name = "gbxAttack";
            this.gbxAttack.Size = new System.Drawing.Size(215, 269);
            this.gbxAttack.TabIndex = 9;
            this.gbxAttack.TabStop = false;
            this.gbxAttack.Text = "Attacking";
            // 
            // rtbAttackLog
            // 
            this.rtbAttackLog.Location = new System.Drawing.Point(7, 192);
            this.rtbAttackLog.Name = "rtbAttackLog";
            this.rtbAttackLog.Size = new System.Drawing.Size(208, 77);
            this.rtbAttackLog.TabIndex = 3;
            this.rtbAttackLog.Text = "";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(7, 162);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(208, 23);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // rtbSelectedEnemy
            // 
            this.rtbSelectedEnemy.Location = new System.Drawing.Point(7, 48);
            this.rtbSelectedEnemy.Name = "rtbSelectedEnemy";
            this.rtbSelectedEnemy.Size = new System.Drawing.Size(208, 96);
            this.rtbSelectedEnemy.TabIndex = 1;
            this.rtbSelectedEnemy.Text = "";
            // 
            // cbxEnemies
            // 
            this.cbxEnemies.FormattingEnabled = true;
            this.cbxEnemies.Location = new System.Drawing.Point(7, 20);
            this.cbxEnemies.Name = "cbxEnemies";
            this.cbxEnemies.Size = new System.Drawing.Size(208, 21);
            this.cbxEnemies.TabIndex = 0;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(749, 88);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(215, 96);
            this.rtbInfo.TabIndex = 8;
            this.rtbInfo.Text = "";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(244, 94);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(35, 13);
            this.lblMap.TabIndex = 7;
            this.lblMap.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 661);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.gbxAttack);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAttack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox gbxAttack;
        private System.Windows.Forms.RichTextBox rtbAttackLog;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.RichTextBox rtbSelectedEnemy;
        private System.Windows.Forms.ComboBox cbxEnemies;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lblMap;
    }
}

