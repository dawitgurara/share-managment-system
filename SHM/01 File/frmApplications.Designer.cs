namespace SHM
{
    partial class frmApplications
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
            System.Windows.Forms.Label appNameLabel1;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label currentPeriodLabel;
            System.Windows.Forms.Label maximumPeriodLabel;
            System.Windows.Forms.Label appPathLabel;
            System.Windows.Forms.Label dataPathLabel;
            System.Windows.Forms.Label reportPathLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplications));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaximumPeriodTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.currentPeriodLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.appPathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.dataPathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.reportPathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.tspApplications = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.periodEndToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fbdApplications = new System.Windows.Forms.FolderBrowserDialog();
            appNameLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            currentPeriodLabel = new System.Windows.Forms.Label();
            maximumPeriodLabel = new System.Windows.Forms.Label();
            appPathLabel = new System.Windows.Forms.Label();
            dataPathLabel = new System.Windows.Forms.Label();
            reportPathLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPeriodLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPathButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPathButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPathButtonEdit.Properties)).BeginInit();
            this.tspApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel1
            // 
            appNameLabel1.AutoSize = true;
            appNameLabel1.Location = new System.Drawing.Point(76, 33);
            appNameLabel1.Name = "appNameLabel1";
            appNameLabel1.Size = new System.Drawing.Size(38, 13);
            appNameLabel1.TabIndex = 0;
            appNameLabel1.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(51, 59);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // currentPeriodLabel
            // 
            currentPeriodLabel.AutoSize = true;
            currentPeriodLabel.Location = new System.Drawing.Point(37, 85);
            currentPeriodLabel.Name = "currentPeriodLabel";
            currentPeriodLabel.Size = new System.Drawing.Size(77, 13);
            currentPeriodLabel.TabIndex = 4;
            currentPeriodLabel.Text = "Current Period:";
            // 
            // maximumPeriodLabel
            // 
            maximumPeriodLabel.AutoSize = true;
            maximumPeriodLabel.Location = new System.Drawing.Point(280, 86);
            maximumPeriodLabel.Name = "maximumPeriodLabel";
            maximumPeriodLabel.Size = new System.Drawing.Size(87, 13);
            maximumPeriodLabel.TabIndex = 6;
            maximumPeriodLabel.Text = "Maximum Period:";
            // 
            // appPathLabel
            // 
            appPathLabel.AutoSize = true;
            appPathLabel.Location = new System.Drawing.Point(60, 111);
            appPathLabel.Name = "appPathLabel";
            appPathLabel.Size = new System.Drawing.Size(54, 13);
            appPathLabel.TabIndex = 10;
            appPathLabel.Text = "App Path:";
            // 
            // dataPathLabel
            // 
            dataPathLabel.AutoSize = true;
            dataPathLabel.Location = new System.Drawing.Point(56, 137);
            dataPathLabel.Name = "dataPathLabel";
            dataPathLabel.Size = new System.Drawing.Size(58, 13);
            dataPathLabel.TabIndex = 12;
            dataPathLabel.Text = "Data Path:";
            // 
            // reportPathLabel
            // 
            reportPathLabel.AutoSize = true;
            reportPathLabel.Location = new System.Drawing.Point(51, 163);
            reportPathLabel.Name = "reportPathLabel";
            reportPathLabel.Size = new System.Drawing.Size(67, 13);
            reportPathLabel.TabIndex = 14;
            reportPathLabel.Text = "Report Path:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaximumPeriodTextBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.appNameTextBox);
            this.groupBox1.Controls.Add(appNameLabel1);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(currentPeriodLabel);
            this.groupBox1.Controls.Add(this.currentPeriodLookUpEdit);
            this.groupBox1.Controls.Add(maximumPeriodLabel);
            this.groupBox1.Controls.Add(appPathLabel);
            this.groupBox1.Controls.Add(this.appPathButtonEdit);
            this.groupBox1.Controls.Add(dataPathLabel);
            this.groupBox1.Controls.Add(this.dataPathButtonEdit);
            this.groupBox1.Controls.Add(reportPathLabel);
            this.groupBox1.Controls.Add(this.reportPathButtonEdit);
            this.groupBox1.Location = new System.Drawing.Point(79, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Detail";
            // 
            // MaximumPeriodTextBox
            // 
            this.MaximumPeriodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaximumPeriodTextBox.Location = new System.Drawing.Point(370, 83);
            this.MaximumPeriodTextBox.Name = "MaximumPeriodTextBox";
            this.MaximumPeriodTextBox.Size = new System.Drawing.Size(122, 20);
            this.MaximumPeriodTextBox.TabIndex = 24;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 57);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(244, 20);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appNameTextBox.Location = new System.Drawing.Point(120, 31);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.appNameTextBox.TabIndex = 22;
            // 
            // currentPeriodLookUpEdit
            // 
            this.currentPeriodLookUpEdit.Location = new System.Drawing.Point(120, 82);
            this.currentPeriodLookUpEdit.Name = "currentPeriodLookUpEdit";
            this.currentPeriodLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.currentPeriodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currentPeriodLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YearPeriodName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.currentPeriodLookUpEdit.Properties.DisplayMember = "YearPeriodName";
            this.currentPeriodLookUpEdit.Properties.NullText = "";
            this.currentPeriodLookUpEdit.Properties.ReadOnly = true;
            this.currentPeriodLookUpEdit.Properties.ValueMember = "YearPeriod";
            this.currentPeriodLookUpEdit.Size = new System.Drawing.Size(134, 20);
            this.currentPeriodLookUpEdit.TabIndex = 5;
            // 
            // appPathButtonEdit
            // 
            this.appPathButtonEdit.Location = new System.Drawing.Point(120, 108);
            this.appPathButtonEdit.Name = "appPathButtonEdit";
            this.appPathButtonEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.appPathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.appPathButtonEdit.Size = new System.Drawing.Size(372, 20);
            this.appPathButtonEdit.TabIndex = 11;
            this.appPathButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.appPathButtonEdit_ButtonClick);
            // 
            // dataPathButtonEdit
            // 
            this.dataPathButtonEdit.Location = new System.Drawing.Point(120, 134);
            this.dataPathButtonEdit.Name = "dataPathButtonEdit";
            this.dataPathButtonEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataPathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dataPathButtonEdit.Size = new System.Drawing.Size(372, 20);
            this.dataPathButtonEdit.TabIndex = 13;
            this.dataPathButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dataPathButtonEdit_ButtonClick);
            // 
            // reportPathButtonEdit
            // 
            this.reportPathButtonEdit.Location = new System.Drawing.Point(120, 160);
            this.reportPathButtonEdit.Name = "reportPathButtonEdit";
            this.reportPathButtonEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.reportPathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.reportPathButtonEdit.Size = new System.Drawing.Size(372, 20);
            this.reportPathButtonEdit.TabIndex = 15;
            this.reportPathButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reportPathButtonEdit_ButtonClick);
            // 
            // tspApplications
            // 
            this.tspApplications.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.refreshToolStripButton1,
            this.periodEndToolStripButton});
            this.tspApplications.Location = new System.Drawing.Point(0, 0);
            this.tspApplications.Name = "tspApplications";
            this.tspApplications.Size = new System.Drawing.Size(697, 25);
            this.tspApplications.TabIndex = 2;
            this.tspApplications.TabStop = true;
            this.tspApplications.Text = "toolStrip1";
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
            this.refreshToolStripButton1.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // periodEndToolStripButton
            // 
            this.periodEndToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("periodEndToolStripButton.Image")));
            this.periodEndToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.periodEndToolStripButton.Name = "periodEndToolStripButton";
            this.periodEndToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.periodEndToolStripButton.Text = "Period End";
            this.periodEndToolStripButton.Click += new System.EventHandler(this.periodEndToolStripButton_Click);
            // 
            // frmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(697, 268);
            this.Controls.Add(this.tspApplications);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applications Detail Entry Form";
            this.Load += new System.EventHandler(this.frmApplications_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPeriodLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPathButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPathButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPathButtonEdit.Properties)).EndInit();
            this.tspApplications.ResumeLayout(false);
            this.tspApplications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit currentPeriodLookUpEdit;
        private DevExpress.XtraEditors.ButtonEdit appPathButtonEdit;
        private DevExpress.XtraEditors.ButtonEdit dataPathButtonEdit;
        private DevExpress.XtraEditors.ButtonEdit reportPathButtonEdit;
        private System.Windows.Forms.ToolStrip tspApplications;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton1;
        private System.Windows.Forms.ToolStripButton periodEndToolStripButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.TextBox MaximumPeriodTextBox;
        private System.Windows.Forms.FolderBrowserDialog fbdApplications;
    }
}