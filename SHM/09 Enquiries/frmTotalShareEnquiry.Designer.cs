namespace SHM
{
    partial class frmTotalShareEnquiry
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
            this.gctTotalShare = new DevExpress.XtraGrid.GridControl();
            this.gridTotalShare = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTotalSubscribedShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSubscribedShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPaidUpShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPaidUpShareAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalUnpaidShareNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalUnpaidAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluEmpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewDept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluNewStation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluTypeofPayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // gctTotalShare
            // 
            this.gctTotalShare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctTotalShare.EmbeddedNavigator.Name = "";
            this.gctTotalShare.Location = new System.Drawing.Point(1, -3);
            this.gctTotalShare.MainView = this.gridTotalShare;
            this.gctTotalShare.Name = "gctTotalShare";
            this.gctTotalShare.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluEmpId,
            this.rluNewDept,
            this.rluNewStation,
            this.rluTypeofPayment});
            this.gctTotalShare.Size = new System.Drawing.Size(1038, 214);
            this.gctTotalShare.TabIndex = 9;
            this.gctTotalShare.TabStop = false;
            this.gctTotalShare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTotalShare});
            // 
            // gridTotalShare
            // 
            this.gridTotalShare.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTotalSubscribedShareNo,
            this.colTotalSubscribedShareAmnt,
            this.colTotalPaidUpShareNo,
            this.colTotalPaidUpShareAmnt,
            this.colTotalUnpaidShareNo,
            this.colTotalUnpaidAmnt});
            this.gridTotalShare.GridControl = this.gctTotalShare;
            this.gridTotalShare.Name = "gridTotalShare";
            this.gridTotalShare.OptionsBehavior.Editable = false;
            this.gridTotalShare.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridTotalShare.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridTotalShare.OptionsView.ColumnAutoWidth = false;
            this.gridTotalShare.OptionsView.ShowGroupPanel = false;
            // 
            // colTotalSubscribedShareNo
            // 
            this.colTotalSubscribedShareNo.Caption = "Total Subscribed Share No.";
            this.colTotalSubscribedShareNo.FieldName = "TotalSubscribedShareNo";
            this.colTotalSubscribedShareNo.Name = "colTotalSubscribedShareNo";
            this.colTotalSubscribedShareNo.Visible = true;
            this.colTotalSubscribedShareNo.VisibleIndex = 0;
            this.colTotalSubscribedShareNo.Width = 179;
            // 
            // colTotalSubscribedShareAmnt
            // 
            this.colTotalSubscribedShareAmnt.Caption = "Total Subscribed Share Amnt.";
            this.colTotalSubscribedShareAmnt.FieldName = "TotalSubscribedShareAmnt";
            this.colTotalSubscribedShareAmnt.Name = "colTotalSubscribedShareAmnt";
            this.colTotalSubscribedShareAmnt.Visible = true;
            this.colTotalSubscribedShareAmnt.VisibleIndex = 1;
            this.colTotalSubscribedShareAmnt.Width = 168;
            // 
            // colTotalPaidUpShareNo
            // 
            this.colTotalPaidUpShareNo.Caption = "Total Paidup Share No.";
            this.colTotalPaidUpShareNo.FieldName = "TotalPaidUpShareNo";
            this.colTotalPaidUpShareNo.Name = "colTotalPaidUpShareNo";
            this.colTotalPaidUpShareNo.Visible = true;
            this.colTotalPaidUpShareNo.VisibleIndex = 2;
            this.colTotalPaidUpShareNo.Width = 178;
            // 
            // colTotalPaidUpShareAmnt
            // 
            this.colTotalPaidUpShareAmnt.Caption = "Total Paidup Share Amnt.";
            this.colTotalPaidUpShareAmnt.FieldName = "TotalPaidUpShareAmnt";
            this.colTotalPaidUpShareAmnt.Name = "colTotalPaidUpShareAmnt";
            this.colTotalPaidUpShareAmnt.Visible = true;
            this.colTotalPaidUpShareAmnt.VisibleIndex = 3;
            this.colTotalPaidUpShareAmnt.Width = 164;
            // 
            // colTotalUnpaidShareNo
            // 
            this.colTotalUnpaidShareNo.Caption = "Total Unpaid Share No.";
            this.colTotalUnpaidShareNo.FieldName = "TotalUnpaidShareNo";
            this.colTotalUnpaidShareNo.Name = "colTotalUnpaidShareNo";
            this.colTotalUnpaidShareNo.OptionsColumn.ReadOnly = true;
            this.colTotalUnpaidShareNo.Visible = true;
            this.colTotalUnpaidShareNo.VisibleIndex = 4;
            this.colTotalUnpaidShareNo.Width = 175;
            // 
            // colTotalUnpaidAmnt
            // 
            this.colTotalUnpaidAmnt.Caption = "Total Unpaid Amnt.";
            this.colTotalUnpaidAmnt.FieldName = "TotalUnpaidAmnt";
            this.colTotalUnpaidAmnt.Name = "colTotalUnpaidAmnt";
            this.colTotalUnpaidAmnt.OptionsColumn.ReadOnly = true;
            this.colTotalUnpaidAmnt.Visible = true;
            this.colTotalUnpaidAmnt.VisibleIndex = 5;
            this.colTotalUnpaidAmnt.Width = 149;
            // 
            // rluEmpId
            // 
            this.rluEmpId.AutoHeight = false;
            this.rluEmpId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluEmpId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.rluEmpId.DisplayMember = "FullName";
            this.rluEmpId.Name = "rluEmpId";
            this.rluEmpId.NullText = "";
            this.rluEmpId.ValueMember = "Id";
            // 
            // rluNewDept
            // 
            this.rluNewDept.AutoHeight = false;
            this.rluNewDept.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNewDept.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeptDesc", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.rluNewDept.DisplayMember = "DeptDesc";
            this.rluNewDept.Name = "rluNewDept";
            this.rluNewDept.NullText = "";
            this.rluNewDept.ValueMember = "DeptCode";
            // 
            // rluNewStation
            // 
            this.rluNewStation.AutoHeight = false;
            this.rluNewStation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluNewStation.DisplayMember = "Description";
            this.rluNewStation.Name = "rluNewStation";
            this.rluNewStation.NullText = "";
            this.rluNewStation.ValueMember = "Id";
            // 
            // rluTypeofPayment
            // 
            this.rluTypeofPayment.AutoHeight = false;
            this.rluTypeofPayment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluTypeofPayment.DisplayMember = "TypeofPayment";
            this.rluTypeofPayment.Name = "rluTypeofPayment";
            this.rluTypeofPayment.NullText = "";
            this.rluTypeofPayment.ValueMember = "Id";
            // 
            // frmTotalShareEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 211);
            this.Controls.Add(this.gctTotalShare);
            this.Name = "frmTotalShareEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Share Enquiry";
            this.Load += new System.EventHandler(this.frmTotalShareEnquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctTotalShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotalShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluNewStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluTypeofPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctTotalShare;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTotalShare;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluEmpId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluNewStation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluTypeofPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSubscribedShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSubscribedShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPaidUpShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPaidUpShareAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalUnpaidShareNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalUnpaidAmnt;
    }
}