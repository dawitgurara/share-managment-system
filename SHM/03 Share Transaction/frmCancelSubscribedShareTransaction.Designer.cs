namespace SHM
{
    partial class frmCancelSubscribedShareTransaction
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
            System.Windows.Forms.Label EffectiveDateDateLabel;
            System.Windows.Forms.Label letterDateEthLabel;
            System.Windows.Forms.Label NoofShareSoldLabel;
            System.Windows.Forms.Label AmntofShareSoldLabel;
            System.Windows.Forms.Label DORegLabel;
            System.Windows.Forms.Label DORegEthLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label SHIdLabel;
            System.Windows.Forms.Label RegCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelSubscribedShareTransaction));
            this.tspCancelShSubscribe = new System.Windows.Forms.ToolStrip();
            this.CancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchByComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gctShareSubscribe = new DevExpress.XtraGrid.GridControl();
            this.gridShareSubscribe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDateEth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoofShareSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmntofShareSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLmWs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gctCancelSubscrb = new DevExpress.XtraGrid.GridControl();
            this.gridCancelSubscrb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrnId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDateEth1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtDt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrtWs2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this.AmntofShareSoldTextBox = new System.Windows.Forms.TextBox();
            this.EffectiveDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoofShareSoldTextBox = new System.Windows.Forms.TextBox();
            this.EffectiveDateEthTextBox = new System.Windows.Forms.TextBox();
            this.SbscribtionDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.DORegEthTextBox = new System.Windows.Forms.TextBox();
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SHIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.DORegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IsLBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.IsGBFounderCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            EffectiveDateDateLabel = new System.Windows.Forms.Label();
            letterDateEthLabel = new System.Windows.Forms.Label();
            NoofShareSoldLabel = new System.Windows.Forms.Label();
            AmntofShareSoldLabel = new System.Windows.Forms.Label();
            DORegLabel = new System.Windows.Forms.Label();
            DORegEthLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            SHIdLabel = new System.Windows.Forms.Label();
            RegCodeLabel = new System.Windows.Forms.Label();
            this.tspCancelShSubscribe.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctShareSubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShareSubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctCancelSubscrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCancelSubscrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).BeginInit();
            this.SbscribtionDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EffectiveDateDateLabel
            // 
            EffectiveDateDateLabel.AutoSize = true;
            EffectiveDateDateLabel.Location = new System.Drawing.Point(12, 23);
            EffectiveDateDateLabel.Name = "EffectiveDateDateLabel";
            EffectiveDateDateLabel.Size = new System.Drawing.Size(104, 13);
            EffectiveDateDateLabel.TabIndex = 191;
            EffectiveDateDateLabel.Text = "Effective Date (Grg):";
            // 
            // letterDateEthLabel
            // 
            letterDateEthLabel.AutoSize = true;
            letterDateEthLabel.Location = new System.Drawing.Point(280, 22);
            letterDateEthLabel.Name = "letterDateEthLabel";
            letterDateEthLabel.Size = new System.Drawing.Size(88, 13);
            letterDateEthLabel.TabIndex = 192;
            letterDateEthLabel.Text = "Letter Date (Eth):";
            // 
            // NoofShareSoldLabel
            // 
            NoofShareSoldLabel.AutoSize = true;
            NoofShareSoldLabel.Location = new System.Drawing.Point(301, 47);
            NoofShareSoldLabel.Name = "NoofShareSoldLabel";
            NoofShareSoldLabel.Size = new System.Drawing.Size(67, 13);
            NoofShareSoldLabel.TabIndex = 198;
            NoofShareSoldLabel.Text = "No of Share:";
            // 
            // AmntofShareSoldLabel
            // 
            AmntofShareSoldLabel.AutoSize = true;
            AmntofShareSoldLabel.Location = new System.Drawing.Point(39, 49);
            AmntofShareSoldLabel.Name = "AmntofShareSoldLabel";
            AmntofShareSoldLabel.Size = new System.Drawing.Size(77, 13);
            AmntofShareSoldLabel.TabIndex = 194;
            AmntofShareSoldLabel.Text = "Amnt of Share:";
            // 
            // DORegLabel
            // 
            DORegLabel.AutoSize = true;
            DORegLabel.Location = new System.Drawing.Point(26, 43);
            DORegLabel.Name = "DORegLabel";
            DORegLabel.Size = new System.Drawing.Size(91, 13);
            DORegLabel.TabIndex = 93;
            DORegLabel.Text = "Date ofReg (Grg):";
            // 
            // DORegEthLabel
            // 
            DORegEthLabel.AutoSize = true;
            DORegEthLabel.Location = new System.Drawing.Point(278, 45);
            DORegEthLabel.Name = "DORegEthLabel";
            DORegEthLabel.Size = new System.Drawing.Size(93, 13);
            DORegEthLabel.TabIndex = 94;
            DORegEthLabel.Text = "Date of Reg (Eth):";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(500, 18);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 72;
            sexLabel.Text = "Sex:";
            // 
            // SHIdLabel
            // 
            SHIdLabel.AutoSize = true;
            SHIdLabel.Location = new System.Drawing.Point(50, 18);
            SHIdLabel.Name = "SHIdLabel";
            SHIdLabel.Size = new System.Drawing.Size(67, 13);
            SHIdLabel.TabIndex = 9;
            SHIdLabel.Text = "Shareholder:";
            // 
            // RegCodeLabel
            // 
            RegCodeLabel.AutoSize = true;
            RegCodeLabel.Location = new System.Drawing.Point(22, 71);
            RegCodeLabel.Name = "RegCodeLabel";
            RegCodeLabel.Size = new System.Drawing.Size(94, 13);
            RegCodeLabel.TabIndex = 114;
            RegCodeLabel.Text = "Registration Code:";
            // 
            // tspCancelShSubscribe
            // 
            this.tspCancelShSubscribe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspCancelShSubscribe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelToolStripButton,
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.searchByComboBox});
            this.tspCancelShSubscribe.Location = new System.Drawing.Point(0, 0);
            this.tspCancelShSubscribe.Name = "tspCancelShSubscribe";
            this.tspCancelShSubscribe.Size = new System.Drawing.Size(1150, 25);
            this.tspCancelShSubscribe.TabIndex = 5;
            this.tspCancelShSubscribe.TabStop = true;
            this.tspCancelShSubscribe.Text = "toolStrip1";
            // 
            // CancelToolStripButton
            // 
            this.CancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelToolStripButton.Image")));
            this.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelToolStripButton.Name = "CancelToolStripButton";
            this.CancelToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.CancelToolStripButton.Text = "Cancel";
            this.CancelToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 246);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 313);
            this.tabControl1.TabIndex = 199;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gctShareSubscribe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Share Subscribed List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gctShareSubscribe
            // 
            this.gctShareSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctShareSubscribe.EmbeddedNavigator.Name = "";
            this.gctShareSubscribe.Location = new System.Drawing.Point(0, 0);
            this.gctShareSubscribe.MainView = this.gridShareSubscribe;
            this.gctShareSubscribe.Name = "gctShareSubscribe";
            this.gctShareSubscribe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation});
            this.gctShareSubscribe.Size = new System.Drawing.Size(1094, 273);
            this.gctShareSubscribe.TabIndex = 0;
            this.gctShareSubscribe.TabStop = false;
            this.gctShareSubscribe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridShareSubscribe});
            this.gctShareSubscribe.DoubleClick += new System.EventHandler(this.gridShareSubscribe_DoubleClick);
            // 
            // gridShareSubscribe
            // 
            this.gridShareSubscribe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrnId,
            this.colSHId,
            this.colEffectiveDate,
            this.colEffectiveDateEth,
            this.colNoofShareSold,
            this.colAmntofShareSold,
            this.colCrtBy1,
            this.colCrtDt1,
            this.colCrtWs1,
            this.colLmBy1,
            this.colLmDt1,
            this.colLmWs1});
            this.gridShareSubscribe.GridControl = this.gctShareSubscribe;
            this.gridShareSubscribe.Name = "gridShareSubscribe";
            this.gridShareSubscribe.OptionsBehavior.Editable = false;
            this.gridShareSubscribe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridShareSubscribe.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridShareSubscribe.OptionsView.ColumnAutoWidth = false;
            this.gridShareSubscribe.OptionsView.ShowGroupPanel = false;
            this.gridShareSubscribe.DoubleClick += new System.EventHandler(this.gridShareSubscribe_DoubleClick);
            // 
            // colTrnId
            // 
            this.colTrnId.Caption = "Trn Id";
            this.colTrnId.FieldName = "TrnId";
            this.colTrnId.Name = "colTrnId";
            this.colTrnId.OptionsColumn.ReadOnly = true;
            this.colTrnId.Visible = true;
            this.colTrnId.VisibleIndex = 0;
            this.colTrnId.Width = 65;
            // 
            // colSHId
            // 
            this.colSHId.Caption = "SHId";
            this.colSHId.FieldName = "SHId";
            this.colSHId.Name = "colSHId";
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.Caption = "Effective Date (Grg.)";
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 1;
            this.colEffectiveDate.Width = 152;
            // 
            // colEffectiveDateEth
            // 
            this.colEffectiveDateEth.Caption = "Effective Date (Eth)";
            this.colEffectiveDateEth.FieldName = "EffectiveDateEth";
            this.colEffectiveDateEth.Name = "colEffectiveDateEth";
            this.colEffectiveDateEth.Visible = true;
            this.colEffectiveDateEth.VisibleIndex = 2;
            this.colEffectiveDateEth.Width = 130;
            // 
            // colNoofShareSold
            // 
            this.colNoofShareSold.Caption = "No of Share Subscribed";
            this.colNoofShareSold.FieldName = "NoofShareSold";
            this.colNoofShareSold.Name = "colNoofShareSold";
            this.colNoofShareSold.Visible = true;
            this.colNoofShareSold.VisibleIndex = 3;
            this.colNoofShareSold.Width = 166;
            // 
            // colAmntofShareSold
            // 
            this.colAmntofShareSold.Caption = "Amount  of Share Subscribed";
            this.colAmntofShareSold.FieldName = "AmntofShareSold";
            this.colAmntofShareSold.Name = "colAmntofShareSold";
            this.colAmntofShareSold.Visible = true;
            this.colAmntofShareSold.VisibleIndex = 4;
            this.colAmntofShareSold.Width = 167;
            // 
            // colCrtBy1
            // 
            this.colCrtBy1.Caption = "CrtBy";
            this.colCrtBy1.FieldName = "CrtBy";
            this.colCrtBy1.Name = "colCrtBy1";
            this.colCrtBy1.Visible = true;
            this.colCrtBy1.VisibleIndex = 5;
            // 
            // colCrtDt1
            // 
            this.colCrtDt1.Caption = "CrtDt";
            this.colCrtDt1.FieldName = "CrtDt";
            this.colCrtDt1.Name = "colCrtDt1";
            this.colCrtDt1.Visible = true;
            this.colCrtDt1.VisibleIndex = 6;
            // 
            // colCrtWs1
            // 
            this.colCrtWs1.Caption = "CrtWs";
            this.colCrtWs1.FieldName = "CrtWs";
            this.colCrtWs1.Name = "colCrtWs1";
            this.colCrtWs1.Visible = true;
            this.colCrtWs1.VisibleIndex = 7;
            // 
            // colLmBy1
            // 
            this.colLmBy1.Caption = "LmBy";
            this.colLmBy1.FieldName = "LmBy";
            this.colLmBy1.Name = "colLmBy1";
            this.colLmBy1.Visible = true;
            this.colLmBy1.VisibleIndex = 8;
            // 
            // colLmDt1
            // 
            this.colLmDt1.Caption = "LmDt";
            this.colLmDt1.FieldName = "LmDt";
            this.colLmDt1.Name = "colLmDt1";
            this.colLmDt1.Visible = true;
            this.colLmDt1.VisibleIndex = 9;
            // 
            // colLmWs1
            // 
            this.colLmWs1.Caption = "LmWs";
            this.colLmWs1.FieldName = "LmWs";
            this.colLmWs1.Name = "colLmWs1";
            this.colLmWs1.Visible = true;
            this.colLmWs1.VisibleIndex = 10;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gctCancelSubscrb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1065, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Canceled Subscribtion List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gctCancelSubscrb
            // 
            this.gctCancelSubscrb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctCancelSubscrb.EmbeddedNavigator.Name = "";
            this.gctCancelSubscrb.Location = new System.Drawing.Point(3, 0);
            this.gctCancelSubscrb.MainView = this.gridCancelSubscrb;
            this.gctCancelSubscrb.Name = "gctCancelSubscrb";
            this.gctCancelSubscrb.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gctCancelSubscrb.Size = new System.Drawing.Size(1066, 284);
            this.gctCancelSubscrb.TabIndex = 1;
            this.gctCancelSubscrb.TabStop = false;
            this.gctCancelSubscrb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCancelSubscrb});
            // 
            // gridCancelSubscrb
            // 
            this.gridCancelSubscrb.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrnId1,
            this.colEffectiveDate1,
            this.colEffectiveDateEth1,
            this.colCrtBy2,
            this.colCrtDt2,
            this.colCrtWs2});
            this.gridCancelSubscrb.GridControl = this.gctCancelSubscrb;
            this.gridCancelSubscrb.Name = "gridCancelSubscrb";
            this.gridCancelSubscrb.OptionsBehavior.Editable = false;
            this.gridCancelSubscrb.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCancelSubscrb.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridCancelSubscrb.OptionsView.ColumnAutoWidth = false;
            this.gridCancelSubscrb.OptionsView.ShowGroupPanel = false;
            // 
            // colTrnId1
            // 
            this.colTrnId1.Caption = "Trn Id";
            this.colTrnId1.FieldName = "TrnId";
            this.colTrnId1.Name = "colTrnId1";
            this.colTrnId1.Visible = true;
            this.colTrnId1.VisibleIndex = 0;
            // 
            // colEffectiveDate1
            // 
            this.colEffectiveDate1.Caption = "Effective Date (Grg.)";
            this.colEffectiveDate1.FieldName = "EffectiveDate";
            this.colEffectiveDate1.Name = "colEffectiveDate1";
            this.colEffectiveDate1.Visible = true;
            this.colEffectiveDate1.VisibleIndex = 1;
            this.colEffectiveDate1.Width = 135;
            // 
            // colEffectiveDateEth1
            // 
            this.colEffectiveDateEth1.Caption = "Effective Date (Eth)";
            this.colEffectiveDateEth1.FieldName = "EffectiveDateEth";
            this.colEffectiveDateEth1.Name = "colEffectiveDateEth1";
            this.colEffectiveDateEth1.Visible = true;
            this.colEffectiveDateEth1.VisibleIndex = 2;
            this.colEffectiveDateEth1.Width = 127;
            // 
            // colCrtBy2
            // 
            this.colCrtBy2.Caption = "CrtBy";
            this.colCrtBy2.FieldName = "CrtBy";
            this.colCrtBy2.Name = "colCrtBy2";
            this.colCrtBy2.Visible = true;
            this.colCrtBy2.VisibleIndex = 3;
            // 
            // colCrtDt2
            // 
            this.colCrtDt2.Caption = "CrtDt";
            this.colCrtDt2.FieldName = "CrtDt";
            this.colCrtDt2.Name = "colCrtDt2";
            this.colCrtDt2.Visible = true;
            this.colCrtDt2.VisibleIndex = 4;
            // 
            // colCrtWs2
            // 
            this.colCrtWs2.Caption = "CrtWs";
            this.colCrtWs2.FieldName = "CrtWs";
            this.colCrtWs2.Name = "colCrtWs2";
            this.colCrtWs2.Visible = true;
            this.colCrtWs2.VisibleIndex = 5;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gctSHRegBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 287);
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
            this.gctSHRegBook.Size = new System.Drawing.Size(1069, 284);
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
            this.colSubscribedShareNoOrg.Width = 150;
            // 
            // colSubscribedShareAmtOrg
            // 
            this.colSubscribedShareAmtOrg.Caption = "Subscribed Share Amnt Org.";
            this.colSubscribedShareAmtOrg.FieldName = "SubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Name = "colSubscribedShareAmtOrg";
            this.colSubscribedShareAmtOrg.Visible = true;
            this.colSubscribedShareAmtOrg.VisibleIndex = 2;
            this.colSubscribedShareAmtOrg.Width = 157;
            // 
            // colSubscribedShareNoModif
            // 
            this.colSubscribedShareNoModif.Caption = "Subscribed Share No. Modif.";
            this.colSubscribedShareNoModif.FieldName = "SubscribedShareNoModif";
            this.colSubscribedShareNoModif.Name = "colSubscribedShareNoModif";
            this.colSubscribedShareNoModif.Visible = true;
            this.colSubscribedShareNoModif.VisibleIndex = 3;
            this.colSubscribedShareNoModif.Width = 156;
            // 
            // colSubscribedShareAmtModif
            // 
            this.colSubscribedShareAmtModif.Caption = "Subscribed Share Amnt. Modif.";
            this.colSubscribedShareAmtModif.FieldName = "SubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Name = "colSubscribedShareAmtModif";
            this.colSubscribedShareAmtModif.Visible = true;
            this.colSubscribedShareAmtModif.VisibleIndex = 4;
            this.colSubscribedShareAmtModif.Width = 175;
            // 
            // colPaidUpNoofShare
            // 
            this.colPaidUpNoofShare.Caption = "Paid Up No of Share";
            this.colPaidUpNoofShare.FieldName = "PaidUpNoofShare";
            this.colPaidUpNoofShare.Name = "colPaidUpNoofShare";
            this.colPaidUpNoofShare.Visible = true;
            this.colPaidUpNoofShare.VisibleIndex = 5;
            this.colPaidUpNoofShare.Width = 117;
            // 
            // colPaidUpShareAmt
            // 
            this.colPaidUpShareAmt.Caption = "Paid Up Share Amt";
            this.colPaidUpShareAmt.FieldName = "PaidUpShareAmt";
            this.colPaidUpShareAmt.Name = "colPaidUpShareAmt";
            this.colPaidUpShareAmt.Visible = true;
            this.colPaidUpShareAmt.VisibleIndex = 6;
            this.colPaidUpShareAmt.Width = 99;
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
            // AmntofShareSoldTextBox
            // 
            this.AmntofShareSoldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmntofShareSoldTextBox.Location = new System.Drawing.Point(119, 45);
            this.AmntofShareSoldTextBox.Name = "AmntofShareSoldTextBox";
            this.AmntofShareSoldTextBox.Size = new System.Drawing.Size(108, 20);
            this.AmntofShareSoldTextBox.TabIndex = 3;
            this.AmntofShareSoldTextBox.TabStop = false;
            // 
            // EffectiveDateDateTimePicker
            // 
            this.EffectiveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EffectiveDateDateTimePicker.Location = new System.Drawing.Point(119, 19);
            this.EffectiveDateDateTimePicker.Name = "EffectiveDateDateTimePicker";
            this.EffectiveDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.EffectiveDateDateTimePicker.TabIndex = 1;
            this.EffectiveDateDateTimePicker.Value = new System.DateTime(2017, 10, 6, 0, 0, 0, 0);
            // 
            // NoofShareSoldTextBox
            // 
            this.NoofShareSoldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoofShareSoldTextBox.Location = new System.Drawing.Point(374, 45);
            this.NoofShareSoldTextBox.Name = "NoofShareSoldTextBox";
            this.NoofShareSoldTextBox.ReadOnly = true;
            this.NoofShareSoldTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoofShareSoldTextBox.TabIndex = 4;
            this.NoofShareSoldTextBox.TabStop = false;
            // 
            // EffectiveDateEthTextBox
            // 
            this.EffectiveDateEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EffectiveDateEthTextBox.Location = new System.Drawing.Point(374, 19);
            this.EffectiveDateEthTextBox.Name = "EffectiveDateEthTextBox";
            this.EffectiveDateEthTextBox.ReadOnly = true;
            this.EffectiveDateEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EffectiveDateEthTextBox.TabIndex = 2;
            this.EffectiveDateEthTextBox.TabStop = false;
            // 
            // SbscribtionDetailGroupBox
            // 
            this.SbscribtionDetailGroupBox.Controls.Add(this.EffectiveDateEthTextBox);
            this.SbscribtionDetailGroupBox.Controls.Add(AmntofShareSoldLabel);
            this.SbscribtionDetailGroupBox.Controls.Add(NoofShareSoldLabel);
            this.SbscribtionDetailGroupBox.Controls.Add(letterDateEthLabel);
            this.SbscribtionDetailGroupBox.Controls.Add(this.NoofShareSoldTextBox);
            this.SbscribtionDetailGroupBox.Controls.Add(EffectiveDateDateLabel);
            this.SbscribtionDetailGroupBox.Controls.Add(this.EffectiveDateDateTimePicker);
            this.SbscribtionDetailGroupBox.Controls.Add(this.AmntofShareSoldTextBox);
            this.SbscribtionDetailGroupBox.Location = new System.Drawing.Point(22, 152);
            this.SbscribtionDetailGroupBox.Name = "SbscribtionDetailGroupBox";
            this.SbscribtionDetailGroupBox.Size = new System.Drawing.Size(652, 80);
            this.SbscribtionDetailGroupBox.TabIndex = 200;
            this.SbscribtionDetailGroupBox.TabStop = false;
            // 
            // DORegEthTextBox
            // 
            this.DORegEthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DORegEthTextBox.Location = new System.Drawing.Point(374, 41);
            this.DORegEthTextBox.Name = "DORegEthTextBox";
            this.DORegEthTextBox.ReadOnly = true;
            this.DORegEthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DORegEthTextBox.TabIndex = 95;
            this.DORegEthTextBox.TabStop = false;
            // 
            // sexLookUpEdit
            // 
            this.sexLookUpEdit.Location = new System.Drawing.Point(534, 15);
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
            // SHIdLookUpEdit
            // 
            this.SHIdLookUpEdit.Location = new System.Drawing.Point(119, 15);
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
            // RegCodeTextBox
            // 
            this.RegCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegCodeTextBox.Location = new System.Drawing.Point(119, 68);
            this.RegCodeTextBox.Name = "RegCodeTextBox";
            this.RegCodeTextBox.ReadOnly = true;
            this.RegCodeTextBox.Size = new System.Drawing.Size(108, 20);
            this.RegCodeTextBox.TabIndex = 115;
            this.RegCodeTextBox.TabStop = false;
            // 
            // DORegDateTimePicker
            // 
            this.DORegDateTimePicker.Enabled = false;
            this.DORegDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DORegDateTimePicker.Location = new System.Drawing.Point(119, 42);
            this.DORegDateTimePicker.Name = "DORegDateTimePicker";
            this.DORegDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.DORegDateTimePicker.TabIndex = 148;
            this.DORegDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            // 
            // IsLBFounderCheckBox
            // 
            this.IsLBFounderCheckBox.AutoSize = true;
            this.IsLBFounderCheckBox.Enabled = false;
            this.IsLBFounderCheckBox.Location = new System.Drawing.Point(279, 71);
            this.IsLBFounderCheckBox.Name = "IsLBFounderCheckBox";
            this.IsLBFounderCheckBox.Size = new System.Drawing.Size(92, 17);
            this.IsLBFounderCheckBox.TabIndex = 149;
            this.IsLBFounderCheckBox.Text = "Is LB Founder";
            this.IsLBFounderCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsGBFounderCheckBox
            // 
            this.IsGBFounderCheckBox.AutoSize = true;
            this.IsGBFounderCheckBox.Enabled = false;
            this.IsGBFounderCheckBox.Location = new System.Drawing.Point(377, 71);
            this.IsGBFounderCheckBox.Name = "IsGBFounderCheckBox";
            this.IsGBFounderCheckBox.Size = new System.Drawing.Size(94, 17);
            this.IsGBFounderCheckBox.TabIndex = 150;
            this.IsGBFounderCheckBox.Text = "Is GB Founder";
            this.IsGBFounderCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(22, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 105);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            // 
            // frmCancelSubscribedShareTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.SbscribtionDetailGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspCancelShSubscribe);
            this.Name = "frmCancelSubscribedShareTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Subscribed Share Transaction";
            this.Load += new System.EventHandler(this.frmCancelSubscribedShareTransaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCancelSubscribedShareTransaction_KeyDown);
            this.tspCancelShSubscribe.ResumeLayout(false);
            this.tspCancelShSubscribe.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctShareSubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShareSubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctCancelSubscrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCancelSubscrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSHRegBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFrmDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTransferType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluToStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFromStation)).EndInit();
            this.SbscribtionDetailGroupBox.ResumeLayout(false);
            this.SbscribtionDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIdLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspCancelShSubscribe;
        private System.Windows.Forms.ToolStripButton CancelToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox searchByComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gctShareSubscribe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridShareSubscribe;
        private DevExpress.XtraGrid.Columns.GridColumn colTrnId;
        private DevExpress.XtraGrid.Columns.GridColumn colSHId;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDateEth;
        private DevExpress.XtraGrid.Columns.GridColumn colNoofShareSold;
        private DevExpress.XtraGrid.Columns.GridColumn colAmntofShareSold;
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
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl gctCancelSubscrb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCancelSubscrb;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colTrnId1;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDateEth1;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtDt2;
        private DevExpress.XtraGrid.Columns.GridColumn colCrtWs2;
        private System.Windows.Forms.TextBox AmntofShareSoldTextBox;
        private System.Windows.Forms.DateTimePicker EffectiveDateDateTimePicker;
        private System.Windows.Forms.TextBox NoofShareSoldTextBox;
        private System.Windows.Forms.TextBox EffectiveDateEthTextBox;
        private System.Windows.Forms.GroupBox SbscribtionDetailGroupBox;
        private System.Windows.Forms.TextBox DORegEthTextBox;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit SHIdLookUpEdit;
        private System.Windows.Forms.TextBox RegCodeTextBox;
        private System.Windows.Forms.DateTimePicker DORegDateTimePicker;
        private System.Windows.Forms.CheckBox IsLBFounderCheckBox;
        private System.Windows.Forms.CheckBox IsGBFounderCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}