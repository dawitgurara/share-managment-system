namespace SHM
{
    partial class frmDefaults
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
            System.Windows.Forms.Label passwordExpiryDaysLabel;
            System.Windows.Forms.Label minimumPwdLengthLabel;
            System.Windows.Forms.Label noOfUnsuccessAttemptLabel;
            System.Windows.Forms.Label gracelogInLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefaults));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasswordExpiryDaysTextBox = new System.Windows.Forms.TextBox();
            this.MinimumPwdLengthTextBox = new System.Windows.Forms.TextBox();
            this.NoOfUnsuccessAttemptTextBox = new System.Windows.Forms.TextBox();
            this.GraceLoginsTextBox = new System.Windows.Forms.TextBox();
            this.tspDefaults = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            passwordExpiryDaysLabel = new System.Windows.Forms.Label();
            minimumPwdLengthLabel = new System.Windows.Forms.Label();
            noOfUnsuccessAttemptLabel = new System.Windows.Forms.Label();
            gracelogInLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tspDefaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordExpiryDaysLabel
            // 
            passwordExpiryDaysLabel.AutoSize = true;
            passwordExpiryDaysLabel.BackColor = System.Drawing.SystemColors.Control;
            passwordExpiryDaysLabel.Location = new System.Drawing.Point(31, 36);
            passwordExpiryDaysLabel.Name = "passwordExpiryDaysLabel";
            passwordExpiryDaysLabel.Size = new System.Drawing.Size(114, 13);
            passwordExpiryDaysLabel.TabIndex = 2;
            passwordExpiryDaysLabel.Text = "Password Expiry Days:";
            // 
            // minimumPwdLengthLabel
            // 
            minimumPwdLengthLabel.AutoSize = true;
            minimumPwdLengthLabel.Location = new System.Drawing.Point(9, 62);
            minimumPwdLengthLabel.Name = "minimumPwdLengthLabel";
            minimumPwdLengthLabel.Size = new System.Drawing.Size(136, 13);
            minimumPwdLengthLabel.TabIndex = 4;
            minimumPwdLengthLabel.Text = "Minimum Password Length:";
            // 
            // noOfUnsuccessAttemptLabel
            // 
            noOfUnsuccessAttemptLabel.AutoSize = true;
            noOfUnsuccessAttemptLabel.Location = new System.Drawing.Point(271, 36);
            noOfUnsuccessAttemptLabel.Name = "noOfUnsuccessAttemptLabel";
            noOfUnsuccessAttemptLabel.Size = new System.Drawing.Size(142, 13);
            noOfUnsuccessAttemptLabel.TabIndex = 6;
            noOfUnsuccessAttemptLabel.Text = "No of Unsuccessful Attempt:";
            // 
            // gracelogInLabel
            // 
            gracelogInLabel.AutoSize = true;
            gracelogInLabel.Location = new System.Drawing.Point(347, 61);
            gracelogInLabel.Name = "gracelogInLabel";
            gracelogInLabel.Size = new System.Drawing.Size(67, 13);
            gracelogInLabel.TabIndex = 8;
            gracelogInLabel.Text = "Grace log in:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(passwordExpiryDaysLabel);
            this.groupBox1.Controls.Add(this.PasswordExpiryDaysTextBox);
            this.groupBox1.Controls.Add(minimumPwdLengthLabel);
            this.groupBox1.Controls.Add(this.MinimumPwdLengthTextBox);
            this.groupBox1.Controls.Add(noOfUnsuccessAttemptLabel);
            this.groupBox1.Controls.Add(this.NoOfUnsuccessAttemptTextBox);
            this.groupBox1.Controls.Add(gracelogInLabel);
            this.groupBox1.Controls.Add(this.GraceLoginsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // PasswordExpiryDaysTextBox
            // 
            this.PasswordExpiryDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordExpiryDaysTextBox.Location = new System.Drawing.Point(150, 33);
            this.PasswordExpiryDaysTextBox.Name = "PasswordExpiryDaysTextBox";
            this.PasswordExpiryDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordExpiryDaysTextBox.TabIndex = 3;
            // 
            // MinimumPwdLengthTextBox
            // 
            this.MinimumPwdLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinimumPwdLengthTextBox.Location = new System.Drawing.Point(150, 59);
            this.MinimumPwdLengthTextBox.Name = "MinimumPwdLengthTextBox";
            this.MinimumPwdLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumPwdLengthTextBox.TabIndex = 5;
            // 
            // NoOfUnsuccessAttemptTextBox
            // 
            this.NoOfUnsuccessAttemptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoOfUnsuccessAttemptTextBox.Location = new System.Drawing.Point(416, 33);
            this.NoOfUnsuccessAttemptTextBox.Name = "NoOfUnsuccessAttemptTextBox";
            this.NoOfUnsuccessAttemptTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoOfUnsuccessAttemptTextBox.TabIndex = 7;
            // 
            // GraceLoginsTextBox
            // 
            this.GraceLoginsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraceLoginsTextBox.Location = new System.Drawing.Point(416, 59);
            this.GraceLoginsTextBox.Name = "GraceLoginsTextBox";
            this.GraceLoginsTextBox.Size = new System.Drawing.Size(100, 20);
            this.GraceLoginsTextBox.TabIndex = 9;
            // 
            // tspDefaults
            // 
            this.tspDefaults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspDefaults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.refreshToolStripButton1});
            this.tspDefaults.Location = new System.Drawing.Point(0, 0);
            this.tspDefaults.Name = "tspDefaults";
            this.tspDefaults.Size = new System.Drawing.Size(617, 25);
            this.tspDefaults.TabIndex = 2;
            this.tspDefaults.TabStop = true;
            this.tspDefaults.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // refreshToolStripButton1
            // 
            this.refreshToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton1.Image")));
            this.refreshToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton1.Name = "refreshToolStripButton1";
            this.refreshToolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton1.Text = "&Refresh";
            this.refreshToolStripButton1.Click += new System.EventHandler(this.refreshToolStripButton1_Click);
            // 
            // frmDefaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(617, 188);
            this.Controls.Add(this.tspDefaults);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDefaults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Default Values Entry Form";
            this.Load += new System.EventHandler(this.frmDefaults_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDefaults_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tspDefaults.ResumeLayout(false);
            this.tspDefaults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PasswordExpiryDaysTextBox;
        private System.Windows.Forms.TextBox MinimumPwdLengthTextBox;
        private System.Windows.Forms.TextBox NoOfUnsuccessAttemptTextBox;
        private System.Windows.Forms.TextBox GraceLoginsTextBox;
        private System.Windows.Forms.ToolStrip tspDefaults;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton1;
    }
}