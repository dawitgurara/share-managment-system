namespace SHM
{
    partial class frmShareTransfer
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
            System.Windows.Forms.Label TypeofTransferLabel;
            System.Windows.Forms.Label DateofTransferLabel;
            System.Windows.Forms.Label EffectiveDateEthLabel;
            System.Windows.Forms.Label NoofShareSoldLabel;
            System.Windows.Forms.Label AmntofShareSoldLabel;
            System.Windows.Forms.Label RegCodeLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label DORegEthLabel;
            System.Windows.Forms.Label DORegLabel;
            System.Windows.Forms.Label TotalPaidupLabel;
            System.Windows.Forms.Label budgetYearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShareTransfer));
            this.SHIdLabel = new System.Windows.Forms.Label();
            this.tspShTransfer = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TypeofTransferLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EffectiveDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EffectiveDateEthTextBox = new System.Windows.Forms.TextBox();
            this.NoOfShareTransferedTextBox = new System.Windows.Forms.TextBox();
            this.AmntOfShareTransferedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYearAll = new DevExpress.XtraEditors.CheckEdit();
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.IsGBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalPaidupTextBox = new System.Windows.Forms.TextBox();
            this.IsLBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.DORegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.TransferFromSHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DORegEthTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gctShareTransfer = new DevExpress.XtraGrid.GridControl();
            this.gridShareTransfer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransferId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferToSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluSHId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTypeofTransfer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluTranserType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransferFromSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmntOfShareTransfered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoOfShareTransfered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.TransferToSHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            TypeofTransferLabel = new System.Windows.Forms.Label();
            DateofTransferLabel = new System.Windows.Forms.Label();
            EffectiveDateEthLabel = new System.Windows.Forms.Label();
            NoofShareSoldLabel = new System.Windows.Forms.Label();
            AmntofShareSoldLabel = new System.Windows.Forms.Label();
            RegCodeLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            DORegEthLabel = new System.Windows.Forms.Label();
            DORegLabel = new System.Windows.Forms.Label();
            TotalPaidupLabel = new System.Windows.Forms.Label();
            budgetYearLabel = new System.Windows.Forms.Label();
            this.tspShTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeofTransferLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferFromSHIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctShareTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShareTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTranserType)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.TransferToSHIdLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeofTransferLabel
            // 
            TypeofTransferLabel.AutoSize = true;
            TypeofTransferLabel.Location = new System.Drawing.Point(485, 211);
            TypeofTransferLabel.Name = "TypeofTransferLabel";
            TypeofTransferLabel.Size = new System.Drawing.Size(88, 13);
            TypeofTransferLabel.TabIndex = 226;
            TypeofTransferLabel.Text = "Type of Transfer:";
            // 
            // DateofTransferLabel
            // 
            DateofTransferLabel.AutoSize = true;
            DateofTransferLabel.Location = new System.Drawing.Point(18, 237);
            DateofTransferLabel.Name = "DateofTransferLabel";
            DateofTransferLabel.Size = new System.Drawing.Size(104, 13);
            DateofTransferLabel.TabIndex = 222;
            DateofTransferLabel.Text = "Effective Date (Grg):";
            // 
            // EffectiveDateEthLabel
            // 
            EffectiveDateEthLabel.AutoSize = true;
            EffectiveDateEthLabel.Location = new System.Drawing.Point(266, 237);
            EffectiveDateEthLabel.Name = "EffectiveDateEthLabel";
            EffectiveDateEthLabel.Size = new System.Drawing.Size(103, 13);
            EffectiveDateEthLabel.TabIndex = 223;
            EffectiveDateEthLabel.Text = "Effective Date (Eth):";
            // 
            // NoofShareSoldLabel
            // 
            NoofShareSoldLabel.AutoSize = true;
            NoofShareSoldLabel.Location = new System.Drawing.Point(304, 262);
            NoofShareSoldLabel.Name = "NoofShareSoldLabel";
            NoofShareSoldLabel.Size = new System.Drawing.Size(67, 13);
            NoofShareSoldLabel.TabIndex = 221;
            NoofShareSoldLabel.Text = "No of Share:";
            // 
            // AmntofShareSoldLabel
            // 
            AmntofShareSoldLabel.AutoSize = true;
            AmntofShareSoldLabel.Location = new System.Drawing.Point(42, 260);
            AmntofShareSoldLabel.Name = "AmntofShareSoldLabel";
            AmntofShareSoldLabel.Size = new System.Drawing.Size(77, 13);
            AmntofShareSoldLabel.TabIndex = 219;
            AmntofShareSoldLabel.Text = "Amnt of Share:";
            // 
            // RegCodeLabel
            // 
            RegCodeLabel.AutoSize = true;
            RegCodeLabel.Location = new System.Drawing.Point(22, 104);
            RegCodeLabel.Name = "RegCodeLabel";
            RegCodeLabel.Size = new System.Drawing.Size(94, 13);
            RegCodeLabel.TabIndex = 114;
            RegCodeLabel.Text = "Registration Code:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(532, 50);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 72;
            sexLabel.Text = "Sex:";
            // 
            // DORegEthLabel
            // 
            DORegEthLabel.AutoSize = true;
            DORegEthLabel.Location = new System.Drawing.Point(269, 75);
            DORegEthLabel.Name = "DORegEthLabel";
            DORegEthLabel.Size = new System.Drawing.Size(93, 13);
            DORegEthLabel.TabIndex = 94;
            DORegEthLabel.Text = "Date of Reg (Eth):";
            // 
            // DORegLabel
            // 
            DORegLabel.AutoSize = true;
            DORegLabel.Location = new System.Drawing.Point(26, 75);
            DORegLabel.Name = "DORegLabel";
            DORegLabel.Size = new System.Drawing.Size(91, 13);
            DORegLabel.TabIndex = 93;
            DORegLabel.Text = "Date ofReg (Grg):";
            // 
            // TotalPaidupLabel
            // 
            TotalPaidupLabel.AutoSize = true;
            TotalPaidupLabel.Location = new System.Drawing.Point(490, 78);
            TotalPaidupLabel.Name = "TotalPaidupLabel";
            TotalPaidupLabel.Size = new System.Drawing.Size(70, 13);
            TotalPaidupLabel.TabIndex = 233;
            TotalPaidupLabel.Text = "Total Paidup:";
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(44, 22);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(69, 13);
            budgetYearLabel.TabIndex = 235;
            budgetYearLabel.Text = "Budget Year:";
            // 
            // SHIdLabel
            // 
            this.SHIdLabel.AutoSize = true;
            this.SHIdLabel.Location = new System.Drawing.Point(42, 50);
            this.SHIdLabel.Name = "SHIdLabel";
            this.SHIdLabel.Size = new System.Drawing.Size(75, 13);
            this.SHIdLabel.TabIndex = 9;
            this.SHIdLabel.Text = "Transfer From:";
            // 
            // tspShTransfer
            // 
            this.tspShTransfer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspShTransfer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.searchByComboBox});
            this.tspShTransfer.Location = new System.Drawing.Point(0, 0);
            this.tspShTransfer.Name = "tspShTransfer";
            this.tspShTransfer.Size = new System.Drawing.Size(1028, 25);
            this.tspShTransfer.TabIndex = 7;
            this.tspShTransfer.TabStop = true;
            this.tspShTransfer.Text = "toolStrip1";
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
            // TypeofTransferLookUpEdit
            // 
            this.TypeofTransferLookUpEdit.Location = new System.Drawing.Point(578, 208);
            this.TypeofTransferLookUpEdit.Name = "TypeofTransferLookUpEdit";
            this.TypeofTransferLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TypeofTransferLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeofTransferLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeofTransfer", "TypeofTransfer", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.TypeofTransferLookUpEdit.Properties.DisplayMember = "TypeofTransfer";
            this.TypeofTransferLookUpEdit.Properties.NullText = "";
            this.TypeofTransferLookUpEdit.Properties.ShowHeader = false;
            this.TypeofTransferLookUpEdit.Properties.ValueMember = "Id";
            this.TypeofTransferLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.TypeofTransferLookUpEdit.TabIndex = 212;
            this.TypeofTransferLookUpEdit.TabStop = false;
            this.TypeofTransferLookUpEdit.EditValueChanged += new System.EventHandler(this.TypeofTransferLookUpEdit_EditValueChanged);
            // 
            // EffectiveDateDateTimePicker
            // 
            this.EffectiveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EffectiveDateDateTimePicker.Location = new System.Drawing.Point(125, 234);
            this.EffectiveDateDateTimePicker.Name = "EffectiveDateDateTimePicker";
            this.EffectiveDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.EffectiveDateDateTimePicker.TabIndex = 211;
            this.EffectiveDateDateTimePicker.Value = new System.DateTime(2017, 10, 7, 0, 0, 0, 0);
            this.EffectiveDateDateTimePicker.Validated += new System.EventHandler(this.EffectiveDateDateTimePicker_Validated);
            // 
            // EffectiveDateEthTextBox
            // 
            this.EffectiveDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EffectiveDateEthTextBox.Location = new System.Drawing.Point(372, 234);
            this.EffectiveDateEthTextBox.Name = "EffectiveDateEthTextBox";
            this.EffectiveDateEthTextBox.ReadOnly = true;
            this.EffectiveDateEthTextBox.Size = new System.Drawing.Size(108, 20);
            this.EffectiveDateEthTextBox.TabIndex = 224;
            this.EffectiveDateEthTextBox.TabStop = false;
            // 
            // NoOfShareTransferedTextBox
            // 
            this.NoOfShareTransferedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoOfShareTransferedTextBox.Location = new System.Drawing.Point(372, 260);
            this.NoOfShareTransferedTextBox.Name = "NoOfShareTransferedTextBox";
            this.NoOfShareTransferedTextBox.ReadOnly = true;
            this.NoOfShareTransferedTextBox.Size = new System.Drawing.Size(108, 20);
            this.NoOfShareTransferedTextBox.TabIndex = 214;
            this.NoOfShareTransferedTextBox.TabStop = false;
            // 
            // AmntOfShareTransferedTextBox
            // 
            this.AmntOfShareTransferedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmntOfShareTransferedTextBox.Location = new System.Drawing.Point(125, 258);
            this.AmntOfShareTransferedTextBox.Name = "AmntOfShareTransferedTextBox";
            this.AmntOfShareTransferedTextBox.Size = new System.Drawing.Size(108, 20);
            this.AmntOfShareTransferedTextBox.TabIndex = 213;
            this.AmntOfShareTransferedTextBox.TabStop = false;
            this.AmntOfShareTransferedTextBox.TextChanged += new System.EventHandler(this.AmntOfShareTransferedTextBox_TextChanged);
            this.AmntOfShareTransferedTextBox.Validated += new System.EventHandler(this.AmntOfShareTransferedTextBox_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkYearAll);
            this.groupBox1.Controls.Add(this.FiscalYearLookUpEdit);
            this.groupBox1.Controls.Add(budgetYearLabel);
            this.groupBox1.Controls.Add(TotalPaidupLabel);
            this.groupBox1.Controls.Add(this.IsGBFounderCheckBox);
            this.groupBox1.Controls.Add(this.TotalPaidupTextBox);
            this.groupBox1.Controls.Add(this.IsLBFounderCheckBox);
            this.groupBox1.Controls.Add(this.DORegDateTimePicker);
            this.groupBox1.Controls.Add(RegCodeLabel);
            this.groupBox1.Controls.Add(this.RegCodeTextBox);
            this.groupBox1.Controls.Add(this.TransferFromSHIdLookUpEdit);
            this.groupBox1.Controls.Add(this.SHIdLabel);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexLookUpEdit);
            this.groupBox1.Controls.Add(this.DORegEthTextBox);
            this.groupBox1.Controls.Add(DORegEthLabel);
            this.groupBox1.Controls.Add(DORegLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 143);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            // 
            // chkYearAll
            // 
            this.chkYearAll.Location = new System.Drawing.Point(532, 19);
            this.chkYearAll.Name = "chkYearAll";
            this.chkYearAll.Properties.Caption = "All";
            this.chkYearAll.Size = new System.Drawing.Size(51, 19);
            this.chkYearAll.TabIndex = 236;
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
            this.FiscalYearLookUpEdit.TabIndex = 234;
            this.FiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.FiscalYearLookUpEdit_EditValueChanged);
            // 
            // IsGBFounderCheckBox
            // 
            this.IsGBFounderCheckBox.AutoSize = true;
            this.IsGBFounderCheckBox.Enabled = false;
            this.IsGBFounderCheckBox.Location = new System.Drawing.Point(374, 103);
            this.IsGBFounderCheckBox.Name = "IsGBFounderCheckBox";
            this.IsGBFounderCheckBox.Size = new System.Drawing.Size(94, 17);
            this.IsGBFounderCheckBox.TabIndex = 150;
            this.IsGBFounderCheckBox.Text = "Is GB Founder";
            this.IsGBFounderCheckBox.UseVisualStyleBackColor = true;
            // 
            // TotalPaidupTextBox
            // 
            this.TotalPaidupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPaidupTextBox.Location = new System.Drawing.Point(562, 75);
            this.TotalPaidupTextBox.Name = "TotalPaidupTextBox";
            this.TotalPaidupTextBox.ReadOnly = true;
            this.TotalPaidupTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPaidupTextBox.TabIndex = 232;
            this.TotalPaidupTextBox.TabStop = false;
            // 
            // IsLBFounderCheckBox
            // 
            this.IsLBFounderCheckBox.AutoSize = true;
            this.IsLBFounderCheckBox.Enabled = false;
            this.IsLBFounderCheckBox.Location = new System.Drawing.Point(272, 103);
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
            this.DORegDateTimePicker.Location = new System.Drawing.Point(119, 74);
            this.DORegDateTimePicker.Name = "DORegDateTimePicker";
            this.DORegDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.DORegDateTimePicker.TabIndex = 148;
            this.DORegDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            // 
            // RegCodeTextBox
            // 
            this.RegCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegCodeTextBox.Location = new System.Drawing.Point(119, 100);
            this.RegCodeTextBox.Name = "RegCodeTextBox";
            this.RegCodeTextBox.ReadOnly = true;
            this.RegCodeTextBox.Size = new System.Drawing.Size(108, 20);
            this.RegCodeTextBox.TabIndex = 115;
            this.RegCodeTextBox.TabStop = false;
            // 
            // TransferFromSHIdLookUpEdit
            // 
            this.TransferFromSHIdLookUpEdit.EditValue = "";
            this.TransferFromSHIdLookUpEdit.Location = new System.Drawing.Point(119, 47);
            this.TransferFromSHIdLookUpEdit.Name = "TransferFromSHIdLookUpEdit";
            this.TransferFromSHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TransferFromSHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferFromSHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHId", "SH Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegCode", "Reg Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.TransferFromSHIdLookUpEdit.Properties.DisplayMember = "SHRegCodeWithName";
            this.TransferFromSHIdLookUpEdit.Properties.NullText = "";
            this.TransferFromSHIdLookUpEdit.Properties.ValueMember = "SHId";
            this.TransferFromSHIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.TransferFromSHIdLookUpEdit.TabIndex = 0;
            this.TransferFromSHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.TransferFromSHIdLookUpEdit_EditValueChanged);
            // 
            // sexLookUpEdit
            // 
            this.sexLookUpEdit.Location = new System.Drawing.Point(562, 47);
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
            this.DORegEthTextBox.Location = new System.Drawing.Point(374, 73);
            this.DORegEthTextBox.Name = "DORegEthTextBox";
            this.DORegEthTextBox.ReadOnly = true;
            this.DORegEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DORegEthTextBox.TabIndex = 95;
            this.DORegEthTextBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 285);
            this.tabControl1.TabIndex = 229;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gctShareTransfer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ShareTransfered List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gctShareTransfer
            // 
            this.gctShareTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctShareTransfer.EmbeddedNavigator.Name = "";
            this.gctShareTransfer.Location = new System.Drawing.Point(0, 0);
            this.gctShareTransfer.MainView = this.gridShareTransfer;
            this.gctShareTransfer.Name = "gctShareTransfer";
            this.gctShareTransfer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation,
            this.rluTypeofPayment,
            this.rluTranserType,
            this.rluSHId});
            this.gctShareTransfer.Size = new System.Drawing.Size(1065, 263);
            this.gctShareTransfer.TabIndex = 7;
            this.gctShareTransfer.TabStop = false;
            this.gctShareTransfer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridShareTransfer});
            // 
            // gridShareTransfer
            // 
            this.gridShareTransfer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransferId,
            this.colTransferToSHId,
            this.colTypeofTransfer,
            this.colTransferFromSHId,
            this.colAmntOfShareTransfered,
            this.colNoOfShareTransfered,
            this.colEffectiveDate,
            this.colEffectiveDateEth,
            this.colCrtBy1,
            this.colCrtDt1,
            this.colCrtWs1,
            this.colLmBy1,
            this.colLmDt1,
            this.colLmWs1});
            this.gridShareTransfer.GridControl = this.gctShareTransfer;
            this.gridShareTransfer.Name = "gridShareTransfer";
            this.gridShareTransfer.OptionsBehavior.Editable = false;
            this.gridShareTransfer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridShareTransfer.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridShareTransfer.OptionsView.ColumnAutoWidth = false;
            this.gridShareTransfer.OptionsView.ShowGroupPanel = false;
            // 
            // colTransferId
            // 
            this.colTransferId.Caption = "TransferId";
            this.colTransferId.FieldName = "TransferId";
            this.colTransferId.Name = "colTransferId";
            this.colTransferId.OptionsColumn.ReadOnly = true;
            // 
            // colTransferToSHId
            // 
            this.colTransferToSHId.Caption = "Transfer To";
            this.colTransferToSHId.ColumnEdit = this.rluSHId;
            this.colTransferToSHId.FieldName = "TransferToSHId";
            this.colTransferToSHId.Name = "colTransferToSHId";
            this.colTransferToSHId.Visible = true;
            this.colTransferToSHId.VisibleIndex = 0;
            this.colTransferToSHId.Width = 285;
            // 
            // rluSHId
            // 
            this.rluSHId.AutoHeight = false;
            this.rluSHId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluSHId.DisplayMember = "FullName";
            this.rluSHId.Name = "rluSHId";
            this.rluSHId.NullText = "";
            this.rluSHId.ValueMember = "SHId";
            // 
            // colTypeofTransfer
            // 
            this.colTypeofTransfer.Caption = "Type of Transfer";
            this.colTypeofTransfer.ColumnEdit = this.rluTranserType;
            this.colTypeofTransfer.FieldName = "TypeofTransfer";
            this.colTypeofTransfer.Name = "colTypeofTransfer";
            this.colTypeofTransfer.Visible = true;
            this.colTypeofTransfer.VisibleIndex = 1;
            this.colTypeofTransfer.Width = 159;
            // 
            // rluTranserType
            // 
            this.rluTranserType.AutoHeight = false;
            this.rluTranserType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluTranserType.DisplayMember = "TypeofTransfer";
            this.rluTranserType.Name = "rluTranserType";
            this.rluTranserType.NullText = "";
            this.rluTranserType.ValueMember = "Id";
            // 
            // colTransferFromSHId
            // 
            this.colTransferFromSHId.Caption = "TransferFromSHId";
            this.colTransferFromSHId.FieldName = "TransferFromSHId";
            this.colTransferFromSHId.Name = "colTransferFromSHId";
            // 
            // colAmntOfShareTransfered
            // 
            this.colAmntOfShareTransfered.Caption = "Amnt of Share Transfered";
            this.colAmntOfShareTransfered.FieldName = "AmntOfShareTransfered";
            this.colAmntOfShareTransfered.Name = "colAmntOfShareTransfered";
            this.colAmntOfShareTransfered.Visible = true;
            this.colAmntOfShareTransfered.VisibleIndex = 2;
            this.colAmntOfShareTransfered.Width = 165;
            // 
            // colNoOfShareTransfered
            // 
            this.colNoOfShareTransfered.Caption = "No of Share Transfered";
            this.colNoOfShareTransfered.FieldName = "NoOfShareTransfered";
            this.colNoOfShareTransfered.Name = "colNoOfShareTransfered";
            this.colNoOfShareTransfered.Visible = true;
            this.colNoOfShareTransfered.VisibleIndex = 3;
            this.colNoOfShareTransfered.Width = 161;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.Caption = "Effective Date (Grg)";
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 4;
            this.colEffectiveDate.Width = 160;
            // 
            // colEffectiveDateEth
            // 
            this.colEffectiveDateEth.Caption = "Effective Date (Eth)";
            this.colEffectiveDateEth.FieldName = "EffectiveDateEth";
            this.colEffectiveDateEth.Name = "colEffectiveDateEth";
            this.colEffectiveDateEth.Visible = true;
            this.colEffectiveDateEth.VisibleIndex = 5;
            this.colEffectiveDateEth.Width = 130;
            // 
            // colCrtBy1
            // 
            this.colCrtBy1.Caption = "CrtBy";
            this.colCrtBy1.FieldName = "CrtBy";
            this.colCrtBy1.Name = "colCrtBy1";
            this.colCrtBy1.Visible = true;
            this.colCrtBy1.VisibleIndex = 6;
            // 
            // colCrtDt1
            // 
            this.colCrtDt1.Caption = "CrtDt";
            this.colCrtDt1.FieldName = "CrtDt";
            this.colCrtDt1.Name = "colCrtDt1";
            this.colCrtDt1.Visible = true;
            this.colCrtDt1.VisibleIndex = 7;
            // 
            // colCrtWs1
            // 
            this.colCrtWs1.Caption = "CrtWs";
            this.colCrtWs1.FieldName = "CrtWs";
            this.colCrtWs1.Name = "colCrtWs1";
            this.colCrtWs1.Visible = true;
            this.colCrtWs1.VisibleIndex = 8;
            // 
            // colLmBy1
            // 
            this.colLmBy1.Caption = "LmBy";
            this.colLmBy1.FieldName = "LmBy";
            this.colLmBy1.Name = "colLmBy1";
            this.colLmBy1.Visible = true;
            this.colLmBy1.VisibleIndex = 9;
            // 
            // colLmDt1
            // 
            this.colLmDt1.Caption = "LmDt";
            this.colLmDt1.FieldName = "LmDt";
            this.colLmDt1.Name = "colLmDt1";
            this.colLmDt1.Visible = true;
            this.colLmDt1.VisibleIndex = 10;
            // 
            // colLmWs1
            // 
            this.colLmWs1.Caption = "LmWs";
            this.colLmWs1.FieldName = "LmWs";
            this.colLmWs1.Name = "colLmWs1";
            this.colLmWs1.Visible = true;
            this.colLmWs1.VisibleIndex = 11;
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
            this.colSHId1.Width = 97;
            // 
            // colSubscribedShareNoOrg
            // 
            this.colSubscribedShareNoOrg.Caption = "Subscribed Share No Org.";
            this.colSubscribedShareNoOrg.FieldName = "SubscribedShareNoOrg";
            this.colSubscribedShareNoOrg.Name = "colSubscribedShareNoOrg";
            this.colSubscribedShareNoOrg.Visible = true;
            this.colSubscribedShareNoOrg.VisibleIndex = 1;
            this.colSubscribedShareNoOrg.Width = 158;
            // 
            // colSubscribedShareAmtOrg
            // 
            this.colSubscribedShareAmtOrg.Caption = "Subscribed Share Amnt Org.";
            this.colSubscribedShareAmtOrg.FieldName = "SubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Name = "colSubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Visible = true;
            this.colSubscribedShareAmtOrg.VisibleIndex = 2;
            this.colSubscribedShareAmtOrg.Width = 151;
            // 
            // colSubscribedShareNoModif
            // 
            this.colSubscribedShareNoModif.Caption = "Subscribed Share No. Modif.";
            this.colSubscribedShareNoModif.FieldName = "SubscribedShareNoModif";
            this.colSubscribedShareNoModif.Name = "colSubscribedShareNoModif";
            this.colSubscribedShareNoModif.Visible = true;
            this.colSubscribedShareNoModif.VisibleIndex = 3;
            this.colSubscribedShareNoModif.Width = 169;
            // 
            // colSubscribedShareAmtModif
            // 
            this.colSubscribedShareAmtModif.Caption = "Subscribed Share Amnt. Modif.";
            this.colSubscribedShareAmtModif.FieldName = "SubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Name = "colSubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Visible = true;
            this.colSubscribedShareAmtModif.VisibleIndex = 4;
            this.colSubscribedShareAmtModif.Width = 193;
            // 
            // colPaidUpNoofShare
            // 
            this.colPaidUpNoofShare.Caption = "Paid Up No of Share";
            this.colPaidUpNoofShare.FieldName = "PaidUpNoofShare";
            this.colPaidUpNoofShare.Name = "colPaidUpNoofShare";
            this.colPaidUpNoofShare.Visible = true;
            this.colPaidUpNoofShare.VisibleIndex = 5;
            this.colPaidUpNoofShare.Width = 135;
            // 
            // colPaidUpShareAmt
            // 
            this.colPaidUpShareAmt.Caption = "Paid Up Share Amt";
            this.colPaidUpShareAmt.FieldName = "PaidUpShareAmt";
            this.colPaidUpShareAmt.Name = "colPaidUpShareAmt";
            this.colPaidUpShareAmt.Visible = true;
            this.colPaidUpShareAmt.VisibleIndex = 6;
            this.colPaidUpShareAmt.Width = 151;
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
            // TransferToSHIdLookUpEdit
            // 
            this.TransferToSHIdLookUpEdit.EditValue = "";
            this.TransferToSHIdLookUpEdit.Location = new System.Drawing.Point(125, 208);
            this.TransferToSHIdLookUpEdit.Name = "TransferToSHIdLookUpEdit";
            this.TransferToSHIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TransferToSHIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferToSHIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHId", "SH Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegCode", "Reg Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.TransferToSHIdLookUpEdit.Properties.DisplayMember = "SHRegCodeWithName";
            this.TransferToSHIdLookUpEdit.Properties.NullText = "";
            this.TransferToSHIdLookUpEdit.Properties.ValueMember = "SHId";
            this.TransferToSHIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.TransferToSHIdLookUpEdit.TabIndex = 230;
            this.TransferToSHIdLookUpEdit.EditValueChanged += new System.EventHandler(this.TransferToSHIdLookUpEdit_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 231;
            this.label3.Text = "Transfer To:";
            // 
            // frmShareTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.TransferToSHIdLookUpEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(TypeofTransferLabel);
            this.Controls.Add(this.TypeofTransferLookUpEdit);
            this.Controls.Add(this.EffectiveDateDateTimePicker);
            this.Controls.Add(DateofTransferLabel);
            this.Controls.Add(EffectiveDateEthLabel);
            this.Controls.Add(this.EffectiveDateEthTextBox);
            this.Controls.Add(NoofShareSoldLabel);
            this.Controls.Add(this.NoOfShareTransferedTextBox);
            this.Controls.Add(this.AmntOfShareTransferedTextBox);
            this.Controls.Add(AmntofShareSoldLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspShTransfer);
            this.Name = "frmShareTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share Transfer Entry Form";
            this.Load += new System.EventHandler(this.frmShareTransfer_Load);
            this.tspShTransfer.ResumeLayout(false);
            this.tspShTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeofTransferLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkYearAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferFromSHIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctShareTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShareTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluSHId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTranserType)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.TransferToSHIdLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspShTransfer;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
        private DevExpress.XtraEditors.LookUpEdit TypeofTransferLookUpEdit;
        private System.Windows.Forms.DateTimePicker EffectiveDateDateTimePicker;
        private System.Windows.Forms.TextBox EffectiveDateEthTextBox;
        private System.Windows.Forms.TextBox NoOfShareTransferedTextBox;
        private System.Windows.Forms.TextBox AmntOfShareTransferedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IsGBFounderCheckBox;
        private System.Windows.Forms.CheckBox IsLBFounderCheckBox;
        private System.Windows.Forms.DateTimePicker DORegDateTimePicker;
        private System.Windows.Forms.TextBox RegCodeTextBox;
        private DevExpress.XtraEditors.LookUpEdit TransferFromSHIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private System.Windows.Forms.TextBox DORegEthTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gctShareTransfer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridShareTransfer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeofPayment;
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
        private System.Windows.Forms.Label SHIdLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeofTransfer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferFromSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferToSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colNoOfShareTransfered;
        private DevExpress.XtraGrid.Columns.GridColumn colAmntOfShareTransfered;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colLmWs1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTranserType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluSHId;
        private DevExpress.XtraEditors.LookUpEdit TransferToSHIdLookUpEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalPaidupTextBox;
        private DevExpress.XtraEditors.CheckEdit chkYearAll;
        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
    }
}