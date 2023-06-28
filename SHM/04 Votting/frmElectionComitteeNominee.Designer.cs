namespace SHM
{
    partial class frmElectionComitteeNominee
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
            System.Windows.Forms.Label SessionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElectionComitteeNominee));
            this.tspComtNomnee = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.DoNEthTextBox = new System.Windows.Forms.TextBox();
            this.DoNDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NomineeSHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctComtNomnee = new DevExpress.XtraGrid.GridControl();
            this.gridComtNominee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNominationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeFullNameAmharic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluMeetingType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNomineeLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            SessionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.tspComtNomnee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctComtNomnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComtNominee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(69, 22);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 0;
            SessionLabel.Text = "Session:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 48);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(100, 13);
            iDLabel.TabIndex = 96;
            iDLabel.Text = "Select Shareholder:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 13);
            label2.TabIndex = 98;
            label2.Text = "Date of Nomination:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(228, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 13);
            label3.TabIndex = 100;
            label3.Text = "Date of Nomination (Eth):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(66, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 13);
            label4.TabIndex = 102;
            label4.Text = "Remark:";
            // 
            // tspComtNomnee
            // 
            this.tspComtNomnee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspComtNomnee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.searchByComboBox});
            this.tspComtNomnee.Location = new System.Drawing.Point(0, 0);
            this.tspComtNomnee.Name = "tspComtNomnee";
            this.tspComtNomnee.Size = new System.Drawing.Size(1000, 25);
            this.tspComtNomnee.TabIndex = 7;
            this.tspComtNomnee.TabStop = true;
            this.tspComtNomnee.Text = "toolStrip1";
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
            // searchByComboBox
            // 
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(200, 25);
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.RemarkTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.DoNEthTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.DoNDateTimePicker);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.NomineeSHIdLookUpEdit);
            this.groupBox1.Controls.Add(SessionLabel);
            this.groupBox1.Controls.Add(this.SessionIdLookUpEdit);
            this.groupBox1.Location = new System.Drawing.Point(34, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemarkTextBox.Location = new System.Drawing.Point(119, 97);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(458, 20);
            this.RemarkTextBox.TabIndex = 101;
            this.RemarkTextBox.TabStop = false;
            // 
            // DoNEthTextBox
            // 
            this.DoNEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoNEthTextBox.Location = new System.Drawing.Point(360, 71);
            this.DoNEthTextBox.Name = "DoNEthTextBox";
            this.DoNEthTextBox.ReadOnly = true;
            this.DoNEthTextBox.Size = new System.Drawing.Size(91, 20);
            this.DoNEthTextBox.TabIndex = 99;
            this.DoNEthTextBox.TabStop = false;
            // 
            // DoNDateTimePicker
            // 
            this.DoNDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoNDateTimePicker.Location = new System.Drawing.Point(119, 71);
            this.DoNDateTimePicker.Name = "DoNDateTimePicker";
            this.DoNDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.DoNDateTimePicker.TabIndex = 97;
            this.DoNDateTimePicker.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.DoNDateTimePicker.Validated += new System.EventHandler(this.DoNDateTimePicker_Validated);
            // 
            // NomineeSHIdLookUpEdit
            // 
            this.NomineeSHIdLookUpEdit.Location = new System.Drawing.Point(119, 45);
            this.NomineeSHIdLookUpEdit.Name = "NomineeSHIdLookUpEdit";
            this.NomineeSHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NomineeSHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NomineeSHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHId", "SH Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegCode", "Reg Code", 10),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.NomineeSHIdLookUpEdit.Properties.DisplayMember = "SHRegCodeWithName";
            this.NomineeSHIdLookUpEdit.Properties.DropDownRows = 20;
            this.NomineeSHIdLookUpEdit.Properties.NullText = "";
            this.NomineeSHIdLookUpEdit.Properties.ValueMember = "SHId";
            this.NomineeSHIdLookUpEdit.Size = new System.Drawing.Size(458, 20);
            this.NomineeSHIdLookUpEdit.TabIndex = 95;
            this.NomineeSHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SHIdLookUpEdit_EditValueChanged);
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(119, 19);
            this.SessionIdLookUpEdit.Name = "SessionIdLookUpEdit";
            this.SessionIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.SessionIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SessionIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionId", "Session Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeOfMeeting", "Meeting Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionNane", "Session Nane", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Venue", "Venue", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.SessionIdLookUpEdit.Properties.DisplayMember = "SessionNane";
            this.SessionIdLookUpEdit.Properties.NullText = "";
            this.SessionIdLookUpEdit.Properties.ShowHeader = false;
            this.SessionIdLookUpEdit.Properties.ValueMember = "SessionId";
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(458, 20);
            this.SessionIdLookUpEdit.TabIndex = 0;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // gctComtNomnee
            // 
            this.gctComtNomnee.EmbeddedNavigator.Name = "";
            this.gctComtNomnee.Location = new System.Drawing.Point(0, 199);
            this.gctComtNomnee.MainView = this.gridComtNominee;
            this.gctComtNomnee.Name = "gctComtNomnee";
            this.gctComtNomnee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType,
            this.rluNomineeLookUpEdit});
            this.gctComtNomnee.Size = new System.Drawing.Size(988, 264);
            this.gctComtNomnee.TabIndex = 9;
            this.gctComtNomnee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridComtNominee});
            // 
            // gridComtNominee
            // 
            this.gridComtNominee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNominationId,
            this.colSessionId,
            this.colSHId,
            this.colNomineeRegCode,
            this.colNomineeFullName,
            this.colNomineeFullNameAmharic,
            this.colRemark,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridComtNominee.CustomizationFormBounds = new System.Drawing.Rectangle(816, 472, 208, 170);
            this.gridComtNominee.GridControl = this.gctComtNomnee;
            this.gridComtNominee.Name = "gridComtNominee";
            this.gridComtNominee.OptionsBehavior.Editable = false;
            this.gridComtNominee.OptionsView.ColumnAutoWidth = false;
            this.gridComtNominee.OptionsView.ShowGroupPanel = false;
            this.gridComtNominee.DoubleClick += new System.EventHandler(this.gridComtNominee_DoubleClick);
            // 
            // colNominationId
            // 
            this.colNominationId.Caption = "So. No.";
            this.colNominationId.FieldName = "NomineeId";
            this.colNominationId.Name = "colNominationId";
            this.colNominationId.OptionsColumn.ReadOnly = true;
            this.colNominationId.Visible = true;
            this.colNominationId.VisibleIndex = 0;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "Session Id";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SHId";
            this.colSHId.Name = "colSHId";
            // 
            // colNomineeRegCode
            // 
            this.colNomineeRegCode.Caption = "Reg.Code";
            this.colNomineeRegCode.FieldName = "NomineeRegCode";
            this.colNomineeRegCode.Name = "colNomineeRegCode";
            this.colNomineeRegCode.Visible = true;
            this.colNomineeRegCode.VisibleIndex = 1;
            this.colNomineeRegCode.Width = 76;
            // 
            // colNomineeFullName
            // 
            this.colNomineeFullName.Caption = "Nominee Full Name";
            this.colNomineeFullName.FieldName = "NomineeFullName";
            this.colNomineeFullName.Name = "colNomineeFullName";
            this.colNomineeFullName.Visible = true;
            this.colNomineeFullName.VisibleIndex = 2;
            this.colNomineeFullName.Width = 320;
            // 
            // colNomineeFullNameAmharic
            // 
            this.colNomineeFullNameAmharic.AppearanceCell.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeFullNameAmharic.AppearanceCell.Options.UseFont = true;
            this.colNomineeFullNameAmharic.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeFullNameAmharic.AppearanceHeader.Options.UseFont = true;
            this.colNomineeFullNameAmharic.Caption = "yXŒ xSm‰+ ÷¸t&& SM";
            this.colNomineeFullNameAmharic.FieldName = "NomineeFullNameAmharic";
            this.colNomineeFullNameAmharic.Name = "colNomineeFullNameAmharic";
            this.colNomineeFullNameAmharic.Visible = true;
            this.colNomineeFullNameAmharic.VisibleIndex = 3;
            this.colNomineeFullNameAmharic.Width = 319;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Remark";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            this.colRemark.Width = 178;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 5;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 6;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 7;
            // 
            // colLmBy
            // 
            this.colLmBy.Caption = "LmBy";
            this.colLmBy.FieldName = "LmBy";
            this.colLmBy.Name = "colLmBy";
            this.colLmBy.Visible = true;
            this.colLmBy.VisibleIndex = 8;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 9;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 10;
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
            // rluNomineeLookUpEdit
            // 
            this.rluNomineeLookUpEdit.AutoHeight = false;
            this.rluNomineeLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNomineeLookUpEdit.DisplayMember = "FullName";
            this.rluNomineeLookUpEdit.Name = "rluNomineeLookUpEdit";
            this.rluNomineeLookUpEdit.NullText = "";
            this.rluNomineeLookUpEdit.ValueMember = "SHId";
            // 
            // frmElectionComitteeNominee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 475);
            this.Controls.Add(this.gctComtNomnee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspComtNomnee);
            this.Name = "frmElectionComitteeNominee";
            this.Text = "Election Committee Nominee Entry Form";
            this.Load += new System.EventHandler(this.frmElectionComitteeNominee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmElectionComitteeNominee_KeyDown);
            this.tspComtNomnee.ResumeLayout(false);
            this.tspComtNomnee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctComtNomnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComtNominee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspComtNomnee;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctComtNomnee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridComtNominee;
        private DevExpress.XtraGrid.Columns.GridColumn colNominationId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeRegCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeFullNameAmharic;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private DevExpress.XtraEditors.LookUpEdit NomineeSHIdLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNomineeLookUpEdit;
        private System.Windows.Forms.DateTimePicker DoNDateTimePicker;
        private System.Windows.Forms.TextBox DoNEthTextBox;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeFullName;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
    }
}