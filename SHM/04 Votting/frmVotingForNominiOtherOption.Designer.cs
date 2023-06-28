namespace SHM
{
    partial class frmVotingForNominiOtherOption
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
            System.Windows.Forms.Label AgendaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotingForNominiOtherOption));
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gctVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVotingId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdVoted = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAtnd = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gctNotVotedSH = new DevExpress.XtraGrid.GridControl();
            this.gridNotVotedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdNotVoted = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NomineeSHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tspSelectionCriteria = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            SessionLabel = new System.Windows.Forms.Label();
            AgendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdVoted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotVoted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).BeginInit();
            this.tspSelectionCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(35, 36);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 68;
            SessionLabel.Text = "Session:";
            // 
            // AgendaLabel
            // 
            AgendaLabel.AutoSize = true;
            AgendaLabel.Location = new System.Drawing.Point(30, 62);
            AgendaLabel.Name = "AgendaLabel";
            AgendaLabel.Size = new System.Drawing.Size(52, 13);
            AgendaLabel.TabIndex = 72;
            AgendaLabel.Text = "Nominee:";
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(85, 33);
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
            this.SessionIdLookUpEdit.TabIndex = 67;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gctVotedSH);
            this.groupBox1.Location = new System.Drawing.Point(523, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 501);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shareholders,   voted for the selected Nominee";
            // 
            // gctVotedSH
            // 
            this.gctVotedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctVotedSH.EmbeddedNavigator.Name = "";
            this.gctVotedSH.Location = new System.Drawing.Point(0, 12);
            this.gctVotedSH.MainView = this.gridVotedSH;
            this.gctVotedSH.Name = "gctVotedSH";
            this.gctVotedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluSHIdAtnd,
            this.rluSHIdVoted});
            this.gctVotedSH.Size = new System.Drawing.Size(499, 483);
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
            this.colRegCode1,
            this.colSHId2,
            this.colShareNo1,
            this.colShareAmnt1});
            this.gridVotedSH.GridControl = this.gctVotedSH;
            this.gridVotedSH.Name = "gridVotedSH";
            this.gridVotedSH.OptionsBehavior.Editable = false;
            this.gridVotedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridVotedSH.OptionsCustomization.AllowGroup = false;
            this.gridVotedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridVotedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridVotedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridVotedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridVotedSH.OptionsView.ShowGroupPanel = false;
            this.gridVotedSH.OptionsView.ShowHorzLines = false;
            this.gridVotedSH.OptionsView.ShowVertLines = false;
            this.gridVotedSH.DoubleClick += new System.EventHandler(this.gridVotedSH_DoubleClick);
            // 
            // colVotingId
            // 
            this.colVotingId.Caption = "colVotingId";
            this.colVotingId.FieldName = "VotingId";
            this.colVotingId.Name = "colVotingId";
            // 
            // colSessionId1
            // 
            this.colSessionId1.Caption = "SessionId";
            this.colSessionId1.FieldName = "SessionId";
            this.colSessionId1.Name = "colSessionId1";
            // 
            // colRegCode1
            // 
            this.colRegCode1.Caption = "Registration Code";
            this.colRegCode1.FieldName = "RegCode";
            this.colRegCode1.Name = "colRegCode1";
            this.colRegCode1.Visible = true;
            this.colRegCode1.VisibleIndex = 0;
            this.colRegCode1.Width = 106;
            // 
            // colSHId2
            // 
            this.colSHId2.Caption = "Full Name";
            this.colSHId2.ColumnEdit = this.rluSHIdVoted;
            this.colSHId2.FieldName = "VoterSHId";
            this.colSHId2.Name = "colSHId2";
            this.colSHId2.Visible = true;
            this.colSHId2.VisibleIndex = 1;
            this.colSHId2.Width = 239;
            // 
            // rluSHIdVoted
            // 
            this.rluSHIdVoted.AutoHeight = false;
            this.rluSHIdVoted.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdVoted.DisplayMember = "FullName";
            this.rluSHIdVoted.Name = "rluSHIdVoted";
            this.rluSHIdVoted.NullText = "";
            this.rluSHIdVoted.ValueMember = "SHId";
            // 
            // colShareNo1
            // 
            this.colShareNo1.Caption = "Subscribed Share No.";
            this.colShareNo1.FieldName = "ShareNo";
            this.colShareNo1.Name = "colShareNo1";
            this.colShareNo1.Visible = true;
            this.colShareNo1.VisibleIndex = 2;
            this.colShareNo1.Width = 133;
            // 
            // colShareAmnt1
            // 
            this.colShareAmnt1.Caption = "Subscribed Share Amnt.";
            this.colShareAmnt1.FieldName = "ShareAmnt";
            this.colShareAmnt1.Name = "colShareAmnt1";
            this.colShareAmnt1.Width = 149;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gctNotVotedSH);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 501);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shareholders, not voted for the selected nominee";
            // 
            // gctNotVotedSH
            // 
            this.gctNotVotedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctNotVotedSH.EmbeddedNavigator.Name = "";
            this.gctNotVotedSH.Location = new System.Drawing.Point(6, 12);
            this.gctNotVotedSH.MainView = this.gridNotVotedSH;
            this.gctNotVotedSH.Name = "gctNotVotedSH";
            this.gctNotVotedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.rluSHIdNotVoted});
            this.gctNotVotedSH.Size = new System.Drawing.Size(499, 483);
            this.gctNotVotedSH.TabIndex = 54;
            this.gctNotVotedSH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNotVotedSH});
            // 
            // gridNotVotedSH
            // 
            this.gridNotVotedSH.ActiveFilterEnabled = false;
            this.gridNotVotedSH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegCode,
            this.colSHId,
            this.colShareNo,
            this.colShareAmnt});
            this.gridNotVotedSH.GridControl = this.gctNotVotedSH;
            this.gridNotVotedSH.Name = "gridNotVotedSH";
            this.gridNotVotedSH.OptionsBehavior.Editable = false;
            this.gridNotVotedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridNotVotedSH.OptionsCustomization.AllowGroup = false;
            this.gridNotVotedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridNotVotedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridNotVotedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridNotVotedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridNotVotedSH.OptionsView.ShowGroupPanel = false;
            this.gridNotVotedSH.OptionsView.ShowHorzLines = false;
            this.gridNotVotedSH.OptionsView.ShowVertLines = false;
            this.gridNotVotedSH.DoubleClick += new System.EventHandler(this.gridNotVotedSH_DoubleClick);
            // 
            // colRegCode
            // 
            this.colRegCode.Caption = "Registration Code";
            this.colRegCode.FieldName = "RegCode";
            this.colRegCode.Name = "colRegCode";
            this.colRegCode.Visible = true;
            this.colRegCode.VisibleIndex = 0;
            this.colRegCode.Width = 106;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "Full Name";
            this.colSHId.ColumnEdit = this.rluSHIdNotVoted;
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            this.colSHId.Visible = true;
            this.colSHId.VisibleIndex = 1;
            this.colSHId.Width = 245;
            // 
            // rluSHIdNotVoted
            // 
            this.rluSHIdNotVoted.AutoHeight = false;
            this.rluSHIdNotVoted.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHIdNotVoted.DisplayMember = "FullName";
            this.rluSHIdNotVoted.Name = "rluSHIdNotVoted";
            this.rluSHIdNotVoted.NullText = "";
            this.rluSHIdNotVoted.ValueMember = "SHId";
            // 
            // colShareNo
            // 
            this.colShareNo.Caption = "Subscribed Share No.";
            this.colShareNo.FieldName = "ShareNo";
            this.colShareNo.Name = "colShareNo";
            this.colShareNo.Visible = true;
            this.colShareNo.VisibleIndex = 2;
            this.colShareNo.Width = 127;
            // 
            // colShareAmnt
            // 
            this.colShareAmnt.Caption = "Subscribed Share Amnt.";
            this.colShareAmnt.FieldName = "ShareAmnt";
            this.colShareAmnt.Name = "colShareAmnt";
            this.colShareAmnt.Width = 140;
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
            // NomineeSHIdLookUpEdit
            // 
            this.NomineeSHIdLookUpEdit.Location = new System.Drawing.Point(85, 59);
            this.NomineeSHIdLookUpEdit.Name = "NomineeSHIdLookUpEdit";
            this.NomineeSHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NomineeSHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NomineeSHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeId", "S.No.", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeSHId", "Nominee SH Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeFullName", "Nominee Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomineeFullNameAmharic", "Nominee Amharic Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.NomineeSHIdLookUpEdit.Properties.DisplayMember = "NomineeFullName";
            this.NomineeSHIdLookUpEdit.Properties.NullText = "";
            this.NomineeSHIdLookUpEdit.Properties.ShowHeader = false;
            this.NomineeSHIdLookUpEdit.Properties.ValueMember = "NomineeSHId";
            this.NomineeSHIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.NomineeSHIdLookUpEdit.TabIndex = 71;
            this.NomineeSHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.NomineeSHIdLookUpEdit_EditValueChanged);
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
            this.tspSelectionCriteria.TabIndex = 73;
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
            // frmVotingForNominiOtherOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1028, 593);
            this.Controls.Add(this.tspSelectionCriteria);
            this.Controls.Add(AgendaLabel);
            this.Controls.Add(this.NomineeSHIdLookUpEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Name = "frmVotingForNominiOtherOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting for Election Committee Nominee";
            this.Load += new System.EventHandler(this.frmVotingForNominiOtherOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdVoted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotVotedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotVoted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomineeSHIdLookUpEdit.Properties)).EndInit();
            this.tspSelectionCriteria.ResumeLayout(false);
            this.tspSelectionCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gctVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVotedSH;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId1;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gctNotVotedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNotVotedSH;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdNotVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit NomineeSHIdLookUpEdit;
        private System.Windows.Forms.ToolStrip tspSelectionCriteria;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private DevExpress.XtraGrid.Columns.GridColumn colVotingId;
    }
}