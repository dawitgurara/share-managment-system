namespace SHM
{
    partial class frmReminderSelection
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
            this.gctRemSelection = new DevExpress.XtraGrid.GridControl();
            this.gridRemSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRepId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gctRemSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // gctRemSelection
            // 
            this.gctRemSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctRemSelection.EmbeddedNavigator.Name = "";
            this.gctRemSelection.Location = new System.Drawing.Point(0, 0);
            this.gctRemSelection.MainView = this.gridRemSelection;
            this.gctRemSelection.Name = "gctRemSelection";
            this.gctRemSelection.Size = new System.Drawing.Size(755, 402);
            this.gctRemSelection.TabIndex = 3;
            this.gctRemSelection.TabStop = false;
            this.gctRemSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRemSelection});
            // 
            // gridRemSelection
            // 
            this.gridRemSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepId,
            this.colRepName});
            this.gridRemSelection.GridControl = this.gctRemSelection;
            this.gridRemSelection.Name = "gridRemSelection";
            this.gridRemSelection.OptionsBehavior.Editable = false;
            this.gridRemSelection.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridRemSelection.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridRemSelection.OptionsView.ColumnAutoWidth = false;
            this.gridRemSelection.OptionsView.ShowColumnHeaders = false;
            this.gridRemSelection.OptionsView.ShowGroupPanel = false;
            this.gridRemSelection.OptionsView.ShowIndicator = false;
            // 
            // colRepId
            // 
            this.colRepId.Caption = "Id";
            this.colRepId.FieldName = "RemId";
            this.colRepId.Name = "colRepId";
            this.colRepId.Visible = true;
            this.colRepId.VisibleIndex = 1;
            // 
            // colRepName
            // 
            this.colRepName.Caption = "Name";
            this.colRepName.FieldName = "RemMessage";
            this.colRepName.Name = "colRepName";
            this.colRepName.Visible = true;
            this.colRepName.VisibleIndex = 0;
            this.colRepName.Width = 627;
            // 
            // frmReminderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 402);
            this.Controls.Add(this.gctRemSelection);
            this.Name = "frmReminderSelection";
            this.Text = "frmReminderSelection";
            ((System.ComponentModel.ISupportInitialize)(this.gctRemSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctRemSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRemSelection;
        private DevExpress.XtraGrid.Columns.GridColumn colRepId;
        private DevExpress.XtraGrid.Columns.GridColumn colRepName;
    }
}