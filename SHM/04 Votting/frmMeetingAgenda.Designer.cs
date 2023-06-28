namespace SHM
{
    partial class frmMeetingAgenda
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
            System.Windows.Forms.Label AgendaLabel;
            System.Windows.Forms.Label SessionLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeetingAgenda));
            this.tspMettingAgenda = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgendaAmharicTextBox = new System.Windows.Forms.TextBox();
            this.AgendaTextBox = new System.Windows.Forms.TextBox();
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctMeetingAgenda = new DevExpress.XtraGrid.GridControl();
            this.gridMeetingAgenda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAgendaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgendaAmharic = new DevExpress.XtraGrid.Columns.GridColumn();
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
            AgendaLabel = new System.Windows.Forms.Label();
            SessionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tspMettingAgenda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMeetingAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeetingAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            this.SuspendLayout();
            // 
            // AgendaLabel
            // 
            AgendaLabel.AutoSize = true;
            AgendaLabel.Location = new System.Drawing.Point(33, 48);
            AgendaLabel.Name = "AgendaLabel";
            AgendaLabel.Size = new System.Drawing.Size(47, 13);
            AgendaLabel.TabIndex = 91;
            AgendaLabel.Text = "Agenda:";
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(32, 22);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 0;
            SessionLabel.Text = "Session:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(41, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 93;
            label1.Text = "xjNÄÝ";
            // 
            // tspMettingAgenda
            // 
            this.tspMettingAgenda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspMettingAgenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspMettingAgenda.Location = new System.Drawing.Point(0, 0);
            this.tspMettingAgenda.Name = "tspMettingAgenda";
            this.tspMettingAgenda.Size = new System.Drawing.Size(997, 25);
            this.tspMettingAgenda.TabIndex = 6;
            this.tspMettingAgenda.TabStop = true;
            this.tspMettingAgenda.Text = "toolStrip1";
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
            this.groupBox1.Controls.Add(this.AgendaAmharicTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.AgendaTextBox);
            this.groupBox1.Controls.Add(AgendaLabel);
            this.groupBox1.Controls.Add(SessionLabel);
            this.groupBox1.Controls.Add(this.SessionIdLookUpEdit);
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // AgendaAmharicTextBox
            // 
            this.AgendaAmharicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgendaAmharicTextBox.Font = new System.Drawing.Font("VG2 Main", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaAmharicTextBox.Location = new System.Drawing.Point(82, 71);
            this.AgendaAmharicTextBox.Name = "AgendaAmharicTextBox";
            this.AgendaAmharicTextBox.Size = new System.Drawing.Size(540, 24);
            this.AgendaAmharicTextBox.TabIndex = 94;
            // 
            // AgendaTextBox
            // 
            this.AgendaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgendaTextBox.Location = new System.Drawing.Point(82, 45);
            this.AgendaTextBox.Name = "AgendaTextBox";
            this.AgendaTextBox.Size = new System.Drawing.Size(540, 20);
            this.AgendaTextBox.TabIndex = 92;
            this.AgendaTextBox.Validated += new System.EventHandler(this.AgendaTextBox_Validated);
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(82, 19);
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
            this.SessionIdLookUpEdit.TabIndex = 0;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // gctMeetingAgenda
            // 
            this.gctMeetingAgenda.EmbeddedNavigator.Name = "";
            this.gctMeetingAgenda.Location = new System.Drawing.Point(12, 167);
            this.gctMeetingAgenda.MainView = this.gridMeetingAgenda;
            this.gctMeetingAgenda.Name = "gctMeetingAgenda";
            this.gctMeetingAgenda.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType});
            this.gctMeetingAgenda.Size = new System.Drawing.Size(973, 281);
            this.gctMeetingAgenda.TabIndex = 8;
            this.gctMeetingAgenda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMeetingAgenda});
            // 
            // gridMeetingAgenda
            // 
            this.gridMeetingAgenda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAgendaId,
            this.colSessionId,
            this.colAgenda,
            this.colAgendaAmharic,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridMeetingAgenda.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridMeetingAgenda.GridControl = this.gctMeetingAgenda;
            this.gridMeetingAgenda.Name = "gridMeetingAgenda";
            this.gridMeetingAgenda.OptionsBehavior.Editable = false;
            this.gridMeetingAgenda.OptionsView.ColumnAutoWidth = false;
            this.gridMeetingAgenda.OptionsView.ShowGroupPanel = false;
            this.gridMeetingAgenda.DoubleClick += new System.EventHandler(this.gridMeetingAgenda_DoubleClick);
            // 
            // colAgendaId
            // 
            this.colAgendaId.Caption = "AgendaId";
            this.colAgendaId.FieldName = "AgendaId";
            this.colAgendaId.Name = "colAgendaId";
            this.colAgendaId.OptionsColumn.ReadOnly = true;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colAgenda
            // 
            this.colAgenda.Caption = "Agenda";
            this.colAgenda.FieldName = "Agenda";
            this.colAgenda.Name = "colAgenda";
            this.colAgenda.Visible = true;
            this.colAgenda.VisibleIndex = 0;
            this.colAgenda.Width = 477;
            // 
            // colAgendaAmharic
            // 
            this.colAgendaAmharic.AppearanceCell.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAgendaAmharic.AppearanceCell.Options.UseFont = true;
            this.colAgendaAmharic.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAgendaAmharic.AppearanceHeader.Options.UseFont = true;
            this.colAgendaAmharic.Caption = "xjNÄ";
            this.colAgendaAmharic.FieldName = "AgendaAmharic";
            this.colAgendaAmharic.Name = "colAgendaAmharic";
            this.colAgendaAmharic.Visible = true;
            this.colAgendaAmharic.VisibleIndex = 1;
            this.colAgendaAmharic.Width = 477;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 2;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 3;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 4;
            // 
            // colLmBy
            // 
            this.colLmBy.Caption = "LmBy";
            this.colLmBy.FieldName = "LmBy";
            this.colLmBy.Name = "colLmBy";
            this.colLmBy.Visible = true;
            this.colLmBy.VisibleIndex = 5;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 6;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 7;
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
            // frmMeetingAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(997, 460);
            this.Controls.Add(this.gctMeetingAgenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspMettingAgenda);
            this.Name = "frmMeetingAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Agenda Entry Form";
            this.Load += new System.EventHandler(this.frmMeetingAgenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMeetingAgenda_KeyDown);
            this.tspMettingAgenda.ResumeLayout(false);
            this.tspMettingAgenda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMeetingAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeetingAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMettingAgenda;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AgendaTextBox;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctMeetingAgenda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMeetingAgenda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private System.Windows.Forms.TextBox AgendaAmharicTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaAmharic;
    }
}