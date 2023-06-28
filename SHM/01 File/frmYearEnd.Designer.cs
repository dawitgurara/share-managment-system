namespace SHM
{
    partial class frmYearEnd
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
            System.Windows.Forms.Label budgetYearLabel;
            this.FiscalYearLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.btnYearEnd = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            budgetYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetYearLabel
            // 
            budgetYearLabel.AutoSize = true;
            budgetYearLabel.Location = new System.Drawing.Point(41, 15);
            budgetYearLabel.Name = "budgetYearLabel";
            budgetYearLabel.Size = new System.Drawing.Size(62, 13);
            budgetYearLabel.TabIndex = 2;
            budgetYearLabel.Text = "Fiscal Year:";
            // 
            // FiscalYearLookUpEdit
            // 
            this.FiscalYearLookUpEdit.Location = new System.Drawing.Point(109, 12);
            this.FiscalYearLookUpEdit.Name = "FiscalYearLookUpEdit";
            this.FiscalYearLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.FiscalYearLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FiscalYearLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FiscalYear", "Fiscal Year", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.FiscalYearLookUpEdit.Properties.DisplayMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Properties.NullText = "";
            this.FiscalYearLookUpEdit.Properties.ShowHeader = false;
            this.FiscalYearLookUpEdit.Properties.ValueMember = "FiscalYear";
            this.FiscalYearLookUpEdit.Size = new System.Drawing.Size(220, 20);
            this.FiscalYearLookUpEdit.TabIndex = 1;
            this.FiscalYearLookUpEdit.EditValueChanged += new System.EventHandler(this.budgetYearLookUpEdit_EditValueChanged);
            // 
            // btnYearEnd
            // 
            this.btnYearEnd.Location = new System.Drawing.Point(143, 91);
            this.btnYearEnd.Name = "btnYearEnd";
            this.btnYearEnd.Size = new System.Drawing.Size(130, 23);
            this.btnYearEnd.TabIndex = 6;
            this.btnYearEnd.Text = "Do Year End";
            this.btnYearEnd.UseVisualStyleBackColor = true;
            this.btnYearEnd.Click += new System.EventHandler(this.btnYearEnd_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(41, 52);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 13);
            this.statusLabel.TabIndex = 127;
            this.statusLabel.Text = "Ready";
            // 
            // frmYearEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(473, 176);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btnYearEnd);
            this.Controls.Add(budgetYearLabel);
            this.Controls.Add(this.FiscalYearLookUpEdit);
            this.Name = "frmYearEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year End";
            this.Load += new System.EventHandler(this.frmYearEnd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYearEnd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FiscalYearLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit FiscalYearLookUpEdit;
        private System.Windows.Forms.Button btnYearEnd;
        private System.Windows.Forms.Label statusLabel;
    }
}