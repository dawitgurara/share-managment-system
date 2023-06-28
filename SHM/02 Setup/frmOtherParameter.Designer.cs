namespace SHM
{
    partial class frmOtherParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherParameter));
            this.tspGlobalParameter = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gctOtherParameter = new DevExpress.XtraGrid.GridControl();
            this.gridGlobalParameter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctParameterValue = new DevExpress.XtraGrid.GridControl();
            this.gridParameterValue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tspGlobalParameter.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctOtherParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGlobalParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctParameterValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameterValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tspGlobalParameter
            // 
            this.tspGlobalParameter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.tspGlobalParameter.Location = new System.Drawing.Point(0, 0);
            this.tspGlobalParameter.Name = "tspGlobalParameter";
            this.tspGlobalParameter.Size = new System.Drawing.Size(988, 25);
            this.tspGlobalParameter.TabIndex = 4;
            this.tspGlobalParameter.TabStop = true;
            this.tspGlobalParameter.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Visible = false;
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
            this.printToolStripButton.Size = new System.Drawing.Size(96, 22);
            this.printToolStripButton.Text = "&Print Preview";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(99, 22);
            this.toolStripTextBox1.Text = "Parameter Type";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gctOtherParameter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gctParameterValue);
            this.splitContainer1.Size = new System.Drawing.Size(988, 425);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 5;
            // 
            // gctOtherParameter
            // 
            this.gctOtherParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctOtherParameter.EmbeddedNavigator.Name = "";
            this.gctOtherParameter.Location = new System.Drawing.Point(0, 0);
            this.gctOtherParameter.MainView = this.gridGlobalParameter;
            this.gctOtherParameter.Name = "gctOtherParameter";
            this.gctOtherParameter.Size = new System.Drawing.Size(199, 425);
            this.gctOtherParameter.TabIndex = 55;
            this.gctOtherParameter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGlobalParameter});
            this.gctOtherParameter.Click += new System.EventHandler(this.gridOtherParameter_Click);
            // 
            // gridGlobalParameter
            // 
            this.gridGlobalParameter.ActiveFilterEnabled = false;
            this.gridGlobalParameter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescription,
            this.colTableName});
            this.gridGlobalParameter.GridControl = this.gctOtherParameter;
            this.gridGlobalParameter.Name = "gridGlobalParameter";
            this.gridGlobalParameter.OptionsBehavior.Editable = false;
            this.gridGlobalParameter.OptionsCustomization.AllowColumnMoving = false;
            this.gridGlobalParameter.OptionsCustomization.AllowFilter = false;
            this.gridGlobalParameter.OptionsCustomization.AllowGroup = false;
            this.gridGlobalParameter.OptionsCustomization.AllowSort = false;
            this.gridGlobalParameter.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridGlobalParameter.OptionsSelection.UseIndicatorForSelection = false;
            this.gridGlobalParameter.OptionsView.ColumnAutoWidth = false;
            this.gridGlobalParameter.OptionsView.ShowGroupPanel = false;
            this.gridGlobalParameter.OptionsView.ShowHorzLines = false;
            this.gridGlobalParameter.OptionsView.ShowIndicator = false;
            this.gridGlobalParameter.OptionsView.ShowVertLines = false;
            this.gridGlobalParameter.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridOtherParameter_FocusedRowChanged);
            this.gridGlobalParameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridOtherParameter_KeyDown);
            this.gridGlobalParameter.Click += new System.EventHandler(this.gridOtherParameter_Click);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Parameter Type";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 199;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "TableName";
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            // 
            // gctParameterValue
            // 
            this.gctParameterValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctParameterValue.EmbeddedNavigator.Name = "";
            this.gctParameterValue.Location = new System.Drawing.Point(0, 0);
            this.gctParameterValue.MainView = this.gridParameterValue;
            this.gctParameterValue.Name = "gctParameterValue";
            this.gctParameterValue.Size = new System.Drawing.Size(785, 425);
            this.gctParameterValue.TabIndex = 55;
            this.gctParameterValue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridParameterValue});
            // 
            // gridParameterValue
            // 
            this.gridParameterValue.ActiveFilterEnabled = false;
            this.gridParameterValue.GridControl = this.gctParameterValue;
            this.gridParameterValue.Name = "gridParameterValue";
            this.gridParameterValue.OptionsCustomization.AllowFilter = false;
            this.gridParameterValue.OptionsCustomization.AllowGroup = false;
            this.gridParameterValue.OptionsCustomization.AllowSort = false;
            this.gridParameterValue.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridParameterValue.OptionsView.ColumnAutoWidth = false;
            this.gridParameterValue.OptionsView.EnableAppearanceEvenRow = true;
            this.gridParameterValue.OptionsView.EnableAppearanceOddRow = true;
            this.gridParameterValue.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridParameterValue.OptionsView.ShowGroupPanel = false;
            this.gridParameterValue.OptionsView.ShowHorzLines = false;
            this.gridParameterValue.OptionsView.ShowVertLines = false;
            this.gridParameterValue.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridParameterValue_InitNewRow);
            this.gridParameterValue.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridParameterValue_FocusedRowChanged);
            this.gridParameterValue.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridParameterValue_CellValueChanged);
            this.gridParameterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridOtherParameter_KeyDown);
            // 
            // frmOtherParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspGlobalParameter);
            this.Name = "frmOtherParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGlobalParameter";
            this.Load += new System.EventHandler(this.frmOtherParameter_Load);
            this.tspGlobalParameter.ResumeLayout(false);
            this.tspGlobalParameter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctOtherParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGlobalParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctParameterValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameterValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspGlobalParameter;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gctOtherParameter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGlobalParameter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.GridControl gctParameterValue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridParameterValue;
    }
}