﻿namespace SHM
{
    partial class frmPayDividend
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
            System.Windows.Forms.Label RegCodeLabel;
            System.Windows.Forms.Label SHIdLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label DORegEthLabel;
            System.Windows.Forms.Label DORegLabel;
            System.Windows.Forms.Label GrossDividendCapitalizedLabel;
            System.Windows.Forms.Label GrossDividendPaidtoOSLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label ReceiptNoLabel;
            System.Windows.Forms.Label DateofPaymentLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label GrossDividendPaidtoShLabel;
            System.Windows.Forms.Label GrossDividendLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayDividend));
            this.tspDivPayment = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.IsGBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.IsLBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.DORegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.SHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DORegEthTextBox = new System.Windows.Forms.TextBox();
            this.IsCapitalizedCheckBox = new System.Windows.Forms.CheckBox();
            this.IsPaidtoShCheckBox = new System.Windows.Forms.CheckBox();
            this.IsPaidtoOSCheckBox = new System.Windows.Forms.CheckBox();
            this.GrossDividendCapitalizedTextBox = new System.Windows.Forms.TextBox();
            this.GrossDividendPaidtoOSTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnpaidShareTextBox = new System.Windows.Forms.TextBox();
            this.PVNoTextBox = new System.Windows.Forms.TextBox();
            this.PaymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentDateEthTextBox = new System.Windows.Forms.TextBox();
            this.GrossDividendPaidtoShTextBox = new System.Windows.Forms.TextBox();
            this.GrossDividendTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gctDividendPayment = new DevExpress.XtraGrid.GridControl();
            this.gridDividendPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossDividend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossDividendPaidtoSh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossDividendPaidtoOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossDividendCapitalized = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDividendPayable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaidtoSh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaidtoOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCapitalized = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCanceled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluTypeofPayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this.DividendPayableTextBox = new System.Windows.Forms.TextBox();
            this.TaxAmntTextBox = new System.Windows.Forms.TextBox();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.DeductTaxLOSPCheckBox = new System.Windows.Forms.CheckBox();
            budgetYearLabel = new System.Windows.Forms.Label();
            RegCodeLabel = new System.Windows.Forms.Label();
            SHIdLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            DORegEthLabel = new System.Windows.Forms.Label();
            DORegLabel = new System.Windows.Forms.Label();
            GrossDividendCapitalizedLabel = new System.Windows.Forms.Label();
            GrossDividendPaidtoOSLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ReceiptNoLabel = new System.Windows.Forms.Label();
            DateofPaymentLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            GrossDividendPaidtoShLabel = new System.Windows.Forms.Label();
            GrossDividendLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tspDivPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).BeginInit();
            this.DivGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // GrossDividendCapitalizedLabel
            // 
            GrossDividendCapitalizedLabel.AutoSize = true;
            GrossDividendCapitalizedLabel.Enabled = false;
            GrossDividendCapitalizedLabel.Location = new System.Drawing.Point(754, 73);
            GrossDividendCapitalizedLabel.Name = "GrossDividendCapitalizedLabel";
            GrossDividendCapitalizedLabel.Size = new System.Drawing.Size(136, 13);
            GrossDividendCapitalizedLabel.TabIndex = 232;
            GrossDividendCapitalizedLabel.Text = "Gross Dividend Capitalized:";
            // 
            // GrossDividendPaidtoOSLabel
            // 
            GrossDividendPaidtoOSLabel.AutoSize = true;
            GrossDividendPaidtoOSLabel.Location = new System.Drawing.Point(491, 74);
            GrossDividendPaidtoOSLabel.Name = "GrossDividendPaidtoOSLabel";
            GrossDividendPaidtoOSLabel.Size = new System.Drawing.Size(136, 13);
            GrossDividendPaidtoOSLabel.TabIndex = 230;
            GrossDividendPaidtoOSLabel.Text = "Gross Dividend Paid to OS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(784, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 228;
            label1.Text = "Total Unpaid Share:";
            // 
            // ReceiptNoLabel
            // 
            ReceiptNoLabel.AutoSize = true;
            ReceiptNoLabel.Location = new System.Drawing.Point(73, 19);
            ReceiptNoLabel.Name = "ReceiptNoLabel";
            ReceiptNoLabel.Size = new System.Drawing.Size(41, 13);
            ReceiptNoLabel.TabIndex = 226;
            ReceiptNoLabel.Text = "PV No:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(513, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 13);
            label2.TabIndex = 224;
            label2.Text = "Date of Payment (Eth):";
            // 
            // GrossDividendPaidtoShLabel
            // 
            GrossDividendPaidtoShLabel.AutoSize = true;
            GrossDividendPaidtoShLabel.Location = new System.Drawing.Point(238, 74);
            GrossDividendPaidtoShLabel.Name = "GrossDividendPaidtoShLabel";
            GrossDividendPaidtoShLabel.Size = new System.Drawing.Size(134, 13);
            GrossDividendPaidtoShLabel.TabIndex = 222;
            GrossDividendPaidtoShLabel.Text = "Gross Dividend Paid to Sh:";
            // 
            // GrossDividendLabel
            // 
            GrossDividendLabel.AutoSize = true;
            GrossDividendLabel.Location = new System.Drawing.Point(35, 74);
            GrossDividendLabel.Name = "GrossDividendLabel";
            GrossDividendLabel.Size = new System.Drawing.Size(82, 13);
            GrossDividendLabel.TabIndex = 221;
            GrossDividendLabel.Text = "Gross Dividend:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(73, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 13);
            label3.TabIndex = 238;
            label3.Text = "Remark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(62, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 13);
            label4.TabIndex = 240;
            label4.Text = "10 % Tax:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(275, 99);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 13);
            label5.TabIndex = 242;
            label5.Text = "Dividend Payable:";
            // 
            // tspDivPayment
            // 
            this.tspDivPayment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspDivPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.searchByComboBox});
            this.tspDivPayment.Location = new System.Drawing.Point(0, 0);
            this.tspDivPayment.Name = "tspDivPayment";
            this.tspDivPayment.Size = new System.Drawing.Size(1100, 25);
            this.tspDivPayment.TabIndex = 7;
            this.tspDivPayment.TabStop = true;
            this.tspDivPayment.Text = "toolStrip1";
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
            this.groupBox1.Location = new System.Drawing.Point(57, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 143);
            this.groupBox1.TabIndex = 9;
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
            // IsCapitalizedCheckBox
            // 
            this.IsCapitalizedCheckBox.AutoSize = true;
            this.IsCapitalizedCheckBox.Enabled = false;
            this.IsCapitalizedCheckBox.Location = new System.Drawing.Point(890, 43);
            this.IsCapitalizedCheckBox.Name = "IsCapitalizedCheckBox";
            this.IsCapitalizedCheckBox.Size = new System.Drawing.Size(91, 17);
            this.IsCapitalizedCheckBox.TabIndex = 235;
            this.IsCapitalizedCheckBox.Text = "Is  Capitalized";
            this.IsCapitalizedCheckBox.UseVisualStyleBackColor = true;
            this.IsCapitalizedCheckBox.CheckedChanged += new System.EventHandler(this.IsCapitalizedCheckBox_CheckedChanged);
            // 
            // IsPaidtoShCheckBox
            // 
            this.IsPaidtoShCheckBox.AutoSize = true;
            this.IsPaidtoShCheckBox.Location = new System.Drawing.Point(374, 43);
            this.IsPaidtoShCheckBox.Name = "IsPaidtoShCheckBox";
            this.IsPaidtoShCheckBox.Size = new System.Drawing.Size(86, 17);
            this.IsPaidtoShCheckBox.TabIndex = 234;
            this.IsPaidtoShCheckBox.Text = "Is Paid to Sh";
            this.IsPaidtoShCheckBox.UseVisualStyleBackColor = true;
            this.IsPaidtoShCheckBox.CheckedChanged += new System.EventHandler(this.IsPaidtoShCheckBox_CheckedChanged);
            // 
            // IsPaidtoOSCheckBox
            // 
            this.IsPaidtoOSCheckBox.AutoSize = true;
            this.IsPaidtoOSCheckBox.Location = new System.Drawing.Point(633, 43);
            this.IsPaidtoOSCheckBox.Name = "IsPaidtoOSCheckBox";
            this.IsPaidtoOSCheckBox.Size = new System.Drawing.Size(88, 17);
            this.IsPaidtoOSCheckBox.TabIndex = 233;
            this.IsPaidtoOSCheckBox.Text = "Is Paid to OS";
            this.IsPaidtoOSCheckBox.UseVisualStyleBackColor = true;
            this.IsPaidtoOSCheckBox.CheckedChanged += new System.EventHandler(this.IsPaidtoOSCheckBox_CheckedChanged);
            // 
            // GrossDividendCapitalizedTextBox
            // 
            this.GrossDividendCapitalizedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossDividendCapitalizedTextBox.Enabled = false;
            this.GrossDividendCapitalizedTextBox.Location = new System.Drawing.Point(890, 70);
            this.GrossDividendCapitalizedTextBox.Name = "GrossDividendCapitalizedTextBox";
            this.GrossDividendCapitalizedTextBox.Size = new System.Drawing.Size(108, 20);
            this.GrossDividendCapitalizedTextBox.TabIndex = 231;
            this.GrossDividendCapitalizedTextBox.TabStop = false;
            this.GrossDividendCapitalizedTextBox.TextChanged += new System.EventHandler(this.GrossDividendCapitalizedTextBox_TextChanged);
            this.GrossDividendCapitalizedTextBox.Validated += new System.EventHandler(this.GrossDividendCapitalizedTextBox_Validated);
            // 
            // GrossDividendPaidtoOSTextBox
            // 
            this.GrossDividendPaidtoOSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossDividendPaidtoOSTextBox.Location = new System.Drawing.Point(633, 71);
            this.GrossDividendPaidtoOSTextBox.Name = "GrossDividendPaidtoOSTextBox";
            this.GrossDividendPaidtoOSTextBox.Size = new System.Drawing.Size(108, 20);
            this.GrossDividendPaidtoOSTextBox.TabIndex = 229;
            this.GrossDividendPaidtoOSTextBox.TabStop = false;
            this.GrossDividendPaidtoOSTextBox.TextChanged += new System.EventHandler(this.GrossDividendPaidtoOSTextBox_TextChanged);
            this.GrossDividendPaidtoOSTextBox.Validated += new System.EventHandler(this.GrossDividendPaidtoOSTextBox_Validated);
            // 
            // TotalUnpaidShareTextBox
            // 
            this.TotalUnpaidShareTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalUnpaidShareTextBox.Enabled = false;
            this.TotalUnpaidShareTextBox.Location = new System.Drawing.Point(890, 18);
            this.TotalUnpaidShareTextBox.Name = "TotalUnpaidShareTextBox";
            this.TotalUnpaidShareTextBox.ReadOnly = true;
            this.TotalUnpaidShareTextBox.Size = new System.Drawing.Size(108, 20);
            this.TotalUnpaidShareTextBox.TabIndex = 227;
            this.TotalUnpaidShareTextBox.TabStop = false;
            // 
            // PVNoTextBox
            // 
            this.PVNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PVNoTextBox.Location = new System.Drawing.Point(120, 17);
            this.PVNoTextBox.Name = "PVNoTextBox";
            this.PVNoTextBox.Size = new System.Drawing.Size(108, 20);
            this.PVNoTextBox.TabIndex = 217;
            this.PVNoTextBox.TabStop = false;
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
            // GrossDividendPaidtoShTextBox
            // 
            this.GrossDividendPaidtoShTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossDividendPaidtoShTextBox.Location = new System.Drawing.Point(374, 71);
            this.GrossDividendPaidtoShTextBox.Name = "GrossDividendPaidtoShTextBox";
            this.GrossDividendPaidtoShTextBox.Size = new System.Drawing.Size(108, 20);
            this.GrossDividendPaidtoShTextBox.TabIndex = 220;
            this.GrossDividendPaidtoShTextBox.TabStop = false;
            this.GrossDividendPaidtoShTextBox.TextChanged += new System.EventHandler(this.GrossDividendPaidtoShTextBox_TextChanged);
            this.GrossDividendPaidtoShTextBox.Validated += new System.EventHandler(this.GrossDividendPaidtoShTextBox_Validated);
            // 
            // GrossDividendTextBox
            // 
            this.GrossDividendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossDividendTextBox.Enabled = false;
            this.GrossDividendTextBox.Location = new System.Drawing.Point(120, 71);
            this.GrossDividendTextBox.Name = "GrossDividendTextBox";
            this.GrossDividendTextBox.Size = new System.Drawing.Size(108, 20);
            this.GrossDividendTextBox.TabIndex = 219;
            this.GrossDividendTextBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(42, 369);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 257);
            this.tabControl1.TabIndex = 236;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gctDividendPayment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dividend Paid List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gctDividendPayment
            // 
            this.gctDividendPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctDividendPayment.EmbeddedNavigator.Name = "";
            this.gctDividendPayment.Location = new System.Drawing.Point(0, 0);
            this.gctDividendPayment.MainView = this.gridDividendPayment;
            this.gctDividendPayment.Name = "gctDividendPayment";
            this.gctDividendPayment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation,
            this.rluTypeofPayment});
            this.gctDividendPayment.Size = new System.Drawing.Size(1192, 228);
            this.gctDividendPayment.TabIndex = 7;
            this.gctDividendPayment.TabStop = false;
            this.gctDividendPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDividendPayment});
            // 
            // gridDividendPayment
            // 
            this.gridDividendPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrnNo,
            this.colFiscalYear,
            this.colSHId,
            this.colPaymentDate,
            this.colPaymentDateEth,
            this.colPVNo,
            this.colGrossDividend,
            this.colGrossDividendPaidtoSh,
            this.colGrossDividendPaidtoOS,
            this.colGrossDividendCapitalized,
            this.colDividendPayable,
            this.colIsPaidtoSh,
            this.colIsPaidtoOS,
            this.colIsCapitalized,
            this.colIsCanceled,
            this.colCrtBy1,
            this.colCrtDt1,
            this.colCrtWs1,
            this.colLmBy1,
            this.colLmDt1,
            this.colLmWs1});
            this.gridDividendPayment.GridControl = this.gctDividendPayment;
            this.gridDividendPayment.Name = "gridDividendPayment";
            this.gridDividendPayment.OptionsBehavior.Editable = false;
            this.gridDividendPayment.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridDividendPayment.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridDividendPayment.OptionsView.ColumnAutoWidth = false;
            this.gridDividendPayment.OptionsView.ShowGroupPanel = false;
            this.gridDividendPayment.DoubleClick += new System.EventHandler(this.gridDividendPayment_DoubleClick);
            // 
            // colTrnNo
            // 
            this.colTrnNo.Caption = "TrnNo";
            this.colTrnNo.FieldName = "TrnNo";
            this.colTrnNo.Name = "colTrnNo";
            this.colTrnNo.OptionsColumn.ReadOnly = true;
            this.colTrnNo.Width = 56;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            this.colFiscalYear.Visible = true;
            this.colFiscalYear.VisibleIndex = 0;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SH Id";
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            this.colSHId.Width = 43;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "Payment Date(Grg)";
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 1;
            this.colPaymentDate.Width = 111;
            // 
            // colPaymentDateEth
            // 
            this.colPaymentDateEth.Caption = "Payment Date (Eth)";
            this.colPaymentDateEth.FieldName = "PaymentDateEth";
            this.colPaymentDateEth.Name = "colPaymentDateEth";
            this.colPaymentDateEth.Visible = true;
            this.colPaymentDateEth.VisibleIndex = 2;
            this.colPaymentDateEth.Width = 107;
            // 
            // colPVNo
            // 
            this.colPVNo.Caption = "PV No.";
            this.colPVNo.FieldName = "PVNo";
            this.colPVNo.Name = "colPVNo";
            this.colPVNo.Visible = true;
            this.colPVNo.VisibleIndex = 3;
            this.colPVNo.Width = 62;
            // 
            // colGrossDividend
            // 
            this.colGrossDividend.Caption = "Gross Dividend";
            this.colGrossDividend.FieldName = "GrossDividend";
            this.colGrossDividend.Name = "colGrossDividend";
            this.colGrossDividend.Visible = true;
            this.colGrossDividend.VisibleIndex = 4;
            this.colGrossDividend.Width = 106;
            // 
            // colGrossDividendPaidtoSh
            // 
            this.colGrossDividendPaidtoSh.Caption = "Gross Dividend Paid to Sh.";
            this.colGrossDividendPaidtoSh.FieldName = "GrossDividendPaidtoSh";
            this.colGrossDividendPaidtoSh.Name = "colGrossDividendPaidtoSh";
            this.colGrossDividendPaidtoSh.Visible = true;
            this.colGrossDividendPaidtoSh.VisibleIndex = 5;
            this.colGrossDividendPaidtoSh.Width = 140;
            // 
            // colGrossDividendPaidtoOS
            // 
            this.colGrossDividendPaidtoOS.Caption = "Gross Dividend Paid to OS";
            this.colGrossDividendPaidtoOS.FieldName = "GrossDividendPaidtoOS";
            this.colGrossDividendPaidtoOS.Name = "colGrossDividendPaidtoOS";
            this.colGrossDividendPaidtoOS.Visible = true;
            this.colGrossDividendPaidtoOS.VisibleIndex = 6;
            this.colGrossDividendPaidtoOS.Width = 114;
            // 
            // colGrossDividendCapitalized
            // 
            this.colGrossDividendCapitalized.Caption = "Gross Dividend Capitalized";
            this.colGrossDividendCapitalized.FieldName = "GrossDividendCapitalized";
            this.colGrossDividendCapitalized.Name = "colGrossDividendCapitalized";
            this.colGrossDividendCapitalized.Visible = true;
            this.colGrossDividendCapitalized.VisibleIndex = 7;
            // 
            // colDividendPayable
            // 
            this.colDividendPayable.Caption = "Dividend Payable";
            this.colDividendPayable.FieldName = "DividendPayable";
            this.colDividendPayable.Name = "colDividendPayable";
            this.colDividendPayable.Visible = true;
            this.colDividendPayable.VisibleIndex = 8;
            // 
            // colIsPaidtoSh
            // 
            this.colIsPaidtoSh.Caption = "Is Paid to Sh.";
            this.colIsPaidtoSh.FieldName = "IsPaidtoSh";
            this.colIsPaidtoSh.Name = "colIsPaidtoSh";
            this.colIsPaidtoSh.Visible = true;
            this.colIsPaidtoSh.VisibleIndex = 9;
            // 
            // colIsPaidtoOS
            // 
            this.colIsPaidtoOS.Caption = "Is Paid to OS.";
            this.colIsPaidtoOS.FieldName = "IsPaidtoOS";
            this.colIsPaidtoOS.Name = "colIsPaidtoOS";
            this.colIsPaidtoOS.Visible = true;
            this.colIsPaidtoOS.VisibleIndex = 10;
            // 
            // colIsCapitalized
            // 
            this.colIsCapitalized.Caption = "Is Capitalized";
            this.colIsCapitalized.FieldName = "IsCapitalized";
            this.colIsCapitalized.Name = "colIsCapitalized";
            this.colIsCapitalized.Visible = true;
            this.colIsCapitalized.VisibleIndex = 11;
            // 
            // colIsCanceled
            // 
            this.colIsCanceled.Caption = "Is Canceled";
            this.colIsCanceled.FieldName = "IsCanceled";
            this.colIsCanceled.Name = "colIsCanceled";
            this.colIsCanceled.Visible = true;
            this.colIsCanceled.VisibleIndex = 12;
            // 
            // colCrtBy1
            // 
            this.colCrtBy1.Caption = "CrtBy";
            this.colCrtBy1.FieldName = "CrtBy";
            this.colCrtBy1.Name = "colCrtBy1";
            this.colCrtBy1.Visible = true;
            this.colCrtBy1.VisibleIndex = 13;
            // 
            // colCrtDt1
            // 
            this.colCrtDt1.Caption = "CrtDt";
            this.colCrtDt1.FieldName = "CrtDt";
            this.colCrtDt1.Name = "colCrtDt1";
            this.colCrtDt1.Visible = true;
            this.colCrtDt1.VisibleIndex = 14;
            // 
            // colCrtWs1
            // 
            this.colCrtWs1.Caption = "CrtWs";
            this.colCrtWs1.FieldName = "CrtWs";
            this.colCrtWs1.Name = "colCrtWs1";
            this.colCrtWs1.Visible = true;
            this.colCrtWs1.VisibleIndex = 15;
            // 
            // colLmBy1
            // 
            this.colLmBy1.Caption = "LmBy";
            this.colLmBy1.FieldName = "LmBy";
            this.colLmBy1.Name = "colLmBy1";
            this.colLmBy1.Visible = true;
            this.colLmBy1.VisibleIndex = 16;
            // 
            // colLmDt1
            // 
            this.colLmDt1.Caption = "LmDt";
            this.colLmDt1.FieldName = "LmDt";
            this.colLmDt1.Name = "colLmDt1";
            this.colLmDt1.Visible = true;
            this.colLmDt1.VisibleIndex = 17;
            // 
            // colLmWs1
            // 
            this.colLmWs1.Caption = "LmWs";
            this.colLmWs1.FieldName = "LmWs";
            this.colLmWs1.Name = "colLmWs1";
            this.colLmWs1.Visible = true;
            this.colLmWs1.VisibleIndex = 18;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gctSHRegBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Share Register Book ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gctSHRegBook
            // 
            this.gctSHRegBook.EmbeddedNavigator.Name = "";
            this.gctSHRegBook.Location = new System.Drawing.Point(-16, 0);
            this.gctSHRegBook.MainView = this.gridSHRegBook;
            this.gctSHRegBook.Name = "gctSHRegBook";
            this.gctSHRegBook.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluFrmDept,
            this.rluToDept,
            this.rluTransferType,
            this.rluToStation,
            this.rluFromStation});
            this.gctSHRegBook.Size = new System.Drawing.Size(1062, 263);
            this.gctSHRegBook.TabIndex = 0;
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
            this.colSubscribedShareNoOrg.Width = 141;
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
            this.colSubscribedShareNoModif.Width = 159;
            // 
            // colSubscribedShareAmtModif
            // 
            this.colSubscribedShareAmtModif.Caption = "Subscribed Share Amnt. Modif.";
            this.colSubscribedShareAmtModif.FieldName = "SubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Name = "colSubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Visible = true;
            this.colSubscribedShareAmtModif.VisibleIndex = 4;
            this.colSubscribedShareAmtModif.Width = 171;
            // 
            // colPaidUpNoofShare
            // 
            this.colPaidUpNoofShare.Caption = "Paid Up No of Share";
            this.colPaidUpNoofShare.FieldName = "PaidUpNoofShare";
            this.colPaidUpNoofShare.Name = "colPaidUpNoofShare";
            this.colPaidUpNoofShare.Visible = true;
            this.colPaidUpNoofShare.VisibleIndex = 5;
            this.colPaidUpNoofShare.Width = 124;
            // 
            // colPaidUpShareAmt
            // 
            this.colPaidUpShareAmt.Caption = "Paid Up Share Amt";
            this.colPaidUpShareAmt.FieldName = "PaidUpShareAmt";
            this.colPaidUpShareAmt.Name = "colPaidUpShareAmt";
            this.colPaidUpShareAmt.Visible = true;
            this.colPaidUpShareAmt.VisibleIndex = 6;
            this.colPaidUpShareAmt.Width = 108;
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
            this.DivGroupBox.Controls.Add(label5);
            this.DivGroupBox.Controls.Add(this.DividendPayableTextBox);
            this.DivGroupBox.Controls.Add(label4);
            this.DivGroupBox.Controls.Add(this.TaxAmntTextBox);
            this.DivGroupBox.Controls.Add(label3);
            this.DivGroupBox.Controls.Add(this.RemarkTextBox);
            this.DivGroupBox.Controls.Add(this.DeductTaxLOSPCheckBox);
            this.DivGroupBox.Controls.Add(this.PaymentDateDateTimePicker);
            this.DivGroupBox.Controls.Add(this.PaymentDateEthTextBox);
            this.DivGroupBox.Controls.Add(GrossDividendCapitalizedLabel);
            this.DivGroupBox.Controls.Add(this.IsCapitalizedCheckBox);
            this.DivGroupBox.Controls.Add(this.GrossDividendCapitalizedTextBox);
            this.DivGroupBox.Controls.Add(label2);
            this.DivGroupBox.Controls.Add(GrossDividendPaidtoOSLabel);
            this.DivGroupBox.Controls.Add(this.IsPaidtoShCheckBox);
            this.DivGroupBox.Controls.Add(this.GrossDividendPaidtoOSTextBox);
            this.DivGroupBox.Controls.Add(this.IsPaidtoOSCheckBox);
            this.DivGroupBox.Controls.Add(GrossDividendPaidtoShLabel);
            this.DivGroupBox.Controls.Add(DateofPaymentLabel);
            this.DivGroupBox.Controls.Add(this.GrossDividendPaidtoShTextBox);
            this.DivGroupBox.Controls.Add(this.GrossDividendTextBox);
            this.DivGroupBox.Controls.Add(ReceiptNoLabel);
            this.DivGroupBox.Controls.Add(GrossDividendLabel);
            this.DivGroupBox.Controls.Add(this.PVNoTextBox);
            this.DivGroupBox.Controls.Add(this.TotalUnpaidShareTextBox);
            this.DivGroupBox.Controls.Add(label1);
            this.DivGroupBox.Location = new System.Drawing.Point(57, 190);
            this.DivGroupBox.Name = "DivGroupBox";
            this.DivGroupBox.Size = new System.Drawing.Size(1034, 157);
            this.DivGroupBox.TabIndex = 237;
            this.DivGroupBox.TabStop = false;
            // 
            // DividendPayableTextBox
            // 
            this.DividendPayableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DividendPayableTextBox.Location = new System.Drawing.Point(374, 97);
            this.DividendPayableTextBox.Name = "DividendPayableTextBox";
            this.DividendPayableTextBox.Size = new System.Drawing.Size(108, 20);
            this.DividendPayableTextBox.TabIndex = 241;
            this.DividendPayableTextBox.TabStop = false;
            // 
            // TaxAmntTextBox
            // 
            this.TaxAmntTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxAmntTextBox.Location = new System.Drawing.Point(119, 96);
            this.TaxAmntTextBox.Name = "TaxAmntTextBox";
            this.TaxAmntTextBox.ReadOnly = true;
            this.TaxAmntTextBox.Size = new System.Drawing.Size(108, 20);
            this.TaxAmntTextBox.TabIndex = 239;
            this.TaxAmntTextBox.TabStop = false;
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemarkTextBox.Location = new System.Drawing.Point(120, 121);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(840, 20);
            this.RemarkTextBox.TabIndex = 237;
            this.RemarkTextBox.TabStop = false;
            // 
            // DeductTaxLOSPCheckBox
            // 
            this.DeductTaxLOSPCheckBox.AutoSize = true;
            this.DeductTaxLOSPCheckBox.Location = new System.Drawing.Point(119, 43);
            this.DeductTaxLOSPCheckBox.Name = "DeductTaxLOSPCheckBox";
            this.DeductTaxLOSPCheckBox.Size = new System.Drawing.Size(224, 17);
            this.DeductTaxLOSPCheckBox.TabIndex = 236;
            this.DeductTaxLOSPCheckBox.Text = "Deduct Tax from Late Outstanding Payers";
            this.DeductTaxLOSPCheckBox.UseVisualStyleBackColor = true;
            this.DeductTaxLOSPCheckBox.CheckedChanged += new System.EventHandler(this.DeductTaxLOSPCheckBox_CheckedChanged);
            // 
            // frmPayDividend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.DivGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspDivPayment);
            this.Name = "frmPayDividend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Dividend";
            this.Load += new System.EventHandler(this.frmPayDividend_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPayDividend_KeyDown);
            this.tspDivPayment.ResumeLayout(false);
            this.tspDivPayment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDividendPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDividendPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDivPayment;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private System.Windows.Forms.CheckBox IsGBFounderCheckBox;
        private System.Windows.Forms.CheckBox IsLBFounderCheckBox;
        private System.Windows.Forms.DateTimePicker DORegDateTimePicker;
        private System.Windows.Forms.TextBox RegCodeTextBox;
        private DevExpress.XtraEditors.LookUpEdit SHIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private System.Windows.Forms.TextBox DORegEthTextBox;
        private System.Windows.Forms.CheckBox IsCapitalizedCheckBox;
        private System.Windows.Forms.CheckBox IsPaidtoShCheckBox;
        private System.Windows.Forms.CheckBox IsPaidtoOSCheckBox;
        private System.Windows.Forms.TextBox GrossDividendCapitalizedTextBox;
        private System.Windows.Forms.TextBox GrossDividendPaidtoOSTextBox;
        private System.Windows.Forms.TextBox TotalUnpaidShareTextBox;
        private System.Windows.Forms.TextBox PVNoTextBox;
        private System.Windows.Forms.DateTimePicker PaymentDateDateTimePicker;
        private System.Windows.Forms.TextBox PaymentDateEthTextBox;
        private System.Windows.Forms.TextBox GrossDividendPaidtoShTextBox;
        private System.Windows.Forms.TextBox GrossDividendTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gctDividendPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDividendPayment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluEmpId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewStation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeofPayment;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTrnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colPVNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossDividend;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossDividendPaidtoSh;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossDividendPaidtoOS;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossDividendCapitalized;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaidtoSh;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaidtoOS;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCapitalized;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs1;
        private System.Windows.Forms.GroupBox DivGroupBox;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCanceled;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.CheckBox DeductTaxLOSPCheckBox;
        private System.Windows.Forms.TextBox TaxAmntTextBox;
        private System.Windows.Forms.TextBox DividendPayableTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colDividendPayable;
    }
}