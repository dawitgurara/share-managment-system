namespace SHM
{
    partial class frmSharePayment
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
            System.Windows.Forms.Label RegCodeLabel;
            System.Windows.Forms.Label SHIdLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label DORegEthLabel;
            System.Windows.Forms.Label DORegLabel;
            System.Windows.Forms.Label budgetYearLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label TypeofPaymentLabel;
            System.Windows.Forms.Label ReceiptNoLabel;
            System.Windows.Forms.Label DateofPaymentLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label EffectiveDateDateLabel;
            System.Windows.Forms.Label letterDateEthLabel;
            System.Windows.Forms.Label AmntofShareSoldLabel;
            System.Windows.Forms.Label NoofShareSoldLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSharePayment));
            this.tspShPayment = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.IsGBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.IsLBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.DORegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.SHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DORegEthTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnpaidSharetextBox = new System.Windows.Forms.TextBox();
            this.TypeofPaymentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ReceiptNoTextBox = new System.Windows.Forms.TextBox();
            this.DateofPaymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateofPaymentEthTextBox = new System.Windows.Forms.TextBox();
            this.NoofSharePaidTextBox = new System.Windows.Forms.TextBox();
            this.EffectiveDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AmntofSharePaidTextBox = new System.Windows.Forms.TextBox();
            this.EffectiveDateEthTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gctSharePayment = new DevExpress.XtraGrid.GridControl();
            this.gridSharePayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateofPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateofPaymentEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeofPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluTypeofPayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoofSharePaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmntofSharePaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            RegCodeLabel = new System.Windows.Forms.Label();
            SHIdLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            DORegEthLabel = new System.Windows.Forms.Label();
            DORegLabel = new System.Windows.Forms.Label();
            budgetYearLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TypeofPaymentLabel = new System.Windows.Forms.Label();
            ReceiptNoLabel = new System.Windows.Forms.Label();
            DateofPaymentLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            EffectiveDateDateLabel = new System.Windows.Forms.Label();
            letterDateEthLabel = new System.Windows.Forms.Label();
            AmntofShareSoldLabel = new System.Windows.Forms.Label();
            NoofShareSoldLabel = new System.Windows.Forms.Label();
            this.tspShPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeofPaymentLookUpEdit.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSharePayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSharePayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).BeginInit();
            this.SuspendLayout();
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
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(44, 22);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(69, 13);
            budgetYearLabel.TabIndex = 152;
            budgetYearLabel.Text = "Budget Year:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(745, 189);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 262;
            label1.Text = "Total Unpaid Share:";
            // 
            // TypeofPaymentLabel
            // 
            TypeofPaymentLabel.AutoSize = true;
            TypeofPaymentLabel.Location = new System.Drawing.Point(538, 216);
            TypeofPaymentLabel.Name = "TypeofPaymentLabel";
            TypeofPaymentLabel.Size = new System.Drawing.Size(90, 13);
            TypeofPaymentLabel.TabIndex = 260;
            TypeofPaymentLabel.Text = "Type of Payment:";
            // 
            // ReceiptNoLabel
            // 
            ReceiptNoLabel.AutoSize = true;
            ReceiptNoLabel.Location = new System.Drawing.Point(91, 188);
            ReceiptNoLabel.Name = "ReceiptNoLabel";
            ReceiptNoLabel.Size = new System.Drawing.Size(64, 13);
            ReceiptNoLabel.TabIndex = 259;
            ReceiptNoLabel.Text = "Receipt No:";
            // 
            // DateofPaymentLabel
            // 
            DateofPaymentLabel.AutoSize = true;
            DateofPaymentLabel.Location = new System.Drawing.Point(40, 216);
            DateofPaymentLabel.Name = "DateofPaymentLabel";
            DateofPaymentLabel.Size = new System.Drawing.Size(115, 13);
            DateofPaymentLabel.TabIndex = 256;
            DateofPaymentLabel.Text = "Date of Payment (Grg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(289, 216);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 13);
            label2.TabIndex = 257;
            label2.Text = "Date of Payment (Eth):";
            // 
            // EffectiveDateDateLabel
            // 
            EffectiveDateDateLabel.AutoSize = true;
            EffectiveDateDateLabel.Location = new System.Drawing.Point(299, 189);
            EffectiveDateDateLabel.Name = "EffectiveDateDateLabel";
            EffectiveDateDateLabel.Size = new System.Drawing.Size(104, 13);
            EffectiveDateDateLabel.TabIndex = 251;
            EffectiveDateDateLabel.Text = "Effective Date (Grg):";
            // 
            // letterDateEthLabel
            // 
            letterDateEthLabel.AutoSize = true;
            letterDateEthLabel.Location = new System.Drawing.Point(526, 189);
            letterDateEthLabel.Name = "letterDateEthLabel";
            letterDateEthLabel.Size = new System.Drawing.Size(103, 13);
            letterDateEthLabel.TabIndex = 252;
            letterDateEthLabel.Text = "Effective Date (Eth):";
            // 
            // AmntofShareSoldLabel
            // 
            AmntofShareSoldLabel.AutoSize = true;
            AmntofShareSoldLabel.Location = new System.Drawing.Point(74, 240);
            AmntofShareSoldLabel.Name = "AmntofShareSoldLabel";
            AmntofShareSoldLabel.Size = new System.Drawing.Size(77, 13);
            AmntofShareSoldLabel.TabIndex = 254;
            AmntofShareSoldLabel.Text = "Amnt of Share:";
            // 
            // NoofShareSoldLabel
            // 
            NoofShareSoldLabel.AutoSize = true;
            NoofShareSoldLabel.Location = new System.Drawing.Point(331, 242);
            NoofShareSoldLabel.Name = "NoofShareSoldLabel";
            NoofShareSoldLabel.Size = new System.Drawing.Size(67, 13);
            NoofShareSoldLabel.TabIndex = 264;
            NoofShareSoldLabel.Text = "No of Share:";
            // 
            // tspShPayment
            // 
            this.tspShPayment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspShPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.searchByComboBox});
            this.tspShPayment.Location = new System.Drawing.Point(0, 0);
            this.tspShPayment.Name = "tspShPayment";
            this.tspShPayment.Size = new System.Drawing.Size(1094, 25);
            this.tspShPayment.TabIndex = 6;
            this.tspShPayment.TabStop = true;
            this.tspShPayment.Text = "toolStrip1";
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
            this.groupBox1.Controls.Add(this.chkYearAll);
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
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(532, 19);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 153;
            this.chkYearAll.CheckedChanged += new System.EventHandler(this.chkYearAll_CheckedChanged);
            // 
            // FiscalYearLookUpEdit
            // 
            this.FiscalYearLookUpEdit.Location = new System.Drawing.Point(119, 19);
            this.FiscalYearLookUpEdit.Name = "FiscalYearLookUpEdit";
            this.FiscalYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.FiscalYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FiscalYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDate", "Start Date", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EndDate", "End Date", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Closed", "Closed", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.FiscalYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Properties.NullText = "";
            this.FiscalYearLookUpEdit.Properties.ShowHeader = false;
            this.FiscalYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.FiscalYearLookUpEdit.TabIndex = 0;
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
            this.SHIdLookUpEdit.TabIndex = 1;
            this.SHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SHIdLookUpEdit_EditValueChanged);
            // 
            // sexLookUpEdit
            // 
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
            this.DORegEthTextBox.Location = new System.Drawing.Point(374, 72);
            this.DORegEthTextBox.Name = "DORegEthTextBox";
            this.DORegEthTextBox.ReadOnly = true;
            this.DORegEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DORegEthTextBox.TabIndex = 95;
            this.DORegEthTextBox.TabStop = false;
            // 
            // TotalUnpaidSharetextBox
            // 
            this.TotalUnpaidSharetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalUnpaidSharetextBox.Location = new System.Drawing.Point(853, 187);
            this.TotalUnpaidSharetextBox.Name = "TotalUnpaidSharetextBox";
            this.TotalUnpaidSharetextBox.ReadOnly = true;
            this.TotalUnpaidSharetextBox.Size = new System.Drawing.Size(108, 20);
            this.TotalUnpaidSharetextBox.TabIndex = 8;
            this.TotalUnpaidSharetextBox.TabStop = false;
            // 
            // TypeofPaymentLookUpEdit
            // 
            this.TypeofPaymentLookUpEdit.Location = new System.Drawing.Point(631, 213);
            this.TypeofPaymentLookUpEdit.Name = "TypeofPaymentLookUpEdit";
            this.TypeofPaymentLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TypeofPaymentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeofPaymentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeofPayment", "TypeofPayment", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.TypeofPaymentLookUpEdit.Properties.DisplayMember = "TypeofPayment";
            this.TypeofPaymentLookUpEdit.Properties.NullText = "";
            this.TypeofPaymentLookUpEdit.Properties.ShowHeader = false;
            this.TypeofPaymentLookUpEdit.Properties.ValueMember = "Id";
            this.TypeofPaymentLookUpEdit.Size = new System.Drawing.Size(147, 20);
            this.TypeofPaymentLookUpEdit.TabIndex = 4;
            this.TypeofPaymentLookUpEdit.TabStop = false;
            this.TypeofPaymentLookUpEdit.EditValueChanged += new System.EventHandler(this.TypeofPaymentLookUpEdit_EditValueChanged);
            this.TypeofPaymentLookUpEdit.Validated += new System.EventHandler(this.TypeofPaymentLookUpEdit_EditValueChanged);
            // 
            // ReceiptNoTextBox
            // 
            this.ReceiptNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiptNoTextBox.Location = new System.Drawing.Point(157, 186);
            this.ReceiptNoTextBox.Name = "ReceiptNoTextBox";
            this.ReceiptNoTextBox.Size = new System.Drawing.Size(108, 20);
            this.ReceiptNoTextBox.TabIndex = 2;
            this.ReceiptNoTextBox.TabStop = false;
            this.ReceiptNoTextBox.Validated += new System.EventHandler(this.ReceiptNoTextBox_Validated);
            // 
            // DateofPaymentDateTimePicker
            // 
            this.DateofPaymentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateofPaymentDateTimePicker.Location = new System.Drawing.Point(157, 213);
            this.DateofPaymentDateTimePicker.Name = "DateofPaymentDateTimePicker";
            this.DateofPaymentDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.DateofPaymentDateTimePicker.TabIndex = 3;
            this.DateofPaymentDateTimePicker.Value = new System.DateTime(2017, 10, 7, 0, 0, 0, 0);
            this.DateofPaymentDateTimePicker.Validated += new System.EventHandler(this.DateofPaymentDateTimePicker_Validated);
            // 
            // DateofPaymentEthTextBox
            // 
            this.DateofPaymentEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateofPaymentEthTextBox.Location = new System.Drawing.Point(404, 213);
            this.DateofPaymentEthTextBox.Name = "DateofPaymentEthTextBox";
            this.DateofPaymentEthTextBox.ReadOnly = true;
            this.DateofPaymentEthTextBox.Size = new System.Drawing.Size(108, 20);
            this.DateofPaymentEthTextBox.TabIndex = 9;
            this.DateofPaymentEthTextBox.TabStop = false;
            // 
            // NoofSharePaidTextBox
            // 
            this.NoofSharePaidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoofSharePaidTextBox.Location = new System.Drawing.Point(404, 240);
            this.NoofSharePaidTextBox.Name = "NoofSharePaidTextBox";
            this.NoofSharePaidTextBox.ReadOnly = true;
            this.NoofSharePaidTextBox.Size = new System.Drawing.Size(108, 20);
            this.NoofSharePaidTextBox.TabIndex = 10;
            this.NoofSharePaidTextBox.TabStop = false;
            // 
            // EffectiveDateDateTimePicker
            // 
            this.EffectiveDateDateTimePicker.Enabled = false;
            this.EffectiveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EffectiveDateDateTimePicker.Location = new System.Drawing.Point(404, 186);
            this.EffectiveDateDateTimePicker.Name = "EffectiveDateDateTimePicker";
            this.EffectiveDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.EffectiveDateDateTimePicker.TabIndex = 6;
            this.EffectiveDateDateTimePicker.TabStop = false;
            this.EffectiveDateDateTimePicker.Value = new System.DateTime(2017, 12, 19, 0, 0, 0, 0);
            // 
            // AmntofSharePaidTextBox
            // 
            this.AmntofSharePaidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmntofSharePaidTextBox.Location = new System.Drawing.Point(157, 238);
            this.AmntofSharePaidTextBox.Name = "AmntofSharePaidTextBox";
            this.AmntofSharePaidTextBox.Size = new System.Drawing.Size(108, 20);
            this.AmntofSharePaidTextBox.TabIndex = 5;
            this.AmntofSharePaidTextBox.TabStop = false;
            this.AmntofSharePaidTextBox.Validated += new System.EventHandler(this.AmntofSharePaidTextBox_Validated);
            // 
            // EffectiveDateEthTextBox
            // 
            this.EffectiveDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EffectiveDateEthTextBox.Location = new System.Drawing.Point(631, 186);
            this.EffectiveDateEthTextBox.Name = "EffectiveDateEthTextBox";
            this.EffectiveDateEthTextBox.ReadOnly = true;
            this.EffectiveDateEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EffectiveDateEthTextBox.TabIndex = 7;
            this.EffectiveDateEthTextBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 276);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 285);
            this.tabControl1.TabIndex = 263;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gctSharePayment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Share Paid List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gctSharePayment
            // 
            this.gctSharePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctSharePayment.EmbeddedNavigator.Name = "";
            this.gctSharePayment.Location = new System.Drawing.Point(0, 0);
            this.gctSharePayment.MainView = this.gridSharePayment;
            this.gctSharePayment.Name = "gctSharePayment";
            this.gctSharePayment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation,
            this.rluTypeofPayment});
            this.gctSharePayment.Size = new System.Drawing.Size(1065, 263);
            this.gctSharePayment.TabIndex = 7;
            this.gctSharePayment.TabStop = false;
            this.gctSharePayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSharePayment});
            // 
            // gridSharePayment
            // 
            this.gridSharePayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaymentId,
            this.colSHId,
            this.colReceiptNo,
            this.colDateofPayment,
            this.colDateofPaymentEth,
            this.colTypeofPayment,
            this.colEffectiveDate,
            this.colEffectiveDateEth,
            this.colNoofSharePaid,
            this.colAmntofSharePaid,
            this.colCrtBy1,
            this.colCrtDt1,
            this.colCrtWs1,
            this.colLmBy1,
            this.colLmDt1,
            this.colLmWs1});
            this.gridSharePayment.GridControl = this.gctSharePayment;
            this.gridSharePayment.Name = "gridSharePayment";
            this.gridSharePayment.OptionsBehavior.Editable = false;
            this.gridSharePayment.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridSharePayment.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridSharePayment.OptionsView.ColumnAutoWidth = false;
            this.gridSharePayment.OptionsView.ShowGroupPanel = false;
            this.gridSharePayment.DoubleClick += new System.EventHandler(this.gridSharePayment_DoubleClick);
            // 
            // colPaymentId
            // 
            this.colPaymentId.Caption = "PaymentId";
            this.colPaymentId.FieldName = "PaymentId";
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.OptionsColumn.ReadOnly = true;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SHId";
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            // 
            // colReceiptNo
            // 
            this.colReceiptNo.Caption = "Receipt No";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 0;
            this.colReceiptNo.Width = 114;
            // 
            // colDateofPayment
            // 
            this.colDateofPayment.Caption = "Date of Payment (Grg)";
            this.colDateofPayment.FieldName = "DateofPayment";
            this.colDateofPayment.Name = "colDateofPayment";
            this.colDateofPayment.Visible = true;
            this.colDateofPayment.VisibleIndex = 1;
            this.colDateofPayment.Width = 167;
            // 
            // colDateofPaymentEth
            // 
            this.colDateofPaymentEth.Caption = "Dateof Payment (Eth)";
            this.colDateofPaymentEth.FieldName = "DateofPaymentEth";
            this.colDateofPaymentEth.Name = "colDateofPaymentEth";
            this.colDateofPaymentEth.Visible = true;
            this.colDateofPaymentEth.VisibleIndex = 2;
            this.colDateofPaymentEth.Width = 131;
            // 
            // colTypeofPayment
            // 
            this.colTypeofPayment.Caption = "Type of Payment";
            this.colTypeofPayment.ColumnEdit = this.rluTypeofPayment;
            this.colTypeofPayment.FieldName = "TypeofPayment";
            this.colTypeofPayment.Name = "colTypeofPayment";
            this.colTypeofPayment.Visible = true;
            this.colTypeofPayment.VisibleIndex = 3;
            this.colTypeofPayment.Width = 119;
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
            // colEffectiveDate
            // 
            this.colEffectiveDate.Caption = "Effective Date (Grg)";
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 4;
            this.colEffectiveDate.Width = 129;
            // 
            // colEffectiveDateEth
            // 
            this.colEffectiveDateEth.Caption = "Effective Date (Eth)";
            this.colEffectiveDateEth.FieldName = "EffectiveDateEth";
            this.colEffectiveDateEth.Name = "colEffectiveDateEth";
            this.colEffectiveDateEth.Visible = true;
            this.colEffectiveDateEth.VisibleIndex = 5;
            this.colEffectiveDateEth.Width = 131;
            // 
            // colNoofSharePaid
            // 
            this.colNoofSharePaid.Caption = "No of Share Paid";
            this.colNoofSharePaid.FieldName = "NoofSharePaid";
            this.colNoofSharePaid.Name = "colNoofSharePaid";
            this.colNoofSharePaid.Visible = true;
            this.colNoofSharePaid.VisibleIndex = 6;
            this.colNoofSharePaid.Width = 124;
            // 
            // colAmntofSharePaid
            // 
            this.colAmntofSharePaid.Caption = "Amnt of Share Paid";
            this.colAmntofSharePaid.FieldName = "AmntofSharePaid";
            this.colAmntofSharePaid.Name = "colAmntofSharePaid";
            this.colAmntofSharePaid.Visible = true;
            this.colAmntofSharePaid.VisibleIndex = 7;
            this.colAmntofSharePaid.Width = 129;
            // 
            // colCrtBy1
            // 
            this.colCrtBy1.Caption = "CrtBy";
            this.colCrtBy1.FieldName = "CrtBy";
            this.colCrtBy1.Name = "colCrtBy1";
            this.colCrtBy1.Visible = true;
            this.colCrtBy1.VisibleIndex = 8;
            // 
            // colCrtDt1
            // 
            this.colCrtDt1.Caption = "CrtDt";
            this.colCrtDt1.FieldName = "CrtDt";
            this.colCrtDt1.Name = "colCrtDt1";
            this.colCrtDt1.Visible = true;
            this.colCrtDt1.VisibleIndex = 9;
            // 
            // colCrtWs1
            // 
            this.colCrtWs1.Caption = "CrtWs";
            this.colCrtWs1.FieldName = "CrtWs";
            this.colCrtWs1.Name = "colCrtWs1";
            this.colCrtWs1.Visible = true;
            this.colCrtWs1.VisibleIndex = 10;
            // 
            // colLmBy1
            // 
            this.colLmBy1.Caption = "LmBy";
            this.colLmBy1.FieldName = "LmBy";
            this.colLmBy1.Name = "colLmBy1";
            this.colLmBy1.Visible = true;
            this.colLmBy1.VisibleIndex = 11;
            // 
            // colLmDt1
            // 
            this.colLmDt1.Caption = "LmDt";
            this.colLmDt1.FieldName = "LmDt";
            this.colLmDt1.Name = "colLmDt1";
            this.colLmDt1.Visible = true;
            this.colLmDt1.VisibleIndex = 12;
            // 
            // colLmWs1
            // 
            this.colLmWs1.Caption = "LmWs";
            this.colLmWs1.FieldName = "LmWs";
            this.colLmWs1.Name = "colLmWs1";
            this.colLmWs1.Visible = true;
            this.colLmWs1.VisibleIndex = 13;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gctSHRegBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Share Register Book ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gctSHRegBook
            // 
            this.gctSHRegBook.EmbeddedNavigator.Name = "";
            this.gctSHRegBook.Location = new System.Drawing.Point(0, 0);
            this.gctSHRegBook.MainView = this.gridSHRegBook;
            this.gctSHRegBook.Name = "gctSHRegBook";
            this.gctSHRegBook.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluFrmDept,
            this.rluToDept,
            this.rluTransferType,
            this.rluToStation,
            this.rluFromStation});
            this.gctSHRegBook.Size = new System.Drawing.Size(1065, 263);
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
            this.colSubscribedShareNoOrg.Width = 145;
            // 
            // colSubscribedShareAmtOrg
            // 
            this.colSubscribedShareAmtOrg.Caption = "Subscribed Share Amnt Org.";
            this.colSubscribedShareAmtOrg.FieldName = "SubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Name = "colSubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Visible = true;
            this.colSubscribedShareAmtOrg.VisibleIndex = 2;
            this.colSubscribedShareAmtOrg.Width = 171;
            // 
            // colSubscribedShareNoModif
            // 
            this.colSubscribedShareNoModif.Caption = "Subscribed Share No. Modif.";
            this.colSubscribedShareNoModif.FieldName = "SubscribedShareNoModif";
            this.colSubscribedShareNoModif.Name = "colSubscribedShareNoModif";
            this.colSubscribedShareNoModif.Visible = true;
            this.colSubscribedShareNoModif.VisibleIndex = 3;
            this.colSubscribedShareNoModif.Width = 158;
            // 
            // colSubscribedShareAmtModif
            // 
            this.colSubscribedShareAmtModif.Caption = "Subscribed Share Amnt. Modif.";
            this.colSubscribedShareAmtModif.FieldName = "SubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Name = "colSubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Visible = true;
            this.colSubscribedShareAmtModif.VisibleIndex = 4;
            this.colSubscribedShareAmtModif.Width = 178;
            // 
            // colPaidUpNoofShare
            // 
            this.colPaidUpNoofShare.Caption = "Paid Up No of Share";
            this.colPaidUpNoofShare.FieldName = "PaidUpNoofShare";
            this.colPaidUpNoofShare.Name = "colPaidUpNoofShare";
            this.colPaidUpNoofShare.Visible = true;
            this.colPaidUpNoofShare.VisibleIndex = 5;
            this.colPaidUpNoofShare.Width = 116;
            // 
            // colPaidUpShareAmt
            // 
            this.colPaidUpShareAmt.Caption = "Paid Up Share Amt";
            this.colPaidUpShareAmt.FieldName = "PaidUpShareAmt";
            this.colPaidUpShareAmt.Name = "colPaidUpShareAmt";
            this.colPaidUpShareAmt.Visible = true;
            this.colPaidUpShareAmt.VisibleIndex = 6;
            this.colPaidUpShareAmt.Width = 117;
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
            // frmSharePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1094, 574);
            this.Controls.Add(NoofShareSoldLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label1);
            this.Controls.Add(this.TotalUnpaidSharetextBox);
            this.Controls.Add(TypeofPaymentLabel);
            this.Controls.Add(this.TypeofPaymentLookUpEdit);
            this.Controls.Add(this.ReceiptNoTextBox);
            this.Controls.Add(ReceiptNoLabel);
            this.Controls.Add(this.DateofPaymentDateTimePicker);
            this.Controls.Add(DateofPaymentLabel);
            this.Controls.Add(label2);
            this.Controls.Add(this.DateofPaymentEthTextBox);
            this.Controls.Add(this.NoofSharePaidTextBox);
            this.Controls.Add(this.EffectiveDateDateTimePicker);
            this.Controls.Add(this.AmntofSharePaidTextBox);
            this.Controls.Add(EffectiveDateDateLabel);
            this.Controls.Add(letterDateEthLabel);
            this.Controls.Add(this.EffectiveDateEthTextBox);
            this.Controls.Add(AmntofShareSoldLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspShPayment);
            this.Name = "frmSharePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share Payment Entry Form";
            this.Load += new System.EventHandler(this.frmSharePayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSharePayment_KeyDown);
            this.tspShPayment.ResumeLayout(false);
            this.tspShPayment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeofPaymentLookUpEdit.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctSharePayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSharePayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspShPayment;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IsGBFounderCheckBox;
        private System.Windows.Forms.CheckBox IsLBFounderCheckBox;
        private System.Windows.Forms.DateTimePicker DORegDateTimePicker;
        private System.Windows.Forms.TextBox RegCodeTextBox;
        private DevExpress.XtraEditors.LookUpEdit SHIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private System.Windows.Forms.TextBox DORegEthTextBox;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private System.Windows.Forms.TextBox TotalUnpaidSharetextBox;
        private DevExpress.XtraEditors.LookUpEdit TypeofPaymentLookUpEdit;
        private System.Windows.Forms.TextBox ReceiptNoTextBox;
        private System.Windows.Forms.DateTimePicker DateofPaymentDateTimePicker;
        private System.Windows.Forms.TextBox DateofPaymentEthTextBox;
        private System.Windows.Forms.TextBox NoofSharePaidTextBox;
        private System.Windows.Forms.DateTimePicker EffectiveDateDateTimePicker;
        private System.Windows.Forms.TextBox AmntofSharePaidTextBox;
        private System.Windows.Forms.TextBox EffectiveDateEthTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gctSharePayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSharePayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentId;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDateofPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDateofPaymentEth;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeofPayment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeofPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colNoofSharePaid;
        private DevExpress.XtraGrid.Columns.GridColumn colAmntofSharePaid;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluEmpId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewStation;
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
    }
}