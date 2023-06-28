namespace SHM
{
    partial class frmReportPreview
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
            this.ctrlReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ctrlReportViewer
            // 
            this.ctrlReportViewer.ActiveViewIndex = -1;
            this.ctrlReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrlReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ctrlReportViewer.Name = "ctrlReportViewer";
            this.ctrlReportViewer.SelectionFormula = "";
            this.ctrlReportViewer.Size = new System.Drawing.Size(1028, 670);
            this.ctrlReportViewer.TabIndex = 0;
            this.ctrlReportViewer.ViewTimeSelectionFormula = "";
            // 
            // frmReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 670);
            this.Controls.Add(this.ctrlReportViewer);
            this.Name = "frmReportPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportPreview";
            this.Load += new System.EventHandler(this.frmReportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ctrlReportViewer;
    }
}