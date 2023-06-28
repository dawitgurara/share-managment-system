namespace SHM
{
    partial class frmOtherParameterSetup
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
            System.Windows.Forms.Label repIdLabel;
            System.Windows.Forms.Label repNameLabel;
            System.Windows.Forms.Label dataObjNameLabel;
            System.Windows.Forms.Label repIdLabel1;
            System.Windows.Forms.Label controlTypeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label fieldNameLabel;
            System.Windows.Forms.Label listFieldsLabel;
            System.Windows.Forms.Label dataSourceTypeLabel;
            System.Windows.Forms.Label dataSourceLabel;
            System.Windows.Forms.Label valueMemberLabel;
            System.Windows.Forms.Label displayMemberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherParameterSetup));
            this.tspGlobalParameterSetup = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tableNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.idLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tctGlobalParameterSetup = new System.Windows.Forms.TabControl();
            this.tabParameterColumn = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.fieldNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.controlTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctParameterColumns = new DevExpress.XtraGrid.GridControl();
            this.gridParameterColumns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParameterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluFieldName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluControlType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDisplayMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListFields = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tspParameterColumns = new System.Windows.Forms.ToolStrip();
            this.addColumnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeColumnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshColumnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lookUpEditPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.listFieldsTextBox = new System.Windows.Forms.TextBox();
            this.valueMemberTextBox = new System.Windows.Forms.TextBox();
            this.displayMemberTextBox = new System.Windows.Forms.TextBox();
            this.dataSourceTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            repIdLabel = new System.Windows.Forms.Label();
            repNameLabel = new System.Windows.Forms.Label();
            dataObjNameLabel = new System.Windows.Forms.Label();
            repIdLabel1 = new System.Windows.Forms.Label();
            controlTypeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            fieldNameLabel = new System.Windows.Forms.Label();
            listFieldsLabel = new System.Windows.Forms.Label();
            dataSourceTypeLabel = new System.Windows.Forms.Label();
            dataSourceLabel = new System.Windows.Forms.Label();
            valueMemberLabel = new System.Windows.Forms.Label();
            displayMemberLabel = new System.Windows.Forms.Label();
            this.tspGlobalParameterSetup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLookUpEdit.Properties)).BeginInit();
            this.tctGlobalParameterSetup.SuspendLayout();
            this.tabParameterColumn.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctParameterColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameterColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluControlType)).BeginInit();
            this.tspParameterColumns.SuspendLayout();
            this.lookUpEditPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceTypeLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repIdLabel
            // 
            repIdLabel.AutoSize = true;
            repIdLabel.Location = new System.Drawing.Point(45, 21);
            repIdLabel.Name = "repIdLabel";
            repIdLabel.Size = new System.Drawing.Size(70, 13);
            repIdLabel.TabIndex = 6;
            repIdLabel.Text = "Parameter Id:";
            // 
            // repNameLabel
            // 
            repNameLabel.AutoSize = true;
            repNameLabel.Location = new System.Drawing.Point(52, 46);
            repNameLabel.Name = "repNameLabel";
            repNameLabel.Size = new System.Drawing.Size(63, 13);
            repNameLabel.TabIndex = 8;
            repNameLabel.Text = "Description:";
            // 
            // dataObjNameLabel
            // 
            dataObjNameLabel.AutoSize = true;
            dataObjNameLabel.Location = new System.Drawing.Point(327, 21);
            dataObjNameLabel.Name = "dataObjNameLabel";
            dataObjNameLabel.Size = new System.Drawing.Size(68, 13);
            dataObjNameLabel.TabIndex = 12;
            dataObjNameLabel.Text = "Table Name:";
            // 
            // repIdLabel1
            // 
            repIdLabel1.AutoSize = true;
            repIdLabel1.Location = new System.Drawing.Point(24, 51);
            repIdLabel1.Name = "repIdLabel1";
            repIdLabel1.Size = new System.Drawing.Size(103, 13);
            repIdLabel1.TabIndex = 36;
            repIdLabel1.Text = "Selected Parameter:";
            // 
            // controlTypeLabel
            // 
            controlTypeLabel.AutoSize = true;
            controlTypeLabel.Location = new System.Drawing.Point(398, 49);
            controlTypeLabel.Name = "controlTypeLabel";
            controlTypeLabel.Size = new System.Drawing.Size(70, 13);
            controlTypeLabel.TabIndex = 17;
            controlTypeLabel.Text = "Control Type:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(190, 50);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(46, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Caption:";
            // 
            // fieldNameLabel
            // 
            fieldNameLabel.AutoSize = true;
            fieldNameLabel.Location = new System.Drawing.Point(6, 49);
            fieldNameLabel.Name = "fieldNameLabel";
            fieldNameLabel.Size = new System.Drawing.Size(63, 13);
            fieldNameLabel.TabIndex = 9;
            fieldNameLabel.Text = "Field Name:";
            // 
            // listFieldsLabel
            // 
            listFieldsLabel.AutoSize = true;
            listFieldsLabel.Location = new System.Drawing.Point(23, 60);
            listFieldsLabel.Name = "listFieldsLabel";
            listFieldsLabel.Size = new System.Drawing.Size(56, 13);
            listFieldsLabel.TabIndex = 8;
            listFieldsLabel.Text = "List Fields:";
            // 
            // dataSourceTypeLabel
            // 
            dataSourceTypeLabel.AutoSize = true;
            dataSourceTypeLabel.Location = new System.Drawing.Point(404, 16);
            dataSourceTypeLabel.Name = "dataSourceTypeLabel";
            dataSourceTypeLabel.Size = new System.Drawing.Size(97, 13);
            dataSourceTypeLabel.TabIndex = 6;
            dataSourceTypeLabel.Text = "Data Source Type:";
            // 
            // dataSourceLabel
            // 
            dataSourceLabel.AutoSize = true;
            dataSourceLabel.Location = new System.Drawing.Point(9, 86);
            dataSourceLabel.Name = "dataSourceLabel";
            dataSourceLabel.Size = new System.Drawing.Size(70, 13);
            dataSourceLabel.TabIndex = 4;
            dataSourceLabel.Text = "Data Source:";
            // 
            // valueMemberLabel
            // 
            valueMemberLabel.AutoSize = true;
            valueMemberLabel.Location = new System.Drawing.Point(242, 16);
            valueMemberLabel.Name = "valueMemberLabel";
            valueMemberLabel.Size = new System.Drawing.Size(78, 13);
            valueMemberLabel.TabIndex = 2;
            valueMemberLabel.Text = "Value Member:";
            // 
            // displayMemberLabel
            // 
            displayMemberLabel.AutoSize = true;
            displayMemberLabel.Location = new System.Drawing.Point(82, 16);
            displayMemberLabel.Name = "displayMemberLabel";
            displayMemberLabel.Size = new System.Drawing.Size(85, 13);
            displayMemberLabel.TabIndex = 0;
            displayMemberLabel.Text = "Display Member:";
            // 
            // tspGlobalParameterSetup
            // 
            this.tspGlobalParameterSetup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspGlobalParameterSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspGlobalParameterSetup.Location = new System.Drawing.Point(0, 0);
            this.tspGlobalParameterSetup.Name = "tspGlobalParameterSetup";
            this.tspGlobalParameterSetup.Size = new System.Drawing.Size(632, 25);
            this.tspGlobalParameterSetup.TabIndex = 6;
            this.tspGlobalParameterSetup.TabStop = true;
            this.tspGlobalParameterSetup.Text = "toolStrip1";
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
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
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
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(repIdLabel);
            this.groupBox1.Controls.Add(repNameLabel);
            this.groupBox1.Controls.Add(dataObjNameLabel);
            this.groupBox1.Controls.Add(this.tableNameLookUpEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 71);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Detail";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(121, 44);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(437, 20);
            this.descriptionTextBox.TabIndex = 160;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(121, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(122, 20);
            this.idTextBox.TabIndex = 159;
            this.idTextBox.Validated += new System.EventHandler(this.idTextBox_Validated);
            // 
            // tableNameLookUpEdit
            // 
            this.tableNameLookUpEdit.Location = new System.Drawing.Point(401, 18);
            this.tableNameLookUpEdit.Name = "tableNameLookUpEdit";
            this.tableNameLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tableNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tableNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataObjName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.tableNameLookUpEdit.Properties.DisplayMember = "DataObjName";
            this.tableNameLookUpEdit.Properties.DropDownRows = 10;
            this.tableNameLookUpEdit.Properties.NullText = "";
            this.tableNameLookUpEdit.Properties.ShowFooter = false;
            this.tableNameLookUpEdit.Properties.ShowHeader = false;
            this.tableNameLookUpEdit.Properties.ValueMember = "DataObjName";
            this.tableNameLookUpEdit.Size = new System.Drawing.Size(157, 20);
            this.tableNameLookUpEdit.TabIndex = 1;
            this.tableNameLookUpEdit.EditValueChanged += new System.EventHandler(this.tableNameLookUpEdit_EditValueChanged);
            // 
            // idLookUpEdit
            // 
            this.idLookUpEdit.Location = new System.Drawing.Point(133, 48);
            this.idLookUpEdit.Name = "idLookUpEdit";
            this.idLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.idLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", "Table Name", 10)});
            this.idLookUpEdit.Properties.DisplayMember = "Description";
            this.idLookUpEdit.Properties.NullText = "";
            this.idLookUpEdit.Properties.ValueMember = "Id";
            this.idLookUpEdit.Size = new System.Drawing.Size(437, 20);
            this.idLookUpEdit.TabIndex = 34;
            this.idLookUpEdit.EditValueChanged += new System.EventHandler(this.idLookUpEdit_EditValueChanged);
            // 
            // tctGlobalParameterSetup
            // 
            this.tctGlobalParameterSetup.Controls.Add(this.tabParameterColumn);
            this.tctGlobalParameterSetup.Location = new System.Drawing.Point(12, 184);
            this.tctGlobalParameterSetup.Name = "tctGlobalParameterSetup";
            this.tctGlobalParameterSetup.SelectedIndex = 0;
            this.tctGlobalParameterSetup.Size = new System.Drawing.Size(613, 397);
            this.tctGlobalParameterSetup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctGlobalParameterSetup.TabIndex = 38;
            // 
            // tabParameterColumn
            // 
            this.tabParameterColumn.Controls.Add(this.groupBox5);
            this.tabParameterColumn.Controls.Add(this.lookUpEditPropertiesGroupBox);
            this.tabParameterColumn.Location = new System.Drawing.Point(4, 22);
            this.tabParameterColumn.Name = "tabParameterColumn";
            this.tabParameterColumn.Padding = new System.Windows.Forms.Padding(3);
            this.tabParameterColumn.Size = new System.Drawing.Size(605, 371);
            this.tabParameterColumn.TabIndex = 0;
            this.tabParameterColumn.Text = "Columns";
            this.tabParameterColumn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.captionTextBox);
            this.groupBox5.Controls.Add(this.fieldNameLookUpEdit);
            this.groupBox5.Controls.Add(controlTypeLabel);
            this.groupBox5.Controls.Add(this.controlTypeLookUpEdit);
            this.groupBox5.Controls.Add(descriptionLabel);
            this.groupBox5.Controls.Add(fieldNameLabel);
            this.groupBox5.Controls.Add(this.gctParameterColumns);
            this.groupBox5.Controls.Add(this.tspParameterColumns);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 205);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // captionTextBox
            // 
            this.captionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionTextBox.Location = new System.Drawing.Point(193, 66);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(202, 20);
            this.captionTextBox.TabIndex = 159;
            // 
            // fieldNameLookUpEdit
            // 
            this.fieldNameLookUpEdit.Location = new System.Drawing.Point(6, 66);
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
            this.fieldNameLookUpEdit.Size = new System.Drawing.Size(181, 20);
            this.fieldNameLookUpEdit.TabIndex = 0;
            this.fieldNameLookUpEdit.EditValueChanged += new System.EventHandler(this.fieldNameLookUpEdit_EditValueChanged);
            // 
            // controlTypeLookUpEdit
            // 
            this.controlTypeLookUpEdit.Location = new System.Drawing.Point(401, 66);
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
            this.controlTypeLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.controlTypeLookUpEdit.TabIndex = 2;
            this.controlTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.controlTypeLookUpEdit_EditValueChanged);
            // 
            // gctParameterColumns
            // 
            this.gctParameterColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctParameterColumns.EmbeddedNavigator.Name = "";
            this.gctParameterColumns.Location = new System.Drawing.Point(6, 92);
            this.gctParameterColumns.MainView = this.gridParameterColumns;
            this.gctParameterColumns.Name = "gctParameterColumns";
            this.gctParameterColumns.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluControlType,
            this.rluFieldName});
            this.gctParameterColumns.Size = new System.Drawing.Size(571, 107);
            this.gctParameterColumns.TabIndex = 4;
            this.gctParameterColumns.TabStop = false;
            this.gctParameterColumns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridParameterColumns});
            this.gctParameterColumns.DoubleClick += new System.EventHandler(this.gridParameterColumns_DoubleClick);
            // 
            // gridParameterColumns
            // 
            this.gridParameterColumns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParameterId,
            this.colFieldName,
            this.colCaption,
            this.colControlType,
            this.colDisplayMember,
            this.colValueMember,
            this.colDataSource,
            this.colDataSourceType,
            this.colListFields});
            this.gridParameterColumns.GridControl = this.gctParameterColumns;
            this.gridParameterColumns.Name = "gridParameterColumns";
            this.gridParameterColumns.OptionsBehavior.Editable = false;
            this.gridParameterColumns.OptionsCustomization.AllowColumnMoving = false;
            this.gridParameterColumns.OptionsCustomization.AllowColumnResizing = false;
            this.gridParameterColumns.OptionsCustomization.AllowFilter = false;
            this.gridParameterColumns.OptionsCustomization.AllowGroup = false;
            this.gridParameterColumns.OptionsCustomization.AllowSort = false;
            this.gridParameterColumns.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridParameterColumns.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridParameterColumns.OptionsView.ColumnAutoWidth = false;
            this.gridParameterColumns.OptionsView.ShowColumnHeaders = false;
            this.gridParameterColumns.OptionsView.ShowGroupPanel = false;
            this.gridParameterColumns.OptionsView.ShowIndicator = false;
            // 
            // colParameterId
            // 
            this.colParameterId.Caption = "ParameterId";
            this.colParameterId.FieldName = "ParameterId";
            this.colParameterId.Name = "colParameterId";
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "FieldName";
            this.colFieldName.ColumnEdit = this.rluFieldName;
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 0;
            this.colFieldName.Width = 183;
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
            // colCaption
            // 
            this.colCaption.Caption = "Caption";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 1;
            this.colCaption.Width = 207;
            // 
            // colControlType
            // 
            this.colControlType.Caption = "ControlType";
            this.colControlType.ColumnEdit = this.rluControlType;
            this.colControlType.FieldName = "ControlType";
            this.colControlType.Name = "colControlType";
            this.colControlType.Visible = true;
            this.colControlType.VisibleIndex = 2;
            this.colControlType.Width = 174;
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
            // tspParameterColumns
            // 
            this.tspParameterColumns.BackColor = System.Drawing.Color.White;
            this.tspParameterColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripButton,
            this.removeColumnToolStripButton,
            this.refreshColumnToolStripButton});
            this.tspParameterColumns.Location = new System.Drawing.Point(3, 16);
            this.tspParameterColumns.Name = "tspParameterColumns";
            this.tspParameterColumns.Size = new System.Drawing.Size(577, 25);
            this.tspParameterColumns.TabIndex = 3;
            this.tspParameterColumns.TabStop = true;
            this.tspParameterColumns.Text = "toolStrip1";
            // 
            // addColumnToolStripButton
            // 
            this.addColumnToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addColumnToolStripButton.Image")));
            this.addColumnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addColumnToolStripButton.Name = "addColumnToolStripButton";
            this.addColumnToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addColumnToolStripButton.Text = "Add";
            this.addColumnToolStripButton.Click += new System.EventHandler(this.addColumnToolStripButton_Click);
            // 
            // removeColumnToolStripButton
            // 
            this.removeColumnToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeColumnToolStripButton.Image")));
            this.removeColumnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeColumnToolStripButton.Name = "removeColumnToolStripButton";
            this.removeColumnToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.removeColumnToolStripButton.Text = "Remove";
            this.removeColumnToolStripButton.Click += new System.EventHandler(this.removeColumnToolStripButton_Click);
            // 
            // refreshColumnToolStripButton
            // 
            this.refreshColumnToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshColumnToolStripButton.Image")));
            this.refreshColumnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshColumnToolStripButton.Name = "refreshColumnToolStripButton";
            this.refreshColumnToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshColumnToolStripButton.Text = "&Refresh";
            this.refreshColumnToolStripButton.Click += new System.EventHandler(this.refreshColumnToolStripButton_Click);
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
            this.lookUpEditPropertiesGroupBox.Location = new System.Drawing.Point(3, 214);
            this.lookUpEditPropertiesGroupBox.Name = "lookUpEditPropertiesGroupBox";
            this.lookUpEditPropertiesGroupBox.Size = new System.Drawing.Size(583, 141);
            this.lookUpEditPropertiesGroupBox.TabIndex = 4;
            this.lookUpEditPropertiesGroupBox.TabStop = false;
            this.lookUpEditPropertiesGroupBox.Text = "LookUpEdit Properties";
            this.lookUpEditPropertiesGroupBox.Visible = false;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataSourceTextBox.Location = new System.Drawing.Point(85, 84);
            this.dataSourceTextBox.Multiline = true;
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(491, 40);
            this.dataSourceTextBox.TabIndex = 162;
            // 
            // listFieldsTextBox
            // 
            this.listFieldsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFieldsTextBox.Location = new System.Drawing.Point(85, 58);
            this.listFieldsTextBox.Name = "listFieldsTextBox";
            this.listFieldsTextBox.Size = new System.Drawing.Size(491, 20);
            this.listFieldsTextBox.TabIndex = 161;
            // 
            // valueMemberTextBox
            // 
            this.valueMemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueMemberTextBox.Location = new System.Drawing.Point(242, 32);
            this.valueMemberTextBox.Name = "valueMemberTextBox";
            this.valueMemberTextBox.Size = new System.Drawing.Size(157, 20);
            this.valueMemberTextBox.TabIndex = 160;
            // 
            // displayMemberTextBox
            // 
            this.displayMemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayMemberTextBox.Location = new System.Drawing.Point(85, 32);
            this.displayMemberTextBox.Name = "displayMemberTextBox";
            this.displayMemberTextBox.Size = new System.Drawing.Size(151, 20);
            this.displayMemberTextBox.TabIndex = 159;
            // 
            // dataSourceTypeLookUpEdit
            // 
            this.dataSourceTypeLookUpEdit.Location = new System.Drawing.Point(405, 32);
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
            this.dataSourceTypeLookUpEdit.Size = new System.Drawing.Size(172, 20);
            this.dataSourceTypeLookUpEdit.TabIndex = 2;
            // 
            // frmOtherParameterSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(632, 585);
            this.Controls.Add(this.tctGlobalParameterSetup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(repIdLabel1);
            this.Controls.Add(this.idLookUpEdit);
            this.Controls.Add(this.tspGlobalParameterSetup);
            this.Name = "frmOtherParameterSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOtherParameterSetup";
            this.Load += new System.EventHandler(this.frmOtherParameterSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOtherParameterSetup_KeyDown);
            this.tspGlobalParameterSetup.ResumeLayout(false);
            this.tspGlobalParameterSetup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLookUpEdit.Properties)).EndInit();
            this.tctGlobalParameterSetup.ResumeLayout(false);
            this.tabParameterColumn.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctParameterColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameterColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluFieldName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluControlType)).EndInit();
            this.tspParameterColumns.ResumeLayout(false);
            this.tspParameterColumns.PerformLayout();
            this.lookUpEditPropertiesGroupBox.ResumeLayout(false);
            this.lookUpEditPropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceTypeLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspGlobalParameterSetup;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit tableNameLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit idLookUpEdit;
        private System.Windows.Forms.TabControl tctGlobalParameterSetup;
        private System.Windows.Forms.TabPage tabParameterColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LookUpEdit fieldNameLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit controlTypeLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctParameterColumns;
        private DevExpress.XtraGrid.Views.Grid.GridView gridParameterColumns;
        private DevExpress.XtraGrid.Columns.GridColumn colParameterId;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colControlType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluControlType;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayMember;
        private DevExpress.XtraGrid.Columns.GridColumn colValueMember;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colListFields;
        private System.Windows.Forms.ToolStrip tspParameterColumns;
        private System.Windows.Forms.ToolStripButton addColumnToolStripButton;
        private System.Windows.Forms.ToolStripButton removeColumnToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshColumnToolStripButton;
        private System.Windows.Forms.GroupBox lookUpEditPropertiesGroupBox;
        private DevExpress.XtraEditors.LookUpEdit dataSourceTypeLookUpEdit;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.TextBox displayMemberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox listFieldsTextBox;
        private System.Windows.Forms.TextBox valueMemberTextBox;
    }
}