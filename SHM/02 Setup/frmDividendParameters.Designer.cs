namespace SHM
{
    partial class frmDividendParameters
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
            System.Windows.Forms.Label NetProfitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDividendParameters));
            this.tspDividendParam = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.TotalAmntForDividendTextBox = new System.Windows.Forms.TextBox();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctDividendParam = new DevExpress.XtraGrid.GridControl();
            this.gridDividendParam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmntForDividend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.button1 = new System.Windows.Forms.Button();
            budgetYearLabel = new System.Windows.Forms.Label();
            NetProfitLabel = new System.Windows.Forms.Label();
            this.tspDividendParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(164, 22);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(62, 13);
            budgetYearLabel.TabIndex = 0;
            budgetYearLabel.Text = "Fiscal Year:";
            // 
            // NetProfitLabel
            // 
            NetProfitLabel.AutoSize = true;
            NetProfitLabel.Location = new System.Drawing.Point(90, 49);
            NetProfitLabel.Name = "NetProfitLabel";
            NetProfitLabel.Size = new System.Drawing.Size(136, 13);
            NetProfitLabel.TabIndex = 2;
            NetProfitLabel.Text = "Total Amount For Dividend:";
            // 
            // tspDividendParam
            // 
            this.tspDividendParam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspDividendParam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspDividendParam.Location = new System.Drawing.Point(0, 0);
            this.tspDividendParam.Name = "tspDividendParam";
            this.tspDividendParam.Size = new System.Drawing.Size(1004, 25);
            this.tspDividendParam.TabIndex = 4;
            this.tspDividendParam.TabStop = true;
            this.tspDividendParam.Text = "toolStrip1";
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
            this.groupBox1.Controls.Add(this.chkYearAll);
            this.groupBox1.Controls.Add(this.TotalAmntForDividendTextBox);
            this.groupBox1.Controls.Add(budgetYearLabel);
            this.groupBox1.Controls.Add(this.FiscalYearLookUpEdit);
            this.groupBox1.Controls.Add(NetProfitLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(419, 20);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 34;
            this.chkYearAll.CheckedChanged += new System.EventHandler(this.chkYearAll_CheckedChanged);
            // 
            // TotalAmntForDividendTextBox
            // 
            this.TotalAmntForDividendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAmntForDividendTextBox.Location = new System.Drawing.Point(232, 45);
            this.TotalAmntForDividendTextBox.Name = "TotalAmntForDividendTextBox";
            this.TotalAmntForDividendTextBox.Size = new System.Drawing.Size(238, 20);
            this.TotalAmntForDividendTextBox.TabIndex = 29;
            // 
            // FiscalYearLookUpEdit
            // 
            this.FiscalYearLookUpEdit.Location = new System.Drawing.Point(232, 20);
            this.FiscalYearLookUpEdit.Name = "FiscalYearLookUpEdit";
            this.FiscalYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.FiscalYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FiscalYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.FiscalYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Properties.NullText = "";
            this.FiscalYearLookUpEdit.Properties.ShowHeader = false;
            this.FiscalYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.FiscalYearLookUpEdit.TabIndex = 0;
            this.FiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.budgetYearLookUpEdit_EditValueChanged);
            // 
            // gctDividendParam
            // 
            this.gctDividendParam.EmbeddedNavigator.Name = "";
            this.gctDividendParam.Location = new System.Drawing.Point(12, 170);
            this.gctDividendParam.MainView = this.gridDividendParam;
            this.gctDividendParam.Name = "gctDividendParam";
            this.gctDividendParam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear});
            this.gctDividendParam.Size = new System.Drawing.Size(992, 259);
            this.gctDividendParam.TabIndex = 6;
            this.gctDividendParam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDividendParam});
            this.gctDividendParam.DoubleClick += new System.EventHandler(this.gridDividendParam_DoubleClick);
            // 
            // gridDividendParam
            // 
            this.gridDividendParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiscalYear,
            this.colTotalAmntForDividend,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridDividendParam.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridDividendParam.GridControl = this.gctDividendParam;
            this.gridDividendParam.Name = "gridDividendParam";
            this.gridDividendParam.OptionsBehavior.Editable = false;
            this.gridDividendParam.OptionsView.ColumnAutoWidth = false;
            this.gridDividendParam.OptionsView.ShowGroupPanel = false;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            this.colFiscalYear.Visible = true;
            this.colFiscalYear.VisibleIndex = 0;
            this.colFiscalYear.Width = 94;
            // 
            // colTotalAmntForDividend
            // 
            this.colTotalAmntForDividend.Caption = "Total Amnt For Dividend";
            this.colTotalAmntForDividend.FieldName = "TotalAmntForDividend";
            this.colTotalAmntForDividend.Name = "colTotalAmntForDividend";
            this.colTotalAmntForDividend.Visible = true;
            this.colTotalAmntForDividend.VisibleIndex = 1;
            this.colTotalAmntForDividend.Width = 142;
            // 
            // colCrtBy
            // 
            this.colCrtBy.Caption = "CrtBy";
            this.colCrtBy.FieldName = "CrtBy";
            this.colCrtBy.Name = "colCrtBy";
            this.colCrtBy.Visible = true;
            this.colCrtBy.VisibleIndex = 7;
            // 
            // colCrtDt
            // 
            this.colCrtDt.Caption = "CrtDt";
            this.colCrtDt.FieldName = "CrtDt";
            this.colCrtDt.Name = "colCrtDt";
            this.colCrtDt.Visible = true;
            this.colCrtDt.VisibleIndex = 6;
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
            this.colLmBy.VisibleIndex = 2;
            // 
            // colLmDt
            // 
            this.colLmDt.Caption = "LmDt";
            this.colLmDt.FieldName = "LmDt";
            this.colLmDt.Name = "colLmDt";
            this.colLmDt.Visible = true;
            this.colLmDt.VisibleIndex = 3;
            // 
            // colLmWs
            // 
            this.colLmWs.Caption = "LmWs";
            this.colLmWs.FieldName = "LmWs";
            this.colLmWs.Name = "colLmWs";
            this.colLmWs.Visible = true;
            this.colLmWs.VisibleIndex = 4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDividendParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1004, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gctDividendParam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspDividendParam);
            this.Name = "frmDividendParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividend Parameters";
            this.Load += new System.EventHandler(this.frmDividendParameters_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDividendParameters_KeyDown);
            this.tspDividendParam.ResumeLayout(false);
            this.tspDividendParam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDividendParam;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotalAmntForDividendTextBox;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctDividendParam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDividendParam;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmntForDividend;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private System.Windows.Forms.Button button1;
    }
}