namespace SHM
{
    partial class frmReportSelection
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
            this.gctRepSelection = new DevExpress.XtraGrid.GridControl();
            this.gridRepSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gctRepSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // gctRepSelection
            // 
            this.gctRepSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctRepSelection.EmbeddedNavigator.Name = "";
            this.gctRepSelection.Location = new System.Drawing.Point(0, 0);
            this.gctRepSelection.MainView = this.gridRepSelection;
            this.gctRepSelection.Name = "gctRepSelection";
            this.gctRepSelection.Size = new System.Drawing.Size(723, 483);
            this.gctRepSelection.TabIndex = 2;
            this.gctRepSelection.TabStop = false;
            this.gctRepSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRepSelection});
            this.gctRepSelection.DoubleClick += new System.EventHandler(this.gridRepSelection_DoubleClick);
            this.gctRepSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridRepSelection_KeyDown);
            // 
            // gridRepSelection
            // 
            this.gridRepSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepId,
            this.colRepName});
            this.gridRepSelection.GridControl = this.gctRepSelection;
            this.gridRepSelection.Name = "gridRepSelection";
            this.gridRepSelection.OptionsBehavior.Editable = false;
            this.gridRepSelection.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridRepSelection.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridRepSelection.OptionsView.ColumnAutoWidth = false;
            this.gridRepSelection.OptionsView.ShowGroupPanel = false;
            // 
            // colRepId
            // 
            this.colRepId.Caption = "Id";
            this.colRepId.FieldName = "RepId";
            this.colRepId.Name = "colRepId";
            this.colRepId.Visible = true;
            this.colRepId.VisibleIndex = 1;
            // 
            // colRepName
            // 
            this.colRepName.Caption = "Name";
            this.colRepName.FieldName = "RepName";
            this.colRepName.Name = "colRepName";
            this.colRepName.Visible = true;
            this.colRepName.VisibleIndex = 0;
            this.colRepName.Width = 627;
            // 
            // frmReportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 483);
            this.Controls.Add(this.gctRepSelection);
            this.Name = "frmReportSelection";
            this.Text = "frmReportSelection";
            this.Load += new System.EventHandler(this.frmReportSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctRepSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctRepSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRepSelection;
        private DevExpress.XtraGrid.Columns.GridColumn colRepId;
        private DevExpress.XtraGrid.Columns.GridColumn colRepName;
    }
}