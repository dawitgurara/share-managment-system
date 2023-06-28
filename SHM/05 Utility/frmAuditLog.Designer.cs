namespace SHM
{
    partial class frmAuditLog
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label fieldNameLabel;
            System.Windows.Forms.Label dataObjNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditLog));
            this.tspAuditLog = new System.Windows.Forms.ToolStrip();
            this.showToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.keyFldLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.actionTakenLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.fldChgLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tblNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gctAuditLog = new DevExpress.XtraGrid.GridControl();
            this.gridAuditLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTblName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyFld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionTaken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFldChg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogWs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            fieldNameLabel = new System.Windows.Forms.Label();
            dataObjNameLabel = new System.Windows.Forms.Label();
            this.tspAuditLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyFldLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionTakenLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fldChgLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctAuditLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuditLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(303, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 13);
            label4.TabIndex = 35;
            label4.Text = "Key Field Value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(601, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 34;
            label3.Text = "To Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(591, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 33;
            label2.Text = "From Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(341, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 32;
            label1.Text = "Action:";
            // 
            // fieldNameLabel
            // 
            fieldNameLabel.AutoSize = true;
            fieldNameLabel.Location = new System.Drawing.Point(47, 67);
            fieldNameLabel.Name = "fieldNameLabel";
            fieldNameLabel.Size = new System.Drawing.Size(45, 13);
            fieldNameLabel.TabIndex = 31;
            fieldNameLabel.Text = "Column:";
            // 
            // dataObjNameLabel
            // 
            dataObjNameLabel.AutoSize = true;
            dataObjNameLabel.Location = new System.Drawing.Point(55, 41);
            dataObjNameLabel.Name = "dataObjNameLabel";
            dataObjNameLabel.Size = new System.Drawing.Size(37, 13);
            dataObjNameLabel.TabIndex = 30;
            dataObjNameLabel.Text = "Table:";
            // 
            // tspAuditLog
            // 
            this.tspAuditLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tspAuditLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton});
            this.tspAuditLog.Location = new System.Drawing.Point(0, 0);
            this.tspAuditLog.Name = "tspAuditLog";
            this.tspAuditLog.Size = new System.Drawing.Size(1074, 25);
            this.tspAuditLog.TabIndex = 7;
            this.tspAuditLog.TabStop = true;
            this.tspAuditLog.Text = "toolStrip1";
            // 
            // showToolStripButton
            // 
            this.showToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripButton.Image")));
            this.showToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showToolStripButton.Name = "showToolStripButton";
            this.showToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.showToolStripButton.Text = "&Show Log";
            this.showToolStripButton.Click += new System.EventHandler(this.showToolStripButton_Click);
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
            // keyFldLookUpEdit
            // 
            this.keyFldLookUpEdit.Location = new System.Drawing.Point(392, 64);
            this.keyFldLookUpEdit.Name = "keyFldLookUpEdit";
            this.keyFldLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.keyFldLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.keyFldLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KeyValue", "Key Value", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.keyFldLookUpEdit.Properties.DisplayMember = "KeyValue";
            this.keyFldLookUpEdit.Properties.NullText = "";
            this.keyFldLookUpEdit.Properties.ShowFooter = false;
            this.keyFldLookUpEdit.Properties.ShowHeader = false;
            this.keyFldLookUpEdit.Properties.ValueMember = "KeyValue";
            this.keyFldLookUpEdit.Size = new System.Drawing.Size(141, 20);
            this.keyFldLookUpEdit.TabIndex = 29;
            // 
            // actionTakenLookUpEdit
            // 
            this.actionTakenLookUpEdit.Location = new System.Drawing.Point(392, 38);
            this.actionTakenLookUpEdit.Name = "actionTakenLookUpEdit";
            this.actionTakenLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.actionTakenLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.actionTakenLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionName", "Action", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.actionTakenLookUpEdit.Properties.DisplayMember = "ActionName";
            this.actionTakenLookUpEdit.Properties.NullText = "";
            this.actionTakenLookUpEdit.Properties.ShowFooter = false;
            this.actionTakenLookUpEdit.Properties.ShowHeader = false;
            this.actionTakenLookUpEdit.Properties.ValueMember = "ActionName";
            this.actionTakenLookUpEdit.Size = new System.Drawing.Size(141, 20);
            this.actionTakenLookUpEdit.TabIndex = 28;
            // 
            // fldChgLookUpEdit
            // 
            this.fldChgLookUpEdit.Location = new System.Drawing.Point(98, 64);
            this.fldChgLookUpEdit.Name = "fldChgLookUpEdit";
            this.fldChgLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fldChgLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fldChgLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColumnName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.fldChgLookUpEdit.Properties.DisplayMember = "ColumnName";
            this.fldChgLookUpEdit.Properties.NullText = "";
            this.fldChgLookUpEdit.Properties.ShowFooter = false;
            this.fldChgLookUpEdit.Properties.ShowHeader = false;
            this.fldChgLookUpEdit.Properties.ValueMember = "ColumnName";
            this.fldChgLookUpEdit.Size = new System.Drawing.Size(170, 20);
            this.fldChgLookUpEdit.TabIndex = 27;
            this.fldChgLookUpEdit.EditValueChanged += new System.EventHandler(this.fldChgLookUpEdit_EditValueChanged);
            // 
            // tblNameLookUpEdit
            // 
            this.tblNameLookUpEdit.Location = new System.Drawing.Point(98, 38);
            this.tblNameLookUpEdit.Name = "tblNameLookUpEdit";
            this.tblNameLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tblNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tblNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataObjName", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.tblNameLookUpEdit.Properties.DisplayMember = "DataObjName";
            this.tblNameLookUpEdit.Properties.DropDownRows = 10;
            this.tblNameLookUpEdit.Properties.NullText = "";
            this.tblNameLookUpEdit.Properties.ShowFooter = false;
            this.tblNameLookUpEdit.Properties.ShowHeader = false;
            this.tblNameLookUpEdit.Properties.ValueMember = "DataObjName";
            this.tblNameLookUpEdit.Size = new System.Drawing.Size(170, 20);
            this.tblNameLookUpEdit.TabIndex = 26;
            this.tblNameLookUpEdit.EditValueChanged += new System.EventHandler(this.tblNameLookUpEdit_EditValueChanged);
            // 
            // gctAuditLog
            // 
            this.gctAuditLog.EmbeddedNavigator.Name = "";
            this.gctAuditLog.Location = new System.Drawing.Point(0, 90);
            this.gctAuditLog.MainView = this.gridAuditLog;
            this.gctAuditLog.Name = "gctAuditLog";
            this.gctAuditLog.Size = new System.Drawing.Size(1074, 518);
            this.gctAuditLog.TabIndex = 36;
            this.gctAuditLog.TabStop = false;
            this.gctAuditLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAuditLog});
            // 
            // gridAuditLog
            // 
            this.gridAuditLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogId,
            this.colTblName,
            this.colKeyFld,
            this.colActionTaken,
            this.colFldChg,
            this.colOldValue,
            this.colNewValue,
            this.colUserId,
            this.colLogDt,
            this.colLogWs});
            this.gridAuditLog.GridControl = this.gctAuditLog;
            this.gridAuditLog.GroupPanelText = " ";
            this.gridAuditLog.Name = "gridAuditLog";
            this.gridAuditLog.OptionsBehavior.Editable = false;
            this.gridAuditLog.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridAuditLog.OptionsView.ColumnAutoWidth = false;
            this.gridAuditLog.OptionsView.EnableAppearanceEvenRow = true;
            this.gridAuditLog.OptionsView.EnableAppearanceOddRow = true;
            this.gridAuditLog.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridAuditLog.OptionsView.ShowGroupPanel = false;
            this.gridAuditLog.OptionsView.ShowHorzLines = false;
            this.gridAuditLog.OptionsView.ShowVertLines = false;
            // 
            // colLogId
            // 
            this.colLogId.Caption = "Log Id";
            this.colLogId.FieldName = "LogId";
            this.colLogId.Name = "colLogId";
            this.colLogId.OptionsColumn.ReadOnly = true;
            this.colLogId.Visible = true;
            this.colLogId.VisibleIndex = 0;
            this.colLogId.Width = 54;
            // 
            // colTblName
            // 
            this.colTblName.Caption = "Table ";
            this.colTblName.FieldName = "TblName";
            this.colTblName.Name = "colTblName";
            this.colTblName.Visible = true;
            this.colTblName.VisibleIndex = 1;
            this.colTblName.Width = 121;
            // 
            // colKeyFld
            // 
            this.colKeyFld.Caption = "Key Field Value";
            this.colKeyFld.FieldName = "KeyFld";
            this.colKeyFld.Name = "colKeyFld";
            this.colKeyFld.Visible = true;
            this.colKeyFld.VisibleIndex = 4;
            this.colKeyFld.Width = 110;
            // 
            // colActionTaken
            // 
            this.colActionTaken.Caption = "Action";
            this.colActionTaken.FieldName = "ActionTaken";
            this.colActionTaken.Name = "colActionTaken";
            this.colActionTaken.Visible = true;
            this.colActionTaken.VisibleIndex = 3;
            this.colActionTaken.Width = 112;
            // 
            // colFldChg
            // 
            this.colFldChg.Caption = "Column";
            this.colFldChg.FieldName = "FldChg";
            this.colFldChg.Name = "colFldChg";
            this.colFldChg.Visible = true;
            this.colFldChg.VisibleIndex = 2;
            this.colFldChg.Width = 132;
            // 
            // colOldValue
            // 
            this.colOldValue.Caption = "Old Value";
            this.colOldValue.FieldName = "OldValue";
            this.colOldValue.Name = "colOldValue";
            this.colOldValue.Visible = true;
            this.colOldValue.VisibleIndex = 5;
            this.colOldValue.Width = 103;
            // 
            // colNewValue
            // 
            this.colNewValue.Caption = "New Value";
            this.colNewValue.FieldName = "NewValue";
            this.colNewValue.Name = "colNewValue";
            this.colNewValue.Visible = true;
            this.colNewValue.VisibleIndex = 6;
            this.colNewValue.Width = 100;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "User Name";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 7;
            this.colUserId.Width = 103;
            // 
            // colLogDt
            // 
            this.colLogDt.Caption = "Log Date";
            this.colLogDt.FieldName = "LogDt";
            this.colLogDt.Name = "colLogDt";
            this.colLogDt.Visible = true;
            this.colLogDt.VisibleIndex = 8;
            this.colLogDt.Width = 90;
            // 
            // colLogWs
            // 
            this.colLogWs.Caption = "Log Workstation";
            this.colLogWs.FieldName = "LogWs";
            this.colLogWs.Name = "colLogWs";
            this.colLogWs.Visible = true;
            this.colLogWs.VisibleIndex = 9;
            this.colLogWs.Width = 136;
            // 
            // fromDateDateTimePicker
            // 
            this.fromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateDateTimePicker.Location = new System.Drawing.Point(656, 41);
            this.fromDateDateTimePicker.Name = "fromDateDateTimePicker";
            this.fromDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.fromDateDateTimePicker.TabIndex = 150;
            this.fromDateDateTimePicker.Value = new System.DateTime(2017, 9, 7, 0, 0, 0, 0);
            // 
            // toDateDateTimePicker
            // 
            this.toDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateDateTimePicker.Location = new System.Drawing.Point(656, 67);
            this.toDateDateTimePicker.Name = "toDateDateTimePicker";
            this.toDateDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.toDateDateTimePicker.TabIndex = 151;
            this.toDateDateTimePicker.Value = new System.DateTime(2017, 9, 7, 0, 0, 0, 0);
            // 
            // frmAuditLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1074, 606);
            this.Controls.Add(this.toDateDateTimePicker);
            this.Controls.Add(this.fromDateDateTimePicker);
            this.Controls.Add(this.gctAuditLog);
            this.Controls.Add(label4);
            this.Controls.Add(this.keyFldLookUpEdit);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.actionTakenLookUpEdit);
            this.Controls.Add(this.fldChgLookUpEdit);
            this.Controls.Add(fieldNameLabel);
            this.Controls.Add(dataObjNameLabel);
            this.Controls.Add(this.tblNameLookUpEdit);
            this.Controls.Add(this.tspAuditLog);
            this.Name = "frmAuditLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuditLog";
            this.Load += new System.EventHandler(this.frmAuditLog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAuditLog_KeyDown);
            this.tspAuditLog.ResumeLayout(false);
            this.tspAuditLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyFldLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionTakenLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fldChgLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctAuditLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuditLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspAuditLog;
        private System.Windows.Forms.ToolStripButton showToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit keyFldLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit actionTakenLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit fldChgLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit tblNameLookUpEdit;
        private DevExpress.XtraGrid.GridControl gctAuditLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAuditLog;
        private DevExpress.XtraGrid.Columns.GridColumn colLogId;
        private DevExpress.XtraGrid.Columns.GridColumn colTblName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyFld;
        private DevExpress.XtraGrid.Columns.GridColumn colActionTaken;
        private DevExpress.XtraGrid.Columns.GridColumn colFldChg;
        private DevExpress.XtraGrid.Columns.GridColumn colOldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValue;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colLogDt;
        private DevExpress.XtraGrid.Columns.GridColumn colLogWs;
        private System.Windows.Forms.DateTimePicker fromDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateDateTimePicker;
    }
}