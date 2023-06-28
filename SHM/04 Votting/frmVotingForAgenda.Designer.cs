namespace SHM
{
    partial class frmVotingForAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotingForAgenda));
            this.AgendaLabel = new System.Windows.Forms.Label();
            this.tspSelectionCriteria = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AgendaIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gctNotVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridNotVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdNotAtend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgendaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluAgendaIdNotAttend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgendaAmharic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluAgendaCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gctVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVotingId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAttend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRegCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgendaId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluAgendaIdAttend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAtnd = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluSHIdAtend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            SessionLabel = new System.Windows.Forms.Label();
            this.tspSelectionCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaIdNotAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaCheckEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaIdAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(21, 40);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 74;
            SessionLabel.Text = "Session:";
            // 
            // AgendaLabel
            // 
            this.AgendaLabel.AutoSize = true;
            this.AgendaLabel.Location = new System.Drawing.Point(21, 66);
            this.AgendaLabel.Name = "AgendaLabel";
            this.AgendaLabel.Size = new System.Drawing.Size(47, 13);
            this.AgendaLabel.TabIndex = 76;
            this.AgendaLabel.Text = "Agenda:";
            // 
            // tspSelectionCriteria
            // 
            this.tspSelectionCriteria.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspSelectionCriteria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.refreshToolStripButton});
            this.tspSelectionCriteria.Location = new System.Drawing.Point(0, 0);
            this.tspSelectionCriteria.Name = "tspSelectionCriteria";
            this.tspSelectionCriteria.Size = new System.Drawing.Size(1028, 25);
            this.tspSelectionCriteria.TabIndex = 61;
            this.tspSelectionCriteria.TabStop = true;
            this.tspSelectionCriteria.Text = "toolStrip1";
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
            // AgendaIdLookUpEdit
            // 
            this.AgendaIdLookUpEdit.Location = new System.Drawing.Point(71, 63);
            this.AgendaIdLookUpEdit.Name = "AgendaIdLookUpEdit";
            this.AgendaIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.AgendaIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AgendaIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgendaId", "Agenda Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agenda", "Agenda", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.AgendaIdLookUpEdit.Properties.DisplayMember = "Agenda";
            this.AgendaIdLookUpEdit.Properties.NullText = "";
            this.AgendaIdLookUpEdit.Properties.ShowHeader = false;
            this.AgendaIdLookUpEdit.Properties.ValueMember = "AgendaId";
            this.AgendaIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.AgendaIdLookUpEdit.TabIndex = 75;
            this.AgendaIdLookUpEdit.EditValueChanged += new System.EventHandler(this.AgendaIdLookUpEdit_EditValueChanged);
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(71, 37);
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
            this.SessionIdLookUpEdit.TabIndex = 73;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gctNotVotedSH);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 495);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shareholders, not voted for the selected agenda";
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
            this.rluSHIdNotAtend,
            this.rluAgendaCheckEdit,
            this.rluAgendaIdNotAttend});
            this.gctNotVotedSH.Size = new System.Drawing.Size(503, 476);
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
            this.colSHId,
            this.colRegCode,
            this.colAgendaId,
            this.colShareNo,
            this.colShareAmnt,
            this.colAgenda,
            this.colAgendaAmharic});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSHId, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridNotVotedSH.DoubleClick += new System.EventHandler(this.gridNotVotedSH_DoubleClick);
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colSHId
            // 
            this.colSHId.Caption = "Full Name";
            this.colSHId.ColumnEdit = this.rluSHIdNotAtend;
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            // 
            // rluSHIdNotAtend
            // 
            this.rluSHIdNotAtend.AutoHeight = false;
            this.rluSHIdNotAtend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdNotAtend.DisplayMember = "FullName";
            this.rluSHIdNotAtend.Name = "rluSHIdNotAtend";
            this.rluSHIdNotAtend.NullText = "";
            this.rluSHIdNotAtend.ValueMember = "SHId";
            // 
            // colRegCode
            // 
            this.colRegCode.Caption = "Registration Code";
            this.colRegCode.FieldName = "RegCode";
            this.colRegCode.Name = "colRegCode";
            // 
            // colAgendaId
            // 
            this.colAgendaId.Caption = "Agenda";
            this.colAgendaId.ColumnEdit = this.rluAgendaIdNotAttend;
            this.colAgendaId.FieldName = "AgendaId";
            this.colAgendaId.Name = "colAgendaId";
            this.colAgendaId.Visible = true;
            this.colAgendaId.VisibleIndex = 0;
            this.colAgendaId.Width = 354;
            // 
            // rluAgendaIdNotAttend
            // 
            this.rluAgendaIdNotAttend.AutoHeight = false;
            this.rluAgendaIdNotAttend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluAgendaIdNotAttend.DisplayMember = "Agenda";
            this.rluAgendaIdNotAttend.Name = "rluAgendaIdNotAttend";
            this.rluAgendaIdNotAttend.NullText = "";
            this.rluAgendaIdNotAttend.ValueMember = "AgendaId";
            // 
            // colShareNo
            // 
            this.colShareNo.Caption = "Subscribed Share No.";
            this.colShareNo.FieldName = "ShareNo";
            this.colShareNo.Name = "colShareNo";
            this.colShareNo.Visible = true;
            this.colShareNo.VisibleIndex = 1;
            this.colShareNo.Width = 121;
            // 
            // colShareAmnt
            // 
            this.colShareAmnt.Caption = "ShareAmnt";
            this.colShareAmnt.FieldName = "ShareAmnt";
            this.colShareAmnt.Name = "colShareAmnt";
            // 
            // colAgenda
            // 
            this.colAgenda.Caption = "Agenda";
            this.colAgenda.FieldName = "Agenda";
            this.colAgenda.Name = "colAgenda";
            this.colAgenda.Width = 500;
            // 
            // colAgendaAmharic
            // 
            this.colAgendaAmharic.Caption = "AgendaAmharic";
            this.colAgendaAmharic.FieldName = "AgendaAmharic";
            this.colAgendaAmharic.Name = "colAgendaAmharic";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gctVotedSH);
            this.groupBox1.Location = new System.Drawing.Point(533, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 495);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shareholders,   voted for the selected agenda";
            // 
            // gctVotedSH
            // 
            this.gctVotedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctVotedSH.EmbeddedNavigator.Name = "";
            this.gctVotedSH.Location = new System.Drawing.Point(6, 12);
            this.gctVotedSH.MainView = this.gridVotedSH;
            this.gctVotedSH.Name = "gctVotedSH";
            this.gctVotedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluSHIdAtnd,
            this.rluSHIdAtend,
            this.repositoryItemCheckEdit1,
            this.rluSHIdAttend,
            this.rluAgendaIdAttend});
            this.gctVotedSH.Size = new System.Drawing.Size(489, 477);
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
            this.colSHId1,
            this.colRegCode1,
            this.colAgendaId1,
            this.colShareNo1,
            this.colShareAmnt1});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSHId1, DevExpress.Data.ColumnSortOrder.Ascending),
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
            // colSHId1
            // 
            this.colSHId1.Caption = "Full Name";
            this.colSHId1.ColumnEdit = this.rluSHIdAttend;
            this.colSHId1.FieldName = "SHId";
            this.colSHId1.Name = "colSHId1";
            // 
            // rluSHIdAttend
            // 
            this.rluSHIdAttend.AutoHeight = false;
            this.rluSHIdAttend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdAttend.DisplayMember = "FullName";
            this.rluSHIdAttend.Name = "rluSHIdAttend";
            this.rluSHIdAttend.NullText = "";
            this.rluSHIdAttend.ValueMember = "SHId";
            // 
            // colRegCode1
            // 
            this.colRegCode1.Caption = "Registration Code";
            this.colRegCode1.FieldName = "RegCode";
            this.colRegCode1.Name = "colRegCode1";
            // 
            // colAgendaId1
            // 
            this.colAgendaId1.Caption = "Agenda";
            this.colAgendaId1.ColumnEdit = this.rluAgendaIdAttend;
            this.colAgendaId1.FieldName = "AgendaId";
            this.colAgendaId1.Name = "colAgendaId1";
            this.colAgendaId1.Visible = true;
            this.colAgendaId1.VisibleIndex = 0;
            this.colAgendaId1.Width = 350;
            // 
            // rluAgendaIdAttend
            // 
            this.rluAgendaIdAttend.AutoHeight = false;
            this.rluAgendaIdAttend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluAgendaIdAttend.DisplayMember = "Agenda";
            this.rluAgendaIdAttend.Name = "rluAgendaIdAttend";
            this.rluAgendaIdAttend.NullText = "";
            this.rluAgendaIdAttend.ValueMember = "AgendaId";
            // 
            // colShareNo1
            // 
            this.colShareNo1.Caption = "Subscribed Share No.";
            this.colShareNo1.FieldName = "ShareNo";
            this.colShareNo1.Name = "colShareNo1";
            this.colShareNo1.Visible = true;
            this.colShareNo1.VisibleIndex = 1;
            this.colShareNo1.Width = 113;
            // 
            // colShareAmnt1
            // 
            this.colShareAmnt1.Caption = "ShareAmnt";
            this.colShareAmnt1.FieldName = "ShareAmnt";
            this.colShareAmnt1.Name = "colShareAmnt1";
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
            // frmVotingForAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AgendaLabel);
            this.Controls.Add(this.AgendaIdLookUpEdit);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Controls.Add(this.tspSelectionCriteria);
            this.Name = "frmVotingForAgenda";
            this.Text = "frmVotingForAgenda";
            this.Load += new System.EventHandler(this.frmVotingForAgenda_Load);
            this.tspSelectionCriteria.ResumeLayout(false);
            this.tspSelectionCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaIdNotAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaCheckEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgendaIdAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspSelectionCriteria;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit AgendaIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gctNotVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNotVotedSH;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdNotAtend;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gctVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVotedSH;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtend;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rluAgendaCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colAgenda;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaAmharic;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaId;
        private System.Windows.Forms.Label AgendaLabel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluAgendaIdNotAttend;
        private DevExpress.XtraGrid.Columns.GridColumn colVotingId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId1;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId1;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAttend;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluAgendaIdAttend;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
    }
}