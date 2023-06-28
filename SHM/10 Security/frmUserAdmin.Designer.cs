namespace SHM
{
    partial class frmUserAdmin
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userNameLabel1;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label lastLoginLabel;
            System.Windows.Forms.Label passwordChangedOnLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAdmin));
            this.tspUserAdmin = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.chkUserAll = new System.Windows.Forms.CheckBox();
            this.userIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserIsLockedCheckBox = new System.Windows.Forms.CheckBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordChangedOnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastLoginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.alreadyLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tctRights = new System.Windows.Forms.TabControl();
            this.tabUserRights = new System.Windows.Forms.TabPage();
            this.tspUserRights = new System.Windows.Forms.ToolStrip();
            this.checkAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkNoneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkRefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tctUserRights = new System.Windows.Forms.TabControl();
            this.tabUserMenuRights = new System.Windows.Forms.TabPage();
            this.gctUserMenuRights = new DevExpress.XtraGrid.GridControl();
            this.gridUserMenuRights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGranted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabUserRoleRights = new System.Windows.Forms.TabPage();
            this.gctUserRoleRights = new DevExpress.XtraGrid.GridControl();
            this.gridUserRoleRights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGranted1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplication1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForUnitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabUserReportRights = new System.Windows.Forms.TabPage();
            this.gctUserReportRights = new DevExpress.XtraGrid.GridControl();
            this.gridUserReportRights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabUserReminderRights = new System.Windows.Forms.TabPage();
            this.gctUserReminderRights = new DevExpress.XtraGrid.GridControl();
            this.gridUserReminderRights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabUserGlobalParameterRights = new System.Windows.Forms.TabPage();
            this.gctUserGlobalParameterRights = new DevExpress.XtraGrid.GridControl();
            this.gridUserGlobalParameterRights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            userNameLabel = new System.Windows.Forms.Label();
            userNameLabel1 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            lastLoginLabel = new System.Windows.Forms.Label();
            passwordChangedOnLabel = new System.Windows.Forms.Label();
            this.tspUserAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIdLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tctRights.SuspendLayout();
            this.tabUserRights.SuspendLayout();
            this.tspUserRights.SuspendLayout();
            this.tctUserRights.SuspendLayout();
            this.tabUserMenuRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUserMenuRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserMenuRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.tabUserRoleRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUserRoleRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRoleRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.tabUserReportRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUserReportRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserReportRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit7)).BeginInit();
            this.tabUserReminderRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUserReminderRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserReminderRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).BeginInit();
            this.tabUserGlobalParameterRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctUserGlobalParameterRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserGlobalParameterRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit8)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(35, 46);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(77, 13);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "Selected User:";
            // 
            // userNameLabel1
            // 
            userNameLabel1.AutoSize = true;
            userNameLabel1.Location = new System.Drawing.Point(23, 11);
            userNameLabel1.Name = "userNameLabel1";
            userNameLabel1.Size = new System.Drawing.Size(63, 13);
            userNameLabel1.TabIndex = 0;
            userNameLabel1.Text = "User Name:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(29, 37);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(308, 43);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // lastLoginLabel
            // 
            lastLoginLabel.AutoSize = true;
            lastLoginLabel.Location = new System.Drawing.Point(23, 68);
            lastLoginLabel.Name = "lastLoginLabel";
            lastLoginLabel.Size = new System.Drawing.Size(59, 13);
            lastLoginLabel.TabIndex = 10;
            lastLoginLabel.Text = "Last Login:";
            // 
            // passwordChangedOnLabel
            // 
            passwordChangedOnLabel.AutoSize = true;
            passwordChangedOnLabel.Location = new System.Drawing.Point(245, 69);
            passwordChangedOnLabel.Name = "passwordChangedOnLabel";
            passwordChangedOnLabel.Size = new System.Drawing.Size(119, 13);
            passwordChangedOnLabel.TabIndex = 12;
            passwordChangedOnLabel.Text = "Password Changed On:";
            // 
            // tspUserAdmin
            // 
            this.tspUserAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspUserAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton1});
            this.tspUserAdmin.Location = new System.Drawing.Point(0, 0);
            this.tspUserAdmin.Name = "tspUserAdmin";
            this.tspUserAdmin.Size = new System.Drawing.Size(744, 25);
            this.tspUserAdmin.TabIndex = 5;
            this.tspUserAdmin.TabStop = true;
            this.tspUserAdmin.Text = "toolStrip1";
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
            this.deleteToolStripButton.Visible = false;
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
            // refreshToolStripButton1
            // 
            this.refreshToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton1.Image")));
            this.refreshToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton1.Name = "refreshToolStripButton1";
            this.refreshToolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton1.Text = "&Refresh";
            this.refreshToolStripButton1.Click += new System.EventHandler(this.refreshToolStripButton1_Click);
            // 
            // chkUserAll
            // 
            this.chkUserAll.AutoSize = true;
            this.chkUserAll.Location = new System.Drawing.Point(486, 45);
            this.chkUserAll.Name = "chkUserAll";
            this.chkUserAll.Size = new System.Drawing.Size(37, 17);
            this.chkUserAll.TabIndex = 8;
            this.chkUserAll.Text = "All";
            this.chkUserAll.UseVisualStyleBackColor = true;
            this.chkUserAll.CheckedChanged += new System.EventHandler(this.chkUserAll_CheckedChanged);
            // 
            // userIdLookUpEdit
            // 
            this.userIdLookUpEdit.Location = new System.Drawing.Point(118, 43);
            this.userIdLookUpEdit.Name = "userIdLookUpEdit";
            this.userIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.userIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsActive", "Active", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AlreadyLogin", "Already Login", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastLogin", "Last Login", 51, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)});
            this.userIdLookUpEdit.Properties.DisplayMember = "UserName";
            this.userIdLookUpEdit.Properties.NullText = "";
            this.userIdLookUpEdit.Properties.PopupWidth = 450;
            this.userIdLookUpEdit.Properties.ValueMember = "UserId";
            this.userIdLookUpEdit.Size = new System.Drawing.Size(362, 20);
            this.userIdLookUpEdit.TabIndex = 7;
            this.userIdLookUpEdit.EditValueChanged += new System.EventHandler(this.userIdLookUpEdit_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserIsLockedCheckBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.passwordChangedOnDateTimePicker);
            this.groupBox1.Controls.Add(this.lastLoginDateTimePicker);
            this.groupBox1.Controls.Add(userNameLabel1);
            this.groupBox1.Controls.Add(fullNameLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.alreadyLoginCheckBox);
            this.groupBox1.Controls.Add(lastLoginLabel);
            this.groupBox1.Controls.Add(passwordChangedOnLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // UserIsLockedCheckBox
            // 
            this.UserIsLockedCheckBox.Location = new System.Drawing.Point(370, 11);
            this.UserIsLockedCheckBox.Name = "UserIsLockedCheckBox";
            this.UserIsLockedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.UserIsLockedCheckBox.TabIndex = 161;
            this.UserIsLockedCheckBox.Text = "Lock User";
            this.UserIsLockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTextBox.Location = new System.Drawing.Point(92, 36);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.fullNameTextBox.TabIndex = 160;
            this.fullNameTextBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(370, 41);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(108, 20);
            this.passwordTextBox.TabIndex = 159;
            this.passwordTextBox.TabStop = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Location = new System.Drawing.Point(92, 11);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.userNameTextBox.TabIndex = 158;
            this.userNameTextBox.TabStop = false;
            // 
            // passwordChangedOnDateTimePicker
            // 
            this.passwordChangedOnDateTimePicker.Enabled = false;
            this.passwordChangedOnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.passwordChangedOnDateTimePicker.Location = new System.Drawing.Point(370, 68);
            this.passwordChangedOnDateTimePicker.Name = "passwordChangedOnDateTimePicker";
            this.passwordChangedOnDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.passwordChangedOnDateTimePicker.TabIndex = 150;
            this.passwordChangedOnDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            // 
            // lastLoginDateTimePicker
            // 
            this.lastLoginDateTimePicker.Enabled = false;
            this.lastLoginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastLoginDateTimePicker.Location = new System.Drawing.Point(92, 62);
            this.lastLoginDateTimePicker.Name = "lastLoginDateTimePicker";
            this.lastLoginDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.lastLoginDateTimePicker.TabIndex = 149;
            this.lastLoginDateTimePicker.Value = new System.DateTime(2017, 6, 13, 17, 2, 56, 0);
            // 
            // alreadyLoginCheckBox
            // 
            this.alreadyLoginCheckBox.Enabled = false;
            this.alreadyLoginCheckBox.Location = new System.Drawing.Point(260, 11);
            this.alreadyLoginCheckBox.Name = "alreadyLoginCheckBox";
            this.alreadyLoginCheckBox.Size = new System.Drawing.Size(104, 24);
            this.alreadyLoginCheckBox.TabIndex = 9;
            this.alreadyLoginCheckBox.Text = "Already Login";
            this.alreadyLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Location = new System.Drawing.Point(569, 41);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(81, 24);
            this.isActiveCheckBox.TabIndex = 1;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            this.isActiveCheckBox.Visible = false;
            // 
            // tctRights
            // 
            this.tctRights.Controls.Add(this.tabUserRights);
            this.tctRights.Location = new System.Drawing.Point(16, 190);
            this.tctRights.Name = "tctRights";
            this.tctRights.SelectedIndex = 0;
            this.tctRights.Size = new System.Drawing.Size(716, 434);
            this.tctRights.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctRights.TabIndex = 10;
            // 
            // tabUserRights
            // 
            this.tabUserRights.AutoScroll = true;
            this.tabUserRights.Controls.Add(this.tspUserRights);
            this.tabUserRights.Controls.Add(this.tctUserRights);
            this.tabUserRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserRights.Name = "tabUserRights";
            this.tabUserRights.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserRights.Size = new System.Drawing.Size(708, 408);
            this.tabUserRights.TabIndex = 1;
            this.tabUserRights.Text = "User Rights";
            this.tabUserRights.UseVisualStyleBackColor = true;
            // 
            // tspUserRights
            // 
            this.tspUserRights.BackColor = System.Drawing.Color.White;
            this.tspUserRights.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspUserRights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripButton,
            this.checkNoneToolStripButton,
            this.checkRefreshToolStripButton});
            this.tspUserRights.Location = new System.Drawing.Point(3, 3);
            this.tspUserRights.Name = "tspUserRights";
            this.tspUserRights.Size = new System.Drawing.Size(702, 25);
            this.tspUserRights.TabIndex = 9;
            this.tspUserRights.TabStop = true;
            this.tspUserRights.Text = "toolStrip1";
            // 
            // checkAllToolStripButton
            // 
            this.checkAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkAllToolStripButton.Image")));
            this.checkAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkAllToolStripButton.Name = "checkAllToolStripButton";
            this.checkAllToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.checkAllToolStripButton.Text = "Select All";
            this.checkAllToolStripButton.Click += new System.EventHandler(this.checkAllToolStripButton_Click);
            // 
            // checkNoneToolStripButton
            // 
            this.checkNoneToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkNoneToolStripButton.Image")));
            this.checkNoneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkNoneToolStripButton.Name = "checkNoneToolStripButton";
            this.checkNoneToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.checkNoneToolStripButton.Text = "Clear All";
            this.checkNoneToolStripButton.Click += new System.EventHandler(this.checkNoneToolStripButton_Click);
            // 
            // checkRefreshToolStripButton
            // 
            this.checkRefreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkRefreshToolStripButton.Image")));
            this.checkRefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkRefreshToolStripButton.Name = "checkRefreshToolStripButton";
            this.checkRefreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.checkRefreshToolStripButton.Text = "&Refresh";
            this.checkRefreshToolStripButton.Click += new System.EventHandler(this.checkRefreshToolStripButton_Click);
            // 
            // tctUserRights
            // 
            this.tctUserRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tctUserRights.Controls.Add(this.tabUserMenuRights);
            this.tctUserRights.Controls.Add(this.tabUserRoleRights);
            this.tctUserRights.Controls.Add(this.tabUserReportRights);
            this.tctUserRights.Controls.Add(this.tabUserReminderRights);
            this.tctUserRights.Controls.Add(this.tabUserGlobalParameterRights);
            this.tctUserRights.ItemSize = new System.Drawing.Size(100, 18);
            this.tctUserRights.Location = new System.Drawing.Point(-4, 35);
            this.tctUserRights.Name = "tctUserRights";
            this.tctUserRights.SelectedIndex = 0;
            this.tctUserRights.Size = new System.Drawing.Size(716, 366);
            this.tctUserRights.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctUserRights.TabIndex = 1;
            // 
            // tabUserMenuRights
            // 
            this.tabUserMenuRights.Controls.Add(this.gctUserMenuRights);
            this.tabUserMenuRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserMenuRights.Name = "tabUserMenuRights";
            this.tabUserMenuRights.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserMenuRights.Size = new System.Drawing.Size(708, 340);
            this.tabUserMenuRights.TabIndex = 1;
            this.tabUserMenuRights.Text = "Menu";
            this.tabUserMenuRights.UseVisualStyleBackColor = true;
            // 
            // gctUserMenuRights
            // 
            this.gctUserMenuRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctUserMenuRights.Cursor = System.Windows.Forms.Cursors.Default;
            this.gctUserMenuRights.EmbeddedNavigator.Name = "";
            this.gctUserMenuRights.Location = new System.Drawing.Point(3, 6);
            this.gctUserMenuRights.MainView = this.gridUserMenuRights;
            this.gctUserMenuRights.Name = "gctUserMenuRights";
            this.gctUserMenuRights.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gctUserMenuRights.Size = new System.Drawing.Size(699, 339);
            this.gctUserMenuRights.TabIndex = 0;
            this.gctUserMenuRights.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserMenuRights});
            // 
            // gridUserMenuRights
            // 
            this.gridUserMenuRights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGranted,
            this.colDescription,
            this.colCodeNo,
            this.colApplication,
            this.colMenuName,
            this.colGroupCode});
            this.gridUserMenuRights.GridControl = this.gctUserMenuRights;
            this.gridUserMenuRights.Name = "gridUserMenuRights";
            this.gridUserMenuRights.OptionsCustomization.AllowColumnMoving = false;
            this.gridUserMenuRights.OptionsCustomization.AllowColumnResizing = false;
            this.gridUserMenuRights.OptionsCustomization.AllowFilter = false;
            this.gridUserMenuRights.OptionsCustomization.AllowGroup = false;
            this.gridUserMenuRights.OptionsCustomization.AllowSort = false;
            this.gridUserMenuRights.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridUserMenuRights.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridUserMenuRights.OptionsView.EnableAppearanceEvenRow = true;
            this.gridUserMenuRights.OptionsView.EnableAppearanceOddRow = true;
            this.gridUserMenuRights.OptionsView.ShowGroupPanel = false;
            this.gridUserMenuRights.OptionsView.ShowIndicator = false;
            // 
            // colGranted
            // 
            this.colGranted.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colGranted.FieldName = "Granted";
            this.colGranted.Name = "colGranted";
            this.colGranted.Visible = true;
            this.colGranted.VisibleIndex = 0;
            this.colGranted.Width = 38;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 745;
            // 
            // colCodeNo
            // 
            this.colCodeNo.Caption = "CodeNo";
            this.colCodeNo.FieldName = "CodeNo";
            this.colCodeNo.Name = "colCodeNo";
            this.colCodeNo.OptionsColumn.ReadOnly = true;
            // 
            // colApplication
            // 
            this.colApplication.Caption = "Application";
            this.colApplication.FieldName = "Application";
            this.colApplication.Name = "colApplication";
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "MenuName";
            this.colMenuName.FieldName = "MenuName";
            this.colMenuName.Name = "colMenuName";
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "GroupCode";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            // 
            // tabUserRoleRights
            // 
            this.tabUserRoleRights.Controls.Add(this.gctUserRoleRights);
            this.tabUserRoleRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserRoleRights.Name = "tabUserRoleRights";
            this.tabUserRoleRights.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserRoleRights.Size = new System.Drawing.Size(708, 340);
            this.tabUserRoleRights.TabIndex = 0;
            this.tabUserRoleRights.Text = "Roles";
            this.tabUserRoleRights.UseVisualStyleBackColor = true;
            // 
            // gctUserRoleRights
            // 
            this.gctUserRoleRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctUserRoleRights.EmbeddedNavigator.Name = "";
            this.gctUserRoleRights.Location = new System.Drawing.Point(3, 6);
            this.gctUserRoleRights.MainView = this.gridUserRoleRights;
            this.gctUserRoleRights.Name = "gctUserRoleRights";
            this.gctUserRoleRights.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gctUserRoleRights.Size = new System.Drawing.Size(699, 328);
            this.gctUserRoleRights.TabIndex = 0;
            this.gctUserRoleRights.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserRoleRights});
            // 
            // gridUserRoleRights
            // 
            this.gridUserRoleRights.ActiveFilterEnabled = false;
            this.gridUserRoleRights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGranted1,
            this.colRoleName,
            this.colRoleId,
            this.colApplication1,
            this.colForUnitType});
            this.gridUserRoleRights.GridControl = this.gctUserRoleRights;
            this.gridUserRoleRights.Name = "gridUserRoleRights";
            this.gridUserRoleRights.OptionsCustomization.AllowColumnMoving = false;
            this.gridUserRoleRights.OptionsCustomization.AllowColumnResizing = false;
            this.gridUserRoleRights.OptionsCustomization.AllowFilter = false;
            this.gridUserRoleRights.OptionsCustomization.AllowGroup = false;
            this.gridUserRoleRights.OptionsCustomization.AllowSort = false;
            this.gridUserRoleRights.OptionsView.EnableAppearanceEvenRow = true;
            this.gridUserRoleRights.OptionsView.EnableAppearanceOddRow = true;
            this.gridUserRoleRights.OptionsView.ShowGroupPanel = false;
            this.gridUserRoleRights.OptionsView.ShowIndicator = false;
            // 
            // colGranted1
            // 
            this.colGranted1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colGranted1.FieldName = "Granted";
            this.colGranted1.Name = "colGranted1";
            this.colGranted1.Visible = true;
            this.colGranted1.VisibleIndex = 0;
            this.colGranted1.Width = 38;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Name";
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.OptionsColumn.ReadOnly = true;
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 745;
            // 
            // colRoleId
            // 
            this.colRoleId.Caption = "RoleId";
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.OptionsColumn.ReadOnly = true;
            // 
            // colApplication1
            // 
            this.colApplication1.Caption = "Application";
            this.colApplication1.FieldName = "Application";
            this.colApplication1.Name = "colApplication1";
            // 
            // colForUnitType
            // 
            this.colForUnitType.Caption = "ForUnitType";
            this.colForUnitType.FieldName = "ForUnitType";
            this.colForUnitType.Name = "colForUnitType";
            // 
            // tabUserReportRights
            // 
            this.tabUserReportRights.Controls.Add(this.gctUserReportRights);
            this.tabUserReportRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserReportRights.Name = "tabUserReportRights";
            this.tabUserReportRights.Size = new System.Drawing.Size(708, 340);
            this.tabUserReportRights.TabIndex = 4;
            this.tabUserReportRights.Text = "Reports";
            this.tabUserReportRights.UseVisualStyleBackColor = true;
            // 
            // gctUserReportRights
            // 
            this.gctUserReportRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctUserReportRights.EmbeddedNavigator.Name = "";
            this.gctUserReportRights.Location = new System.Drawing.Point(5, 6);
            this.gctUserReportRights.MainView = this.gridUserReportRights;
            this.gctUserReportRights.Name = "gctUserReportRights";
            this.gctUserReportRights.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit7});
            this.gctUserReportRights.Size = new System.Drawing.Size(700, 328);
            this.gctUserReportRights.TabIndex = 3;
            this.gctUserReportRights.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserReportRights});
            // 
            // gridUserReportRights
            // 
            this.gridUserReportRights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn12});
            this.gridUserReportRights.GridControl = this.gctUserReportRights;
            this.gridUserReportRights.Name = "gridUserReportRights";
            this.gridUserReportRights.OptionsCustomization.AllowColumnMoving = false;
            this.gridUserReportRights.OptionsCustomization.AllowColumnResizing = false;
            this.gridUserReportRights.OptionsCustomization.AllowFilter = false;
            this.gridUserReportRights.OptionsCustomization.AllowGroup = false;
            this.gridUserReportRights.OptionsView.EnableAppearanceEvenRow = true;
            this.gridUserReportRights.OptionsView.EnableAppearanceOddRow = true;
            this.gridUserReportRights.OptionsView.ShowGroupPanel = false;
            this.gridUserReportRights.OptionsView.ShowIndicator = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.ColumnEdit = this.repositoryItemCheckEdit7;
            this.gridColumn6.FieldName = "Granted";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 31;
            // 
            // repositoryItemCheckEdit7
            // 
            this.repositoryItemCheckEdit7.AutoHeight = false;
            this.repositoryItemCheckEdit7.Name = "repositoryItemCheckEdit7";
            this.repositoryItemCheckEdit7.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Description";
            this.gridColumn7.FieldName = "RepName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 498;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "RepId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Report Group";
            this.gridColumn12.FieldName = "ReportGroup";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 152;
            // 
            // tabUserReminderRights
            // 
            this.tabUserReminderRights.Controls.Add(this.gctUserReminderRights);
            this.tabUserReminderRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserReminderRights.Name = "tabUserReminderRights";
            this.tabUserReminderRights.Size = new System.Drawing.Size(708, 340);
            this.tabUserReminderRights.TabIndex = 5;
            this.tabUserReminderRights.Text = "Reminders";
            this.tabUserReminderRights.UseVisualStyleBackColor = true;
            // 
            // gctUserReminderRights
            // 
            this.gctUserReminderRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctUserReminderRights.EmbeddedNavigator.Name = "";
            this.gctUserReminderRights.Location = new System.Drawing.Point(5, 6);
            this.gctUserReminderRights.MainView = this.gridUserReminderRights;
            this.gctUserReminderRights.Name = "gctUserReminderRights";
            this.gctUserReminderRights.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit6});
            this.gctUserReminderRights.Size = new System.Drawing.Size(699, 328);
            this.gctUserReminderRights.TabIndex = 2;
            this.gctUserReminderRights.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserReminderRights});
            // 
            // gridUserReminderRights
            // 
            this.gridUserReminderRights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5});
            this.gridUserReminderRights.GridControl = this.gctUserReminderRights;
            this.gridUserReminderRights.Name = "gridUserReminderRights";
            this.gridUserReminderRights.OptionsCustomization.AllowColumnMoving = false;
            this.gridUserReminderRights.OptionsCustomization.AllowColumnResizing = false;
            this.gridUserReminderRights.OptionsCustomization.AllowFilter = false;
            this.gridUserReminderRights.OptionsCustomization.AllowGroup = false;
            this.gridUserReminderRights.OptionsCustomization.AllowSort = false;
            this.gridUserReminderRights.OptionsView.EnableAppearanceEvenRow = true;
            this.gridUserReminderRights.OptionsView.EnableAppearanceOddRow = true;
            this.gridUserReminderRights.OptionsView.ShowGroupPanel = false;
            this.gridUserReminderRights.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit6;
            this.gridColumn1.FieldName = "Granted";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 42;
            // 
            // repositoryItemCheckEdit6
            // 
            this.repositoryItemCheckEdit6.AutoHeight = false;
            this.repositoryItemCheckEdit6.Name = "repositoryItemCheckEdit6";
            this.repositoryItemCheckEdit6.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Description";
            this.gridColumn4.FieldName = "RemMessage";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 789;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Id";
            this.gridColumn5.FieldName = "RemId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // tabUserGlobalParameterRights
            // 
            this.tabUserGlobalParameterRights.Controls.Add(this.gctUserGlobalParameterRights);
            this.tabUserGlobalParameterRights.Location = new System.Drawing.Point(4, 22);
            this.tabUserGlobalParameterRights.Name = "tabUserGlobalParameterRights";
            this.tabUserGlobalParameterRights.Size = new System.Drawing.Size(708, 340);
            this.tabUserGlobalParameterRights.TabIndex = 6;
            this.tabUserGlobalParameterRights.Text = "Other Parameters";
            this.tabUserGlobalParameterRights.UseVisualStyleBackColor = true;
            // 
            // gctUserGlobalParameterRights
            // 
            this.gctUserGlobalParameterRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctUserGlobalParameterRights.EmbeddedNavigator.Name = "";
            this.gctUserGlobalParameterRights.Location = new System.Drawing.Point(5, 6);
            this.gctUserGlobalParameterRights.MainView = this.gridUserGlobalParameterRights;
            this.gctUserGlobalParameterRights.Name = "gctUserGlobalParameterRights";
            this.gctUserGlobalParameterRights.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit8});
            this.gctUserGlobalParameterRights.Size = new System.Drawing.Size(699, 328);
            this.gctUserGlobalParameterRights.TabIndex = 4;
            this.gctUserGlobalParameterRights.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserGlobalParameterRights});
            // 
            // gridUserGlobalParameterRights
            // 
            this.gridUserGlobalParameterRights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridUserGlobalParameterRights.GridControl = this.gctUserGlobalParameterRights;
            this.gridUserGlobalParameterRights.Name = "gridUserGlobalParameterRights";
            this.gridUserGlobalParameterRights.OptionsCustomization.AllowColumnMoving = false;
            this.gridUserGlobalParameterRights.OptionsCustomization.AllowColumnResizing = false;
            this.gridUserGlobalParameterRights.OptionsCustomization.AllowFilter = false;
            this.gridUserGlobalParameterRights.OptionsCustomization.AllowGroup = false;
            this.gridUserGlobalParameterRights.OptionsCustomization.AllowSort = false;
            this.gridUserGlobalParameterRights.OptionsView.EnableAppearanceEvenRow = true;
            this.gridUserGlobalParameterRights.OptionsView.EnableAppearanceOddRow = true;
            this.gridUserGlobalParameterRights.OptionsView.ShowGroupPanel = false;
            this.gridUserGlobalParameterRights.OptionsView.ShowIndicator = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.ColumnEdit = this.repositoryItemCheckEdit8;
            this.gridColumn9.FieldName = "Granted";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 42;
            // 
            // repositoryItemCheckEdit8
            // 
            this.repositoryItemCheckEdit8.AutoHeight = false;
            this.repositoryItemCheckEdit8.Name = "repositoryItemCheckEdit8";
            this.repositoryItemCheckEdit8.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Description";
            this.gridColumn10.FieldName = "Description";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 789;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Id";
            this.gridColumn11.FieldName = "Id";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // frmUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(744, 628);
            this.Controls.Add(this.tctRights);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkUserAll);
            this.Controls.Add(this.userIdLookUpEdit);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.tspUserAdmin);
            this.Controls.Add(this.isActiveCheckBox);
            this.Name = "frmUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Administration Form";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserAdmin_KeyDown);
            this.tspUserAdmin.ResumeLayout(false);
            this.tspUserAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIdLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tctRights.ResumeLayout(false);
            this.tabUserRights.ResumeLayout(false);
            this.tabUserRights.PerformLayout();
            this.tspUserRights.ResumeLayout(false);
            this.tspUserRights.PerformLayout();
            this.tctUserRights.ResumeLayout(false);
            this.tabUserMenuRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUserMenuRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserMenuRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.tabUserRoleRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUserRoleRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRoleRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.tabUserReportRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUserReportRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserReportRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit7)).EndInit();
            this.tabUserReminderRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUserReminderRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserReminderRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).EndInit();
            this.tabUserGlobalParameterRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctUserGlobalParameterRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserGlobalParameterRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspUserAdmin;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton1;
        private System.Windows.Forms.CheckBox chkUserAll;
        private DevExpress.XtraEditors.LookUpEdit userIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.CheckBox alreadyLoginCheckBox;
        private System.Windows.Forms.DateTimePicker passwordChangedOnDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastLoginDateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TabControl tctRights;
        private System.Windows.Forms.TabPage tabUserRights;
        private System.Windows.Forms.ToolStrip tspUserRights;
        private System.Windows.Forms.ToolStripButton checkAllToolStripButton;
        private System.Windows.Forms.ToolStripButton checkNoneToolStripButton;
        private System.Windows.Forms.ToolStripButton checkRefreshToolStripButton;
        private System.Windows.Forms.TabControl tctUserRights;
        private System.Windows.Forms.TabPage tabUserMenuRights;
        private DevExpress.XtraGrid.GridControl gctUserMenuRights;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserMenuRights;
        private DevExpress.XtraGrid.Columns.GridColumn colGranted;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApplication;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
        private System.Windows.Forms.TabPage tabUserRoleRights;
        private DevExpress.XtraGrid.GridControl gctUserRoleRights;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserRoleRights;
        private DevExpress.XtraGrid.Columns.GridColumn colGranted1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colApplication1;
        private DevExpress.XtraGrid.Columns.GridColumn colForUnitType;
        private System.Windows.Forms.TabPage tabUserReportRights;
        private DevExpress.XtraGrid.GridControl gctUserReportRights;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserReportRights;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.TabPage tabUserReminderRights;
        private DevExpress.XtraGrid.GridControl gctUserReminderRights;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserReminderRights;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.TabPage tabUserGlobalParameterRights;
        private DevExpress.XtraGrid.GridControl gctUserGlobalParameterRights;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserGlobalParameterRights;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.CheckBox UserIsLockedCheckBox;
    }
}