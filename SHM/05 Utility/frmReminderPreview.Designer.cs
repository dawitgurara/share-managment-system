namespace SHM
{
    partial class frmReminderPreview
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
            this.gctRemPreview = new DevExpress.XtraGrid.GridControl();
            this.gridRemPreview = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gctRemPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // gctRemPreview
            // 
            this.gctRemPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctRemPreview.EmbeddedNavigator.Name = "";
            this.gctRemPreview.Location = new System.Drawing.Point(0, 0);
            this.gctRemPreview.MainView = this.gridRemPreview;
            this.gctRemPreview.Name = "gctRemPreview";
            this.gctRemPreview.Size = new System.Drawing.Size(805, 450);
            this.gctRemPreview.TabIndex = 4;
            this.gctRemPreview.TabStop = false;
            this.gctRemPreview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRemPreview});
            // 
            // gridRemPreview
            // 
            this.gridRemPreview.GridControl = this.gctRemPreview;
            this.gridRemPreview.Name = "gridRemPreview";
            this.gridRemPreview.OptionsBehavior.Editable = false;
            this.gridRemPreview.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridRemPreview.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridRemPreview.OptionsView.ColumnAutoWidth = false;
            this.gridRemPreview.OptionsView.ShowGroupPanel = false;
            // 
            // frmReminderPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.gctRemPreview);
            this.Name = "frmReminderPreview";
            this.Text = "frmReminderPreview";
            ((System.ComponentModel.ISupportInitialize)(this.gctRemPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctRemPreview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRemPreview;
    }
}