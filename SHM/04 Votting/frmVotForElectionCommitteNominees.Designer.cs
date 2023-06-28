namespace SHM
{
    partial class frmVotForElectionCommitteNominees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotForElectionCommitteNominees));
            this.tspVot = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AgendaLabel = new System.Windows.Forms.Label();
            this.NomineeSHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gctNotVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridNotVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoterSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluVoterSHId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluAgendaCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluNomineeSHIdNotSelected = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gctVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVotingId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoterSHIdVotted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluVoterSHIdVotted = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRegCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeIdselected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeSHIdSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeFullName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareNoVoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmntVoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAtnd = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluSHIdAtend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluNomineeSHIdSelected = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            SessionLabel = new System.Windows.Forms.Label();
            this.tspVot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluVoterSHId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHIdNotSelected)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluVoterSHIdVotted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHIdSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(28, 37);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 78;
            SessionLabel.Text = "Session:";
            // 
            // tspVot
            // 
            this.tspVot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspVot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.refreshToolStripButton});
            this.tspVot.Location = new System.Drawing.Point(0, 0);
            this.tspVot.Name = "tspVot";
            this.tspVot.Size = new System.Drawing.Size(1148, 25);
            this.tspVot.TabIndex = 62;
            this.tspVot.TabStop = true;
            this.tspVot.Text = "toolStrip1";
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
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton.Text = "&Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // AgendaLabel
            // 
            this.AgendaLabel.AutoSize = true;
            this.AgendaLabel.Location = new System.Drawing.Point(23, 63);
            this.AgendaLabel.Name = "AgendaLabel";
            this.AgendaLabel.Size = new System.Drawing.Size(52, 13);
            this.AgendaLabel.TabIndex = 80;
            this.AgendaLabel.Text = "Nominee:";
            // 
            // NomineeSHIdLookUpEdit
            // 
            this.NomineeSHIdLookUpEdit.Location = new System.Drawing.Point(79, 60);
            this.NomineeSHIdLookUpEdit.Name = "NomineeSHIdLookUpEdit";
            this.NomineeSHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NomineeSHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NomineeSHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeId", "So.No.", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeSHId", "Nominee SH Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeFullName", "Nominee Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.NomineeSHIdLookUpEdit.Properties.DisplayMember = "NomineeFullName";
            this.NomineeSHIdLookUpEdit.Properties.NullText = "";
            this.NomineeSHIdLookUpEdit.Properties.ShowHeader = false;
            this.NomineeSHIdLookUpEdit.Properties.ValueMember = "NomineeSHId";
            this.NomineeSHIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.NomineeSHIdLookUpEdit.TabIndex = 79;
            this.NomineeSHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.NomineeSHIdLookUpEdit_EditValueChanged);
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(78, 34);
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
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.SessionIdLookUpEdit.TabIndex = 77;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gctNotVotedSH);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 495);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shareholders, not voted for the selected Nominee";
            // 
            // gctNotVotedSH
            // 
            this.gctNotVotedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctNotVotedSH.EmbeddedNavigator.Name = "";
            this.gctNotVotedSH.Location = new System.Drawing.Point(6, 13);
            this.gctNotVotedSH.MainView = this.gridNotVotedSH;
            this.gctNotVotedSH.Name = "gctNotVotedSH";
            this.gctNotVotedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.rluVoterSHId,
            this.rluAgendaCheckEdit,
            this.rluNomineeSHIdNotSelected});
            this.gctNotVotedSH.Size = new System.Drawing.Size(550, 476);
            this.gctNotVotedSH.TabIndex = 54;
            this.gctNotVotedSH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNotVotedSH});
            // 
            // gridNotVotedSH
            // 
            this.gridNotVotedSH.ActiveFilterEnabled = false;
            this.gridNotVotedSH.Appearance.GroupPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridNotVotedSH.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridNotVotedSH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colVoterSHId,
            this.colRegCode,
            this.colNomineeId,
            this.colNomineeSHId,
            this.colNomineeFullName,
            this.colShareNo,
            this.colShareAmnt});
            this.gridNotVotedSH.GridControl = this.gctNotVotedSH;
            this.gridNotVotedSH.GroupCount = 2;
            this.gridNotVotedSH.Name = "gridNotVotedSH";
            this.gridNotVotedSH.OptionsBehavior.Editable = false;
            this.gridNotVotedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridNotVotedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridNotVotedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridNotVotedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridNotVotedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridNotVotedSH.OptionsView.ShowHorzLines = false;
            this.gridNotVotedSH.OptionsView.ShowVertLines = false;
            this.gridNotVotedSH.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVoterSHId, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridNotVotedSH.DoubleClick += new System.EventHandler(this.gridNotVotedSH_DoubleClick);
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colVoterSHId
            // 
            this.colVoterSHId.Caption = "Full Name";
            this.colVoterSHId.ColumnEdit = this.rluVoterSHId;
            this.colVoterSHId.FieldName = "SHId";
            this.colVoterSHId.Name = "colVoterSHId";
            // 
            // rluVoterSHId
            // 
            this.rluVoterSHId.AutoHeight = false;
            this.rluVoterSHId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluVoterSHId.DisplayMember = "FullName";
            this.rluVoterSHId.Name = "rluVoterSHId";
            this.rluVoterSHId.NullText = "";
            this.rluVoterSHId.ValueMember = "SHId";
            // 
            // colRegCode
            // 
            this.colRegCode.Caption = "Registration Code";
            this.colRegCode.FieldName = "RegCode";
            this.colRegCode.Name = "colRegCode";
            // 
            // colNomineeId
            // 
            this.colNomineeId.Caption = "S.No.";
            this.colNomineeId.FieldName = "NomineeId";
            this.colNomineeId.Name = "colNomineeId";
            this.colNomineeId.Visible = true;
            this.colNomineeId.VisibleIndex = 0;
            // 
            // colNomineeSHId
            // 
            this.colNomineeSHId.Caption = "Nominee Name";
            this.colNomineeSHId.FieldName = "NomineeSHId";
            this.colNomineeSHId.Name = "colNomineeSHId";
            this.colNomineeSHId.Width = 354;
            // 
            // colNomineeFullName
            // 
            this.colNomineeFullName.Caption = "Nominee Name";
            this.colNomineeFullName.FieldName = "NomineeFullName";
            this.colNomineeFullName.Name = "colNomineeFullName";
            this.colNomineeFullName.Visible = true;
            this.colNomineeFullName.VisibleIndex = 1;
            // 
            // colShareNo
            // 
            this.colShareNo.Caption = "Subscribed Share No.";
            this.colShareNo.FieldName = "ShareNo";
            this.colShareNo.Name = "colShareNo";
            this.colShareNo.Visible = true;
            this.colShareNo.VisibleIndex = 2;
            this.colShareNo.Width = 121;
            // 
            // colShareAmnt
            // 
            this.colShareAmnt.Caption = "ShareAmnt";
            this.colShareAmnt.FieldName = "ShareAmnt";
            this.colShareAmnt.Name = "colShareAmnt";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit1.DisplayMember = "FullName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // rluAgendaCheckEdit
            // 
            this.rluAgendaCheckEdit.AutoHeight = false;
            this.rluAgendaCheckEdit.Name = "rluAgendaCheckEdit";
            // 
            // rluNomineeSHIdNotSelected
            // 
            this.rluNomineeSHIdNotSelected.AutoHeight = false;
            this.rluNomineeSHIdNotSelected.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNomineeSHIdNotSelected.DisplayMember = "FullName";
            this.rluNomineeSHIdNotSelected.Name = "rluNomineeSHIdNotSelected";
            this.rluNomineeSHIdNotSelected.NullText = "";
            this.rluNomineeSHIdNotSelected.ValueMember = "SHId";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gctVotedSH);
            this.groupBox1.Location = new System.Drawing.Point(580, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 495);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shareholders,   voted for the selected Nominee";
            // 
            // gctVotedSH
            // 
            this.gctVotedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctVotedSH.EmbeddedNavigator.Name = "";
            this.gctVotedSH.Location = new System.Drawing.Point(6, 13);
            this.gctVotedSH.MainView = this.gridVotedSH;
            this.gctVotedSH.Name = "gctVotedSH";
            this.gctVotedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluSHIdAtnd,
            this.rluSHIdAtend,
            this.repositoryItemCheckEdit1,
            this.rluVoterSHIdVotted,
            this.rluNomineeSHIdSelected});
            this.gctVotedSH.Size = new System.Drawing.Size(544, 477);
            this.gctVotedSH.TabIndex = 53;
            this.gctVotedSH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVotedSH});
            // 
            // gridVotedSH
            // 
            this.gridVotedSH.ActiveFilterEnabled = false;
            this.gridVotedSH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVotingId,
            this.colSessionId1,
            this.colVoterSHIdVotted,
            this.colRegCode1,
            this.colNomineeIdselected,
            this.colNomineeSHIdSelected,
            this.colNomineeFullName1,
            this.colShareNoVoted,
            this.colShareAmntVoted});
            this.gridVotedSH.GridControl = this.gctVotedSH;
            this.gridVotedSH.GroupCount = 2;
            this.gridVotedSH.Name = "gridVotedSH";
            this.gridVotedSH.OptionsBehavior.Editable = false;
            this.gridVotedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridVotedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridVotedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridVotedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridVotedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridVotedSH.OptionsView.ShowHorzLines = false;
            this.gridVotedSH.OptionsView.ShowVertLines = false;
            this.gridVotedSH.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVoterSHIdVotted, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegCode1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridVotedSH.DoubleClick += new System.EventHandler(this.gridVotedSH_DoubleClick);
            // 
            // colVotingId
            // 
            this.colVotingId.Caption = "VotingId";
            this.colVotingId.FieldName = "VotingId";
            this.colVotingId.Name = "colVotingId";
            this.colVotingId.OptionsColumn.ReadOnly = true;
            // 
            // colSessionId1
            // 
            this.colSessionId1.Caption = "SessionId";
            this.colSessionId1.FieldName = "SessionId";
            this.colSessionId1.Name = "colSessionId1";
            // 
            // colVoterSHIdVotted
            // 
            this.colVoterSHIdVotted.Caption = "Full Name";
            this.colVoterSHIdVotted.ColumnEdit = this.rluVoterSHIdVotted;
            this.colVoterSHIdVotted.FieldName = "VoterSHId";
            this.colVoterSHIdVotted.Name = "colVoterSHIdVotted";
            // 
            // rluVoterSHIdVotted
            // 
            this.rluVoterSHIdVotted.AutoHeight = false;
            this.rluVoterSHIdVotted.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluVoterSHIdVotted.DisplayMember = "FullName";
            this.rluVoterSHIdVotted.Name = "rluVoterSHIdVotted";
            this.rluVoterSHIdVotted.NullText = "";
            this.rluVoterSHIdVotted.ValueMember = "SHId";
            // 
            // colRegCode1
            // 
            this.colRegCode1.Caption = "Registration Code";
            this.colRegCode1.FieldName = "RegCode";
            this.colRegCode1.Name = "colRegCode1";
            // 
            // colNomineeIdselected
            // 
            this.colNomineeIdselected.Caption = "S.No.";
            this.colNomineeIdselected.FieldName = "NomineeId";
            this.colNomineeIdselected.Name = "colNomineeIdselected";
            this.colNomineeIdselected.Visible = true;
            this.colNomineeIdselected.VisibleIndex = 0;
            this.colNomineeIdselected.Width = 71;
            // 
            // colNomineeSHIdSelected
            // 
            this.colNomineeSHIdSelected.Caption = "Nominee Name";
            this.colNomineeSHIdSelected.FieldName = "NomineeSHId";
            this.colNomineeSHIdSelected.Name = "colNomineeSHIdSelected";
            this.colNomineeSHIdSelected.Width = 333;
            // 
            // colNomineeFullName1
            // 
            this.colNomineeFullName1.Caption = "Nominee Name";
            this.colNomineeFullName1.FieldName = "NomineeFullName";
            this.colNomineeFullName1.Name = "colNomineeFullName1";
            this.colNomineeFullName1.Visible = true;
            this.colNomineeFullName1.VisibleIndex = 1;
            // 
            // colShareNoVoted
            // 
            this.colShareNoVoted.Caption = "Subscribed Share No.";
            this.colShareNoVoted.FieldName = "ShareNo";
            this.colShareNoVoted.Name = "colShareNoVoted";
            this.colShareNoVoted.Visible = true;
            this.colShareNoVoted.VisibleIndex = 2;
            this.colShareNoVoted.Width = 112;
            // 
            // colShareAmntVoted
            // 
            this.colShareAmntVoted.Caption = "ShareAmnt";
            this.colShareAmntVoted.FieldName = "ShareAmnt";
            this.colShareAmntVoted.Name = "colShareAmntVoted";
            // 
            // rluSHIdAtnd
            // 
            this.rluSHIdAtnd.AutoHeight = false;
            this.rluSHIdAtnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdAtnd.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.rluSHIdAtnd.DisplayMember = "FullName";
            this.rluSHIdAtnd.Name = "rluSHIdAtnd";
            this.rluSHIdAtnd.NullText = "";
            this.rluSHIdAtnd.ValueMember = "Id";
            // 
            // rluSHIdAtend
            // 
            this.rluSHIdAtend.AutoHeight = false;
            this.rluSHIdAtend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdAtend.DisplayMember = "FullName";
            this.rluSHIdAtend.Name = "rluSHIdAtend";
            this.rluSHIdAtend.NullText = "";
            this.rluSHIdAtend.ValueMember = "SHId";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // rluNomineeSHIdSelected
            // 
            this.rluNomineeSHIdSelected.AutoHeight = false;
            this.rluNomineeSHIdSelected.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNomineeSHIdSelected.DisplayMember = "Agenda";
            this.rluNomineeSHIdSelected.Name = "rluNomineeSHIdSelected";
            this.rluNomineeSHIdSelected.NullText = "";
            this.rluNomineeSHIdSelected.ValueMember = "AgendaId";
            // 
            // frmVotForElectionCommitteNominees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AgendaLabel);
            this.Controls.Add(this.NomineeSHIdLookUpEdit);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Controls.Add(this.tspVot);
            this.Name = "frmVotForElectionCommitteNominees";
            this.Text = "Vot For Election Committe Nominees";
            this.Load += new System.EventHandler(this.frmVotForElectionCommitteNominees_Load);
            this.tspVot.ResumeLayout(false);
            this.tspVot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluVoterSHId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHIdNotSelected)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluVoterSHIdVotted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHIdSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspVot;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.Label AgendaLabel;
        private DevExpress.XtraEditors.LookUpEdit NomineeSHIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gctNotVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNotVotedSH;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colVoterSHId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluVoterSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeSHId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNomineeSHIdNotSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rluAgendaCheckEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gctVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVotedSH;
        private DevExpress.XtraGrid.Columns.GridColumn colVotingId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId1;
        private DevExpress.XtraGrid.Columns.GridColumn colVoterSHIdVotted;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluVoterSHIdVotted;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeSHIdSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNomineeSHIdSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNoVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmntVoted;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtend;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeIdselected;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeFullName1;
    }
}