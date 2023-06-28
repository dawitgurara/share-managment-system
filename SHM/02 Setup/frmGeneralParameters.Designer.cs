namespace SHM
{
    partial class frmGeneralParameters
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
            System.Windows.Forms.Label PerOfDividTGBFlabel;
            System.Windows.Forms.Label PercOfDividToLBFLabel;
            System.Windows.Forms.Label PercOfSHSupsdToAtndEmrgMeetingLabel;
            System.Windows.Forms.Label PercOfSHSupsdToAtndRegMeetingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralParameters));
            this.tspGeneralParam = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PercOfDividToGBFTextBox = new System.Windows.Forms.TextBox();
            this.PercOfDividToLBFTextBox = new System.Windows.Forms.TextBox();
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox = new System.Windows.Forms.TextBox();
            this.PercOfSHSupsdToAtndRegMeetingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            PerOfDividTGBFlabel = new System.Windows.Forms.Label();
            PercOfDividToLBFLabel = new System.Windows.Forms.Label();
            PercOfSHSupsdToAtndEmrgMeetingLabel = new System.Windows.Forms.Label();
            PercOfSHSupsdToAtndRegMeetingLabel = new System.Windows.Forms.Label();
            this.tspGeneralParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // PerOfDividTGBFlabel
            // 
            PerOfDividTGBFlabel.AutoSize = true;
            PerOfDividTGBFlabel.Location = new System.Drawing.Point(96, 74);
            PerOfDividTGBFlabel.Name = "PerOfDividTGBFlabel";
            PerOfDividTGBFlabel.Size = new System.Drawing.Size(119, 13);
            PerOfDividTGBFlabel.TabIndex = 174;
            PerOfDividTGBFlabel.Text = "Per of Dividend to GBF:";
            // 
            // PercOfDividToLBFLabel
            // 
            PercOfDividToLBFLabel.AutoSize = true;
            PercOfDividToLBFLabel.Location = new System.Drawing.Point(92, 48);
            PercOfDividToLBFLabel.Name = "PercOfDividToLBFLabel";
            PercOfDividToLBFLabel.Size = new System.Drawing.Size(123, 13);
            PercOfDividToLBFLabel.TabIndex = 169;
            PercOfDividToLBFLabel.Text = "Perc of Dividend to LBF:";
            // 
            // PercOfSHSupsdToAtndEmrgMeetingLabel
            // 
            PercOfSHSupsdToAtndEmrgMeetingLabel.AutoSize = true;
            PercOfSHSupsdToAtndEmrgMeetingLabel.Location = new System.Drawing.Point(12, 98);
            PercOfSHSupsdToAtndEmrgMeetingLabel.Name = "PercOfSHSupsdToAtndEmrgMeetingLabel";
            PercOfSHSupsdToAtndEmrgMeetingLabel.Size = new System.Drawing.Size(203, 13);
            PercOfSHSupsdToAtndEmrgMeetingLabel.TabIndex = 170;
            PercOfSHSupsdToAtndEmrgMeetingLabel.Text = "Perc of SH Supsd toAtend Emrg Meeting:";
            // 
            // PercOfSHSupsdToAtndRegMeetingLabel
            // 
            PercOfSHSupsdToAtndRegMeetingLabel.AutoSize = true;
            PercOfSHSupsdToAtndRegMeetingLabel.Location = new System.Drawing.Point(16, 123);
            PercOfSHSupsdToAtndRegMeetingLabel.Name = "PercOfSHSupsdToAtndRegMeetingLabel";
            PercOfSHSupsdToAtndRegMeetingLabel.Size = new System.Drawing.Size(199, 13);
            PercOfSHSupsdToAtndRegMeetingLabel.TabIndex = 171;
            PercOfSHSupsdToAtndRegMeetingLabel.Text = "Perc of SH Supsd toAtend Reg Meeting:";
            // 
            // tspGeneralParam
            // 
            this.tspGeneralParam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspGeneralParam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspGeneralParam.Location = new System.Drawing.Point(0, 0);
            this.tspGeneralParam.Name = "tspGeneralParam";
            this.tspGeneralParam.Size = new System.Drawing.Size(451, 25);
            this.tspGeneralParam.TabIndex = 3;
            this.tspGeneralParam.TabStop = true;
            this.tspGeneralParam.Text = "toolStrip1";
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
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Visible = false;
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton.Text = "&Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // PercOfDividToGBFTextBox
            // 
            this.PercOfDividToGBFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercOfDividToGBFTextBox.Location = new System.Drawing.Point(217, 70);
            this.PercOfDividToGBFTextBox.Name = "PercOfDividToGBFTextBox";
            this.PercOfDividToGBFTextBox.Size = new System.Drawing.Size(136, 20);
            this.PercOfDividToGBFTextBox.TabIndex = 173;
            this.PercOfDividToGBFTextBox.TabStop = false;
            // 
            // PercOfDividToLBFTextBox
            // 
            this.PercOfDividToLBFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercOfDividToLBFTextBox.Location = new System.Drawing.Point(217, 44);
            this.PercOfDividToLBFTextBox.Name = "PercOfDividToLBFTextBox";
            this.PercOfDividToLBFTextBox.Size = new System.Drawing.Size(136, 20);
            this.PercOfDividToLBFTextBox.TabIndex = 161;
            this.PercOfDividToLBFTextBox.TabStop = false;
            // 
            // PercOfSHSupsdToAtndEmrgMeetingTextBox
            // 
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.Location = new System.Drawing.Point(217, 94);
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.Name = "PercOfSHSupsdToAtndEmrgMeetingTextBox";
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.Size = new System.Drawing.Size(136, 20);
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.TabIndex = 162;
            this.PercOfSHSupsdToAtndEmrgMeetingTextBox.TabStop = false;
            // 
            // PercOfSHSupsdToAtndRegMeetingTextBox
            // 
            this.PercOfSHSupsdToAtndRegMeetingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercOfSHSupsdToAtndRegMeetingTextBox.Location = new System.Drawing.Point(217, 120);
            this.PercOfSHSupsdToAtndRegMeetingTextBox.Name = "PercOfSHSupsdToAtndRegMeetingTextBox";
            this.PercOfSHSupsdToAtndRegMeetingTextBox.Size = new System.Drawing.Size(136, 20);
            this.PercOfSHSupsdToAtndRegMeetingTextBox.TabIndex = 165;
            this.PercOfSHSupsdToAtndRegMeetingTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 175;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 176;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 177;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "%";
            // 
            // frmGeneralParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(451, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(PerOfDividTGBFlabel);
            this.Controls.Add(this.PercOfDividToGBFTextBox);
            this.Controls.Add(PercOfDividToLBFLabel);
            this.Controls.Add(PercOfSHSupsdToAtndEmrgMeetingLabel);
            this.Controls.Add(PercOfSHSupsdToAtndRegMeetingLabel);
            this.Controls.Add(this.PercOfDividToLBFTextBox);
            this.Controls.Add(this.PercOfSHSupsdToAtndEmrgMeetingTextBox);
            this.Controls.Add(this.PercOfSHSupsdToAtndRegMeetingTextBox);
            this.Controls.Add(this.tspGeneralParam);
            this.Name = "frmGeneralParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Parameters";
            this.Load += new System.EventHandler(this.frmGeneralParameters_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCompany_KeyDown);
            this.tspGeneralParam.ResumeLayout(false);
            this.tspGeneralParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspGeneralParam;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.TextBox PercOfDividToGBFTextBox;
        private System.Windows.Forms.TextBox PercOfDividToLBFTextBox;
        private System.Windows.Forms.TextBox PercOfSHSupsdToAtndEmrgMeetingTextBox;
        private System.Windows.Forms.TextBox PercOfSHSupsdToAtndRegMeetingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}