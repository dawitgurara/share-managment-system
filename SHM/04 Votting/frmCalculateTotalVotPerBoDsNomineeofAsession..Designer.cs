namespace SHM
{
    partial class frmCalculateTotalVotPerBoDsNomineeofAsession
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
            this.colNomineeSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluNomineeSHId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNoOfNonInfluShareholderVoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoOfInfluShareholderVoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVotByNonInfluencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVotByInfluencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNombyNonInfluence = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHId)).BeginInit();
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
            SessionLabel.Location = new System.Drawing.Point(125, 36);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 20;
            SessionLabel.Text = "Session:";
            // 
            // CalculateandSaveButton
            // 
            this.CalculateandSaveButton.Location = new System.Drawing.Point(275, 86);
            this.CalculateandSaveButton.Name = "CalculateandSaveButton";
            this.CalculateandSaveButton.Size = new System.Drawing.Size(242, 31);
            this.CalculateandSaveButton.TabIndex = 22;
            this.CalculateandSaveButton.Text = "Calculate and Save Total Vot Per Nominee";
            this.CalculateandSaveButton.UseVisualStyleBackColor = true;
            this.CalculateandSaveButton.Click += new System.EventHandler(this.CalculateandSaveButton_Click);
            // 
            // gctTotalVot
            // 
            this.gctTotalVot.EmbeddedNavigator.Name = "";
            this.gctTotalVot.Location = new System.Drawing.Point(0, 149);
            this.gctTotalVot.MainView = this.gridTotalVot;
            this.gctTotalVot.Name = "gctTotalVot";
            this.gctTotalVot.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType,
            this.rluNomineeSHId});
            this.gctTotalVot.Size = new System.Drawing.Size(1209, 429);
            this.gctTotalVot.TabIndex = 21;
            this.gctTotalVot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTotalVot});
            // 
            // gridTotalVot
            // 
            this.gridTotalVot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colNomineeSHId,
            this.colNoOfNonInfluShareholderVoted,
            this.colNoOfInfluShareholderVoted,
            this.colTotalVotByNonInfluencial,
            this.colTotalVotByInfluencial,
            this.colIsNombyNonInfluence,
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
            // colNomineeSHId
            // 
            this.colNomineeSHId.Caption = "BoDs Nominee";
            this.colNomineeSHId.ColumnEdit = this.rluNomineeSHId;
            this.colNomineeSHId.FieldName = "NomineeSHId";
            this.colNomineeSHId.Name = "colNomineeSHId";
            this.colNomineeSHId.Visible = true;
            this.colNomineeSHId.VisibleIndex = 0;
            this.colNomineeSHId.Width = 493;
            // 
            // rluNomineeSHId
            // 
            this.rluNomineeSHId.AutoHeight = false;
            this.rluNomineeSHId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNomineeSHId.DisplayMember = "NomineeFullName";
            this.rluNomineeSHId.Name = "rluNomineeSHId";
            this.rluNomineeSHId.NullText = "";
            this.rluNomineeSHId.ValueMember = "NomineeSHId";
            // 
            // colNoOfNonInfluShareholderVoted
            // 
            this.colNoOfNonInfluShareholderVoted.Caption = "Total Non Influenc. Shareholder Voted";
            this.colNoOfNonInfluShareholderVoted.FieldName = "NoOfNonInfluShareholderVoted";
            this.colNoOfNonInfluShareholderVoted.Name = "colNoOfNonInfluShareholderVoted";
            this.colNoOfNonInfluShareholderVoted.Visible = true;
            this.colNoOfNonInfluShareholderVoted.VisibleIndex = 3;
            this.colNoOfNonInfluShareholderVoted.Width = 199;
            // 
            // colNoOfInfluShareholderVoted
            // 
            this.colNoOfInfluShareholderVoted.Caption = "Total Influenc. Shareholder Voted";
            this.colNoOfInfluShareholderVoted.FieldName = "NoOfInfluShareholderVoted";
            this.colNoOfInfluShareholderVoted.Name = "colNoOfInfluShareholderVoted";
            this.colNoOfInfluShareholderVoted.Visible = true;
            this.colNoOfInfluShareholderVoted.VisibleIndex = 4;
            this.colNoOfInfluShareholderVoted.Width = 177;
            // 
            // colTotalVotByNonInfluencial
            // 
            this.colTotalVotByNonInfluencial.Caption = "Total Vot by Non Influenc.";
            this.colTotalVotByNonInfluencial.FieldName = "TotalVotByNonInfluencial";
            this.colTotalVotByNonInfluencial.Name = "colTotalVotByNonInfluencial";
            this.colTotalVotByNonInfluencial.Visible = true;
            this.colTotalVotByNonInfluencial.VisibleIndex = 1;
            this.colTotalVotByNonInfluencial.Width = 142;
            // 
            // colTotalVotByInfluencial
            // 
            this.colTotalVotByInfluencial.Caption = "Total Vot by  Influenc.";
            this.colTotalVotByInfluencial.FieldName = "TotalVotByInfluencial";
            this.colTotalVotByInfluencial.Name = "colTotalVotByInfluencial";
            this.colTotalVotByInfluencial.Visible = true;
            this.colTotalVotByInfluencial.VisibleIndex = 2;
            this.colTotalVotByInfluencial.Width = 120;
            // 
            // colIsNombyNonInfluence
            // 
            this.colIsNombyNonInfluence.Caption = "Nominated by Non Influencials";
            this.colIsNombyNonInfluence.FieldName = "IsNombyNonInfluence";
            this.colIsNombyNonInfluence.Name = "colIsNombyNonInfluence";
            this.colIsNombyNonInfluence.Visible = true;
            this.colIsNombyNonInfluence.VisibleIndex = 5;
            this.colIsNombyNonInfluence.Width = 161;
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
            // colLmBy
            // 
            this.colLmBy.Caption = "LmBy";
            this.colLmBy.FieldName = "LmBy";
            this.colLmBy.Name = "colLmBy";
            this.colLmBy.Visible = true;
            this.colLmBy.VisibleIndex = 9;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 10;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 11;
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
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(175, 33);
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
            this.SessionIdLookUpEdit.TabIndex = 19;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // frmCalculateTotalVotPerBoDsNomineeofAsession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 577);
            this.Controls.Add(this.CalculateandSaveButton);
            this.Controls.Add(this.gctTotalVot);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Name = "frmCalculateTotalVotPerBoDsNomineeofAsession";
            this.Text = "Calculate Total Vot Per BoDs Nominee of a Session";
            this.Load += new System.EventHandler(this.frmCalculateTotalVotPerBoDsNomineeofAsession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalVot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalVot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeSHId)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeSHId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNomineeSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colNoOfNonInfluShareholderVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVotByNonInfluencial;
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
        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNombyNonInfluence;
        private DevExpress.XtraGrid.Columns.GridColumn colNoOfInfluShareholderVoted;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVotByInfluencial;
    }
}