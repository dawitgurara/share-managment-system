namespace SHM
{
    partial class frmDividendCalculation
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
            System.Windows.Forms.Label budgetYearLabel;
            this.budgetYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gctDividendEntitled = new DevExpress.XtraGrid.GridControl();
            this.gridDividendEntitled = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidupNoofShare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidupShareAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLFRRDiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGFRRDiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommonDiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingDiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDividendAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetDividend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCapitalized = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLBFounder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsGBFounder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            budgetYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.budgetYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendEntitled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendEntitled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(69, 15);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(69, 13);
            budgetYearLabel.TabIndex = 114;
            budgetYearLabel.Text = "Budget Year:";
            // 
            // budgetYearLookUpEdit
            // 
            this.budgetYearLookUpEdit.Location = new System.Drawing.Point(141, 12);
            this.budgetYearLookUpEdit.Name = "budgetYearLookUpEdit";
            this.budgetYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.budgetYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.budgetYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDate", "Start Date", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EndDate", "End Date", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Closed", "Closed", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.budgetYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.budgetYearLookUpEdit.Properties.NullText = "";
            this.budgetYearLookUpEdit.Properties.ShowHeader = false;
            this.budgetYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.budgetYearLookUpEdit.Size = new System.Drawing.Size(640, 20);
            this.budgetYearLookUpEdit.TabIndex = 113;
            this.budgetYearLookUpEdit.EditValueChanged += new System.EventHandler(this.budgetYearLookUpEdit_EditValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(723, 88);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 24);
            this.startButton.TabIndex = 124;
            this.startButton.Text = "Start Calculating";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(834, 88);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 24);
            this.cancelButton.TabIndex = 125;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(43, 88);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 13);
            this.statusLabel.TabIndex = 126;
            this.statusLabel.Text = "Ready";
            // 
            // gctDividendEntitled
            // 
            this.gctDividendEntitled.EmbeddedNavigator.Name = "";
            this.gctDividendEntitled.Location = new System.Drawing.Point(3, 118);
            this.gctDividendEntitled.MainView = this.gridDividendEntitled;
            this.gctDividendEntitled.Name = "gctDividendEntitled";
            this.gctDividendEntitled.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear});
            this.gctDividendEntitled.Size = new System.Drawing.Size(1334, 448);
            this.gctDividendEntitled.TabIndex = 129;
            this.gctDividendEntitled.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDividendEntitled});
            // 
            // gridDividendEntitled
            // 
            this.gridDividendEntitled.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiscalYear,
            this.colSHId,
            this.colRegCode,
            this.colPaidupNoofShare,
            this.colPaidupShareAmt,
            this.colLFRRDiv,
            this.colGFRRDiv,
            this.colCommonDiv,
            this.colRemainingDiv,
            this.colDividendAmount,
            this.colTax,
            this.colNetDividend,
            this.colIsPaid,
            this.colIsCapitalized,
            this.colIsLBFounder,
            this.colIsGBFounder,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs});
            this.gridDividendEntitled.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridDividendEntitled.GridControl = this.gctDividendEntitled;
            this.gridDividendEntitled.Name = "gridDividendEntitled";
            this.gridDividendEntitled.OptionsBehavior.Editable = false;
            this.gridDividendEntitled.OptionsView.ColumnAutoWidth = false;
            this.gridDividendEntitled.OptionsView.ShowGroupPanel = false;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SH Id";
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            // 
            // colRegCode
            // 
            this.colRegCode.Caption = "RegCode";
            this.colRegCode.FieldName = "RegCode";
            this.colRegCode.Name = "colRegCode";
            this.colRegCode.Visible = true;
            this.colRegCode.VisibleIndex = 0;
            this.colRegCode.Width = 64;
            // 
            // colPaidupNoofShare
            // 
            this.colPaidupNoofShare.Caption = "Paidup Share No.";
            this.colPaidupNoofShare.FieldName = "PaidupNoofShare";
            this.colPaidupNoofShare.Name = "colPaidupNoofShare";
            this.colPaidupNoofShare.Visible = true;
            this.colPaidupNoofShare.VisibleIndex = 1;
            this.colPaidupNoofShare.Width = 101;
            // 
            // colPaidupShareAmt
            // 
            this.colPaidupShareAmt.Caption = "Paidup Share Amount";
            this.colPaidupShareAmt.FieldName = "PaidupShareAmt";
            this.colPaidupShareAmt.Name = "colPaidupShareAmt";
            this.colPaidupShareAmt.Visible = true;
            this.colPaidupShareAmt.VisibleIndex = 2;
            this.colPaidupShareAmt.Width = 125;
            // 
            // colLFRRDiv
            // 
            this.colLFRRDiv.Caption = "LFRR Dividend";
            this.colLFRRDiv.FieldName = "LFRRDiv";
            this.colLFRRDiv.Name = "colLFRRDiv";
            this.colLFRRDiv.Visible = true;
            this.colLFRRDiv.VisibleIndex = 3;
            this.colLFRRDiv.Width = 112;
            // 
            // colGFRRDiv
            // 
            this.colGFRRDiv.Caption = "GFRR Dividend";
            this.colGFRRDiv.FieldName = "GFRRDiv";
            this.colGFRRDiv.Name = "colGFRRDiv";
            this.colGFRRDiv.Visible = true;
            this.colGFRRDiv.VisibleIndex = 4;
            this.colGFRRDiv.Width = 111;
            // 
            // colCommonDiv
            // 
            this.colCommonDiv.Caption = "Common Dividend";
            this.colCommonDiv.FieldName = "CommonDiv";
            this.colCommonDiv.Name = "colCommonDiv";
            this.colCommonDiv.Visible = true;
            this.colCommonDiv.VisibleIndex = 5;
            this.colCommonDiv.Width = 119;
            // 
            // colRemainingDiv
            // 
            this.colRemainingDiv.Caption = "Remaining Dividend";
            this.colRemainingDiv.FieldName = "RemainingDiv";
            this.colRemainingDiv.Name = "colRemainingDiv";
            this.colRemainingDiv.Visible = true;
            this.colRemainingDiv.VisibleIndex = 6;
            this.colRemainingDiv.Width = 118;
            // 
            // colDividendAmount
            // 
            this.colDividendAmount.Caption = "Gross Dividend";
            this.colDividendAmount.FieldName = "DividendAmount";
            this.colDividendAmount.Name = "colDividendAmount";
            this.colDividendAmount.Visible = true;
            this.colDividendAmount.VisibleIndex = 7;
            this.colDividendAmount.Width = 110;
            // 
            // colTax
            // 
            this.colTax.Caption = "10 % Tax";
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 8;
            this.colTax.Width = 71;
            // 
            // colNetDividend
            // 
            this.colNetDividend.Caption = "Net Dividend";
            this.colNetDividend.FieldName = "NetDividend";
            this.colNetDividend.Name = "colNetDividend";
            this.colNetDividend.Visible = true;
            this.colNetDividend.VisibleIndex = 9;
            this.colNetDividend.Width = 90;
            // 
            // colIsPaid
            // 
            this.colIsPaid.Caption = "Is Paid";
            this.colIsPaid.FieldName = "IsPaid";
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.Visible = true;
            this.colIsPaid.VisibleIndex = 10;
            this.colIsPaid.Width = 55;
            // 
            // colIsCapitalized
            // 
            this.colIsCapitalized.Caption = "Is Capitalized";
            this.colIsCapitalized.FieldName = "IsCapitalized";
            this.colIsCapitalized.Name = "colIsCapitalized";
            this.colIsCapitalized.Visible = true;
            this.colIsCapitalized.VisibleIndex = 11;
            // 
            // colIsLBFounder
            // 
            this.colIsLBFounder.Caption = "Is LB Founder";
            this.colIsLBFounder.FieldName = "IsLBFounder";
            this.colIsLBFounder.Name = "colIsLBFounder";
            this.colIsLBFounder.Visible = true;
            this.colIsLBFounder.VisibleIndex = 12;
            this.colIsLBFounder.Width = 78;
            // 
            // colIsGBFounder
            // 
            this.colIsGBFounder.Caption = "Is GB Founder";
            this.colIsGBFounder.FieldName = "IsGBFounder";
            this.colIsGBFounder.Name = "colIsGBFounder";
            this.colIsGBFounder.Visible = true;
            this.colIsGBFounder.VisibleIndex = 13;
            this.colIsGBFounder.Width = 93;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 14;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 15;
            // 
            // colCrtWs
            // 
            this.colCrtWs.Caption = "CrtWs";
            this.colCrtWs.FieldName = "CrtWs";
            this.colCrtWs.Name = "colCrtWs";
            this.colCrtWs.Visible = true;
            this.colCrtWs.VisibleIndex = 16;
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
            // frmDividendCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 566);
            this.Controls.Add(this.gctDividendEntitled);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.budgetYearLookUpEdit);
            this.Controls.Add(budgetYearLabel);
            this.Name = "frmDividendCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividend Calculation";
            this.Load += new System.EventHandler(this.frmDividendCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.budgetYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendEntitled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendEntitled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit budgetYearLookUpEdit;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label statusLabel;
        private DevExpress.XtraGrid.GridControl gctDividendEntitled;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDividendEntitled;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidupNoofShare;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidupShareAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colDividendAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCapitalized;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLBFounder;
        private DevExpress.XtraGrid.Columns.GridColumn colIsGBFounder;
        private DevExpress.XtraGrid.Columns.GridColumn colLFRRDiv;
        private DevExpress.XtraGrid.Columns.GridColumn colGFRRDiv;
        private DevExpress.XtraGrid.Columns.GridColumn colCommonDiv;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingDiv;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colNetDividend;
        private DevExpress.XtraGrid.Columns.GridColumn colRegCode;
    }
}