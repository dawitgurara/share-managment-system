namespace SHM
{
    partial class frmReminderSetup
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
            System.Windows.Forms.Label remIdLabel;
            System.Windows.Forms.Label remMessageLabel;
            System.Windows.Forms.Label dataSourceLabel;
            System.Windows.Forms.Label repIdLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReminderSetup));
            this.tspRemindSetup = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.remIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.remMessageTextBox = new System.Windows.Forms.TextBox();
            this.remIdTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            remIdLabel = new System.Windows.Forms.Label();
            remMessageLabel = new System.Windows.Forms.Label();
            dataSourceLabel = new System.Windows.Forms.Label();
            repIdLabel1 = new System.Windows.Forms.Label();
            this.tspRemindSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remIdLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remIdLabel
            // 
            remIdLabel.AutoSize = true;
            remIdLabel.Location = new System.Drawing.Point(42, 23);
            remIdLabel.Name = "remIdLabel";
            remIdLabel.Size = new System.Drawing.Size(67, 13);
            remIdLabel.TabIndex = 0;
            remIdLabel.Text = "Reminder Id:";
            // 
            // remMessageLabel
            // 
            remMessageLabel.AutoSize = true;
            remMessageLabel.Location = new System.Drawing.Point(56, 48);
            remMessageLabel.Name = "remMessageLabel";
            remMessageLabel.Size = new System.Drawing.Size(53, 13);
            remMessageLabel.TabIndex = 2;
            remMessageLabel.Text = "Message:";
            // 
            // dataSourceLabel
            // 
            dataSourceLabel.AutoSize = true;
            dataSourceLabel.Location = new System.Drawing.Point(39, 74);
            dataSourceLabel.Name = "dataSourceLabel";
            dataSourceLabel.Size = new System.Drawing.Size(70, 13);
            dataSourceLabel.TabIndex = 4;
            dataSourceLabel.Text = "Data Source:";
            // 
            // repIdLabel1
            // 
            repIdLabel1.AutoSize = true;
            repIdLabel1.Location = new System.Drawing.Point(18, 46);
            repIdLabel1.Name = "repIdLabel1";
            repIdLabel1.Size = new System.Drawing.Size(100, 13);
            repIdLabel1.TabIndex = 36;
            repIdLabel1.Text = "Selected Reminder:";
            // 
            // tspRemindSetup
            // 
            this.tspRemindSetup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspRemindSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.checkToolStripButton});
            this.tspRemindSetup.Location = new System.Drawing.Point(0, 0);
            this.tspRemindSetup.Name = "tspRemindSetup";
            this.tspRemindSetup.Size = new System.Drawing.Size(636, 25);
            this.tspRemindSetup.TabIndex = 4;
            this.tspRemindSetup.TabStop = true;
            this.tspRemindSetup.Text = "toolStrip1";
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
            // checkToolStripButton
            // 
            this.checkToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkToolStripButton.Image")));
            this.checkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkToolStripButton.Name = "checkToolStripButton";
            this.checkToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.checkToolStripButton.Text = "Check";
            this.checkToolStripButton.Click += new System.EventHandler(this.checkToolStripButton_Click);
            // 
            // remIdLookUpEdit
            // 
            this.remIdLookUpEdit.Location = new System.Drawing.Point(124, 43);
            this.remIdLookUpEdit.Name = "remIdLookUpEdit";
            this.remIdLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.remIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.remIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RemId", "Id", 5),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RemMessage", "Message", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.remIdLookUpEdit.Properties.DisplayMember = "RemMessage";
            this.remIdLookUpEdit.Properties.NullText = "";
            this.remIdLookUpEdit.Properties.ValueMember = "RemId";
            this.remIdLookUpEdit.Size = new System.Drawing.Size(460, 20);
            this.remIdLookUpEdit.TabIndex = 34;
            this.remIdLookUpEdit.EditValueChanged += new System.EventHandler(this.remIdLookUpEdit_EditValueChanged);
            this.remIdLookUpEdit.EnabledChanged += new System.EventHandler(this.remIdLookUpEdit_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataSourceTextBox);
            this.groupBox1.Controls.Add(this.remMessageTextBox);
            this.groupBox1.Controls.Add(this.remIdTextBox);
            this.groupBox1.Controls.Add(remIdLabel);
            this.groupBox1.Controls.Add(remMessageLabel);
            this.groupBox1.Controls.Add(dataSourceLabel);
            this.groupBox1.Controls.Add(this.isActiveCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 420);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reminder Detail";
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataSourceTextBox.Location = new System.Drawing.Point(112, 71);
            this.dataSourceTextBox.Multiline = true;
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(417, 343);
            this.dataSourceTextBox.TabIndex = 161;
            // 
            // remMessageTextBox
            // 
            this.remMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remMessageTextBox.Location = new System.Drawing.Point(112, 45);
            this.remMessageTextBox.Name = "remMessageTextBox";
            this.remMessageTextBox.Size = new System.Drawing.Size(417, 20);
            this.remMessageTextBox.TabIndex = 160;
            // 
            // remIdTextBox
            // 
            this.remIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remIdTextBox.Location = new System.Drawing.Point(112, 20);
            this.remIdTextBox.Name = "remIdTextBox";
            this.remIdTextBox.ReadOnly = true;
            this.remIdTextBox.Size = new System.Drawing.Size(103, 20);
            this.remIdTextBox.TabIndex = 159;
            this.remIdTextBox.Validated += new System.EventHandler(this.remIdTextBox_Validated);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Location = new System.Drawing.Point(477, 16);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(52, 24);
            this.isActiveCheckBox.TabIndex = 1;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmReminderSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(636, 491);
            this.Controls.Add(this.remIdLookUpEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(repIdLabel1);
            this.Controls.Add(this.tspRemindSetup);
            this.Name = "frmReminderSetup";
            this.Text = "frmReminderSetup";
            this.Load += new System.EventHandler(this.frmReminderSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReminderSetup_KeyDown);
            this.tspRemindSetup.ResumeLayout(false);
            this.tspRemindSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remIdLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspRemindSetup;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripButton checkToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit remIdLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox remMessageTextBox;
        private System.Windows.Forms.TextBox remIdTextBox;
    }
}