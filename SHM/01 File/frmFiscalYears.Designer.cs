namespace SHM
{
    partial class frmFiscalYears
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
            System.Windows.Forms.Label fiscalYearLabel;
            System.Windows.Forms.Label fiscalYearLabel1;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label startDateEthLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label endDateEthLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiscalYears));
            this.tspFiscalYears = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fiscalYearTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateEthTextBox = new System.Windows.Forms.TextBox();
            this.endDateEthTextBox = new System.Windows.Forms.TextBox();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            fiscalYearLabel = new System.Windows.Forms.Label();
            fiscalYearLabel1 = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            startDateEthLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            endDateEthLabel = new System.Windows.Forms.Label();
            this.tspFiscalYears.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fiscalYearLabel
            // 
            fiscalYearLabel.AutoSize = true;
            fiscalYearLabel.Location = new System.Drawing.Point(18, 43);
            fiscalYearLabel.Name = "fiscalYearLabel";
            fiscalYearLabel.Size = new System.Drawing.Size(114, 13);
            fiscalYearLabel.TabIndex = 32;
            fiscalYearLabel.Text = "Selected Budget Year:";
            // 
            // fiscalYearLabel1
            // 
            fiscalYearLabel1.AutoSize = true;
            fiscalYearLabel1.Location = new System.Drawing.Point(107, 26);
            fiscalYearLabel1.Name = "fiscalYearLabel1";
            fiscalYearLabel1.Size = new System.Drawing.Size(69, 13);
            fiscalYearLabel1.TabIndex = 42;
            fiscalYearLabel1.Text = "Budget Year:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(85, 52);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(84, 13);
            startDateLabel.TabIndex = 43;
            startDateLabel.Text = "Start Date (Grg):";
            // 
            // startDateEthLabel
            // 
            startDateEthLabel.AutoSize = true;
            startDateEthLabel.Location = new System.Drawing.Point(300, 52);
            startDateEthLabel.Name = "startDateEthLabel";
            startDateEthLabel.Size = new System.Drawing.Size(83, 13);
            startDateEthLabel.TabIndex = 44;
            startDateEthLabel.Text = "Start Date (Eth):";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(88, 77);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(81, 13);
            endDateLabel.TabIndex = 46;
            endDateLabel.Text = "End Date (Grg):";
            // 
            // endDateEthLabel
            // 
            endDateEthLabel.AutoSize = true;
            endDateEthLabel.Location = new System.Drawing.Point(303, 82);
            endDateEthLabel.Name = "endDateEthLabel";
            endDateEthLabel.Size = new System.Drawing.Size(80, 13);
            endDateEthLabel.TabIndex = 47;
            endDateEthLabel.Text = "End Date (Eth):";
            // 
            // tspFiscalYears
            // 
            this.tspFiscalYears.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspFiscalYears.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton1});
            this.tspFiscalYears.Location = new System.Drawing.Point(0, 0);
            this.tspFiscalYears.Name = "tspFiscalYears";
            this.tspFiscalYears.Size = new System.Drawing.Size(582, 25);
            this.tspFiscalYears.TabIndex = 7;
            this.tspFiscalYears.TabStop = true;
            this.tspFiscalYears.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
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
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Enabled = false;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.deleteToolStripButton.Text = "De&lete";
            this.deleteToolStripButton.Visible = false;
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Visible = false;
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
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
            // fiscalYearLookUpEdit
            // 
            this.fiscalYearLookUpEdit.Location = new System.Drawing.Point(131, 39);
            this.fiscalYearLookUpEdit.Name = "fiscalYearLookUpEdit";
            this.fiscalYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fiscalYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fiscalYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 15),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDateEth", "Start Date (Eth)", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EndDateEth", "End Date (Eth)", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Closed", "Closed", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.fiscalYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.fiscalYearLookUpEdit.Properties.NullText = "";
            this.fiscalYearLookUpEdit.Properties.PopupWidth = 350;
            this.fiscalYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.fiscalYearLookUpEdit.Size = new System.Drawing.Size(318, 20);
            this.fiscalYearLookUpEdit.TabIndex = 30;
            this.fiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.fiscalYearLookUpEdit_EditValueChanged);
            // 
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(455, 39);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 31;
            this.chkYearAll.CheckedChanged += new System.EventHandler(this.chkYearAll_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fiscalYearTextBox);
            this.groupBox1.Controls.Add(this.endDateDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateDateTimePicker);
            this.groupBox1.Controls.Add(fiscalYearLabel1);
            this.groupBox1.Controls.Add(startDateLabel);
            this.groupBox1.Controls.Add(startDateEthLabel);
            this.groupBox1.Controls.Add(this.startDateEthTextBox);
            this.groupBox1.Controls.Add(endDateLabel);
            this.groupBox1.Controls.Add(endDateEthLabel);
            this.groupBox1.Controls.Add(this.endDateEthTextBox);
            this.groupBox1.Controls.Add(this.closedCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 114);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BudetYear Detail ";
            // 
            // fiscalYearTextBox
            // 
            this.fiscalYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiscalYearTextBox.Location = new System.Drawing.Point(175, 24);
            this.fiscalYearTextBox.Name = "fiscalYearTextBox";
            this.fiscalYearTextBox.ReadOnly = true;
            this.fiscalYearTextBox.Size = new System.Drawing.Size(108, 20);
            this.fiscalYearTextBox.TabIndex = 153;
            this.fiscalYearTextBox.TabStop = false;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(175, 76);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.endDateDateTimePicker.TabIndex = 152;
            this.endDateDateTimePicker.Value = new System.DateTime(2017, 9, 9, 0, 0, 0, 0);
            this.endDateDateTimePicker.Validated += new System.EventHandler(this.endDateDateTimePicker_Validated);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(175, 50);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.startDateDateTimePicker.TabIndex = 151;
            this.startDateDateTimePicker.Value = new System.DateTime(2017, 9, 9, 0, 0, 0, 0);
            this.startDateDateTimePicker.Validated += new System.EventHandler(this.startDateDateTimePicker_Validated);
            // 
            // startDateEthTextBox
            // 
            this.startDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDateEthTextBox.Location = new System.Drawing.Point(389, 50);
            this.startDateEthTextBox.Name = "startDateEthTextBox";
            this.startDateEthTextBox.ReadOnly = true;
            this.startDateEthTextBox.Size = new System.Drawing.Size(104, 20);
            this.startDateEthTextBox.TabIndex = 45;
            // 
            // endDateEthTextBox
            // 
            this.endDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDateEthTextBox.Location = new System.Drawing.Point(389, 75);
            this.endDateEthTextBox.Name = "endDateEthTextBox";
            this.endDateEthTextBox.ReadOnly = true;
            this.endDateEthTextBox.Size = new System.Drawing.Size(104, 20);
            this.endDateEthTextBox.TabIndex = 48;
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.Location = new System.Drawing.Point(389, 24);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.closedCheckBox.TabIndex = 41;
            this.closedCheckBox.Text = "Closed";
            this.closedCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmFiscalYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fiscalYearLookUpEdit);
            this.Controls.Add(this.chkYearAll);
            this.Controls.Add(fiscalYearLabel);
            this.Controls.Add(this.tspFiscalYears);
            this.Name = "frmFiscalYears";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiscalYears";
            this.Load += new System.EventHandler(this.frmFiscalYears_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFiscalYears_KeyDown);
            this.tspFiscalYears.ResumeLayout(false);
            this.tspFiscalYears.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspFiscalYears;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton1;
        private DevExpress.XtraEditors.LookUpEdit fiscalYearLookUpEdit;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox startDateEthTextBox;
        private System.Windows.Forms.TextBox endDateEthTextBox;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox fiscalYearTextBox;
    }
}