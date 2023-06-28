namespace SHM
{
    partial class frmReportSetup
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
            System.Windows.Forms.Label repIdLabel1;
            System.Windows.Forms.Label dataObjTypeLabel;
            System.Windows.Forms.Label usrNameFldLabel;
            System.Windows.Forms.Label repIdLabel;
            System.Windows.Forms.Label reportGroupLabel;
            System.Windows.Forms.Label repNameLabel;
            System.Windows.Forms.Label reportHeadLabel;
            System.Windows.Forms.Label reportFileNameLabel;
            System.Windows.Forms.Label sortByLabel;
            System.Windows.Forms.Label dataObjNameLabel;
            System.Windows.Forms.Label criteriaLabel;
            System.Windows.Forms.Label listFieldsLabel;
            System.Windows.Forms.Label dataSourceTypeLabel;
            System.Windows.Forms.Label dataSourceLabel;
            System.Windows.Forms.Label valueMemberLabel;
            System.Windows.Forms.Label displayMemberLabel;
            System.Windows.Forms.Label controlTypeLabel;
            System.Windows.Forms.Label comparisionLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label fieldNameLabel;
            System.Windows.Forms.Label dataTypeLabel;
            System.Windows.Forms.Label conjunctionLabel;
            System.Windows.Forms.Label incInHdLabel;
            System.Windows.Forms.Label parmIdLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportSetup));
            this.tspReportSetup = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.repIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RepNameAmharicTextBox = new System.Windows.Forms.TextBox();
            this.usrNameFldTextBox = new System.Windows.Forms.TextBox();
            this.reportHeadTextBox = new System.Windows.Forms.TextBox();
            this.sortByTextBox = new System.Windows.Forms.TextBox();
            this.criteriaTextBox = new System.Windows.Forms.TextBox();
            this.reportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.repNameTextBox = new System.Windows.Forms.TextBox();
            this.repIdTextBox = new System.Windows.Forms.TextBox();
            this.dataObjTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.isByUserCheckBox = new System.Windows.Forms.CheckBox();
            this.reportGroupLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dataObjNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tctReportSetup = new System.Windows.Forms.TabControl();
            this.tabParameter = new System.Windows.Forms.TabPage();
            this.lookUpEditPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.listFieldsTextBox = new System.Windows.Forms.TextBox();
            this.valueMemberTextBox = new System.Windows.Forms.TextBox();
            this.displayMemberTextBox = new System.Windows.Forms.TextBox();
            this.dataSourceTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.paramIdTextBox = new System.Windows.Forms.TextBox();
            this.fieldNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.controlTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.comparisionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dataTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.conjunctionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.incInHdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctRepParameter = new DevExpress.XtraGrid.GridControl();
            this.gridRepParameter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParamId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluFieldName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colComparision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluComparision = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colConjunction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluConjunction = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluDataType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIncInHd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluIncInHd = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colControlType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluControlType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDisplayMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListFields = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tspReportParameter = new System.Windows.Forms.ToolStrip();
            this.addParameterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeParameterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshParameterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabSubreport = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.criteriaTextBoxSubrep = new System.Windows.Forms.TextBox();
            this.subRepIdTextBox = new System.Windows.Forms.TextBox();
            this.dataObjTypeLookUpEditSubrep = new DevExpress.XtraEditors.LookUpEdit();
            this.dataObjNameLookUpEditSubrep = new DevExpress.XtraEditors.LookUpEdit();
            this.gctSubreport = new DevExpress.XtraGrid.GridControl();
            this.gridSubreport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRepId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubRepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataObjType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluDataObjType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDataObjName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluDataObjName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCriteria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSortBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tspSubReport = new System.Windows.Forms.ToolStrip();
            this.addSubrepToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeSubrepToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshSubrepToolStripButton = new System.Windows.Forms.ToolStripButton();
            repIdLabel1 = new System.Windows.Forms.Label();
            dataObjTypeLabel = new System.Windows.Forms.Label();
            usrNameFldLabel = new System.Windows.Forms.Label();
            repIdLabel = new System.Windows.Forms.Label();
            reportGroupLabel = new System.Windows.Forms.Label();
            repNameLabel = new System.Windows.Forms.Label();
            reportHeadLabel = new System.Windows.Forms.Label();
            reportFileNameLabel = new System.Windows.Forms.Label();
            sortByLabel = new System.Windows.Forms.Label();
            dataObjNameLabel = new System.Windows.Forms.Label();
            criteriaLabel = new System.Windows.Forms.Label();
            listFieldsLabel = new System.Windows.Forms.Label();
            dataSourceTypeLabel = new System.Windows.Forms.Label();
            dataSourceLabel = new System.Windows.Forms.Label();
            valueMemberLabel = new System.Windows.Forms.Label();
            displayMemberLabel = new System.Windows.Forms.Label();
            controlTypeLabel = new System.Windows.Forms.Label();
            comparisionLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            fieldNameLabel = new System.Windows.Forms.Label();
            dataTypeLabel = new System.Windows.Forms.Label();
            conjunctionLabel = new System.Windows.Forms.Label();
            incInHdLabel = new System.Windows.Forms.Label();
            parmIdLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tspReportSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repIdLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGroupLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjNameLookUpEdit.Properties)).BeginInit();
            this.tctReportSetup.SuspendLayout();
            this.tabParameter.SuspendLayout();
            this.lookUpEditPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceTypeLookUpEdit.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunctionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incInHdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctRepParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluComparision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluConjunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluIncInHd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluControlType)).BeginInit();
            this.tspReportParameter.SuspendLayout();
            this.tabSubreport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjTypeLookUpEditSubrep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjNameLookUpEditSubrep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSubreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataObjType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataObjName)).BeginInit();
            this.tspSubReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // repIdLabel1
            // 
            repIdLabel1.AutoSize = true;
            repIdLabel1.Location = new System.Drawing.Point(40, 69);
            repIdLabel1.Name = "repIdLabel1";
            repIdLabel1.Size = new System.Drawing.Size(87, 13);
            repIdLabel1.TabIndex = 33;
            repIdLabel1.Text = "Selected Report:";
            // 
            // dataObjTypeLabel
            // 
            dataObjTypeLabel.AutoSize = true;
            dataObjTypeLabel.Location = new System.Drawing.Point(21, 74);
            dataObjTypeLabel.Name = "dataObjTypeLabel";
            dataObjTypeLabel.Size = new System.Drawing.Size(94, 13);
            dataObjTypeLabel.TabIndex = 27;
            dataObjTypeLabel.Text = "Data Object Type:";
            // 
            // usrNameFldLabel
            // 
            usrNameFldLabel.AutoSize = true;
            usrNameFldLabel.Location = new System.Drawing.Point(307, 177);
            usrNameFldLabel.Name = "usrNameFldLabel";
            usrNameFldLabel.Size = new System.Drawing.Size(88, 13);
            usrNameFldLabel.TabIndex = 26;
            usrNameFldLabel.Text = "User Field Name:";
            usrNameFldLabel.Visible = false;
            // 
            // repIdLabel
            // 
            repIdLabel.AutoSize = true;
            repIdLabel.Location = new System.Drawing.Point(58, 21);
            repIdLabel.Name = "repIdLabel";
            repIdLabel.Size = new System.Drawing.Size(54, 13);
            repIdLabel.TabIndex = 6;
            repIdLabel.Text = "Report Id:";
            // 
            // reportGroupLabel
            // 
            reportGroupLabel.AutoSize = true;
            reportGroupLabel.Location = new System.Drawing.Point(41, 47);
            reportGroupLabel.Name = "reportGroupLabel";
            reportGroupLabel.Size = new System.Drawing.Size(74, 13);
            reportGroupLabel.TabIndex = 22;
            reportGroupLabel.Text = "Report Group:";
            // 
            // repNameLabel
            // 
            repNameLabel.AutoSize = true;
            repNameLabel.Location = new System.Drawing.Point(303, 21);
            repNameLabel.Name = "repNameLabel";
            repNameLabel.Size = new System.Drawing.Size(73, 13);
            repNameLabel.TabIndex = 8;
            repNameLabel.Text = "Report Name:";
            // 
            // reportHeadLabel
            // 
            reportHeadLabel.AutoSize = true;
            reportHeadLabel.Location = new System.Drawing.Point(70, 151);
            reportHeadLabel.Name = "reportHeadLabel";
            reportHeadLabel.Size = new System.Drawing.Size(45, 13);
            reportHeadLabel.TabIndex = 20;
            reportHeadLabel.Text = "Header:";
            // 
            // reportFileNameLabel
            // 
            reportFileNameLabel.AutoSize = true;
            reportFileNameLabel.Location = new System.Drawing.Point(319, 47);
            reportFileNameLabel.Name = "reportFileNameLabel";
            reportFileNameLabel.Size = new System.Drawing.Size(57, 13);
            reportFileNameLabel.TabIndex = 10;
            reportFileNameLabel.Text = "File Name:";
            // 
            // sortByLabel
            // 
            sortByLabel.AutoSize = true;
            sortByLabel.Location = new System.Drawing.Point(70, 125);
            sortByLabel.Name = "sortByLabel";
            sortByLabel.Size = new System.Drawing.Size(44, 13);
            sortByLabel.TabIndex = 18;
            sortByLabel.Text = "Sort By:";
            // 
            // dataObjNameLabel
            // 
            dataObjNameLabel.AutoSize = true;
            dataObjNameLabel.Location = new System.Drawing.Point(278, 74);
            dataObjNameLabel.Name = "dataObjNameLabel";
            dataObjNameLabel.Size = new System.Drawing.Size(98, 13);
            dataObjNameLabel.TabIndex = 12;
            dataObjNameLabel.Text = "Data Object Name:";
            // 
            // criteriaLabel
            // 
            criteriaLabel.AutoSize = true;
            criteriaLabel.Location = new System.Drawing.Point(73, 99);
            criteriaLabel.Name = "criteriaLabel";
            criteriaLabel.Size = new System.Drawing.Size(42, 13);
            criteriaLabel.TabIndex = 16;
            criteriaLabel.Text = "Criteria:";
            // 
            // listFieldsLabel
            // 
            listFieldsLabel.AutoSize = true;
            listFieldsLabel.Location = new System.Drawing.Point(359, 20);
            listFieldsLabel.Name = "listFieldsLabel";
            listFieldsLabel.Size = new System.Drawing.Size(56, 13);
            listFieldsLabel.TabIndex = 8;
            listFieldsLabel.Text = "List Fields:";
            // 
            // dataSourceTypeLabel
            // 
            dataSourceTypeLabel.AutoSize = true;
            dataSourceTypeLabel.Location = new System.Drawing.Point(253, 20);
            dataSourceTypeLabel.Name = "dataSourceTypeLabel";
            dataSourceTypeLabel.Size = new System.Drawing.Size(97, 13);
            dataSourceTypeLabel.TabIndex = 6;
            dataSourceTypeLabel.Text = "Data Source Type:";
            // 
            // dataSourceLabel
            // 
            dataSourceLabel.AutoSize = true;
            dataSourceLabel.Location = new System.Drawing.Point(6, 64);
            dataSourceLabel.Name = "dataSourceLabel";
            dataSourceLabel.Size = new System.Drawing.Size(70, 13);
            dataSourceLabel.TabIndex = 4;
            dataSourceLabel.Text = "Data Source:";
            // 
            // valueMemberLabel
            // 
            valueMemberLabel.AutoSize = true;
            valueMemberLabel.Location = new System.Drawing.Point(147, 20);
            valueMemberLabel.Name = "valueMemberLabel";
            valueMemberLabel.Size = new System.Drawing.Size(78, 13);
            valueMemberLabel.TabIndex = 2;
            valueMemberLabel.Text = "Value Member:";
            // 
            // displayMemberLabel
            // 
            displayMemberLabel.AutoSize = true;
            displayMemberLabel.Location = new System.Drawing.Point(3, 20);
            displayMemberLabel.Name = "displayMemberLabel";
            displayMemberLabel.Size = new System.Drawing.Size(85, 13);
            displayMemberLabel.TabIndex = 0;
            displayMemberLabel.Text = "Display Member:";
            // 
            // controlTypeLabel
            // 
            controlTypeLabel.AutoSize = true;
            controlTypeLabel.Location = new System.Drawing.Point(528, 50);
            controlTypeLabel.Name = "controlTypeLabel";
            controlTypeLabel.Size = new System.Drawing.Size(70, 13);
            controlTypeLabel.TabIndex = 17;
            controlTypeLabel.Text = "Control Type:";
            // 
            // comparisionLabel
            // 
            comparisionLabel.AutoSize = true;
            comparisionLabel.Location = new System.Drawing.Point(363, 49);
            comparisionLabel.Name = "comparisionLabel";
            comparisionLabel.Size = new System.Drawing.Size(67, 13);
            comparisionLabel.TabIndex = 17;
            comparisionLabel.Text = "Comparision:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(58, 49);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // fieldNameLabel
            // 
            fieldNameLabel.AutoSize = true;
            fieldNameLabel.Location = new System.Drawing.Point(213, 50);
            fieldNameLabel.Name = "fieldNameLabel";
            fieldNameLabel.Size = new System.Drawing.Size(63, 13);
            fieldNameLabel.TabIndex = 9;
            fieldNameLabel.Text = "Field Name:";
            // 
            // dataTypeLabel
            // 
            dataTypeLabel.AutoSize = true;
            dataTypeLabel.Location = new System.Drawing.Point(433, 50);
            dataTypeLabel.Name = "dataTypeLabel";
            dataTypeLabel.Size = new System.Drawing.Size(60, 13);
            dataTypeLabel.TabIndex = 11;
            dataTypeLabel.Text = "Data Type:";
            // 
            // conjunctionLabel
            // 
            conjunctionLabel.AutoSize = true;
            conjunctionLabel.Location = new System.Drawing.Point(680, 49);
            conjunctionLabel.Name = "conjunctionLabel";
            conjunctionLabel.Size = new System.Drawing.Size(66, 13);
            conjunctionLabel.TabIndex = 13;
            conjunctionLabel.Text = "Conjunction:";
            // 
            // incInHdLabel
            // 
            incInHdLabel.AutoSize = true;
            incInHdLabel.Location = new System.Drawing.Point(749, 49);
            incInHdLabel.Name = "incInHdLabel";
            incInHdLabel.Size = new System.Drawing.Size(68, 13);
            incInHdLabel.TabIndex = 15;
            incInHdLabel.Text = "Inc. in Head:";
            // 
            // parmIdLabel
            // 
            parmIdLabel.AutoSize = true;
            parmIdLabel.Location = new System.Drawing.Point(3, 49);
            parmIdLabel.Name = "parmIdLabel";
            parmIdLabel.Size = new System.Drawing.Size(52, 13);
            parmIdLabel.TabIndex = 6;
            parmIdLabel.Text = "Seq. No.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(484, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 29;
            label4.Text = "Criteria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 13);
            label3.TabIndex = 31;
            label3.Text = "Subreport Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(124, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 29;
            label2.Text = "Data Object Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(221, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 13);
            label1.TabIndex = 14;
            label1.Text = "Data Object Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(699, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 13);
            label5.TabIndex = 166;
            label5.Text = "y¶±Rt$ SMÝ";
            // 
            // tspReportSetup
            // 
            this.tspReportSetup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspReportSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.copyToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspReportSetup.Location = new System.Drawing.Point(0, 0);
            this.tspReportSetup.Name = "tspReportSetup";
            this.tspReportSetup.Size = new System.Drawing.Size(1120, 25);
            this.tspReportSetup.TabIndex = 5;
            this.tspReportSetup.TabStop = true;
            this.tspReportSetup.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
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
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
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
            // repIdLookUpEdit
            // 
            this.repIdLookUpEdit.Location = new System.Drawing.Point(133, 66);
            this.repIdLookUpEdit.Name = "repIdLookUpEdit";
            this.repIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepId", "Report Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReportGroup", "Group", 10)});
            this.repIdLookUpEdit.Properties.DisplayMember = "RepName";
            this.repIdLookUpEdit.Properties.NullText = "";
            this.repIdLookUpEdit.Properties.ValueMember = "RepId";
            this.repIdLookUpEdit.Size = new System.Drawing.Size(390, 20);
            this.repIdLookUpEdit.TabIndex = 32;
            this.repIdLookUpEdit.EditValueChanged += new System.EventHandler(this.repIdLookUpEdit_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RepNameAmharicTextBox);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.usrNameFldTextBox);
            this.groupBox1.Controls.Add(this.reportHeadTextBox);
            this.groupBox1.Controls.Add(this.sortByTextBox);
            this.groupBox1.Controls.Add(this.criteriaTextBox);
            this.groupBox1.Controls.Add(this.reportFileNameTextBox);
            this.groupBox1.Controls.Add(this.repNameTextBox);
            this.groupBox1.Controls.Add(this.repIdTextBox);
            this.groupBox1.Controls.Add(dataObjTypeLabel);
            this.groupBox1.Controls.Add(this.dataObjTypeLookUpEdit);
            this.groupBox1.Controls.Add(usrNameFldLabel);
            this.groupBox1.Controls.Add(this.isByUserCheckBox);
            this.groupBox1.Controls.Add(this.reportGroupLookUpEdit);
            this.groupBox1.Controls.Add(repIdLabel);
            this.groupBox1.Controls.Add(reportGroupLabel);
            this.groupBox1.Controls.Add(repNameLabel);
            this.groupBox1.Controls.Add(reportHeadLabel);
            this.groupBox1.Controls.Add(reportFileNameLabel);
            this.groupBox1.Controls.Add(sortByLabel);
            this.groupBox1.Controls.Add(dataObjNameLabel);
            this.groupBox1.Controls.Add(criteriaLabel);
            this.groupBox1.Controls.Add(this.dataObjNameLookUpEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 208);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Detail";
            // 
            // RepNameAmharicTextBox
            // 
            this.RepNameAmharicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepNameAmharicTextBox.Font = new System.Drawing.Font("VG2 Main", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepNameAmharicTextBox.Location = new System.Drawing.Point(778, 19);
            this.RepNameAmharicTextBox.Name = "RepNameAmharicTextBox";
            this.RepNameAmharicTextBox.Size = new System.Drawing.Size(311, 20);
            this.RepNameAmharicTextBox.TabIndex = 167;
            // 
            // usrNameFldTextBox
            // 
            this.usrNameFldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrNameFldTextBox.Location = new System.Drawing.Point(401, 177);
            this.usrNameFldTextBox.Name = "usrNameFldTextBox";
            this.usrNameFldTextBox.Size = new System.Drawing.Size(292, 20);
            this.usrNameFldTextBox.TabIndex = 165;
            this.usrNameFldTextBox.Visible = false;
            // 
            // reportHeadTextBox
            // 
            this.reportHeadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportHeadTextBox.Location = new System.Drawing.Point(121, 151);
            this.reportHeadTextBox.Name = "reportHeadTextBox";
            this.reportHeadTextBox.Size = new System.Drawing.Size(572, 20);
            this.reportHeadTextBox.TabIndex = 164;
            // 
            // sortByTextBox
            // 
            this.sortByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortByTextBox.Location = new System.Drawing.Point(121, 125);
            this.sortByTextBox.Name = "sortByTextBox";
            this.sortByTextBox.Size = new System.Drawing.Size(572, 20);
            this.sortByTextBox.TabIndex = 163;
            // 
            // criteriaTextBox
            // 
            this.criteriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criteriaTextBox.Location = new System.Drawing.Point(121, 99);
            this.criteriaTextBox.Name = "criteriaTextBox";
            this.criteriaTextBox.Size = new System.Drawing.Size(572, 20);
            this.criteriaTextBox.TabIndex = 162;
            // 
            // reportFileNameTextBox
            // 
            this.reportFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportFileNameTextBox.Location = new System.Drawing.Point(382, 46);
            this.reportFileNameTextBox.Name = "reportFileNameTextBox";
            this.reportFileNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.reportFileNameTextBox.TabIndex = 161;
            // 
            // repNameTextBox
            // 
            this.repNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repNameTextBox.Location = new System.Drawing.Point(382, 19);
            this.repNameTextBox.Name = "repNameTextBox";
            this.repNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.repNameTextBox.TabIndex = 160;
            // 
            // repIdTextBox
            // 
            this.repIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repIdTextBox.Location = new System.Drawing.Point(121, 21);
            this.repIdTextBox.Name = "repIdTextBox";
            this.repIdTextBox.ReadOnly = true;
            this.repIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.repIdTextBox.TabIndex = 159;
            // 
            // dataObjTypeLookUpEdit
            // 
            this.dataObjTypeLookUpEdit.Location = new System.Drawing.Point(121, 71);
            this.dataObjTypeLookUpEdit.Name = "dataObjTypeLookUpEdit";
            this.dataObjTypeLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataObjTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataObjTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataObjTypeLookUpEdit.Properties.DisplayMember = "TypeName";
            this.dataObjTypeLookUpEdit.Properties.DropDownRows = 3;
            this.dataObjTypeLookUpEdit.Properties.NullText = "";
            this.dataObjTypeLookUpEdit.Properties.ShowFooter = false;
            this.dataObjTypeLookUpEdit.Properties.ShowHeader = false;
            this.dataObjTypeLookUpEdit.Properties.ValueMember = "TypeId";
            this.dataObjTypeLookUpEdit.Size = new System.Drawing.Size(134, 20);
            this.dataObjTypeLookUpEdit.TabIndex = 4;
            this.dataObjTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.dataObjTypeLookUpEdit_EditValueChanged);
            // 
            // isByUserCheckBox
            // 
            this.isByUserCheckBox.Location = new System.Drawing.Point(121, 175);
            this.isByUserCheckBox.Name = "isByUserCheckBox";
            this.isByUserCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isByUserCheckBox.TabIndex = 9;
            this.isByUserCheckBox.Text = "Is By User";
            this.isByUserCheckBox.UseVisualStyleBackColor = true;
            this.isByUserCheckBox.Visible = false;
            // 
            // reportGroupLookUpEdit
            // 
            this.reportGroupLookUpEdit.Location = new System.Drawing.Point(121, 45);
            this.reportGroupLookUpEdit.Name = "reportGroupLookUpEdit";
            this.reportGroupLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.reportGroupLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reportGroupLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepGroupName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.reportGroupLookUpEdit.Properties.DisplayMember = "RepGroupName";
            this.reportGroupLookUpEdit.Properties.NullText = "";
            this.reportGroupLookUpEdit.Properties.ShowFooter = false;
            this.reportGroupLookUpEdit.Properties.ShowHeader = false;
            this.reportGroupLookUpEdit.Properties.ValueMember = "RepGroupId";
            this.reportGroupLookUpEdit.Size = new System.Drawing.Size(134, 20);
            this.reportGroupLookUpEdit.TabIndex = 2;
            // 
            // dataObjNameLookUpEdit
            // 
            this.dataObjNameLookUpEdit.Location = new System.Drawing.Point(382, 71);
            this.dataObjNameLookUpEdit.Name = "dataObjNameLookUpEdit";
            this.dataObjNameLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataObjNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataObjNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataObjName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataObjNameLookUpEdit.Properties.DisplayMember = "DataObjName";
            this.dataObjNameLookUpEdit.Properties.DropDownRows = 10;
            this.dataObjNameLookUpEdit.Properties.NullText = "";
            this.dataObjNameLookUpEdit.Properties.ShowFooter = false;
            this.dataObjNameLookUpEdit.Properties.ShowHeader = false;
            this.dataObjNameLookUpEdit.Properties.ValueMember = "DataObjName";
            this.dataObjNameLookUpEdit.Size = new System.Drawing.Size(311, 20);
            this.dataObjNameLookUpEdit.TabIndex = 5;
            this.dataObjNameLookUpEdit.EditValueChanged += new System.EventHandler(this.dataObjNameLookUpEdit_EditValueChanged);
            // 
            // tctReportSetup
            // 
            this.tctReportSetup.Controls.Add(this.tabParameter);
            this.tctReportSetup.Controls.Add(this.tabSubreport);
            this.tctReportSetup.Location = new System.Drawing.Point(12, 322);
            this.tctReportSetup.Name = "tctReportSetup";
            this.tctReportSetup.SelectedIndex = 0;
            this.tctReportSetup.Size = new System.Drawing.Size(851, 342);
            this.tctReportSetup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctReportSetup.TabIndex = 36;
            // 
            // tabParameter
            // 
            this.tabParameter.Controls.Add(this.lookUpEditPropertiesGroupBox);
            this.tabParameter.Controls.Add(this.groupBox5);
            this.tabParameter.Location = new System.Drawing.Point(4, 22);
            this.tabParameter.Name = "tabParameter";
            this.tabParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tabParameter.Size = new System.Drawing.Size(843, 316);
            this.tabParameter.TabIndex = 0;
            this.tabParameter.Text = "Parameters";
            this.tabParameter.UseVisualStyleBackColor = true;
            // 
            // lookUpEditPropertiesGroupBox
            // 
            this.lookUpEditPropertiesGroupBox.Controls.Add(this.dataSourceTextBox);
            this.lookUpEditPropertiesGroupBox.Controls.Add(this.listFieldsTextBox);
            this.lookUpEditPropertiesGroupBox.Controls.Add(this.valueMemberTextBox);
            this.lookUpEditPropertiesGroupBox.Controls.Add(this.displayMemberTextBox);
            this.lookUpEditPropertiesGroupBox.Controls.Add(listFieldsLabel);
            this.lookUpEditPropertiesGroupBox.Controls.Add(dataSourceTypeLabel);
            this.lookUpEditPropertiesGroupBox.Controls.Add(this.dataSourceTypeLookUpEdit);
            this.lookUpEditPropertiesGroupBox.Controls.Add(dataSourceLabel);
            this.lookUpEditPropertiesGroupBox.Controls.Add(valueMemberLabel);
            this.lookUpEditPropertiesGroupBox.Controls.Add(displayMemberLabel);
            this.lookUpEditPropertiesGroupBox.Location = new System.Drawing.Point(6, 214);
            this.lookUpEditPropertiesGroupBox.Name = "lookUpEditPropertiesGroupBox";
            this.lookUpEditPropertiesGroupBox.Size = new System.Drawing.Size(824, 92);
            this.lookUpEditPropertiesGroupBox.TabIndex = 1;
            this.lookUpEditPropertiesGroupBox.TabStop = false;
            this.lookUpEditPropertiesGroupBox.Text = "LookUpEdit Properties";
            this.lookUpEditPropertiesGroupBox.Visible = false;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataSourceTextBox.Location = new System.Drawing.Point(78, 62);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(739, 20);
            this.dataSourceTextBox.TabIndex = 162;
            // 
            // listFieldsTextBox
            // 
            this.listFieldsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFieldsTextBox.Location = new System.Drawing.Point(362, 36);
            this.listFieldsTextBox.Name = "listFieldsTextBox";
            this.listFieldsTextBox.Size = new System.Drawing.Size(455, 20);
            this.listFieldsTextBox.TabIndex = 161;
            // 
            // valueMemberTextBox
            // 
            this.valueMemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueMemberTextBox.Location = new System.Drawing.Point(150, 36);
            this.valueMemberTextBox.Name = "valueMemberTextBox";
            this.valueMemberTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueMemberTextBox.TabIndex = 160;
            // 
            // displayMemberTextBox
            // 
            this.displayMemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayMemberTextBox.Location = new System.Drawing.Point(3, 36);
            this.displayMemberTextBox.Name = "displayMemberTextBox";
            this.displayMemberTextBox.Size = new System.Drawing.Size(141, 20);
            this.displayMemberTextBox.TabIndex = 159;
            // 
            // dataSourceTypeLookUpEdit
            // 
            this.dataSourceTypeLookUpEdit.Location = new System.Drawing.Point(256, 36);
            this.dataSourceTypeLookUpEdit.Name = "dataSourceTypeLookUpEdit";
            this.dataSourceTypeLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataSourceTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataSourceTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataSourceTypeName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataSourceTypeLookUpEdit.Properties.DisplayMember = "DataSourceTypeName";
            this.dataSourceTypeLookUpEdit.Properties.DropDownRows = 3;
            this.dataSourceTypeLookUpEdit.Properties.NullText = "";
            this.dataSourceTypeLookUpEdit.Properties.ShowFooter = false;
            this.dataSourceTypeLookUpEdit.Properties.ShowHeader = false;
            this.dataSourceTypeLookUpEdit.Properties.ValueMember = "DataSourceTypeName";
            this.dataSourceTypeLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.dataSourceTypeLookUpEdit.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.descriptionTextBox);
            this.groupBox5.Controls.Add(this.paramIdTextBox);
            this.groupBox5.Controls.Add(this.fieldNameLookUpEdit);
            this.groupBox5.Controls.Add(controlTypeLabel);
            this.groupBox5.Controls.Add(this.controlTypeLookUpEdit);
            this.groupBox5.Controls.Add(comparisionLabel);
            this.groupBox5.Controls.Add(this.comparisionLookUpEdit);
            this.groupBox5.Controls.Add(descriptionLabel);
            this.groupBox5.Controls.Add(fieldNameLabel);
            this.groupBox5.Controls.Add(dataTypeLabel);
            this.groupBox5.Controls.Add(this.dataTypeLookUpEdit);
            this.groupBox5.Controls.Add(conjunctionLabel);
            this.groupBox5.Controls.Add(this.conjunctionLookUpEdit);
            this.groupBox5.Controls.Add(incInHdLabel);
            this.groupBox5.Controls.Add(this.incInHdLookUpEdit);
            this.groupBox5.Controls.Add(parmIdLabel);
            this.groupBox5.Controls.Add(this.gctRepParameter);
            this.groupBox5.Controls.Add(this.tspReportParameter);
            this.groupBox5.Location = new System.Drawing.Point(6, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(824, 205);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(61, 66);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(150, 20);
            this.descriptionTextBox.TabIndex = 160;
            // 
            // paramIdTextBox
            // 
            this.paramIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paramIdTextBox.Location = new System.Drawing.Point(6, 66);
            this.paramIdTextBox.Name = "paramIdTextBox";
            this.paramIdTextBox.Size = new System.Drawing.Size(49, 20);
            this.paramIdTextBox.TabIndex = 159;
            // 
            // fieldNameLookUpEdit
            // 
            this.fieldNameLookUpEdit.Location = new System.Drawing.Point(216, 66);
            this.fieldNameLookUpEdit.Name = "fieldNameLookUpEdit";
            this.fieldNameLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fieldNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fieldNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColumnName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.fieldNameLookUpEdit.Properties.DisplayMember = "ColumnName";
            this.fieldNameLookUpEdit.Properties.NullText = "";
            this.fieldNameLookUpEdit.Properties.ShowFooter = false;
            this.fieldNameLookUpEdit.Properties.ShowHeader = false;
            this.fieldNameLookUpEdit.Properties.ValueMember = "ColumnName";
            this.fieldNameLookUpEdit.Size = new System.Drawing.Size(144, 20);
            this.fieldNameLookUpEdit.TabIndex = 2;
            this.fieldNameLookUpEdit.EditValueChanged += new System.EventHandler(this.fieldNameLookUpEdit_EditValueChanged);
            // 
            // controlTypeLookUpEdit
            // 
            this.controlTypeLookUpEdit.Location = new System.Drawing.Point(531, 66);
            this.controlTypeLookUpEdit.Name = "controlTypeLookUpEdit";
            this.controlTypeLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.controlTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ControlTypeName", "Control Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.controlTypeLookUpEdit.Properties.DisplayMember = "ControlTypeName";
            this.controlTypeLookUpEdit.Properties.DropDownRows = 4;
            this.controlTypeLookUpEdit.Properties.NullText = "";
            this.controlTypeLookUpEdit.Properties.ShowFooter = false;
            this.controlTypeLookUpEdit.Properties.ShowHeader = false;
            this.controlTypeLookUpEdit.Properties.ValueMember = "ControlTypeFullName";
            this.controlTypeLookUpEdit.Size = new System.Drawing.Size(146, 20);
            this.controlTypeLookUpEdit.TabIndex = 4;
            this.controlTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.controlTypeLookUpEdit_EditValueChanged);
            // 
            // comparisionLookUpEdit
            // 
            this.comparisionLookUpEdit.Location = new System.Drawing.Point(366, 66);
            this.comparisionLookUpEdit.Name = "comparisionLookUpEdit";
            this.comparisionLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.comparisionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comparisionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComparisionName", "Comparision", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.comparisionLookUpEdit.Properties.DisplayMember = "ComparisionName";
            this.comparisionLookUpEdit.Properties.NullText = "";
            this.comparisionLookUpEdit.Properties.ShowFooter = false;
            this.comparisionLookUpEdit.Properties.ShowHeader = false;
            this.comparisionLookUpEdit.Properties.ValueMember = "ComparisionName";
            this.comparisionLookUpEdit.Size = new System.Drawing.Size(64, 20);
            this.comparisionLookUpEdit.TabIndex = 3;
            // 
            // dataTypeLookUpEdit
            // 
            this.dataTypeLookUpEdit.Location = new System.Drawing.Point(436, 66);
            this.dataTypeLookUpEdit.Name = "dataTypeLookUpEdit";
            this.dataTypeLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataTypeName", "Data Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataTypeLookUpEdit.Properties.DisplayMember = "DataTypeName";
            this.dataTypeLookUpEdit.Properties.NullText = "";
            this.dataTypeLookUpEdit.Properties.ReadOnly = true;
            this.dataTypeLookUpEdit.Properties.ShowFooter = false;
            this.dataTypeLookUpEdit.Properties.ShowHeader = false;
            this.dataTypeLookUpEdit.Properties.ValueMember = "DataTypeName";
            this.dataTypeLookUpEdit.Size = new System.Drawing.Size(89, 20);
            this.dataTypeLookUpEdit.TabIndex = 3;
            // 
            // conjunctionLookUpEdit
            // 
            this.conjunctionLookUpEdit.Location = new System.Drawing.Point(683, 66);
            this.conjunctionLookUpEdit.Name = "conjunctionLookUpEdit";
            this.conjunctionLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.conjunctionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.conjunctionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConjunctionName", "Conjunction", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.conjunctionLookUpEdit.Properties.DisplayMember = "ConjunctionName";
            this.conjunctionLookUpEdit.Properties.DropDownRows = 2;
            this.conjunctionLookUpEdit.Properties.NullText = "";
            this.conjunctionLookUpEdit.Properties.ShowFooter = false;
            this.conjunctionLookUpEdit.Properties.ShowHeader = false;
            this.conjunctionLookUpEdit.Properties.ValueMember = "ConjunctionName";
            this.conjunctionLookUpEdit.Size = new System.Drawing.Size(63, 20);
            this.conjunctionLookUpEdit.TabIndex = 5;
            // 
            // incInHdLookUpEdit
            // 
            this.incInHdLookUpEdit.Location = new System.Drawing.Point(752, 66);
            this.incInHdLookUpEdit.Name = "incInHdLookUpEdit";
            this.incInHdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.incInHdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.incInHdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IncInHdName", "Inc", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.incInHdLookUpEdit.Properties.DisplayMember = "IncInHdName";
            this.incInHdLookUpEdit.Properties.DropDownRows = 2;
            this.incInHdLookUpEdit.Properties.NullText = "";
            this.incInHdLookUpEdit.Properties.ShowFooter = false;
            this.incInHdLookUpEdit.Properties.ShowHeader = false;
            this.incInHdLookUpEdit.Properties.ValueMember = "IncInHdId";
            this.incInHdLookUpEdit.Size = new System.Drawing.Size(65, 20);
            this.incInHdLookUpEdit.TabIndex = 6;
            // 
            // gctRepParameter
            // 
            this.gctRepParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctRepParameter.EmbeddedNavigator.Name = "";
            this.gctRepParameter.Location = new System.Drawing.Point(6, 92);
            this.gctRepParameter.MainView = this.gridRepParameter;
            this.gctRepParameter.Name = "gctRepParameter";
            this.gctRepParameter.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluDataType,
            this.rluConjunction,
            this.rluIncInHd,
            this.rluComparision,
            this.rluControlType,
            this.rluFieldName});
            this.gctRepParameter.Size = new System.Drawing.Size(812, 107);
            this.gctRepParameter.TabIndex = 8;
            this.gctRepParameter.TabStop = false;
            this.gctRepParameter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRepParameter});
            this.gctRepParameter.DoubleClick += new System.EventHandler(this.gridRepParameter_DoubleClick);
            // 
            // gridRepParameter
            // 
            this.gridRepParameter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepId,
            this.colParamId,
            this.colDescription,
            this.colFieldName,
            this.colComparision,
            this.colConjunction,
            this.colDataType,
            this.colIncInHd,
            this.colControlType,
            this.colDisplayMember,
            this.colValueMember,
            this.colDataSource,
            this.colDataSourceType,
            this.colListFields});
            this.gridRepParameter.GridControl = this.gctRepParameter;
            this.gridRepParameter.Name = "gridRepParameter";
            this.gridRepParameter.OptionsBehavior.Editable = false;
            this.gridRepParameter.OptionsCustomization.AllowColumnMoving = false;
            this.gridRepParameter.OptionsCustomization.AllowColumnResizing = false;
            this.gridRepParameter.OptionsCustomization.AllowFilter = false;
            this.gridRepParameter.OptionsCustomization.AllowGroup = false;
            this.gridRepParameter.OptionsCustomization.AllowSort = false;
            this.gridRepParameter.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridRepParameter.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridRepParameter.OptionsView.ColumnAutoWidth = false;
            this.gridRepParameter.OptionsView.ShowColumnHeaders = false;
            this.gridRepParameter.OptionsView.ShowGroupPanel = false;
            this.gridRepParameter.OptionsView.ShowIndicator = false;
            // 
            // colRepId
            // 
            this.colRepId.Caption = "RepId";
            this.colRepId.FieldName = "RepId";
            this.colRepId.Name = "colRepId";
            // 
            // colParamId
            // 
            this.colParamId.AppearanceCell.Options.UseTextOptions = true;
            this.colParamId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colParamId.Caption = "ParamId";
            this.colParamId.FieldName = "ParamId";
            this.colParamId.Name = "colParamId";
            this.colParamId.Visible = true;
            this.colParamId.VisibleIndex = 0;
            this.colParamId.Width = 50;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 156;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "FieldName";
            this.colFieldName.ColumnEdit = this.rluFieldName;
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 2;
            this.colFieldName.Width = 151;
            // 
            // rluFieldName
            // 
            this.rluFieldName.AutoHeight = false;
            this.rluFieldName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluFieldName.DisplayMember = "ColumnName";
            this.rluFieldName.Name = "rluFieldName";
            this.rluFieldName.NullText = "";
            this.rluFieldName.ValueMember = "ColumnName";
            // 
            // colComparision
            // 
            this.colComparision.Caption = "Comparision";
            this.colComparision.ColumnEdit = this.rluComparision;
            this.colComparision.FieldName = "Comparision";
            this.colComparision.Name = "colComparision";
            this.colComparision.Visible = true;
            this.colComparision.VisibleIndex = 3;
            this.colComparision.Width = 70;
            // 
            // rluComparision
            // 
            this.rluComparision.AutoHeight = false;
            this.rluComparision.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluComparision.DisplayMember = "ComparisionName";
            this.rluComparision.Name = "rluComparision";
            this.rluComparision.NullText = "";
            this.rluComparision.ValueMember = "ComparisionName";
            // 
            // colConjunction
            // 
            this.colConjunction.Caption = "Conjunction";
            this.colConjunction.ColumnEdit = this.rluConjunction;
            this.colConjunction.FieldName = "Conjunction";
            this.colConjunction.Name = "colConjunction";
            this.colConjunction.Visible = true;
            this.colConjunction.VisibleIndex = 6;
            this.colConjunction.Width = 69;
            // 
            // rluConjunction
            // 
            this.rluConjunction.AutoHeight = false;
            this.rluConjunction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluConjunction.DisplayMember = "ConjunctionName";
            this.rluConjunction.Name = "rluConjunction";
            this.rluConjunction.NullText = "";
            this.rluConjunction.ValueMember = "ConjunctionName";
            // 
            // colDataType
            // 
            this.colDataType.Caption = "DataType";
            this.colDataType.ColumnEdit = this.rluDataType;
            this.colDataType.FieldName = "DataType";
            this.colDataType.Name = "colDataType";
            this.colDataType.Visible = true;
            this.colDataType.VisibleIndex = 4;
            this.colDataType.Width = 95;
            // 
            // rluDataType
            // 
            this.rluDataType.AutoHeight = false;
            this.rluDataType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluDataType.DisplayMember = "DataTypeName";
            this.rluDataType.Name = "rluDataType";
            this.rluDataType.NullText = "";
            this.rluDataType.ValueMember = "DataTypeName";
            // 
            // colIncInHd
            // 
            this.colIncInHd.Caption = "IncInHd";
            this.colIncInHd.ColumnEdit = this.rluIncInHd;
            this.colIncInHd.FieldName = "IncInHd";
            this.colIncInHd.Name = "colIncInHd";
            this.colIncInHd.Visible = true;
            this.colIncInHd.VisibleIndex = 7;
            this.colIncInHd.Width = 60;
            // 
            // rluIncInHd
            // 
            this.rluIncInHd.AutoHeight = false;
            this.rluIncInHd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluIncInHd.DisplayMember = "IncInHdName";
            this.rluIncInHd.Name = "rluIncInHd";
            this.rluIncInHd.NullText = "";
            this.rluIncInHd.ValueMember = "IncInHdId";
            // 
            // colControlType
            // 
            this.colControlType.Caption = "ControlType";
            this.colControlType.ColumnEdit = this.rluControlType;
            this.colControlType.FieldName = "ControlType";
            this.colControlType.Name = "colControlType";
            this.colControlType.Visible = true;
            this.colControlType.VisibleIndex = 5;
            this.colControlType.Width = 154;
            // 
            // rluControlType
            // 
            this.rluControlType.AutoHeight = false;
            this.rluControlType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluControlType.DisplayMember = "ControlTypeName";
            this.rluControlType.Name = "rluControlType";
            this.rluControlType.NullText = "";
            this.rluControlType.ValueMember = "ControlTypeFullName";
            // 
            // colDisplayMember
            // 
            this.colDisplayMember.Caption = "DisplayMember";
            this.colDisplayMember.FieldName = "DisplayMember";
            this.colDisplayMember.Name = "colDisplayMember";
            // 
            // colValueMember
            // 
            this.colValueMember.Caption = "ValueMember";
            this.colValueMember.FieldName = "ValueMember";
            this.colValueMember.Name = "colValueMember";
            // 
            // colDataSource
            // 
            this.colDataSource.Caption = "DataSource";
            this.colDataSource.FieldName = "DataSource";
            this.colDataSource.Name = "colDataSource";
            // 
            // colDataSourceType
            // 
            this.colDataSourceType.Caption = "DataSourceType";
            this.colDataSourceType.FieldName = "DataSourceType";
            this.colDataSourceType.Name = "colDataSourceType";
            // 
            // colListFields
            // 
            this.colListFields.Caption = "ListFields";
            this.colListFields.FieldName = "ListFields";
            this.colListFields.Name = "colListFields";
            // 
            // tspReportParameter
            // 
            this.tspReportParameter.BackColor = System.Drawing.Color.White;
            this.tspReportParameter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParameterToolStripButton,
            this.removeParameterToolStripButton,
            this.refreshParameterToolStripButton});
            this.tspReportParameter.Location = new System.Drawing.Point(3, 16);
            this.tspReportParameter.Name = "tspReportParameter";
            this.tspReportParameter.Size = new System.Drawing.Size(818, 25);
            this.tspReportParameter.TabIndex = 8;
            this.tspReportParameter.TabStop = true;
            this.tspReportParameter.Text = "toolStrip1";
            // 
            // addParameterToolStripButton
            // 
            this.addParameterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addParameterToolStripButton.Image")));
            this.addParameterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addParameterToolStripButton.Name = "addParameterToolStripButton";
            this.addParameterToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addParameterToolStripButton.Text = "Add";
            this.addParameterToolStripButton.Click += new System.EventHandler(this.addParamToolStripButton_Click);
            // 
            // removeParameterToolStripButton
            // 
            this.removeParameterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeParameterToolStripButton.Image")));
            this.removeParameterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeParameterToolStripButton.Name = "removeParameterToolStripButton";
            this.removeParameterToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.removeParameterToolStripButton.Text = "Remove";
            this.removeParameterToolStripButton.Click += new System.EventHandler(this.removeParamToolStripButton_Click);
            // 
            // refreshParameterToolStripButton
            // 
            this.refreshParameterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshParameterToolStripButton.Image")));
            this.refreshParameterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshParameterToolStripButton.Name = "refreshParameterToolStripButton";
            this.refreshParameterToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshParameterToolStripButton.Text = "&Refresh";
            this.refreshParameterToolStripButton.Click += new System.EventHandler(this.refreshParamToolStripButton_Click);
            // 
            // tabSubreport
            // 
            this.tabSubreport.Controls.Add(this.groupBox2);
            this.tabSubreport.Location = new System.Drawing.Point(4, 22);
            this.tabSubreport.Name = "tabSubreport";
            this.tabSubreport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubreport.Size = new System.Drawing.Size(843, 316);
            this.tabSubreport.TabIndex = 1;
            this.tabSubreport.Text = "Subreports";
            this.tabSubreport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.criteriaTextBoxSubrep);
            this.groupBox2.Controls.Add(this.subRepIdTextBox);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.dataObjTypeLookUpEditSubrep);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.dataObjNameLookUpEditSubrep);
            this.groupBox2.Controls.Add(this.gctSubreport);
            this.groupBox2.Controls.Add(this.tspSubReport);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 307);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // criteriaTextBoxSubrep
            // 
            this.criteriaTextBoxSubrep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criteriaTextBoxSubrep.Location = new System.Drawing.Point(487, 69);
            this.criteriaTextBoxSubrep.Name = "criteriaTextBoxSubrep";
            this.criteriaTextBoxSubrep.Size = new System.Drawing.Size(331, 20);
            this.criteriaTextBoxSubrep.TabIndex = 160;
            // 
            // subRepIdTextBox
            // 
            this.subRepIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subRepIdTextBox.Location = new System.Drawing.Point(6, 69);
            this.subRepIdTextBox.Name = "subRepIdTextBox";
            this.subRepIdTextBox.Size = new System.Drawing.Size(115, 20);
            this.subRepIdTextBox.TabIndex = 159;
            this.subRepIdTextBox.Validated += new System.EventHandler(this.subRepIdTextBox_Validated);
            // 
            // dataObjTypeLookUpEditSubrep
            // 
            this.dataObjTypeLookUpEditSubrep.Location = new System.Drawing.Point(124, 69);
            this.dataObjTypeLookUpEditSubrep.Name = "dataObjTypeLookUpEditSubrep";
            this.dataObjTypeLookUpEditSubrep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataObjTypeLookUpEditSubrep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataObjTypeLookUpEditSubrep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataObjTypeLookUpEditSubrep.Properties.DisplayMember = "TypeName";
            this.dataObjTypeLookUpEditSubrep.Properties.DropDownRows = 3;
            this.dataObjTypeLookUpEditSubrep.Properties.NullText = "";
            this.dataObjTypeLookUpEditSubrep.Properties.ShowFooter = false;
            this.dataObjTypeLookUpEditSubrep.Properties.ShowHeader = false;
            this.dataObjTypeLookUpEditSubrep.Properties.ValueMember = "TypeId";
            this.dataObjTypeLookUpEditSubrep.Size = new System.Drawing.Size(94, 20);
            this.dataObjTypeLookUpEditSubrep.TabIndex = 1;
            this.dataObjTypeLookUpEditSubrep.EditValueChanged += new System.EventHandler(this.dataObjTypeLookUpEditSubrep_EditValueChanged);
            // 
            // dataObjNameLookUpEditSubrep
            // 
            this.dataObjNameLookUpEditSubrep.Location = new System.Drawing.Point(224, 69);
            this.dataObjNameLookUpEditSubrep.Name = "dataObjNameLookUpEditSubrep";
            this.dataObjNameLookUpEditSubrep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dataObjNameLookUpEditSubrep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataObjNameLookUpEditSubrep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataObjName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.dataObjNameLookUpEditSubrep.Properties.DisplayMember = "DataObjName";
            this.dataObjNameLookUpEditSubrep.Properties.DropDownRows = 10;
            this.dataObjNameLookUpEditSubrep.Properties.NullText = "";
            this.dataObjNameLookUpEditSubrep.Properties.ShowFooter = false;
            this.dataObjNameLookUpEditSubrep.Properties.ShowHeader = false;
            this.dataObjNameLookUpEditSubrep.Properties.ValueMember = "DataObjName";
            this.dataObjNameLookUpEditSubrep.Size = new System.Drawing.Size(257, 20);
            this.dataObjNameLookUpEditSubrep.TabIndex = 2;
            // 
            // gctSubreport
            // 
            this.gctSubreport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctSubreport.EmbeddedNavigator.Name = "";
            this.gctSubreport.Location = new System.Drawing.Point(6, 92);
            this.gctSubreport.MainView = this.gridSubreport;
            this.gctSubreport.Name = "gctSubreport";
            this.gctSubreport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluDataObjType,
            this.rluDataObjName});
            this.gctSubreport.Size = new System.Drawing.Size(812, 209);
            this.gctSubreport.TabIndex = 8;
            this.gctSubreport.TabStop = false;
            this.gctSubreport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSubreport});
            this.gctSubreport.DoubleClick += new System.EventHandler(this.gridSubreport_DoubleClick);
            // 
            // gridSubreport
            // 
            this.gridSubreport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepId1,
            this.colSubRepId,
            this.colDataObjType,
            this.colDataObjName,
            this.colCriteria,
            this.colSortBy});
            this.gridSubreport.GridControl = this.gctSubreport;
            this.gridSubreport.Name = "gridSubreport";
            this.gridSubreport.OptionsBehavior.Editable = false;
            this.gridSubreport.OptionsCustomization.AllowColumnMoving = false;
            this.gridSubreport.OptionsCustomization.AllowColumnResizing = false;
            this.gridSubreport.OptionsCustomization.AllowFilter = false;
            this.gridSubreport.OptionsCustomization.AllowGroup = false;
            this.gridSubreport.OptionsCustomization.AllowSort = false;
            this.gridSubreport.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridSubreport.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridSubreport.OptionsView.ColumnAutoWidth = false;
            this.gridSubreport.OptionsView.ShowColumnHeaders = false;
            this.gridSubreport.OptionsView.ShowGroupPanel = false;
            this.gridSubreport.OptionsView.ShowIndicator = false;
            // 
            // colRepId1
            // 
            this.colRepId1.Caption = "RepId";
            this.colRepId1.FieldName = "RepId";
            this.colRepId1.Name = "colRepId1";
            // 
            // colSubRepId
            // 
            this.colSubRepId.Caption = "SubRepId";
            this.colSubRepId.FieldName = "SubRepId";
            this.colSubRepId.Name = "colSubRepId";
            this.colSubRepId.Visible = true;
            this.colSubRepId.VisibleIndex = 0;
            this.colSubRepId.Width = 116;
            // 
            // colDataObjType
            // 
            this.colDataObjType.Caption = "DataObjType";
            this.colDataObjType.ColumnEdit = this.rluDataObjType;
            this.colDataObjType.FieldName = "DataObjType";
            this.colDataObjType.Name = "colDataObjType";
            this.colDataObjType.Visible = true;
            this.colDataObjType.VisibleIndex = 1;
            this.colDataObjType.Width = 96;
            // 
            // rluDataObjType
            // 
            this.rluDataObjType.AutoHeight = false;
            this.rluDataObjType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluDataObjType.DisplayMember = "TypeName";
            this.rluDataObjType.Name = "rluDataObjType";
            this.rluDataObjType.NullText = "";
            this.rluDataObjType.ValueMember = "TypeId";
            // 
            // colDataObjName
            // 
            this.colDataObjName.Caption = "DataObjName";
            this.colDataObjName.ColumnEdit = this.rluDataObjName;
            this.colDataObjName.FieldName = "DataObjName";
            this.colDataObjName.Name = "colDataObjName";
            this.colDataObjName.Visible = true;
            this.colDataObjName.VisibleIndex = 2;
            this.colDataObjName.Width = 266;
            // 
            // rluDataObjName
            // 
            this.rluDataObjName.AutoHeight = false;
            this.rluDataObjName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluDataObjName.DisplayMember = "DataObjName";
            this.rluDataObjName.Name = "rluDataObjName";
            this.rluDataObjName.NullText = "";
            this.rluDataObjName.ValueMember = "DataObjName";
            // 
            // colCriteria
            // 
            this.colCriteria.Caption = "Criteria";
            this.colCriteria.FieldName = "Criteria";
            this.colCriteria.Name = "colCriteria";
            this.colCriteria.Visible = true;
            this.colCriteria.VisibleIndex = 3;
            this.colCriteria.Width = 327;
            // 
            // colSortBy
            // 
            this.colSortBy.Caption = "SortBy";
            this.colSortBy.FieldName = "SortBy";
            this.colSortBy.Name = "colSortBy";
            // 
            // tspSubReport
            // 
            this.tspSubReport.BackColor = System.Drawing.Color.White;
            this.tspSubReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubrepToolStripButton,
            this.removeSubrepToolStripButton,
            this.refreshSubrepToolStripButton});
            this.tspSubReport.Location = new System.Drawing.Point(3, 16);
            this.tspSubReport.Name = "tspSubReport";
            this.tspSubReport.Size = new System.Drawing.Size(818, 25);
            this.tspSubReport.TabIndex = 4;
            this.tspSubReport.TabStop = true;
            this.tspSubReport.Text = "toolStrip1";
            // 
            // addSubrepToolStripButton
            // 
            this.addSubrepToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addSubrepToolStripButton.Image")));
            this.addSubrepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addSubrepToolStripButton.Name = "addSubrepToolStripButton";
            this.addSubrepToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addSubrepToolStripButton.Text = "Add";
            this.addSubrepToolStripButton.Click += new System.EventHandler(this.addSubrepToolStripButton_Click);
            // 
            // removeSubrepToolStripButton
            // 
            this.removeSubrepToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeSubrepToolStripButton.Image")));
            this.removeSubrepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeSubrepToolStripButton.Name = "removeSubrepToolStripButton";
            this.removeSubrepToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.removeSubrepToolStripButton.Text = "Remove";
            this.removeSubrepToolStripButton.Click += new System.EventHandler(this.removeSubrepToolStripButton_Click);
            // 
            // refreshSubrepToolStripButton
            // 
            this.refreshSubrepToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshSubrepToolStripButton.Image")));
            this.refreshSubrepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshSubrepToolStripButton.Name = "refreshSubrepToolStripButton";
            this.refreshSubrepToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshSubrepToolStripButton.Text = "&Refresh";
            this.refreshSubrepToolStripButton.Click += new System.EventHandler(this.refreshSubrepToolStripButton_Click);
            // 
            // frmReportSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1120, 669);
            this.Controls.Add(this.tctReportSetup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(repIdLabel1);
            this.Controls.Add(this.repIdLookUpEdit);
            this.Controls.Add(this.tspReportSetup);
            this.Name = "frmReportSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportSetup";
            this.Load += new System.EventHandler(this.frmReportSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReportSetup_KeyDown);
            this.tspReportSetup.ResumeLayout(false);
            this.tspReportSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repIdLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGroupLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjNameLookUpEdit.Properties)).EndInit();
            this.tctReportSetup.ResumeLayout(false);
            this.tabParameter.ResumeLayout(false);
            this.lookUpEditPropertiesGroupBox.ResumeLayout(false);
            this.lookUpEditPropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceTypeLookUpEdit.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjunctionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incInHdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctRepParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFieldName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluComparision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluConjunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluIncInHd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluControlType)).EndInit();
            this.tspReportParameter.ResumeLayout(false);
            this.tspReportParameter.PerformLayout();
            this.tabSubreport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjTypeLookUpEditSubrep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObjNameLookUpEditSubrep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSubreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataObjType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluDataObjName)).EndInit();
            this.tspSubReport.ResumeLayout(false);
            this.tspSubReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspReportSetup;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit repIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit dataObjTypeLookUpEdit;
        private System.Windows.Forms.CheckBox isByUserCheckBox;
        private DevExpress.XtraEditors.LookUpEdit reportGroupLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit dataObjNameLookUpEdit;
        private System.Windows.Forms.TabControl tctReportSetup;
        private System.Windows.Forms.TabPage tabParameter;
        private System.Windows.Forms.GroupBox lookUpEditPropertiesGroupBox;
        private DevExpress.XtraEditors.LookUpEdit dataSourceTypeLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LookUpEdit fieldNameLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit controlTypeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit comparisionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit dataTypeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit conjunctionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit incInHdLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctRepParameter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRepParameter;
        private DevExpress.XtraGrid.Columns.GridColumn colRepId;
        private DevExpress.XtraGrid.Columns.GridColumn colParamId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colComparision;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluComparision;
        private DevExpress.XtraGrid.Columns.GridColumn colConjunction;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluConjunction;
        private DevExpress.XtraGrid.Columns.GridColumn colDataType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluDataType;
        private DevExpress.XtraGrid.Columns.GridColumn colIncInHd;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluIncInHd;
        private DevExpress.XtraGrid.Columns.GridColumn colControlType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluControlType;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayMember;
        private DevExpress.XtraGrid.Columns.GridColumn colValueMember;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colListFields;
        private System.Windows.Forms.ToolStrip tspReportParameter;
        private System.Windows.Forms.ToolStripButton addParameterToolStripButton;
        private System.Windows.Forms.ToolStripButton removeParameterToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshParameterToolStripButton;
        private System.Windows.Forms.TabPage tabSubreport;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit dataObjTypeLookUpEditSubrep;
        private DevExpress.XtraEditors.LookUpEdit dataObjNameLookUpEditSubrep;
        private DevExpress.XtraGrid.GridControl gctSubreport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSubreport;
        private DevExpress.XtraGrid.Columns.GridColumn colRepId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubRepId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataObjType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluDataObjType;
        private DevExpress.XtraGrid.Columns.GridColumn colDataObjName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluDataObjName;
        private DevExpress.XtraGrid.Columns.GridColumn colCriteria;
        private DevExpress.XtraGrid.Columns.GridColumn colSortBy;
        private System.Windows.Forms.ToolStrip tspSubReport;
        private System.Windows.Forms.ToolStripButton addSubrepToolStripButton;
        private System.Windows.Forms.ToolStripButton removeSubrepToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshSubrepToolStripButton;
        private System.Windows.Forms.TextBox sortByTextBox;
        private System.Windows.Forms.TextBox criteriaTextBox;
        private System.Windows.Forms.TextBox reportFileNameTextBox;
        private System.Windows.Forms.TextBox repNameTextBox;
        private System.Windows.Forms.TextBox repIdTextBox;
        private System.Windows.Forms.TextBox reportHeadTextBox;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox listFieldsTextBox;
        private System.Windows.Forms.TextBox valueMemberTextBox;
        private System.Windows.Forms.TextBox displayMemberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox paramIdTextBox;
        private System.Windows.Forms.TextBox criteriaTextBoxSubrep;
        private System.Windows.Forms.TextBox subRepIdTextBox;
        private System.Windows.Forms.TextBox usrNameFldTextBox;
        private System.Windows.Forms.TextBox RepNameAmharicTextBox;
    }
}