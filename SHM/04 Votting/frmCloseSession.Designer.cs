namespace SHM
{
    partial class frmCloseSession
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
            System.Windows.Forms.Label SessionLabel;
            this.SessionIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.CloseButton = new System.Windows.Forms.Button();
            SessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionLabel
            // 
            SessionLabel.AutoSize = true;
            SessionLabel.Location = new System.Drawing.Point(11, 41);
            SessionLabel.Name = "SessionLabel";
            SessionLabel.Size = new System.Drawing.Size(47, 13);
            SessionLabel.TabIndex = 2;
            SessionLabel.Text = "Session:";
            // 
            // SessionIdLookUpEdit
            // 
            this.SessionIdLookUpEdit.Location = new System.Drawing.Point(61, 37);
            this.SessionIdLookUpEdit.Name = "SessionIdLookUpEdit";
            this.SessionIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.SessionIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SessionIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionId", "Session Id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeOfMeeting", "Meeting Type", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SessionNane", "Session Nane", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Venue", "Venue", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.SessionIdLookUpEdit.Properties.DisplayMember = "SessionNane";
            this.SessionIdLookUpEdit.Properties.NullText = "";
            this.SessionIdLookUpEdit.Properties.ShowHeader = false;
            this.SessionIdLookUpEdit.Properties.ValueMember = "SessionId";
            this.SessionIdLookUpEdit.Size = new System.Drawing.Size(540, 20);
            this.SessionIdLookUpEdit.TabIndex = 1;
            this.SessionIdLookUpEdit.EditValueChanged += new System.EventHandler(this.SessionIdLookUpEdit_EditValueChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(212, 84);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(114, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close Session";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // frmCloseSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(613, 146);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(SessionLabel);
            this.Controls.Add(this.SessionIdLookUpEdit);
            this.Name = "frmCloseSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Session";
            this.Load += new System.EventHandler(this.frmCloseSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionIdLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit SessionIdLookUpEdit;
        private System.Windows.Forms.Button CloseButton;
    }
}