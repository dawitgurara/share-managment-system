namespace SHM
{
    partial class frmMeetingSession
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
            System.Windows.Forms.Label budgetYearLabel;
            System.Windows.Forms.Label MeetingDateLabel;
            System.Windows.Forms.Label StartTimeLabel;
            System.Windows.Forms.Label EndTimeLabel;
            System.Windows.Forms.Label MeetingDateEthLebel;
            System.Windows.Forms.Label VenueLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeetingSession));
            this.tspMettingSession = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RoundNoTextBox = new System.Windows.Forms.TextBox();
            this.venuAmharicTextBox = new System.Windows.Forms.TextBox();
            this.VenueTextBox = new System.Windows.Forms.TextBox();
            this.TypeOfMeetingLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MeetingDateEthTextBox = new System.Windows.Forms.TextBox();
            this.MeetingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctMeetingSession = new DevExpress.XtraGrid.GridControl();
            this.gridMeetingSession = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeOfMeeting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluMeetingType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMeetingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            budgetYearLabel = new System.Windows.Forms.Label();
            MeetingDateLabel = new System.Windows.Forms.Label();
            StartTimeLabel = new System.Windows.Forms.Label();
            EndTimeLabel = new System.Windows.Forms.Label();
            MeetingDateEthLebel = new System.Windows.Forms.Label();
            VenueLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tspMettingSession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfMeetingLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMeetingSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeetingSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(82, 22);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(62, 13);
            budgetYearLabel.TabIndex = 0;
            budgetYearLabel.Text = "Fiscal Year:";
            // 
            // MeetingDateLabel
            // 
            MeetingDateLabel.AutoSize = true;
            MeetingDateLabel.Location = new System.Drawing.Point(42, 74);
            MeetingDateLabel.Name = "MeetingDateLabel";
            MeetingDateLabel.Size = new System.Drawing.Size(100, 13);
            MeetingDateLabel.TabIndex = 2;
            MeetingDateLabel.Text = "Meeting Date (Grg):";
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.Location = new System.Drawing.Point(85, 98);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new System.Drawing.Size(58, 13);
            StartTimeLabel.TabIndex = 4;
            StartTimeLabel.Text = "Start Time:";
            // 
            // EndTimeLabel
            // 
            EndTimeLabel.AutoSize = true;
            EndTimeLabel.Location = new System.Drawing.Point(327, 99);
            EndTimeLabel.Name = "EndTimeLabel";
            EndTimeLabel.Size = new System.Drawing.Size(55, 13);
            EndTimeLabel.TabIndex = 6;
            EndTimeLabel.Text = "End Time:";
            // 
            // MeetingDateEthLebel
            // 
            MeetingDateEthLebel.AutoSize = true;
            MeetingDateEthLebel.Location = new System.Drawing.Point(285, 74);
            MeetingDateEthLebel.Name = "MeetingDateEthLebel";
            MeetingDateEthLebel.Size = new System.Drawing.Size(99, 13);
            MeetingDateEthLebel.TabIndex = 10;
            MeetingDateEthLebel.Text = "Meeting Date (Eth):";
            // 
            // VenueLabel
            // 
            VenueLabel.AutoSize = true;
            VenueLabel.Location = new System.Drawing.Point(102, 151);
            VenueLabel.Name = "VenueLabel";
            VenueLabel.Size = new System.Drawing.Size(41, 13);
            VenueLabel.TabIndex = 91;
            VenueLabel.Text = "Venue:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 94;
            label1.Text = "Type of Meeting:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(66, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 13);
            label2.TabIndex = 95;
            label2.Text = "ySBsÆ ï¬Ý";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(62, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 13);
            label3.TabIndex = 96;
            label3.Text = "Round Number:";
            // 
            // tspMettingSession
            // 
            this.tspMettingSession.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspMettingSession.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspMettingSession.Location = new System.Drawing.Point(0, 0);
            this.tspMettingSession.Name = "tspMettingSession";
            this.tspMettingSession.Size = new System.Drawing.Size(1051, 25);
            this.tspMettingSession.TabIndex = 8;
            this.tspMettingSession.TabStop = true;
            this.tspMettingSession.Text = "toolStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoundNoTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.venuAmharicTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.VenueTextBox);
            this.groupBox1.Controls.Add(VenueLabel);
            this.groupBox1.Controls.Add(this.TypeOfMeetingLookUpEdit);
            this.groupBox1.Controls.Add(this.MeetingDateEthTextBox);
            this.groupBox1.Controls.Add(this.MeetingDateDateTimePicker);
            this.groupBox1.Controls.Add(this.chkYearAll);
            this.groupBox1.Controls.Add(this.EndTimeTextBox);
            this.groupBox1.Controls.Add(this.StartTimeTextBox);
            this.groupBox1.Controls.Add(budgetYearLabel);
            this.groupBox1.Controls.Add(this.FiscalYearLookUpEdit);
            this.groupBox1.Controls.Add(MeetingDateLabel);
            this.groupBox1.Controls.Add(StartTimeLabel);
            this.groupBox1.Controls.Add(EndTimeLabel);
            this.groupBox1.Controls.Add(MeetingDateEthLebel);
            this.groupBox1.Location = new System.Drawing.Point(48, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // RoundNoTextBox
            // 
            this.RoundNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoundNoTextBox.Location = new System.Drawing.Point(146, 122);
            this.RoundNoTextBox.Name = "RoundNoTextBox";
            this.RoundNoTextBox.Size = new System.Drawing.Size(120, 20);
            this.RoundNoTextBox.TabIndex = 97;
            // 
            // venuAmharicTextBox
            // 
            this.venuAmharicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.venuAmharicTextBox.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venuAmharicTextBox.Location = new System.Drawing.Point(146, 174);
            this.venuAmharicTextBox.Name = "venuAmharicTextBox";
            this.venuAmharicTextBox.Size = new System.Drawing.Size(362, 20);
            this.venuAmharicTextBox.TabIndex = 6;
            // 
            // VenueTextBox
            // 
            this.VenueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VenueTextBox.Location = new System.Drawing.Point(146, 148);
            this.VenueTextBox.Name = "VenueTextBox";
            this.VenueTextBox.Size = new System.Drawing.Size(362, 20);
            this.VenueTextBox.TabIndex = 5;
            // 
            // TypeOfMeetingLookUpEdit
            // 
            this.TypeOfMeetingLookUpEdit.Location = new System.Drawing.Point(145, 44);
            this.TypeOfMeetingLookUpEdit.Name = "TypeOfMeetingLookUpEdit";
            this.TypeOfMeetingLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TypeOfMeetingLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeOfMeetingLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.TypeOfMeetingLookUpEdit.Properties.DisplayMember = "Description";
            this.TypeOfMeetingLookUpEdit.Properties.NullText = "";
            this.TypeOfMeetingLookUpEdit.Properties.ShowHeader = false;
            this.TypeOfMeetingLookUpEdit.Properties.ValueMember = "Id";
            this.TypeOfMeetingLookUpEdit.Size = new System.Drawing.Size(120, 20);
            this.TypeOfMeetingLookUpEdit.TabIndex = 1;
            this.TypeOfMeetingLookUpEdit.EditValueChanged += new System.EventHandler(this.TypeOfMeetingLookUpEdit_EditValueChanged);
            // 
            // MeetingDateEthTextBox
            // 
            this.MeetingDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeetingDateEthTextBox.Location = new System.Drawing.Point(385, 70);
            this.MeetingDateEthTextBox.Name = "MeetingDateEthTextBox";
            this.MeetingDateEthTextBox.ReadOnly = true;
            this.MeetingDateEthTextBox.Size = new System.Drawing.Size(122, 20);
            this.MeetingDateEthTextBox.TabIndex = 3;
            this.MeetingDateEthTextBox.TabStop = false;
            // 
            // MeetingDateDateTimePicker
            // 
            this.MeetingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MeetingDateDateTimePicker.Location = new System.Drawing.Point(145, 70);
            this.MeetingDateDateTimePicker.Name = "MeetingDateDateTimePicker";
            this.MeetingDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.MeetingDateDateTimePicker.TabIndex = 2;
            this.MeetingDateDateTimePicker.Value = new System.DateTime(2017, 10, 6, 0, 0, 0, 0);
            this.MeetingDateDateTimePicker.Validated += new System.EventHandler(this.MeetingDateDateTimePicker_Validated);
            // 
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(287, 20);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 34;
            this.chkYearAll.CheckedChanged += new System.EventHandler(this.chkYearAll_CheckedChanged);
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndTimeTextBox.Location = new System.Drawing.Point(385, 96);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(122, 20);
            this.EndTimeTextBox.TabIndex = 33;
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartTimeTextBox.Location = new System.Drawing.Point(146, 96);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.StartTimeTextBox.TabIndex = 4;
            // 
            // FiscalYearLookUpEdit
            // 
            this.FiscalYearLookUpEdit.Location = new System.Drawing.Point(146, 19);
            this.FiscalYearLookUpEdit.Name = "FiscalYearLookUpEdit";
            this.FiscalYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.FiscalYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FiscalYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.FiscalYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Properties.NullText = "";
            this.FiscalYearLookUpEdit.Properties.ShowHeader = false;
            this.FiscalYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Size = new System.Drawing.Size(120, 20);
            this.FiscalYearLookUpEdit.TabIndex = 0;
            this.FiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.FiscalYearLookUpEdit_EditValueChanged);
            // 
            // gctMeetingSession
            // 
            this.gctMeetingSession.EmbeddedNavigator.Name = "";
            this.gctMeetingSession.Location = new System.Drawing.Point(14, 248);
            this.gctMeetingSession.MainView = this.gridMeetingSession;
            this.gctMeetingSession.Name = "gctMeetingSession";
            this.gctMeetingSession.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType});
            this.gctMeetingSession.Size = new System.Drawing.Size(897, 249);
            this.gctMeetingSession.TabIndex = 7;
            this.gctMeetingSession.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMeetingSession});
            // 
            // gridMeetingSession
            // 
            this.gridMeetingSession.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colFiscalYear,
            this.colTypeOfMeeting,
            this.colMeetingDate,
            this.colStartTime,
            this.colEndTime,
            this.colVenue,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs});
            this.gridMeetingSession.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridMeetingSession.GridControl = this.gctMeetingSession;
            this.gridMeetingSession.Name = "gridMeetingSession";
            this.gridMeetingSession.OptionsBehavior.Editable = false;
            this.gridMeetingSession.OptionsView.ColumnAutoWidth = false;
            this.gridMeetingSession.OptionsView.ShowGroupPanel = false;
            this.gridMeetingSession.DoubleClick += new System.EventHandler(this.gridMeetingSession_DoubleClick);
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            this.colSessionId.OptionsColumn.ReadOnly = true;
            this.colSessionId.Width = 95;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            this.colFiscalYear.Visible = true;
            this.colFiscalYear.VisibleIndex = 0;
            this.colFiscalYear.Width = 112;
            // 
            // colTypeOfMeeting
            // 
            this.colTypeOfMeeting.Caption = "Type of Meeting";
            this.colTypeOfMeeting.ColumnEdit = this.rluMeetingType;
            this.colTypeOfMeeting.FieldName = "TypeOfMeeting";
            this.colTypeOfMeeting.Name = "colTypeOfMeeting";
            this.colTypeOfMeeting.Visible = true;
            this.colTypeOfMeeting.VisibleIndex = 1;
            this.colTypeOfMeeting.Width = 155;
            // 
            // rluMeetingType
            // 
            this.rluMeetingType.AutoHeight = false;
            this.rluMeetingType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluMeetingType.DisplayMember = "Description";
            this.rluMeetingType.Name = "rluMeetingType";
            this.rluMeetingType.NullText = "";
            this.rluMeetingType.ValueMember = "Id";
            // 
            // colMeetingDate
            // 
            this.colMeetingDate.Caption = "Meeting Date";
            this.colMeetingDate.FieldName = "MeetingDate";
            this.colMeetingDate.Name = "colMeetingDate";
            this.colMeetingDate.Visible = true;
            this.colMeetingDate.VisibleIndex = 2;
            this.colMeetingDate.Width = 164;
            // 
            // colStartTime
            // 
            this.colStartTime.Caption = "Start Time";
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 3;
            this.colStartTime.Width = 116;
            // 
            // colEndTime
            // 
            this.colEndTime.Caption = "End Time";
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 4;
            this.colEndTime.Width = 101;
            // 
            // colVenue
            // 
            this.colVenue.Caption = "Venue";
            this.colVenue.FieldName = "Venue";
            this.colVenue.Name = "colVenue";
            this.colVenue.Visible = true;
            this.colVenue.VisibleIndex = 5;
            this.colVenue.Width = 340;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 6;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 7;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // rluCatagory
            // 
            this.rluCatagory.AutoHeight = false;
            this.rluCatagory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluCatagory.DisplayMember = "Description";
            this.rluCatagory.Name = "rluCatagory";
            this.rluCatagory.NullText = "";
            this.rluCatagory.ValueMember = "Id";
            // 
            // rluBudgetYear
            // 
            this.rluBudgetYear.AutoHeight = false;
            this.rluBudgetYear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluBudgetYear.Name = "rluBudgetYear";
            this.rluBudgetYear.NullText = "";
            // 
            // frmMeetingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1051, 507);
            this.Controls.Add(this.gctMeetingSession);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspMettingSession);
            this.Name = "frmMeetingSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Session Entry Form";
            this.Load += new System.EventHandler(this.frmMeetingSession_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMeetingSession_KeyDown);
            this.Validated += new System.EventHandler(this.MeetingDateDateTimePicker_Validated);
            this.tspMettingSession.ResumeLayout(false);
            this.tspMettingSession.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfMeetingLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMeetingSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeetingSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMettingSession;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctMeetingSession;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMeetingSession;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private System.Windows.Forms.DateTimePicker MeetingDateDateTimePicker;
        private System.Windows.Forms.TextBox MeetingDateEthTextBox;
        private System.Windows.Forms.TextBox VenueTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMeetingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colVenue;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraEditors.LookUpEdit TypeOfMeetingLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfMeeting;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private System.Windows.Forms.TextBox venuAmharicTextBox;
        private System.Windows.Forms.TextBox RoundNoTextBox;
    }
}