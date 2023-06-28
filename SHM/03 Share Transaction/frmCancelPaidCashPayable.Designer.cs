namespace SHM
{
    partial class frmCancelPaidCashPayable
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label DateofPaymentLabel;
            System.Windows.Forms.Label ReceiptNoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label budgetYearLabel;
            System.Windows.Forms.Label RegCodeLabel;
            System.Windows.Forms.Label SHIdLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label DORegEthLabel;
            System.Windows.Forms.Label DORegLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelPaidCashPayable));
            this.tspCanceledCashPayable = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gctCashPaidPayable = new DevExpress.XtraGrid.GridControl();
            this.gridCashPaidPayable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRVNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayableAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaidtoSh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaidtoOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCanceled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluTypeofPayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gctCancelCashPaidPayable = new DevExpress.XtraGrid.GridControl();
            this.gridCancelCashPaidPayable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gctSHRegBook = new DevExpress.XtraGrid.GridControl();
            this.gridSHRegBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSHId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubscribedShareNoOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubscribedShareAmtOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubscribedShareNoModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubscribedShareAmtModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidUpNoofShare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidUpShareAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluFrmDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluToDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluTransferType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluToStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluFromStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DivGroupBox = new System.Windows.Forms.GroupBox();
            this.IsPaidtoOSRadioButton = new System.Windows.Forms.RadioButton();
            this.RVNoTextBox = new System.Windows.Forms.TextBox();
            this.IsPaidtoShRadioButton = new System.Windows.Forms.RadioButton();
            this.PayableAmountTextBox = new System.Windows.Forms.TextBox();
            this.PaymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentDateEthTextBox = new System.Windows.Forms.TextBox();
            this.PVNoTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnpaidShareTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.IsGBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.IsLBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.DORegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.SHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DORegEthTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            DateofPaymentLabel = new System.Windows.Forms.Label();
            ReceiptNoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            budgetYearLabel = new System.Windows.Forms.Label();
            RegCodeLabel = new System.Windows.Forms.Label();
            SHIdLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            DORegEthLabel = new System.Windows.Forms.Label();
            DORegLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tspCanceledCashPayable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCashPaidPayable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashPaidPayable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCancelCashPaidPayable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCancelCashPaidPayable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).BeginInit();
            this.DivGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 13);
            label5.TabIndex = 242;
            label5.Text = "Paid Cash Payable:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(513, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 13);
            label2.TabIndex = 224;
            label2.Text = "Date of Payment (Eth):";
            // 
            // DateofPaymentLabel
            // 
            DateofPaymentLabel.AutoSize = true;
            DateofPaymentLabel.Location = new System.Drawing.Point(257, 20);
            DateofPaymentLabel.Name = "DateofPaymentLabel";
            DateofPaymentLabel.Size = new System.Drawing.Size(115, 13);
            DateofPaymentLabel.TabIndex = 223;
            DateofPaymentLabel.Text = "Date of Payment (Grg):";
            // 
            // ReceiptNoLabel
            // 
            ReceiptNoLabel.AutoSize = true;
            ReceiptNoLabel.Location = new System.Drawing.Point(816, 45);
            ReceiptNoLabel.Name = "ReceiptNoLabel";
            ReceiptNoLabel.Size = new System.Drawing.Size(41, 13);
            ReceiptNoLabel.TabIndex = 226;
            ReceiptNoLabel.Text = "PV No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(758, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 228;
            label1.Text = "Total Unpaid Share:";
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(44, 22);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(69, 13);
            budgetYearLabel.TabIndex = 152;
            budgetYearLabel.Text = "Budget Year:";
            // 
            // RegCodeLabel
            // 
            RegCodeLabel.AutoSize = true;
            RegCodeLabel.Location = new System.Drawing.Point(19, 101);
            RegCodeLabel.Name = "RegCodeLabel";
            RegCodeLabel.Size = new System.Drawing.Size(94, 13);
            RegCodeLabel.TabIndex = 114;
            RegCodeLabel.Text = "Registration Code:";
            // 
            // SHIdLabel
            // 
            SHIdLabel.AutoSize = true;
            SHIdLabel.Location = new System.Drawing.Point(50, 49);
            SHIdLabel.Name = "SHIdLabel";
            SHIdLabel.Size = new System.Drawing.Size(67, 13);
            SHIdLabel.TabIndex = 9;
            SHIdLabel.Text = "Shareholder:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(500, 49);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 72;
            sexLabel.Text = "Sex:";
            // 
            // DORegEthLabel
            // 
            DORegEthLabel.AutoSize = true;
            DORegEthLabel.Location = new System.Drawing.Point(269, 74);
            DORegEthLabel.Name = "DORegEthLabel";
            DORegEthLabel.Size = new System.Drawing.Size(93, 13);
            DORegEthLabel.TabIndex = 94;
            DORegEthLabel.Text = "Date of Reg (Eth):";
            // 
            // DORegLabel
            // 
            DORegLabel.AutoSize = true;
            DORegLabel.Location = new System.Drawing.Point(26, 74);
            DORegLabel.Name = "DORegLabel";
            DORegLabel.Size = new System.Drawing.Size(91, 13);
            DORegLabel.TabIndex = 93;
            DORegLabel.Text = "Date ofReg (Grg):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(71, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 13);
            label3.TabIndex = 250;
            label3.Text = "RV No:";
            // 
            // tspCanceledCashPayable
            // 
            this.tspCanceledCashPayable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspCanceledCashPayable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.searchByComboBox});
            this.tspCanceledCashPayable.Location = new System.Drawing.Point(0, 0);
            this.tspCanceledCashPayable.Name = "tspCanceledCashPayable";
            this.tspCanceledCashPayable.Size = new System.Drawing.Size(1104, 25);
            this.tspCanceledCashPayable.TabIndex = 241;
            this.tspCanceledCashPayable.TabStop = true;
            this.tspCanceledCashPayable.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.saveToolStripButton.Text = "&Cancel";
            this.saveToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.deleteToolStripButton.Text = "De&lete";
            this.deleteToolStripButton.Visible = false;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "search By:";
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(200, 25);
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 281);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 259);
            this.tabControl1.TabIndex = 246;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gctCashPaidPayable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1029, 233);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cash Payable Paid List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gctCashPaidPayable
            // 
            this.gctCashPaidPayable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctCashPaidPayable.EmbeddedNavigator.Name = "";
            this.gctCashPaidPayable.Location = new System.Drawing.Point(0, 8);
            this.gctCashPaidPayable.MainView = this.gridCashPaidPayable;
            this.gctCashPaidPayable.Name = "gctCashPaidPayable";
            this.gctCashPaidPayable.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation,
            this.rluTypeofPayment});
            this.gctCashPaidPayable.Size = new System.Drawing.Size(1026, 219);
            this.gctCashPaidPayable.TabIndex = 8;
            this.gctCashPaidPayable.TabStop = false;
            this.gctCashPaidPayable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCashPaidPayable});
            // 
            // gridCashPaidPayable
            // 
            this.gridCashPaidPayable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrNo,
            this.colFiscalYear,
            this.colSHId,
            this.colRVNo,
            this.colPVNo,
            this.colPayableAmount,
            this.colPaymentDate,
            this.colPaymentDateEth,
            this.colIsPaidtoSh,
            this.colIsPaidtoOS,
            this.colIsCanceled,
            this.colCrtBy1,
            this.colCrtDt1,
            this.colCrtWs1});
            this.gridCashPaidPayable.GridControl = this.gctCashPaidPayable;
            this.gridCashPaidPayable.Name = "gridCashPaidPayable";
            this.gridCashPaidPayable.OptionsBehavior.Editable = false;
            this.gridCashPaidPayable.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCashPaidPayable.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridCashPaidPayable.OptionsView.ColumnAutoWidth = false;
            this.gridCashPaidPayable.OptionsView.ShowGroupPanel = false;
            this.gridCashPaidPayable.DoubleClick += new System.EventHandler(this.gridDividendPayable_DoubleClick);
            // 
            // colTrNo
            // 
            this.colTrNo.Caption = "Trn. No.";
            this.colTrNo.FieldName = "TrNo";
            this.colTrNo.Name = "colTrNo";
            this.colTrNo.Visible = true;
            this.colTrNo.VisibleIndex = 0;
            this.colTrNo.Width = 62;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            this.colFiscalYear.Visible = true;
            this.colFiscalYear.VisibleIndex = 1;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SH Id";
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            this.colSHId.Visible = true;
            this.colSHId.VisibleIndex = 2;
            // 
            // colRVNo
            // 
            this.colRVNo.Caption = "RV No.";
            this.colRVNo.FieldName = "RVNo";
            this.colRVNo.Name = "colRVNo";
            this.colRVNo.Visible = true;
            this.colRVNo.VisibleIndex = 3;
            // 
            // colPVNo
            // 
            this.colPVNo.Caption = "PV No.";
            this.colPVNo.FieldName = "PVNo";
            this.colPVNo.Name = "colPVNo";
            this.colPVNo.Visible = true;
            this.colPVNo.VisibleIndex = 4;
            // 
            // colPayableAmount
            // 
            this.colPayableAmount.Caption = "Payable Amount";
            this.colPayableAmount.FieldName = "PayableAmount";
            this.colPayableAmount.Name = "colPayableAmount";
            this.colPayableAmount.Visible = true;
            this.colPayableAmount.VisibleIndex = 5;
            this.colPayableAmount.Width = 100;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "Payment Date (Grg)";
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 6;
            this.colPaymentDate.Width = 118;
            // 
            // colPaymentDateEth
            // 
            this.colPaymentDateEth.Caption = "PaymentDate (Eth)";
            this.colPaymentDateEth.FieldName = "PaymentDateEth";
            this.colPaymentDateEth.Name = "colPaymentDateEth";
            this.colPaymentDateEth.Visible = true;
            this.colPaymentDateEth.VisibleIndex = 7;
            this.colPaymentDateEth.Width = 119;
            // 
            // colIsPaidtoSh
            // 
            this.colIsPaidtoSh.Caption = "Is Paid to Sh";
            this.colIsPaidtoSh.FieldName = "IsPaidtoSh";
            this.colIsPaidtoSh.Name = "colIsPaidtoSh";
            this.colIsPaidtoSh.Visible = true;
            this.colIsPaidtoSh.VisibleIndex = 8;
            this.colIsPaidtoSh.Width = 89;
            // 
            // colIsPaidtoOS
            // 
            this.colIsPaidtoOS.Caption = "Is Paid to OS";
            this.colIsPaidtoOS.FieldName = "IsPaidtoOS";
            this.colIsPaidtoOS.Name = "colIsPaidtoOS";
            this.colIsPaidtoOS.Visible = true;
            this.colIsPaidtoOS.VisibleIndex = 9;
            this.colIsPaidtoOS.Width = 92;
            // 
            // colIsCanceled
            // 
            this.colIsCanceled.Caption = "Is Canceled";
            this.colIsCanceled.FieldName = "IsCanceled";
            this.colIsCanceled.Name = "colIsCanceled";
            this.colIsCanceled.Visible = true;
            this.colIsCanceled.VisibleIndex = 10;
            this.colIsCanceled.Width = 89;
            // 
            // colCrtBy1
            // 
            this.colCrtBy1.Caption = "CrtBy";
            this.colCrtBy1.FieldName = "CrtBy";
            this.colCrtBy1.Name = "colCrtBy1";
            this.colCrtBy1.Visible = true;
            this.colCrtBy1.VisibleIndex = 11;
            // 
            // colCrtDt1
            // 
            this.colCrtDt1.Caption = "CrtDt";
            this.colCrtDt1.FieldName = "CrtDt";
            this.colCrtDt1.Name = "colCrtDt1";
            this.colCrtDt1.Visible = true;
            this.colCrtDt1.VisibleIndex = 12;
            // 
            // colCrtWs1
            // 
            this.colCrtWs1.Caption = "CrtWs";
            this.colCrtWs1.FieldName = "CrtWs";
            this.colCrtWs1.Name = "colCrtWs1";
            this.colCrtWs1.Visible = true;
            this.colCrtWs1.VisibleIndex = 13;
            // 
            // rluEmpId
            // 
            this.rluEmpId.AutoHeight = false;
            this.rluEmpId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluEmpId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.rluEmpId.DisplayMember = "FullName";
            this.rluEmpId.Name = "rluEmpId";
            this.rluEmpId.NullText = "";
            this.rluEmpId.ValueMember = "Id";
            // 
            // rluNewDept
            // 
            this.rluNewDept.AutoHeight = false;
            this.rluNewDept.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNewDept.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeptDesc", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.rluNewDept.DisplayMember = "DeptDesc";
            this.rluNewDept.Name = "rluNewDept";
            this.rluNewDept.NullText = "";
            this.rluNewDept.ValueMember = "DeptCode";
            // 
            // rluNewStation
            // 
            this.rluNewStation.AutoHeight = false;
            this.rluNewStation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNewStation.DisplayMember = "Description";
            this.rluNewStation.Name = "rluNewStation";
            this.rluNewStation.NullText = "";
            this.rluNewStation.ValueMember = "Id";
            // 
            // rluTypeofPayment
            // 
            this.rluTypeofPayment.AutoHeight = false;
            this.rluTypeofPayment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluTypeofPayment.DisplayMember = "TypeofPayment";
            this.rluTypeofPayment.Name = "rluTypeofPayment";
            this.rluTypeofPayment.NullText = "";
            this.rluTypeofPayment.ValueMember = "Id";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gctCancelCashPaidPayable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Canceled Cash Payable Paid List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gctCancelCashPaidPayable
            // 
            this.gctCancelCashPaidPayable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctCancelCashPaidPayable.EmbeddedNavigator.Name = "";
            this.gctCancelCashPaidPayable.Location = new System.Drawing.Point(-2, 2);
            this.gctCancelCashPaidPayable.MainView = this.gridCancelCashPaidPayable;
            this.gctCancelCashPaidPayable.Name = "gctCancelCashPaidPayable";
            this.gctCancelCashPaidPayable.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gctCancelCashPaidPayable.Size = new System.Drawing.Size(1033, 225);
            this.gctCancelCashPaidPayable.TabIndex = 9;
            this.gctCancelCashPaidPayable.TabStop = false;
            this.gctCancelCashPaidPayable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCancelCashPaidPayable});
            // 
            // gridCancelCashPaidPayable
            // 
            this.gridCancelCashPaidPayable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrNo1,
            this.colSHId2,
            this.colCancelDate,
            this.colCancelDateEth,
            this.colCrtBy2,
            this.colCrtDt2,
            this.colCrtWs2});
            this.gridCancelCashPaidPayable.GridControl = this.gctCancelCashPaidPayable;
            this.gridCancelCashPaidPayable.Name = "gridCancelCashPaidPayable";
            this.gridCancelCashPaidPayable.OptionsBehavior.Editable = false;
            this.gridCancelCashPaidPayable.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCancelCashPaidPayable.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridCancelCashPaidPayable.OptionsView.ColumnAutoWidth = false;
            this.gridCancelCashPaidPayable.OptionsView.ShowGroupPanel = false;
            // 
            // colTrNo1
            // 
            this.colTrNo1.Caption = "Trn No.";
            this.colTrNo1.FieldName = "TrNo";
            this.colTrNo1.Name = "colTrNo1";
            this.colTrNo1.Visible = true;
            this.colTrNo1.VisibleIndex = 0;
            // 
            // colSHId2
            // 
            this.colSHId2.Caption = "SH Id";
            this.colSHId2.FieldName = "SHId";
            this.colSHId2.Name = "colSHId2";
            this.colSHId2.Visible = true;
            this.colSHId2.VisibleIndex = 1;
            // 
            // colCancelDate
            // 
            this.colCancelDate.Caption = "Canceled Date (Grg)";
            this.colCancelDate.FieldName = "CancelDate";
            this.colCancelDate.Name = "colCancelDate";
            this.colCancelDate.Visible = true;
            this.colCancelDate.VisibleIndex = 2;
            this.colCancelDate.Width = 124;
            // 
            // colCancelDateEth
            // 
            this.colCancelDateEth.Caption = "Canceled Date (Eth)";
            this.colCancelDateEth.FieldName = "CancelDateEth";
            this.colCancelDateEth.Name = "colCancelDateEth";
            this.colCancelDateEth.Visible = true;
            this.colCancelDateEth.VisibleIndex = 3;
            this.colCancelDateEth.Width = 127;
            // 
            // colCrtBy2
            // 
            this.colCrtBy2.Caption = "CrtBy";
            this.colCrtBy2.FieldName = "CrtBy";
            this.colCrtBy2.Name = "colCrtBy2";
            this.colCrtBy2.Visible = true;
            this.colCrtBy2.VisibleIndex = 4;
            // 
            // colCrtDt2
            // 
            this.colCrtDt2.Caption = "CrtDt";
            this.colCrtDt2.FieldName = "CrtDt";
            this.colCrtDt2.Name = "colCrtDt2";
            this.colCrtDt2.Visible = true;
            this.colCrtDt2.VisibleIndex = 5;
            // 
            // colCrtWs2
            // 
            this.colCrtWs2.Caption = "CrtWs";
            this.colCrtWs2.FieldName = "CrtWs";
            this.colCrtWs2.Name = "colCrtWs2";
            this.colCrtWs2.Visible = true;
            this.colCrtWs2.VisibleIndex = 6;
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
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeptDesc", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit2.DisplayMember = "DeptDesc";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "DeptCode";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "Description";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "Id";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DisplayMember = "TypeofPayment";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            this.repositoryItemLookUpEdit4.ValueMember = "Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gctSHRegBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Share Register Book ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gctSHRegBook
            // 
            this.gctSHRegBook.EmbeddedNavigator.Name = "";
            this.gctSHRegBook.Location = new System.Drawing.Point(-4, 0);
            this.gctSHRegBook.MainView = this.gridSHRegBook;
            this.gctSHRegBook.Name = "gctSHRegBook";
            this.gctSHRegBook.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluFrmDept,
            this.rluToDept,
            this.rluTransferType,
            this.rluToStation,
            this.rluFromStation});
            this.gctSHRegBook.Size = new System.Drawing.Size(1028, 227);
            this.gctSHRegBook.TabIndex = 1;
            this.gctSHRegBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSHRegBook});
            // 
            // gridSHRegBook
            // 
            this.gridSHRegBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSHId1,
            this.colSubscribedShareNoOrg,
            this.colSubscribedShareAmtOrg,
            this.colSubscribedShareNoModif,
            this.colSubscribedShareAmtModif,
            this.colPaidUpNoofShare,
            this.colPaidUpShareAmt,
            this.colCrtBy,
            this.colCrtDt,
            this.colCrtWs,
            this.colLmBy,
            this.colLmDt,
            this.colLmWs});
            this.gridSHRegBook.GridControl = this.gctSHRegBook;
            this.gridSHRegBook.Name = "gridSHRegBook";
            this.gridSHRegBook.OptionsBehavior.Editable = false;
            this.gridSHRegBook.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridSHRegBook.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridSHRegBook.OptionsView.ColumnAutoWidth = false;
            this.gridSHRegBook.OptionsView.ShowGroupPanel = false;
            // 
            // colSHId1
            // 
            this.colSHId1.Caption = "SH Id";
            this.colSHId1.FieldName = "SHId";
            this.colSHId1.Name = "colSHId1";
            this.colSHId1.Visible = true;
            this.colSHId1.VisibleIndex = 0;
            this.colSHId1.Width = 43;
            // 
            // colSubscribedShareNoOrg
            // 
            this.colSubscribedShareNoOrg.Caption = "Subscribed Share No Org.";
            this.colSubscribedShareNoOrg.FieldName = "SubscribedShareNoOrg";
            this.colSubscribedShareNoOrg.Name = "colSubscribedShareNoOrg";
            this.colSubscribedShareNoOrg.Visible = true;
            this.colSubscribedShareNoOrg.VisibleIndex = 1;
            this.colSubscribedShareNoOrg.Width = 146;
            // 
            // colSubscribedShareAmtOrg
            // 
            this.colSubscribedShareAmtOrg.Caption = "Subscribed Share Amnt Org.";
            this.colSubscribedShareAmtOrg.FieldName = "SubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Name = "colSubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Visible = true;
            this.colSubscribedShareAmtOrg.VisibleIndex = 2;
            this.colSubscribedShareAmtOrg.Width = 162;
            // 
            // colSubscribedShareNoModif
            // 
            this.colSubscribedShareNoModif.Caption = "Subscribed Share No. Modif.";
            this.colSubscribedShareNoModif.FieldName = "SubscribedShareNoModif";
            this.colSubscribedShareNoModif.Name = "colSubscribedShareNoModif";
            this.colSubscribedShareNoModif.Visible = true;
            this.colSubscribedShareNoModif.VisibleIndex = 3;
            this.colSubscribedShareNoModif.Width = 149;
            // 
            // colSubscribedShareAmtModif
            // 
            this.colSubscribedShareAmtModif.Caption = "Subscribed Share Amnt. Modif.";
            this.colSubscribedShareAmtModif.FieldName = "SubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Name = "colSubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Visible = true;
            this.colSubscribedShareAmtModif.VisibleIndex = 4;
            this.colSubscribedShareAmtModif.Width = 169;
            // 
            // colPaidUpNoofShare
            // 
            this.colPaidUpNoofShare.Caption = "Paid Up No of Share";
            this.colPaidUpNoofShare.FieldName = "PaidUpNoofShare";
            this.colPaidUpNoofShare.Name = "colPaidUpNoofShare";
            this.colPaidUpNoofShare.Visible = true;
            this.colPaidUpNoofShare.VisibleIndex = 5;
            this.colPaidUpNoofShare.Width = 115;
            // 
            // colPaidUpShareAmt
            // 
            this.colPaidUpShareAmt.Caption = "Paid Up Share Amt";
            this.colPaidUpShareAmt.FieldName = "PaidUpShareAmt";
            this.colPaidUpShareAmt.Name = "colPaidUpShareAmt";
            this.colPaidUpShareAmt.Visible = true;
            this.colPaidUpShareAmt.VisibleIndex = 6;
            this.colPaidUpShareAmt.Width = 107;
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
            this.colCrtDt.VisibleIndex = 8;
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
            // rluFrmDept
            // 
            this.rluFrmDept.AutoHeight = false;
            this.rluFrmDept.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluFrmDept.DisplayMember = "DeptDesc";
            this.rluFrmDept.Name = "rluFrmDept";
            this.rluFrmDept.NullText = "";
            this.rluFrmDept.ValueMember = "DeptCode";
            // 
            // rluToDept
            // 
            this.rluToDept.AutoHeight = false;
            this.rluToDept.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluToDept.DisplayMember = "DeptDesc";
            this.rluToDept.Name = "rluToDept";
            this.rluToDept.NullText = "";
            this.rluToDept.ValueMember = "DeptCode";
            // 
            // rluTransferType
            // 
            this.rluTransferType.AutoHeight = false;
            this.rluTransferType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluTransferType.DisplayMember = "Description";
            this.rluTransferType.Name = "rluTransferType";
            this.rluTransferType.NullText = "";
            this.rluTransferType.ValueMember = "Id";
            // 
            // rluToStation
            // 
            this.rluToStation.AutoHeight = false;
            this.rluToStation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluToStation.Name = "rluToStation";
            // 
            // rluFromStation
            // 
            this.rluFromStation.AutoHeight = false;
            this.rluFromStation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluFromStation.DisplayMember = "Description";
            this.rluFromStation.Name = "rluFromStation";
            this.rluFromStation.NullText = "";
            this.rluFromStation.ValueMember = "Id";
            // 
            // DivGroupBox
            // 
            this.DivGroupBox.Controls.Add(label3);
            this.DivGroupBox.Controls.Add(this.IsPaidtoOSRadioButton);
            this.DivGroupBox.Controls.Add(this.RVNoTextBox);
            this.DivGroupBox.Controls.Add(this.IsPaidtoShRadioButton);
            this.DivGroupBox.Controls.Add(label5);
            this.DivGroupBox.Controls.Add(this.PayableAmountTextBox);
            this.DivGroupBox.Controls.Add(this.PaymentDateDateTimePicker);
            this.DivGroupBox.Controls.Add(this.PaymentDateEthTextBox);
            this.DivGroupBox.Controls.Add(label2);
            this.DivGroupBox.Controls.Add(DateofPaymentLabel);
            this.DivGroupBox.Controls.Add(ReceiptNoLabel);
            this.DivGroupBox.Controls.Add(this.PVNoTextBox);
            this.DivGroupBox.Controls.Add(this.TotalUnpaidShareTextBox);
            this.DivGroupBox.Controls.Add(label1);
            this.DivGroupBox.Enabled = false;
            this.DivGroupBox.Location = new System.Drawing.Point(21, 190);
            this.DivGroupBox.Name = "DivGroupBox";
            this.DivGroupBox.Size = new System.Drawing.Size(1012, 75);
            this.DivGroupBox.TabIndex = 245;
            this.DivGroupBox.TabStop = false;
            // 
            // IsPaidtoOSRadioButton
            // 
            this.IsPaidtoOSRadioButton.AutoSize = true;
            this.IsPaidtoOSRadioButton.Location = new System.Drawing.Point(376, 46);
            this.IsPaidtoOSRadioButton.Name = "IsPaidtoOSRadioButton";
            this.IsPaidtoOSRadioButton.Size = new System.Drawing.Size(87, 17);
            this.IsPaidtoOSRadioButton.TabIndex = 240;
            this.IsPaidtoOSRadioButton.Text = "Is Paid to OS";
            this.IsPaidtoOSRadioButton.UseVisualStyleBackColor = true;
            // 
            // RVNoTextBox
            // 
            this.RVNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RVNoTextBox.Location = new System.Drawing.Point(125, 45);
            this.RVNoTextBox.Name = "RVNoTextBox";
            this.RVNoTextBox.ReadOnly = true;
            this.RVNoTextBox.Size = new System.Drawing.Size(108, 20);
            this.RVNoTextBox.TabIndex = 249;
            this.RVNoTextBox.TabStop = false;
            // 
            // IsPaidtoShRadioButton
            // 
            this.IsPaidtoShRadioButton.AutoSize = true;
            this.IsPaidtoShRadioButton.Location = new System.Drawing.Point(636, 43);
            this.IsPaidtoShRadioButton.Name = "IsPaidtoShRadioButton";
            this.IsPaidtoShRadioButton.Size = new System.Drawing.Size(85, 17);
            this.IsPaidtoShRadioButton.TabIndex = 244;
            this.IsPaidtoShRadioButton.Text = "Is Paid to Sh";
            this.IsPaidtoShRadioButton.UseVisualStyleBackColor = true;
            // 
            // PayableAmountTextBox
            // 
            this.PayableAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayableAmountTextBox.Location = new System.Drawing.Point(125, 19);
            this.PayableAmountTextBox.Name = "PayableAmountTextBox";
            this.PayableAmountTextBox.ReadOnly = true;
            this.PayableAmountTextBox.Size = new System.Drawing.Size(108, 20);
            this.PayableAmountTextBox.TabIndex = 241;
            this.PayableAmountTextBox.TabStop = false;
            // 
            // PaymentDateDateTimePicker
            // 
            this.PaymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDateDateTimePicker.Location = new System.Drawing.Point(374, 17);
            this.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker";
            this.PaymentDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.PaymentDateDateTimePicker.TabIndex = 218;
            this.PaymentDateDateTimePicker.Value = new System.DateTime(2017, 10, 7, 0, 0, 0, 0);
            this.PaymentDateDateTimePicker.Validated += new System.EventHandler(this.DateofPaymentDateTimePicker_Validated);
            // 
            // PaymentDateEthTextBox
            // 
            this.PaymentDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaymentDateEthTextBox.Enabled = false;
            this.PaymentDateEthTextBox.Location = new System.Drawing.Point(633, 17);
            this.PaymentDateEthTextBox.Name = "PaymentDateEthTextBox";
            this.PaymentDateEthTextBox.ReadOnly = true;
            this.PaymentDateEthTextBox.Size = new System.Drawing.Size(108, 20);
            this.PaymentDateEthTextBox.TabIndex = 225;
            this.PaymentDateEthTextBox.TabStop = false;
            // 
            // PVNoTextBox
            // 
            this.PVNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PVNoTextBox.Location = new System.Drawing.Point(863, 43);
            this.PVNoTextBox.Name = "PVNoTextBox";
            this.PVNoTextBox.Size = new System.Drawing.Size(108, 20);
            this.PVNoTextBox.TabIndex = 217;
            this.PVNoTextBox.TabStop = false;
            // 
            // TotalUnpaidShareTextBox
            // 
            this.TotalUnpaidShareTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalUnpaidShareTextBox.Enabled = false;
            this.TotalUnpaidShareTextBox.Location = new System.Drawing.Point(864, 18);
            this.TotalUnpaidShareTextBox.Name = "TotalUnpaidShareTextBox";
            this.TotalUnpaidShareTextBox.ReadOnly = true;
            this.TotalUnpaidShareTextBox.Size = new System.Drawing.Size(108, 20);
            this.TotalUnpaidShareTextBox.TabIndex = 227;
            this.TotalUnpaidShareTextBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FiscalYearLookUpEdit);
            this.groupBox1.Controls.Add(budgetYearLabel);
            this.groupBox1.Controls.Add(this.IsGBFounderCheckBox);
            this.groupBox1.Controls.Add(this.IsLBFounderCheckBox);
            this.groupBox1.Controls.Add(this.DORegDateTimePicker);
            this.groupBox1.Controls.Add(RegCodeLabel);
            this.groupBox1.Controls.Add(this.RegCodeTextBox);
            this.groupBox1.Controls.Add(this.SHIdLookUpEdit);
            this.groupBox1.Controls.Add(SHIdLabel);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexLookUpEdit);
            this.groupBox1.Controls.Add(this.DORegEthTextBox);
            this.groupBox1.Controls.Add(DORegEthLabel);
            this.groupBox1.Controls.Add(DORegLabel);
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 143);
            this.groupBox1.TabIndex = 244;
            this.groupBox1.TabStop = false;
            // 
            // FiscalYearLookUpEdit
            // 
            this.FiscalYearLookUpEdit.Location = new System.Drawing.Point(119, 19);
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
            this.FiscalYearLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.FiscalYearLookUpEdit.TabIndex = 151;
            this.FiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.FiscalYearLookUpEdit_EditValueChanged);
            // 
            // IsGBFounderCheckBox
            // 
            this.IsGBFounderCheckBox.AutoSize = true;
            this.IsGBFounderCheckBox.Enabled = false;
            this.IsGBFounderCheckBox.Location = new System.Drawing.Point(374, 102);
            this.IsGBFounderCheckBox.Name = "IsGBFounderCheckBox";
            this.IsGBFounderCheckBox.Size = new System.Drawing.Size(94, 17);
            this.IsGBFounderCheckBox.TabIndex = 150;
            this.IsGBFounderCheckBox.Text = "Is GB Founder";
            this.IsGBFounderCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsLBFounderCheckBox
            // 
            this.IsLBFounderCheckBox.AutoSize = true;
            this.IsLBFounderCheckBox.Enabled = false;
            this.IsLBFounderCheckBox.Location = new System.Drawing.Point(272, 102);
            this.IsLBFounderCheckBox.Name = "IsLBFounderCheckBox";
            this.IsLBFounderCheckBox.Size = new System.Drawing.Size(92, 17);
            this.IsLBFounderCheckBox.TabIndex = 149;
            this.IsLBFounderCheckBox.Text = "Is LB Founder";
            this.IsLBFounderCheckBox.UseVisualStyleBackColor = true;
            // 
            // DORegDateTimePicker
            // 
            this.DORegDateTimePicker.Enabled = false;
            this.DORegDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DORegDateTimePicker.Location = new System.Drawing.Point(119, 73);
            this.DORegDateTimePicker.Name = "DORegDateTimePicker";
            this.DORegDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.DORegDateTimePicker.TabIndex = 148;
            this.DORegDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            // 
            // RegCodeTextBox
            // 
            this.RegCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegCodeTextBox.Enabled = false;
            this.RegCodeTextBox.Location = new System.Drawing.Point(119, 99);
            this.RegCodeTextBox.Name = "RegCodeTextBox";
            this.RegCodeTextBox.ReadOnly = true;
            this.RegCodeTextBox.Size = new System.Drawing.Size(108, 20);
            this.RegCodeTextBox.TabIndex = 115;
            this.RegCodeTextBox.TabStop = false;
            // 
            // SHIdLookUpEdit
            // 
            this.SHIdLookUpEdit.EditValue = "";
            this.SHIdLookUpEdit.Location = new System.Drawing.Point(119, 46);
            this.SHIdLookUpEdit.Name = "SHIdLookUpEdit";
            this.SHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.SHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHId", "SH Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegCode", "Reg Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.SHIdLookUpEdit.Properties.DisplayMember = "SHRegCodeWithName";
            this.SHIdLookUpEdit.Properties.NullText = "";
            this.SHIdLookUpEdit.Properties.ValueMember = "SHId";
            this.SHIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.SHIdLookUpEdit.TabIndex = 0;
            this.SHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SHIdLookUpEdit_EditValueChanged);
            // 
            // sexLookUpEdit
            // 
            this.sexLookUpEdit.Enabled = false;
            this.sexLookUpEdit.Location = new System.Drawing.Point(534, 46);
            this.sexLookUpEdit.Name = "sexLookUpEdit";
            this.sexLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sexLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sex", "Sex", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.sexLookUpEdit.Properties.DisplayMember = "Sex";
            this.sexLookUpEdit.Properties.NullText = "";
            this.sexLookUpEdit.Properties.ReadOnly = true;
            this.sexLookUpEdit.Properties.ShowHeader = false;
            this.sexLookUpEdit.Properties.ValueMember = "Sex";
            this.sexLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.sexLookUpEdit.TabIndex = 71;
            this.sexLookUpEdit.TabStop = false;
            // 
            // DORegEthTextBox
            // 
            this.DORegEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DORegEthTextBox.Enabled = false;
            this.DORegEthTextBox.Location = new System.Drawing.Point(374, 72);
            this.DORegEthTextBox.Name = "DORegEthTextBox";
            this.DORegEthTextBox.ReadOnly = true;
            this.DORegEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DORegEthTextBox.TabIndex = 95;
            this.DORegEthTextBox.TabStop = false;
            // 
            // frmCancelPaidCashPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DivGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspCanceledCashPayable);
            this.Name = "frmCancelPaidCashPayable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Paid Cash Payable";
            this.Load += new System.EventHandler(this.frmCancelPaidCashPayable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCancelPaidCashPayable_KeyDown);
            this.tspCanceledCashPayable.ResumeLayout(false);
            this.tspCanceledCashPayable.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCashPaidPayable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashPaidPayable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCancelCashPaidPayable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCancelCashPaidPayable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).EndInit();
            this.DivGroupBox.ResumeLayout(false);
            this.DivGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspCanceledCashPayable;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl gctCashPaidPayable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCashPaidPayable;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluEmpId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewStation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeofPayment;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gctCancelCashPaidPayable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCancelCashPaidPayable;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gctSHRegBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSHRegBook;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubscribedShareNoOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colSubscribedShareAmtOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colSubscribedShareNoModif;
        private DevExpress.XtraGrid.Columns.GridColumn colSubscribedShareAmtModif;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidUpNoofShare;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidUpShareAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluFrmDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluToDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTransferType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluToStation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluFromStation;
        private System.Windows.Forms.GroupBox DivGroupBox;
        private System.Windows.Forms.RadioButton IsPaidtoOSRadioButton;
        private System.Windows.Forms.RadioButton IsPaidtoShRadioButton;
        private System.Windows.Forms.TextBox PayableAmountTextBox;
        private System.Windows.Forms.DateTimePicker PaymentDateDateTimePicker;
        private System.Windows.Forms.TextBox PaymentDateEthTextBox;
        private System.Windows.Forms.TextBox PVNoTextBox;
        private System.Windows.Forms.TextBox TotalUnpaidShareTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private System.Windows.Forms.CheckBox IsGBFounderCheckBox;
        private System.Windows.Forms.CheckBox IsLBFounderCheckBox;
        private System.Windows.Forms.DateTimePicker DORegDateTimePicker;
        private System.Windows.Forms.TextBox RegCodeTextBox;
        private DevExpress.XtraEditors.LookUpEdit SHIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private System.Windows.Forms.TextBox DORegEthTextBox;
        private System.Windows.Forms.TextBox RVNoTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colTrNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colRVNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPVNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPayableAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaidtoSh;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaidtoOS;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCanceled;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId2;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt2;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs2;
    }
}