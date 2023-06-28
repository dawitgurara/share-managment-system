namespace SHM
{
    partial class frmVotingEnquiry
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
            System.Windows.Forms.Label SessionIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotingEnquiry));
            this.tspVotSearch = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gctVotEnquiryType = new DevExpress.XtraGrid.GridControl();
            this.gridVotEnquiryType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctVotEnquiryValue = new DevExpress.XtraGrid.GridControl();
            this.gridVotEnquiryValue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            SessionIdLabel = new System.Windows.Forms.Label();
            this.tspVotSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotEnquiryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotEnquiryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotEnquiryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotEnquiryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionIdLabel
            // 
            SessionIdLabel.AutoSize = true;
            SessionIdLabel.Location = new System.Drawing.Point(71, 44);
            SessionIdLabel.Name = "SessionIdLabel";
            SessionIdLabel.Size = new System.Drawing.Size(47, 13);
            SessionIdLabel.TabIndex = 17;
            SessionIdLabel.Text = "Session:";
            // 
            // tspVotSearch
            // 
            this.tspVotSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspVotSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.tspVotSearch.Location = new System.Drawing.Point(0, 0);
            this.tspVotSearch.Name = "tspVotSearch";
            this.tspVotSearch.Size = new System.Drawing.Size(1016, 25);
            this.tspVotSearch.TabIndex = 15;
            this.tspVotSearch.TabStop = true;
            this.tspVotSearch.Text = "toolStrip1";
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
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(25, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 341);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Session Information";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gctVotEnquiryType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gctVotEnquiryValue);
            this.splitContainer1.Size = new System.Drawing.Size(954, 316);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 57;
            // 
            // gctVotEnquiryType
            // 
            this.gctVotEnquiryType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctVotEnquiryType.EmbeddedNavigator.Name = "";
            this.gctVotEnquiryType.Location = new System.Drawing.Point(0, 0);
            this.gctVotEnquiryType.MainView = this.gridVotEnquiryType;
            this.gctVotEnquiryType.Name = "gctVotEnquiryType";
            this.gctVotEnquiryType.Size = new System.Drawing.Size(157, 316);
            this.gctVotEnquiryType.TabIndex = 0;
            this.gctVotEnquiryType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVotEnquiryType});
            // 
            // gridVotEnquiryType
            // 
            this.gridVotEnquiryType.ActiveFilterEnabled = false;
            this.gridVotEnquiryType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescription,
            this.colTableName});
            this.gridVotEnquiryType.GridControl = this.gctVotEnquiryType;
            this.gridVotEnquiryType.Name = "gridVotEnquiryType";
            this.gridVotEnquiryType.OptionsBehavior.Editable = false;
            this.gridVotEnquiryType.OptionsCustomization.AllowColumnMoving = false;
            this.gridVotEnquiryType.OptionsCustomization.AllowFilter = false;
            this.gridVotEnquiryType.OptionsCustomization.AllowGroup = false;
            this.gridVotEnquiryType.OptionsCustomization.AllowSort = false;
            this.gridVotEnquiryType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridVotEnquiryType.OptionsSelection.UseIndicatorForSelection = false;
            this.gridVotEnquiryType.OptionsView.ColumnAutoWidth = false;
            this.gridVotEnquiryType.OptionsView.ShowColumnHeaders = false;
            this.gridVotEnquiryType.OptionsView.ShowGroupPanel = false;
            this.gridVotEnquiryType.OptionsView.ShowHorzLines = false;
            this.gridVotEnquiryType.OptionsView.ShowIndicator = false;
            this.gridVotEnquiryType.OptionsView.ShowVertLines = false;
            this.gridVotEnquiryType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridVotEnquiryType_FocusedRowChanged);
            this.gridVotEnquiryType.Click += new System.EventHandler(this.gridVotEnquiryType_Click);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Category";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 116;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "TableName";
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            // 
            // gctVotEnquiryValue
            // 
            this.gctVotEnquiryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctVotEnquiryValue.EmbeddedNavigator.Name = "";
            this.gctVotEnquiryValue.Location = new System.Drawing.Point(0, 0);
            this.gctVotEnquiryValue.MainView = this.gridVotEnquiryValue;
            this.gctVotEnquiryValue.Name = "gctVotEnquiryValue";
            this.gctVotEnquiryValue.Size = new System.Drawing.Size(793, 316);
            this.gctVotEnquiryValue.TabIndex = 0;
            this.gctVotEnquiryValue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVotEnquiryValue});
            // 
            // gridVotEnquiryValue
            // 
            this.gridVotEnquiryValue.ActiveFilterEnabled = false;
            this.gridVotEnquiryValue.GridControl = this.gctVotEnquiryValue;
            this.gridVotEnquiryValue.Name = "gridVotEnquiryValue";
            this.gridVotEnquiryValue.OptionsBehavior.Editable = false;
            this.gridVotEnquiryValue.OptionsCustomization.AllowColumnMoving = false;
            this.gridVotEnquiryValue.OptionsCustomization.AllowFilter = false;
            this.gridVotEnquiryValue.OptionsCustomization.AllowGroup = false;
            this.gridVotEnquiryValue.OptionsCustomization.AllowSort = false;
            this.gridVotEnquiryValue.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridVotEnquiryValue.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridVotEnquiryValue.OptionsView.ColumnAutoWidth = false;
            this.gridVotEnquiryValue.OptionsView.EnableAppearanceEvenRow = true;
            this.gridVotEnquiryValue.OptionsView.EnableAppearanceOddRow = true;
            this.gridVotEnquiryValue.OptionsView.ShowGroupPanel = false;
            this.gridVotEnquiryValue.OptionsView.ShowHorzLines = false;
            this.gridVotEnquiryValue.OptionsView.ShowIndicator = false;
            this.gridVotEnquiryValue.OptionsView.ShowVertLines = false;
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(124, 41);
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
            this.SessionIdLookUpEdit.TabIndex = 19;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // frmVotingEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 445);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(SessionIdLabel);
            this.Controls.Add(this.tspVotSearch);
            this.Name = "frmVotingEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Session Enquiry";
            this.Load += new System.EventHandler(this.frmVotingEnquiry_Load);
            this.tspVotSearch.ResumeLayout(false);
            this.tspVotSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctVotEnquiryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotEnquiryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctVotEnquiryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVotEnquiryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspVotSearch;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gctVotEnquiryType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVotEnquiryType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.GridControl gctVotEnquiryValue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVotEnquiryValue;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
    }
}