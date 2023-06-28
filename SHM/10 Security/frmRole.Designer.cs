namespace SHM
{
    partial class frmRole
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
            System.Windows.Forms.Label allowanceDescLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            this.tspRoleType = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gctRoleTypes = new DevExpress.XtraGrid.GridControl();
            this.gridRoleTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            allowanceDescLabel = new System.Windows.Forms.Label();
            this.tspRoleType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctRoleTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeId)).BeginInit();
            this.SuspendLayout();
            // 
            // allowanceDescLabel
            // 
            allowanceDescLabel.AutoSize = true;
            allowanceDescLabel.Location = new System.Drawing.Point(64, 52);
            allowanceDescLabel.Name = "allowanceDescLabel";
            allowanceDescLabel.Size = new System.Drawing.Size(63, 13);
            allowanceDescLabel.TabIndex = 8;
            allowanceDescLabel.Text = "Role Name:";
            // 
            // tspRoleType
            // 
            this.tspRoleType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspRoleType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.refreshToolStripButton});
            this.tspRoleType.Location = new System.Drawing.Point(0, 0);
            this.tspRoleType.Name = "tspRoleType";
            this.tspRoleType.Size = new System.Drawing.Size(632, 25);
            this.tspRoleType.TabIndex = 11;
            this.tspRoleType.TabStop = true;
            this.tspRoleType.Text = "toolStrip1";
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
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton.Text = "&Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roleNameTextBox.Location = new System.Drawing.Point(133, 50);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(356, 20);
            this.roleNameTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gctRoleTypes);
            this.groupBox2.Location = new System.Drawing.Point(22, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 255);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role Types";
            // 
            // gctRoleTypes
            // 
            this.gctRoleTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctRoleTypes.EmbeddedNavigator.Name = "";
            this.gctRoleTypes.Location = new System.Drawing.Point(6, 19);
            this.gctRoleTypes.MainView = this.gridRoleTypes;
            this.gctRoleTypes.Name = "gctRoleTypes";
            this.gctRoleTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluTypeId});
            this.gctRoleTypes.Size = new System.Drawing.Size(575, 230);
            this.gctRoleTypes.TabIndex = 0;
            this.gctRoleTypes.TabStop = false;
            this.gctRoleTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRoleTypes});
            this.gctRoleTypes.DoubleClick += new System.EventHandler(this.gridRoleTypes_DoubleClick);
            // 
            // gridRoleTypes
            // 
            this.gridRoleTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colRoleName});
            this.gridRoleTypes.GridControl = this.gctRoleTypes;
            this.gridRoleTypes.Name = "gridRoleTypes";
            this.gridRoleTypes.OptionsBehavior.Editable = false;
            this.gridRoleTypes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridRoleTypes.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridRoleTypes.OptionsView.ColumnAutoWidth = false;
            this.gridRoleTypes.OptionsView.ShowGroupPanel = false;
            this.gridRoleTypes.DoubleClick += new System.EventHandler(this.gridRoleTypes_DoubleClick);
            // 
            // colRoleId
            // 
            this.colRoleId.Caption = "Role Id";
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.OptionsColumn.ReadOnly = true;
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            this.colRoleId.Width = 53;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Role Name";
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 503;
            // 
            // rluTypeId
            // 
            this.rluTypeId.AutoHeight = false;
            this.rluTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluTypeId.DisplayMember = "PayTypeDesc";
            this.rluTypeId.Name = "rluTypeId";
            this.rluTypeId.NullText = "";
            this.rluTypeId.ValueMember = "ID";
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(632, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(allowanceDescLabel);
            this.Controls.Add(this.roleNameTextBox);
            this.Controls.Add(this.tspRoleType);
            this.Name = "frmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRole";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoles_KeyDown);
            this.tspRoleType.ResumeLayout(false);
            this.tspRoleType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctRoleTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspRoleType;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gctRoleTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRoleTypes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
    }
}