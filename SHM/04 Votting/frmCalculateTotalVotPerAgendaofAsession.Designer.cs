namespace SHM
{
    partial class frmCalculateTotalVotPerAgendaofAsession
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
            this.CalculateandSaveButton = new System.Windows.Forms.Button();
            this.gctTotalVot = new DevExpress.XtraGrid.GridControl();
            this.gridTotalVot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgendaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluAgenda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTotalShareholderVoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalShareNoVoted = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            SessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalVot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalVot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(163, 25);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 12;
            SessionLabel.Text = "Session:";
            // 
            // CalculateandSaveButton
            // 
            this.CalculateandSaveButton.Location = new System.Drawing.Point(306, 64);
            this.CalculateandSaveButton.Name = "CalculateandSaveButton";
            this.CalculateandSaveButton.Size = new System.Drawing.Size(242, 23);
            this.CalculateandSaveButton.TabIndex = 14;
            this.CalculateandSaveButton.Text = "Calculate and Save Total Vot Per Agenda";
            this.CalculateandSaveButton.UseVisualStyleBackColor = true;
            this.CalculateandSaveButton.Click += new System.EventHandler(this.CalculateandSaveButton_Click);
            // 
            // gctTotalVot
            // 
            this.gctTotalVot.EmbeddedNavigator.Name = "";
            this.gctTotalVot.Location = new System.Drawing.Point(12, 107);
            this.gctTotalVot.MainView = this.gridTotalVot;
            this.gctTotalVot.Name = "gctTotalVot";
            this.gctTotalVot.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType,
            this.rluAgenda});
            this.gctTotalVot.Size = new System.Drawing.Size(1066, 281);
            this.gctTotalVot.TabIndex = 13;
            this.gctTotalVot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTotalVot});
            // 
            // gridTotalVot
            // 
            this.gridTotalVot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colAgendaId,
            this.colTotalShareholderVoted,
            this.colTotalShareNoVoted,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridTotalVot.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridTotalVot.GridControl = this.gctTotalVot;
            this.gridTotalVot.Name = "gridTotalVot";
            this.gridTotalVot.OptionsBehavior.Editable = false;
            this.gridTotalVot.OptionsView.ColumnAutoWidth = false;
            this.gridTotalVot.OptionsView.ShowGroupPanel = false;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "Session Id";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colAgendaId
            // 
            this.colAgendaId.Caption = "Agenda";
            this.colAgendaId.ColumnEdit = this.rluAgenda;
            this.colAgendaId.FieldName = "AgendaId";
            this.colAgendaId.Name = "colAgendaId";
            this.colAgendaId.Visible = true;
            this.colAgendaId.VisibleIndex = 0;
            this.colAgendaId.Width = 685;
            // 
            // rluAgenda
            // 
            this.rluAgenda.AutoHeight = false;
            this.rluAgenda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluAgenda.DisplayMember = "Agenda";
            this.rluAgenda.Name = "rluAgenda";
            this.rluAgenda.NullText = "";
            this.rluAgenda.ValueMember = "AgendaId";
            // 
            // colTotalShareholderVoted
            // 
            this.colTotalShareholderVoted.Caption = "Total Shareholder Voted";
            this.colTotalShareholderVoted.FieldName = "TotalShareholderVoted";
            this.colTotalShareholderVoted.Name = "colTotalShareholderVoted";
            this.colTotalShareholderVoted.Visible = true;
            this.colTotalShareholderVoted.VisibleIndex = 1;
            this.colTotalShareholderVoted.Width = 194;
            // 
            // colTotalShareNoVoted
            // 
            this.colTotalShareNoVoted.Caption = "Total Share No. Voted";
            this.colTotalShareNoVoted.FieldName = "TotalShareNoVoted";
            this.colTotalShareNoVoted.Name = "colTotalShareNoVoted";
            this.colTotalShareNoVoted.Visible = true;
            this.colTotalShareNoVoted.VisibleIndex = 2;
            this.colTotalShareNoVoted.Width = 165;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 3;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 4;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 5;
            // 
            // colLmBy
            // 
            this.colLmBy.Caption = "LmBy";
            this.colLmBy.FieldName = "LmBy";
            this.colLmBy.Name = "colLmBy";
            this.colLmBy.Visible = true;
            this.colLmBy.VisibleIndex = 6;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 7;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 8;
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
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(213, 22);
            this.SessionIdLookUpEdit.Name = "SessionIdLookUpEdit";
            this.SessionIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.SessionIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SessionIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionId", "Session Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeOfMeeting", "Meeting Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionName", "Session Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Venue", "Venue", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.SessionIdLookUpEdit.Properties.DisplayMember = "SessionName";
            this.SessionIdLookUpEdit.Properties.NullText = "";
            this.SessionIdLookUpEdit.Properties.ShowHeader = false;
            this.SessionIdLookUpEdit.Properties.ValueMember = "SessionId";
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(488, 20);
            this.SessionIdLookUpEdit.TabIndex = 11;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // frmCalculateTotalVotPerAgendaofAsession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1078, 400);
            this.Controls.Add(this.CalculateandSaveButton);
            this.Controls.Add(this.gctTotalVot);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Name = "frmCalculateTotalVotPerAgendaofAsession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Total Vot Per Agend aof a Session";
            this.Load += new System.EventHandler(this.frmCalculateTotalVotPerAgendaofAsession_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculateTotalVotPerAgendaofAsession_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalVot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalVot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateandSaveButton;
        private DevExpress.XtraGrid.GridControl gctTotalVot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTotalVot;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgendaId;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalShareholderVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalShareNoVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluAgenda;
    }
}