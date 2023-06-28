namespace SHM
{
    partial class frmMeetingAttendee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeetingAttendee));
            this.tspAttendee = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gctNotAtendedSH = new DevExpress.XtraGrid.GridControl();
            this.gridNotAtendedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdNotAtend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gctAtendedSH = new DevExpress.XtraGrid.GridControl();
            this.gridAtendedSH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAtend = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colShareNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShareAmnt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHIdAtnd = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCommitteeResp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommitteeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.colSHId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            SessionLabel = new System.Windows.Forms.Label();
            this.tspAttendee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNotAtendedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotAtendedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctAtendedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendedSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(44, 40);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 66;
            SessionLabel.Text = "Session:";
            // 
            // tspAttendee
            // 
            this.tspAttendee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspAttendee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.refreshToolStripButton});
            this.tspAttendee.Location = new System.Drawing.Point(0, 0);
            this.tspAttendee.Name = "tspAttendee";
            this.tspAttendee.Size = new System.Drawing.Size(1307, 25);
            this.tspAttendee.TabIndex = 59;
            this.tspAttendee.TabStop = true;
            this.tspAttendee.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Enabled = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gctNotAtendedSH);
            this.groupBox2.Location = new System.Drawing.Point(19, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 515);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shareholders not Attended the Meeting";
            // 
            // gctNotAtendedSH
            // 
            this.gctNotAtendedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctNotAtendedSH.EmbeddedNavigator.Name = "";
            this.gctNotAtendedSH.Location = new System.Drawing.Point(4, 12);
            this.gctNotAtendedSH.MainView = this.gridNotAtendedSH;
            this.gctNotAtendedSH.Name = "gctNotAtendedSH";
            this.gctNotAtendedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.rluSHIdNotAtend});
            this.gctNotAtendedSH.Size = new System.Drawing.Size(616, 497);
            this.gctNotAtendedSH.TabIndex = 54;
            this.gctNotAtendedSH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNotAtendedSH});
            // 
            // gridNotAtendedSH
            // 
            this.gridNotAtendedSH.ActiveFilterEnabled = false;
            this.gridNotAtendedSH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegCode,
            this.colSHId,
            this.colShareNo,
            this.colShareAmnt});
            this.gridNotAtendedSH.GridControl = this.gctNotAtendedSH;
            this.gridNotAtendedSH.Name = "gridNotAtendedSH";
            this.gridNotAtendedSH.OptionsBehavior.Editable = false;
            this.gridNotAtendedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridNotAtendedSH.OptionsCustomization.AllowGroup = false;
            this.gridNotAtendedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridNotAtendedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridNotAtendedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridNotAtendedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridNotAtendedSH.OptionsView.ShowGroupPanel = false;
            this.gridNotAtendedSH.OptionsView.ShowHorzLines = false;
            this.gridNotAtendedSH.OptionsView.ShowVertLines = false;
            this.gridNotAtendedSH.DoubleClick += new System.EventHandler(this.gridNotAtendedSH_DoubleClick);
            // 
            // colRegCode
            // 
            this.colRegCode.Caption = "Registration Code";
            this.colRegCode.FieldName = "RegCode";
            this.colRegCode.Name = "colRegCode";
            this.colRegCode.Visible = true;
            this.colRegCode.VisibleIndex = 0;
            this.colRegCode.Width = 100;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "Full Name";
            this.colSHId.ColumnEdit = this.rluSHIdNotAtend;
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            this.colSHId.Visible = true;
            this.colSHId.VisibleIndex = 1;
            this.colSHId.Width = 214;
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
            // colShareNo
            // 
            this.colShareNo.Caption = "Subscribed Share No.";
            this.colShareNo.FieldName = "ShareNo";
            this.colShareNo.Name = "colShareNo";
            this.colShareNo.Visible = true;
            this.colShareNo.VisibleIndex = 2;
            this.colShareNo.Width = 115;
            // 
            // colShareAmnt
            // 
            this.colShareAmnt.Caption = "Subscribed Share Amnt.";
            this.colShareAmnt.FieldName = "ShareAmnt";
            this.colShareAmnt.Name = "colShareAmnt";
            this.colShareAmnt.Visible = true;
            this.colShareAmnt.VisibleIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gctAtendedSH);
            this.groupBox1.Location = new System.Drawing.Point(646, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 515);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shareholders  Attended the Meeting";
            // 
            // gctAtendedSH
            // 
            this.gctAtendedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctAtendedSH.EmbeddedNavigator.Name = "";
            this.gctAtendedSH.Location = new System.Drawing.Point(0, 12);
            this.gctAtendedSH.MainView = this.gridAtendedSH;
            this.gctAtendedSH.Name = "gctAtendedSH";
            this.gctAtendedSH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluSHIdAtnd,
            this.rluSHIdAtend});
            this.gctAtendedSH.Size = new System.Drawing.Size(643, 497);
            this.gctAtendedSH.TabIndex = 53;
            this.gctAtendedSH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAtendedSH});
            // 
            // gridAtendedSH
            // 
            this.gridAtendedSH.ActiveFilterEnabled = false;
            this.gridAtendedSH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId1,
            this.colRegCode1,
            this.colSHId2,
            this.colShareNo1,
            this.colShareAmnt1});
            this.gridAtendedSH.GridControl = this.gctAtendedSH;
            this.gridAtendedSH.Name = "gridAtendedSH";
            this.gridAtendedSH.OptionsBehavior.Editable = false;
            this.gridAtendedSH.OptionsCustomization.AllowColumnMoving = false;
            this.gridAtendedSH.OptionsCustomization.AllowGroup = false;
            this.gridAtendedSH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridAtendedSH.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridAtendedSH.OptionsView.EnableAppearanceEvenRow = true;
            this.gridAtendedSH.OptionsView.EnableAppearanceOddRow = true;
            this.gridAtendedSH.OptionsView.ShowGroupPanel = false;
            this.gridAtendedSH.OptionsView.ShowHorzLines = false;
            this.gridAtendedSH.OptionsView.ShowVertLines = false;
            this.gridAtendedSH.DoubleClick += new System.EventHandler(this.gridAtendedSH_DoubleClick);
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
            this.colRegCode1.Width = 130;
            // 
            // colSHId2
            // 
            this.colSHId2.Caption = "Full Name";
            this.colSHId2.ColumnEdit = this.rluSHIdAtend;
            this.colSHId2.FieldName = "SHId";
            this.colSHId2.Name = "colSHId2";
            this.colSHId2.Visible = true;
            this.colSHId2.VisibleIndex = 1;
            this.colSHId2.Width = 228;
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
            // colShareNo1
            // 
            this.colShareNo1.Caption = "Subscribed Share No.";
            this.colShareNo1.FieldName = "ShareNo";
            this.colShareNo1.Name = "colShareNo1";
            this.colShareNo1.Visible = true;
            this.colShareNo1.VisibleIndex = 2;
            this.colShareNo1.Width = 114;
            // 
            // colShareAmnt1
            // 
            this.colShareAmnt1.Caption = "Subscribed Share Amnt.";
            this.colShareAmnt1.FieldName = "ShareAmnt";
            this.colShareAmnt1.Name = "colShareAmnt1";
            this.colShareAmnt1.Visible = true;
            this.colShareAmnt1.VisibleIndex = 3;
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
            // colCommitteeResp
            // 
            this.colCommitteeResp.Caption = "CommitteeResp";
            this.colCommitteeResp.FieldName = "CommitteeResp";
            this.colCommitteeResp.Name = "colCommitteeResp";
            // 
            // colCommitteeType
            // 
            this.colCommitteeType.Caption = "CommitteeType";
            this.colCommitteeType.FieldName = "CommitteeType";
            this.colCommitteeType.Name = "colCommitteeType";
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Caption = "Member";
            this.colEmployeeId.FieldName = "EmpId";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.Visible = true;
            this.colEmployeeId.VisibleIndex = 0;
            this.colEmployeeId.Width = 256;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(94, 37);
            this.SessionIdLookUpEdit.Name = "SessionIdLookUpEdit";
            this.SessionIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.SessionIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SessionIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionId", "Session Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeOfMeeting", "Meeting Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionNane", "Session Nane", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Venue", "Venue", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.SessionIdLookUpEdit.Properties.DisplayMember = "SessionName";
            this.SessionIdLookUpEdit.Properties.NullText = "";
            this.SessionIdLookUpEdit.Properties.ShowHeader = false;
            this.SessionIdLookUpEdit.Properties.ValueMember = "SessionId";
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.SessionIdLookUpEdit.TabIndex = 65;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // colSHId1
            // 
            this.colSHId1.Caption = "Full Name";
            this.colSHId1.FieldName = "SHId";
            this.colSHId1.Name = "colSHId1";
            this.colSHId1.Visible = true;
            this.colSHId1.VisibleIndex = 0;
            this.colSHId1.Width = 357;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // frmMeetingAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1307, 611);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tspAttendee);
            this.Name = "frmMeetingAttendee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shareholder Meeting Attendee Entry Form";
            this.Load += new System.EventHandler(this.frmMeetingAttendee_Load);
            this.tspAttendee.ResumeLayout(false);
            this.tspAttendee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctNotAtendedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotAtendedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdNotAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctAtendedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendedSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHIdAtnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspAttendee;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gctAtendedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAtendedSH;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtnd;
        private DevExpress.XtraGrid.Columns.GridColumn colCommitteeResp;
        private DevExpress.XtraGrid.Columns.GridColumn colCommitteeType;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdAtend;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId2;
        private DevExpress.XtraGrid.GridControl gctNotAtendedSH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNotAtendedSH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHIdNotAtend;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colShareNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colShareAmnt1;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
    }
}