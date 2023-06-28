namespace SHM
{
    partial class frmCalculateCurrentTotalShare
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
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctTotalShare = new DevExpress.XtraGrid.GridControl();
            this.gridTotalShare = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCalculated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurTotalSubscribedShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurTotalSubscribedShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurTotalPaidupShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurTotalPaidupShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurTotalNoOfShareholder = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.CalculateandSaveButton = new System.Windows.Forms.Button();
            SessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(38, 24);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 2;
            SessionLabel.Text = "Session:";
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(88, 21);
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
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(621, 20);
            this.SessionIdLookUpEdit.TabIndex = 1;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // gctTotalShare
            // 
            this.gctTotalShare.EmbeddedNavigator.Name = "";
            this.gctTotalShare.Location = new System.Drawing.Point(12, 109);
            this.gctTotalShare.MainView = this.gridTotalShare;
            this.gctTotalShare.Name = "gctTotalShare";
            this.gctTotalShare.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType});
            this.gctTotalShare.Size = new System.Drawing.Size(1055, 281);
            this.gctTotalShare.TabIndex = 9;
            this.gctTotalShare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTotalShare});
            // 
            // gridTotalShare
            // 
            this.gridTotalShare.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colDateCalculated,
            this.colCurTotalSubscribedShareNo,
            this.colCurTotalSubscribedShareAmnt,
            this.colCurTotalPaidupShareNo,
            this.colCurTotalPaidupShareAmnt,
            this.colCurTotalNoOfShareholder,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridTotalShare.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridTotalShare.GridControl = this.gctTotalShare;
            this.gridTotalShare.Name = "gridTotalShare";
            this.gridTotalShare.OptionsBehavior.Editable = false;
            this.gridTotalShare.OptionsView.ColumnAutoWidth = false;
            this.gridTotalShare.OptionsView.ShowGroupPanel = false;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "Session Id";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            this.colSessionId.Visible = true;
            this.colSessionId.VisibleIndex = 0;
            // 
            // colDateCalculated
            // 
            this.colDateCalculated.Caption = "Date Calculated";
            this.colDateCalculated.FieldName = "DateCalculated";
            this.colDateCalculated.Name = "colDateCalculated";
            this.colDateCalculated.Visible = true;
            this.colDateCalculated.VisibleIndex = 1;
            this.colDateCalculated.Width = 111;
            // 
            // colCurTotalSubscribedShareNo
            // 
            this.colCurTotalSubscribedShareNo.Caption = "Cur Total Subscribed Share No.";
            this.colCurTotalSubscribedShareNo.FieldName = "CurTotalSubscribedShareNo";
            this.colCurTotalSubscribedShareNo.Name = "colCurTotalSubscribedShareNo";
            this.colCurTotalSubscribedShareNo.Visible = true;
            this.colCurTotalSubscribedShareNo.VisibleIndex = 2;
            this.colCurTotalSubscribedShareNo.Width = 172;
            // 
            // colCurTotalSubscribedShareAmnt
            // 
            this.colCurTotalSubscribedShareAmnt.Caption = "Cur Total Subscribed Share Amnt";
            this.colCurTotalSubscribedShareAmnt.FieldName = "CurTotalSubscribedShareAmnt";
            this.colCurTotalSubscribedShareAmnt.Name = "colCurTotalSubscribedShareAmnt";
            this.colCurTotalSubscribedShareAmnt.Visible = true;
            this.colCurTotalSubscribedShareAmnt.VisibleIndex = 3;
            this.colCurTotalSubscribedShareAmnt.Width = 182;
            // 
            // colCurTotalPaidupShareNo
            // 
            this.colCurTotalPaidupShareNo.Caption = "Cur Total Paidup Share No.";
            this.colCurTotalPaidupShareNo.FieldName = "CurTotalPaidupShareNo";
            this.colCurTotalPaidupShareNo.Name = "colCurTotalPaidupShareNo";
            this.colCurTotalPaidupShareNo.Visible = true;
            this.colCurTotalPaidupShareNo.VisibleIndex = 4;
            this.colCurTotalPaidupShareNo.Width = 163;
            // 
            // colCurTotalPaidupShareAmnt
            // 
            this.colCurTotalPaidupShareAmnt.Caption = "Cur Total Paidup Share Amnt";
            this.colCurTotalPaidupShareAmnt.FieldName = "CurTotalPaidupShareAmnt";
            this.colCurTotalPaidupShareAmnt.Name = "colCurTotalPaidupShareAmnt";
            this.colCurTotalPaidupShareAmnt.Visible = true;
            this.colCurTotalPaidupShareAmnt.VisibleIndex = 5;
            this.colCurTotalPaidupShareAmnt.Width = 166;
            // 
            // colCurTotalNoOfShareholder
            // 
            this.colCurTotalNoOfShareholder.Caption = "Cur Total No of Shareholder";
            this.colCurTotalNoOfShareholder.FieldName = "CurTotalNoOfShareholder";
            this.colCurTotalNoOfShareholder.Name = "colCurTotalNoOfShareholder";
            this.colCurTotalNoOfShareholder.Visible = true;
            this.colCurTotalNoOfShareholder.VisibleIndex = 6;
            this.colCurTotalNoOfShareholder.Width = 169;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 7;
            this.colCrtBy.Width = 213;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 8;
            this.colCrtDt.Width = 135;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 9;
            // 
            // colLmBy
            // 
            this.colLmBy.Caption = "LmBy";
            this.colLmBy.FieldName = "LmBy";
            this.colLmBy.Name = "colLmBy";
            this.colLmBy.Visible = true;
            this.colLmBy.VisibleIndex = 10;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 11;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 12;
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
            // CalculateandSaveButton
            // 
            this.CalculateandSaveButton.Location = new System.Drawing.Point(280, 65);
            this.CalculateandSaveButton.Name = "CalculateandSaveButton";
            this.CalculateandSaveButton.Size = new System.Drawing.Size(203, 23);
            this.CalculateandSaveButton.TabIndex = 10;
            this.CalculateandSaveButton.Text = "Calculate and Save Total Share";
            this.CalculateandSaveButton.UseVisualStyleBackColor = true;
            this.CalculateandSaveButton.Click += new System.EventHandler(this.CalculateandSaveButton_Click);
            // 
            // frmCalculateCurrentTotalShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1068, 402);
            this.Controls.Add(this.CalculateandSaveButton);
            this.Controls.Add(this.gctTotalShare);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Name = "frmCalculateCurrentTotalShare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Current Total Share";
            this.Load += new System.EventHandler(this.frmCalculateCurrentTotalShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctTotalShare;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTotalShare;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private System.Windows.Forms.Button CalculateandSaveButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCalculated;
        private DevExpress.XtraGrid.Columns.GridColumn colCurTotalSubscribedShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCurTotalSubscribedShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colCurTotalPaidupShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCurTotalPaidupShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private DevExpress.XtraGrid.Columns.GridColumn colCurTotalNoOfShareholder;
    }
}