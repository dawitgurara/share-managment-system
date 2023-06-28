namespace SHM
{
    partial class frmPeriods
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
            System.Windows.Forms.Label fiscalYearLabel1;
            System.Windows.Forms.Label calendarYearLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label startDateEthLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label endDateEthLabel;
            System.Windows.Forms.Label periodLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriods));
            this.tspPeriods = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.fiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendarYearTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gctPeriods = new DevExpress.XtraGrid.GridControl();
            this.gridPeriods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYearPeriodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalendarYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.periodLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.endDateEthTextBox = new System.Windows.Forms.TextBox();
            this.startDateEthTextBox = new System.Windows.Forms.TextBox();
            fiscalYearLabel1 = new System.Windows.Forms.Label();
            calendarYearLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            startDateEthLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            endDateEthLabel = new System.Windows.Forms.Label();
            periodLabel = new System.Windows.Forms.Label();
            this.tspPeriods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fiscalYearLabel1
            // 
            fiscalYearLabel1.AutoSize = true;
            fiscalYearLabel1.Location = new System.Drawing.Point(10, 45);
            fiscalYearLabel1.Name = "fiscalYearLabel1";
            fiscalYearLabel1.Size = new System.Drawing.Size(62, 13);
            fiscalYearLabel1.TabIndex = 18;
            fiscalYearLabel1.Text = "Fiscal Year:";
            // 
            // calendarYearLabel
            // 
            calendarYearLabel.AutoSize = true;
            calendarYearLabel.Location = new System.Drawing.Point(135, 20);
            calendarYearLabel.Name = "calendarYearLabel";
            calendarYearLabel.Size = new System.Drawing.Size(77, 13);
            calendarYearLabel.TabIndex = 15;
            calendarYearLabel.Text = "Calendar Year:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(215, 20);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(84, 13);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date (Grg):";
            // 
            // startDateEthLabel
            // 
            startDateEthLabel.AutoSize = true;
            startDateEthLabel.Location = new System.Drawing.Point(427, 21);
            startDateEthLabel.Name = "startDateEthLabel";
            startDateEthLabel.Size = new System.Drawing.Size(83, 13);
            startDateEthLabel.TabIndex = 19;
            startDateEthLabel.Text = "Start Date (Eth):";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(321, 21);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(81, 13);
            endDateLabel.TabIndex = 21;
            endDateLabel.Text = "End Date (Grg):";
            // 
            // endDateEthLabel
            // 
            endDateEthLabel.AutoSize = true;
            endDateEthLabel.Location = new System.Drawing.Point(533, 21);
            endDateEthLabel.Name = "endDateEthLabel";
            endDateEthLabel.Size = new System.Drawing.Size(80, 13);
            endDateEthLabel.TabIndex = 23;
            endDateEthLabel.Text = "End Date (Eth):";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new System.Drawing.Point(3, 20);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(40, 13);
            periodLabel.TabIndex = 9;
            periodLabel.Text = "Period:";
            // 
            // tspPeriods
            // 
            this.tspPeriods.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspPeriods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton1});
            this.tspPeriods.Location = new System.Drawing.Point(0, 0);
            this.tspPeriods.Name = "tspPeriods";
            this.tspPeriods.Size = new System.Drawing.Size(686, 25);
            this.tspPeriods.TabIndex = 4;
            this.tspPeriods.TabStop = true;
            this.tspPeriods.Text = "toolStrip1";
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
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.deleteToolStripButton.Text = "De&lete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
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
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(409, 43);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 17;
            this.chkYearAll.CheckedChanged += new System.EventHandler(this.chkYearAll_CheckedChanged);
            // 
            // fiscalYearLookUpEdit
            // 
            this.fiscalYearLookUpEdit.Location = new System.Drawing.Point(78, 42);
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
            this.fiscalYearLookUpEdit.Size = new System.Drawing.Size(325, 20);
            this.fiscalYearLookUpEdit.TabIndex = 16;
            this.fiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.fiscalYearLookUpEdit_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendarYearTextBox);
            this.groupBox1.Controls.Add(this.endDateDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateDateTimePicker);
            this.groupBox1.Controls.Add(calendarYearLabel);
            this.groupBox1.Controls.Add(startDateLabel);
            this.groupBox1.Controls.Add(startDateEthLabel);
            this.groupBox1.Controls.Add(this.gctPeriods);
            this.groupBox1.Controls.Add(endDateLabel);
            this.groupBox1.Controls.Add(endDateEthLabel);
            this.groupBox1.Controls.Add(this.periodLookUpEdit);
            this.groupBox1.Controls.Add(this.endDateEthTextBox);
            this.groupBox1.Controls.Add(periodLabel);
            this.groupBox1.Controls.Add(this.startDateEthTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 353);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year Periods";
            // 
            // calendarYearTextBox
            // 
            this.calendarYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarYearTextBox.Location = new System.Drawing.Point(138, 36);
            this.calendarYearTextBox.Name = "calendarYearTextBox";
            this.calendarYearTextBox.Size = new System.Drawing.Size(74, 20);
            this.calendarYearTextBox.TabIndex = 154;
            this.calendarYearTextBox.TabStop = false;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(321, 37);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.endDateDateTimePicker.TabIndex = 153;
            this.endDateDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            this.endDateDateTimePicker.Validated += new System.EventHandler(this.endDateDateTimePicker_Validated);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(218, 37);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.startDateDateTimePicker.TabIndex = 152;
            this.startDateDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            this.startDateDateTimePicker.Validated += new System.EventHandler(this.startDateDateTimePicker_Validated);
            // 
            // gctPeriods
            // 
            this.gctPeriods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctPeriods.EmbeddedNavigator.Name = "";
            this.gctPeriods.Location = new System.Drawing.Point(6, 62);
            this.gctPeriods.MainView = this.gridPeriods;
            this.gctPeriods.Name = "gctPeriods";
            this.gctPeriods.Size = new System.Drawing.Size(630, 285);
            this.gctPeriods.TabIndex = 14;
            this.gctPeriods.TabStop = false;
            this.gctPeriods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPeriods});
            this.gctPeriods.DoubleClick += new System.EventHandler(this.gridPeriods_DoubleClick);
            // 
            // gridPeriods
            // 
            this.gridPeriods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYearPeriodName,
            this.colCalendarYear,
            this.colStartDate,
            this.colStartDateEth,
            this.colEndDate,
            this.colEndDateEth,
            this.colPeriod});
            this.gridPeriods.GridControl = this.gctPeriods;
            this.gridPeriods.Name = "gridPeriods";
            this.gridPeriods.OptionsBehavior.Editable = false;
            this.gridPeriods.OptionsCustomization.AllowColumnMoving = false;
            this.gridPeriods.OptionsCustomization.AllowColumnResizing = false;
            this.gridPeriods.OptionsCustomization.AllowFilter = false;
            this.gridPeriods.OptionsCustomization.AllowGroup = false;
            this.gridPeriods.OptionsCustomization.AllowSort = false;
            this.gridPeriods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridPeriods.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridPeriods.OptionsView.ColumnAutoWidth = false;
            this.gridPeriods.OptionsView.ShowColumnHeaders = false;
            this.gridPeriods.OptionsView.ShowGroupPanel = false;
            this.gridPeriods.OptionsView.ShowIndicator = false;
            // 
            // colYearPeriodName
            // 
            this.colYearPeriodName.Caption = "Period";
            this.colYearPeriodName.FieldName = "YearPeriodName";
            this.colYearPeriodName.Name = "colYearPeriodName";
            this.colYearPeriodName.Visible = true;
            this.colYearPeriodName.VisibleIndex = 0;
            this.colYearPeriodName.Width = 128;
            // 
            // colCalendarYear
            // 
            this.colCalendarYear.Caption = "CalendarYear";
            this.colCalendarYear.FieldName = "CalendarYear";
            this.colCalendarYear.Name = "colCalendarYear";
            this.colCalendarYear.Visible = true;
            this.colCalendarYear.VisibleIndex = 1;
            this.colCalendarYear.Width = 79;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "StartDate";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            this.colStartDate.Width = 104;
            // 
            // colStartDateEth
            // 
            this.colStartDateEth.Caption = "StartDateEth";
            this.colStartDateEth.FieldName = "StartDateEth";
            this.colStartDateEth.Name = "colStartDateEth";
            this.colStartDateEth.Visible = true;
            this.colStartDateEth.VisibleIndex = 4;
            this.colStartDateEth.Width = 106;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "EndDate";
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            this.colEndDate.Width = 101;
            // 
            // colEndDateEth
            // 
            this.colEndDateEth.Caption = "EndDateEth";
            this.colEndDateEth.FieldName = "EndDateEth";
            this.colEndDateEth.Name = "colEndDateEth";
            this.colEndDateEth.Visible = true;
            this.colEndDateEth.VisibleIndex = 5;
            this.colEndDateEth.Width = 108;
            // 
            // colPeriod
            // 
            this.colPeriod.Caption = "Period";
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            // 
            // periodLookUpEdit
            // 
            this.periodLookUpEdit.Location = new System.Drawing.Point(6, 36);
            this.periodLookUpEdit.Name = "periodLookUpEdit";
            this.periodLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.periodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.periodLookUpEdit.Properties.DisplayMember = "Name";
            this.periodLookUpEdit.Properties.NullText = "";
            this.periodLookUpEdit.Properties.ShowFooter = false;
            this.periodLookUpEdit.Properties.ShowHeader = false;
            this.periodLookUpEdit.Properties.ValueMember = "PeriodId";
            this.periodLookUpEdit.Size = new System.Drawing.Size(126, 20);
            this.periodLookUpEdit.TabIndex = 0;
            this.periodLookUpEdit.EditValueChanged += new System.EventHandler(this.periodLookUpEdit_EditValueChanged);
            // 
            // endDateEthTextBox
            // 
            this.endDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDateEthTextBox.Location = new System.Drawing.Point(536, 37);
            this.endDateEthTextBox.Name = "endDateEthTextBox";
            this.endDateEthTextBox.ReadOnly = true;
            this.endDateEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateEthTextBox.TabIndex = 24;
            this.endDateEthTextBox.TabStop = false;
            // 
            // startDateEthTextBox
            // 
            this.startDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDateEthTextBox.Location = new System.Drawing.Point(427, 37);
            this.startDateEthTextBox.Name = "startDateEthTextBox";
            this.startDateEthTextBox.ReadOnly = true;
            this.startDateEthTextBox.Size = new System.Drawing.Size(103, 20);
            this.startDateEthTextBox.TabIndex = 20;
            this.startDateEthTextBox.TabStop = false;
            // 
            // frmPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(686, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkYearAll);
            this.Controls.Add(fiscalYearLabel1);
            this.Controls.Add(this.fiscalYearLookUpEdit);
            this.Controls.Add(this.tspPeriods);
            this.Name = "frmPeriods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeriods";
            this.Load += new System.EventHandler(this.frmPeriods_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPeriods_KeyDown);
            this.tspPeriods.ResumeLayout(false);
            this.tspPeriods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPeriods;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton1;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private DevExpress.XtraEditors.LookUpEdit fiscalYearLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gctPeriods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPeriods;
        private DevExpress.XtraGrid.Columns.GridColumn colYearPeriodName;
        private DevExpress.XtraGrid.Columns.GridColumn colCalendarYear;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
        private DevExpress.XtraEditors.LookUpEdit periodLookUpEdit;
        private System.Windows.Forms.TextBox endDateEthTextBox;
        private System.Windows.Forms.TextBox startDateEthTextBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox calendarYearTextBox;
    }
}