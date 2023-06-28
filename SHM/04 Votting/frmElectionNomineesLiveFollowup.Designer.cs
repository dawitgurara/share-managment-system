namespace SHM
{
    partial class frmElectionNomineesLiveFollowup
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.sHMDataSet = new SHM.SHMDataSet();
            this.gctComtNomnee = new DevExpress.XtraGrid.GridControl();
            this.gridComtNominee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNominationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomineeFullNameAmharic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluMeetingType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNomineeLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sHMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctComtNomnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComtNominee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("VG2 Main", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(965, 58);
            this.label2.TabIndex = 70;
            this.label2.Text = "የእጩ አስመራጭ ኮሚቴ አባላት መከታተያ ገጽ";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(2075, 20);
            this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(702, 49);
            this.CurrentTimeLabel.TabIndex = 68;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // sHMDataSet
            // 
            this.sHMDataSet.DataSetName = "SHMDataSet";
            this.sHMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gctComtNomnee
            // 
            this.gctComtNomnee.EmbeddedNavigator.Name = "";
            this.gctComtNomnee.Location = new System.Drawing.Point(12, 109);
            this.gctComtNomnee.MainView = this.gridComtNominee;
            this.gctComtNomnee.Name = "gctComtNomnee";
            this.gctComtNomnee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType,
            this.rluNomineeLookUpEdit});
            this.gctComtNomnee.Size = new System.Drawing.Size(1342, 526);
            this.gctComtNomnee.TabIndex = 71;
            this.gctComtNomnee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridComtNominee});
            // 
            // gridComtNominee
            // 
            this.gridComtNominee.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridComtNominee.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridComtNominee.Appearance.Row.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridComtNominee.Appearance.Row.Options.UseFont = true;
            this.gridComtNominee.AppearancePrint.Row.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridComtNominee.AppearancePrint.Row.Options.UseFont = true;
            this.gridComtNominee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNominationId,
            this.colSessionId,
            this.colSHId,
            this.colNomineeRegCode,
            this.colNomineeFullNameAmharic});
            this.gridComtNominee.CustomizationFormBounds = new System.Drawing.Rectangle(816, 472, 208, 170);
            this.gridComtNominee.FixedLineWidth = 12;
            this.gridComtNominee.GridControl = this.gctComtNomnee;
            this.gridComtNominee.Name = "gridComtNominee";
            this.gridComtNominee.OptionsBehavior.Editable = false;
            this.gridComtNominee.OptionsCustomization.AllowRowSizing = true;
            this.gridComtNominee.OptionsView.ColumnAutoWidth = false;
            this.gridComtNominee.OptionsView.RowAutoHeight = true;
            this.gridComtNominee.OptionsView.ShowColumnHeaders = false;
            this.gridComtNominee.OptionsView.ShowGroupPanel = false;
            this.gridComtNominee.RowHeight = 45;
            // 
            // colNominationId
            // 
            this.colNominationId.AppearanceCell.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNominationId.AppearanceCell.Options.UseFont = true;
            this.colNominationId.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNominationId.AppearanceHeader.Options.UseFont = true;
            this.colNominationId.AppearanceHeader.Options.UseTextOptions = true;
            this.colNominationId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNominationId.Caption = "t.q$.";
            this.colNominationId.FieldName = "NomineeId";
            this.colNominationId.MinWidth = 40;
            this.colNominationId.Name = "colNominationId";
            this.colNominationId.OptionsColumn.ReadOnly = true;
            this.colNominationId.Visible = true;
            this.colNominationId.VisibleIndex = 0;
            this.colNominationId.Width = 143;
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
            this.colNomineeRegCode.AppearanceCell.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeRegCode.AppearanceCell.Options.UseFont = true;
            this.colNomineeRegCode.AppearanceCell.Options.UseTextOptions = true;
            this.colNomineeRegCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNomineeRegCode.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeRegCode.AppearanceHeader.Options.UseFont = true;
            this.colNomineeRegCode.Caption = "m.q$.";
            this.colNomineeRegCode.FieldName = "NomineeRegCode";
            this.colNomineeRegCode.MinWidth = 30;
            this.colNomineeRegCode.Name = "colNomineeRegCode";
            this.colNomineeRegCode.Visible = true;
            this.colNomineeRegCode.VisibleIndex = 1;
            this.colNomineeRegCode.Width = 225;
            // 
            // colNomineeFullNameAmharic
            // 
            this.colNomineeFullNameAmharic.AppearanceCell.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeFullNameAmharic.AppearanceCell.Options.UseFont = true;
            this.colNomineeFullNameAmharic.AppearanceCell.Options.UseTextOptions = true;
            this.colNomineeFullNameAmharic.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNomineeFullNameAmharic.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomineeFullNameAmharic.AppearanceHeader.Options.UseFont = true;
            this.colNomineeFullNameAmharic.Caption = "yXŒ xSm‰+ ÷¸t&& SM";
            this.colNomineeFullNameAmharic.FieldName = "NomineeFullNameAmharic";
            this.colNomineeFullNameAmharic.MinWidth = 30;
            this.colNomineeFullNameAmharic.Name = "colNomineeFullNameAmharic";
            this.colNomineeFullNameAmharic.Visible = true;
            this.colNomineeFullNameAmharic.VisibleIndex = 2;
            this.colNomineeFullNameAmharic.Width = 954;
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 72;
            this.label1.Text = "ተ.ቁ.";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 35);
            this.label3.TabIndex = 73;
            this.label3.Text = "መ.ቁ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("VG2 Main", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(959, 35);
            this.label4.TabIndex = 74;
            this.label4.Text = "የእጩ አስመራጭ ኮሚቴ ስም";
            // 
            // frmElectionNomineesLiveFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gctComtNomnee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Font = new System.Drawing.Font("VG2 Main", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "frmElectionNomineesLiveFollowup";
            this.Text = "የእጩ አስመራጭ ኮሚቴ አባላት መከታተያ ገጽ";
            this.Load += new System.EventHandler(this.frmElectionNomineesLiveFollowup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sHMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctComtNomnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComtNominee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNomineeLookUpEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Timer RefreshTimer;
        private SHMDataSet sHMDataSet;
        private DevExpress.XtraGrid.GridControl gctComtNomnee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridComtNominee;
        private DevExpress.XtraGrid.Columns.GridColumn colNominationId;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeRegCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNomineeFullNameAmharic;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNomineeLookUpEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}