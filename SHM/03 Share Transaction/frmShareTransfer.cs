using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHM
{
    public partial class frmShareTransfer : Form
    {
        #region Fields
        private string _title = "Share Transfer";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHIdFrom = 0;
        private int _SHIdTo = 0;
        private int _Typeoftransfer=0;
        private int _TransferId = 0;
       
        private DateTime _EffectiveDate;
        private decimal _TotalPaidup = 0;

        private string _fiscalYear = "0";
        private DataTable _tblFiscalYear;

        private DataTable _tblTypeofTransfer;
        private DataTable _tblShareTransfer;
        private DataRow _ShareTransfer;
        private DataTable _tblShareTransferList;
       

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;
        private DataTable _tblShareholderToTransfer;

        private DataTable _tblShareRegBook;
        private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrevFrom;
        private DataTable _tblShareRegBookPrevTo;


        private DataTable _tblAuditLog;
        private DataRow _AuditLog;


        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                //this.deleteToolStripButton.Enabled = !this._isNew;
            }
        }
        #endregion

        public frmShareTransfer()
        {
            InitializeComponent();
            
        }

        private void frmShareTransfer_Load(object sender, EventArgs e)
        {
            this.printToolStripButton.Visible = false;
            this._EffectiveDate = clUtility.GetCurrentDate();
           
            BindControls();
            InitForm(true);
            
            BindControlsSH();
            InitFormSH(true);
        }

        private void frmShareTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                this._tblTypeofTransfer = DataObj.GetDataTable("tblTypeofTransfer");
                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderToTransfer = new DataTable("tblShareholderDetail"); 
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));

                this._tblShareTransferList = DataObj.GetDataTable("tblShareTransfer");
                this._tblFiscalYear = DataObj.GetDataTable("ViewFiscalYears");
               

                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);

                clMain.SetDataSource(this.TransferFromSHIdLookUpEdit, this._tblShareholderDetailList);
                clMain.SetDataSource(this.TransferToSHIdLookUpEdit, this._tblShareholderToTransfer);
                clMain.SetDataSource(this.TypeofTransferLookUpEdit, this._tblTypeofTransfer);
                clMain.SetRepositoryDataSource(this.rluSHId, this._tblShareholderDetailList);
                clMain.SetRepositoryDataSource(this.rluTranserType, this._tblTypeofTransfer);

                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;
                
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookPrevFrom = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrevTo = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareTransfer = DataObj.GetDataTable("tblShareTransfer");
                this._tblShareTransfer.Columns["CrtDt"].ReadOnly = true;
                this._tblShareTransfer.Columns["CrtWs"].ReadOnly = true;
                this._tblShareTransfer.Columns["IsCanceled"].ReadOnly = true;
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.TransferFromSHIdLookUpEdit,
                this.TransferToSHIdLookUpEdit,
                this.TypeofTransferLookUpEdit,
                this.EffectiveDateDateTimePicker,
                this.EffectiveDateEthTextBox,
                this.AmntOfShareTransferedTextBox,
                this.NoOfShareTransferedTextBox
                
               
                   
                });

                    clMain.BindControls(cntrsList, this._tblShareTransfer);
                    cntrsList.Clear();

                    clMain.SetDataSource(this.gctShareTransfer, this._tblShareTransferList);
                    clMain.SetDataSource(this.gctSHRegBook, this._tblShareRegBookList);

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void InitForm(bool All)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                DataObj.OpenConnection();
                if (All)
                {
                    if (this.chkYearAll.Checked)
                        DataObj.FillData(this._tblFiscalYear, "select* from ViewFiscalYears order by FiscalYear desc");
                    else
                        DataObj.FillData(this._tblFiscalYear, "select * from ViewFiscalYears where Closed=0");

                    DataObj.FillData(this._tblTypeofTransfer, "SELECT * FROM tblTypeofTransfer");
                    DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql("SHStatus=1 and SHId in (select SHId from tblShareRegBook where isnull(PaidUpNoofShare,0)>0)"));
                    clMain.SetSearchBy(this.TransferFromSHIdLookUpEdit, this.searchByComboBox);

                    
                   
                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId="+this._SHIdFrom);
                GetShareTransferHistory(this._SHIdFrom,this._fiscalYear);
               
               
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                
                if (this.Validate())
                {
                    if (this._SHIdFrom == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select a shareholder");
                        return;
                    }

                    DataObj.OpenConnection();
                    DataObj.BeginTransaction();
                   
                    this._ShareTransfer = this._tblShareTransfer.Rows[0];

                    if(this.NoOfShareTransferedTextBox.Text==string.Empty)

                        this._ShareTransfer["NoOfShareTransfered"] = Convert.ToString(clUtility.GetShareNoByShareAmount(Convert.ToDecimal(this.AmntOfShareTransferedTextBox.Text.Trim())));


                    if (this._TotalPaidup == Convert.ToDecimal(this._ShareTransfer["AmntOfShareTransfered"]))
                        this._ShareTransfer["EffectiveDate"] = Convert.ToDateTime(this.FiscalYearLookUpEdit.GetColumnValue("StartDate"));
                    if (this._isNew)
                            {
                                if (DataObj.Insert(this._title, this._ShareTransfer, false))
                                {
                                    if (InsertAuditlog(this._ShareTransfer))
                                    {
                                        if (InsertShareRegBook())
                                        {
                                            DataObj.CommitTransaction();
                                            AppMessageBox.ShowInformation("Share transfer transaction is saved successfully");
                                        }
                                        else
                                        {
                                            DataObj.RollbackTransaction();
                                            AppMessageBox.ShowInformation("Share transfer transaction is failed");
                                        }
                                    }
                                    else
                                    {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Share transfer transaction is failed");
                                    }
                                   
                                }

                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Share transfer transaction is failed");
                                }
                            }
                            else
                            {// updating is not required because if there is any modification, it should be canceled using canceling shareholder payment transaction
                                //if (DataObj.Update(this._title, this._ShareSubscribing, true))
                                //{
                                    
                                   
                                //}
                            }

                        
                        
                        InitForm(false);
                    

                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.RollbackTransaction();
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
        }

        private bool InsertShareRegBook()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            string cmdText = "";
            decimal TransferShareNo = 0;
            decimal TransferShareAmnt = 0;
            TransferShareNo = Convert.ToDecimal(this._ShareTransfer["NoOfShareTransfered"]);
            TransferShareAmnt = Convert.ToDecimal(this._ShareTransfer["AmntOfShareTransfered"]);
            try
            {
                DataObj.OpenConnection();
                if (!this.GetValidPaidUpShareRegBookBySHId(this._SHIdFrom))
                {
                    AppMessageBox.ShowExclamation("The total paidup balance of the selected shareholder is less than the transfer amount");
                    success = false;
                }
                else
                {
                    cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)-" + TransferShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)-" + TransferShareAmnt + ", PaidUpNoofShare=isnull(PaidUpNoofShare,0)-" + TransferShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)-" + TransferShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHIdFrom;
                    success = DataObj.Execute(cmdText);
                    if (success)
                    {
                       
                        if (!this.GetShareRegBookBySHId(this._SHIdTo))
                        {
                            this._ShareRegBook = this._tblShareRegBook.NewRow();
                            this._ShareRegBook["SHId"] = this._SHIdTo;
                            this._ShareRegBook["SubscribedShareNoOrg"] = this._ShareTransfer["NoOfShareTransfered"];
                            this._ShareRegBook["SubscribedShareAmtOrg"] = this._ShareTransfer["AmntOfShareTransfered"];
                            this._ShareRegBook["SubscribedShareNoModif"] = this._ShareTransfer["NoOfShareTransfered"];
                            this._ShareRegBook["SubscribedShareAmtModif"] = this._ShareTransfer["AmntOfShareTransfered"];
                            this._ShareRegBook["PaidUpNoofShare"] = this._ShareTransfer["NoOfShareTransfered"];
                            this._ShareRegBook["PaidUpShareAmt"] = this._ShareTransfer["AmntOfShareTransfered"];
                            this._ShareRegBook["CrtBy"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._ShareRegBook, false, false);
                        }
                        else
                        {

                            cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)+" + TransferShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)+" + TransferShareAmnt + ", PaidUpNoofShare=isnull(PaidUpNoofShare,0)+" + TransferShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)+" + TransferShareAmnt +  ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHIdTo;
                            success = DataObj.Execute(cmdText);
                        }
                        if (success)
                        {
                            GetShareRegBookListBySHId(this._SHIdFrom);
                            if (this._TotalPaidup == 0)
                            {
                                cmdText = "UPDATE tblShareholderDetail Set SHStatus=0, LmBy='" + clMain.User.UserName +"' WHERE SHId=" + this._SHIdFrom ;
                                success = DataObj.Execute(cmdText);
                            }
                        }
                        
                    }


                   


                     
                    
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return success;
            }
            finally
            {
                DataObj.CloseConnection();

            }
            return success;
        }

        private bool InsertAuditlog(DataRow ShareTransfer)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblShareRegBookPrevFrom.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                    {
                      this._AuditLog["TblName"] = "tblShareRegBook";
                      this._AuditLog["KeyFld"] = "SHId";
                      this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                      this._AuditLog["ActionTaken"] = "Share transfer from";
                      this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                      this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareNoModif"];
                      this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareNoModif"]) - Convert.ToDecimal(ShareTransfer["NoOfShareTransfered"]));
                      this._AuditLog["UserId"] = clMain.User.UserName;
                      success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (Convert.ToInt32(ShareTransfer["AmntOfShareTransfered"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                        this._AuditLog["ActionTaken"] = "Share Transfer from";
                        this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareAmtModif"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                        this._AuditLog["ActionTaken"] = "Share transfer from";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevFrom.Rows[0]["PaidUpNoofShare"]) - Convert.ToDecimal(ShareTransfer["NoOfShareTransfered"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (Convert.ToInt32(ShareTransfer["AmntOfShareTransfered"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                        this._AuditLog["ActionTaken"] = "Share Transfer from";
                        this._AuditLog["FldChged"] = "PaidUpShareAmt";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["PaidUpShareAmt"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevFrom.Rows[0]["PaidUpShareAmt"]) - Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }




/********************************************************************************************************************/


                    GetShareRegBooBySHIdTo(this._SHIdTo);
                    if (success && this._tblShareRegBookPrevTo.Rows.Count > 0)
                    {
                       
                        if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHIdTo;
                            this._AuditLog["ActionTaken"] = "Share transfer to";
                            this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"];
                            this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"]) + Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (success && Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHIdTo;
                            this._AuditLog["ActionTaken"] = "Share Transfer to";
                            this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareAmtModif"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareAmtModif"]) + Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["ActionTaken"] = "Share transfer to";
                            this._AuditLog["FldChged"] = "PaidUpNoofShare";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["PaidUpNoofShare"];
                            this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["PaidUpNoofShare"]) + Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (success && Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["ActionTaken"] = "Share Transfer to";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevTo.Rows[0]["PaidUpShareAmt"]) + Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                    }

                }
               
                    
                    
                


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();

            }
            return success;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TransferId = 0;
            this._SHIdFrom = 0;
            this._SHIdTo=0;
            this._Typeoftransfer = 0;

            this.GetShareTransferEntry(this._SHIdFrom, this._SHIdTo, this._Typeoftransfer, this._EffectiveDate);
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                //GetSharePaymentHistory(this._SHId, this._fiscalYear);
            }
        }

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void TransferFromSHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.TransferFromSHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.TransferFromSHIdLookUpEdit.EditValue))
            {
                this._SHIdFrom = 0;
                this._TotalPaidup = 0;
                this.TotalPaidupTextBox.Text = "";
                this._tblShareholderDetailBrowse.Rows.Clear();
            }
            else
            {
                this._SHIdFrom = Convert.ToInt32(this.TransferFromSHIdLookUpEdit.EditValue);
                this.GetShareholderBrowse(this._SHIdFrom);
                GetShareholderToTransfer(this._SHIdFrom);
                GetShareRegBookListBySHId(this._SHIdFrom);
                //if (!GetShareRegBookListBySHId(this._SHIdFrom))
                //{
                //    AppMessageBox.ShowExclamation("Share subscription is not recorded. Please subscribe share before transfering.");
                //    this.TransferFromSHIdLookUpEdit.Focus();
                //    this.TransferFromSHIdLookUpEdit.EditValue = null;
                //}
                //else if (this._TotalPaidup == 0)
                //{
                //    AppMessageBox.ShowExclamation("This shareholder didn't pay his subscribed share amount. You can not transfer unpaid share to others.");
                //    this.TransferFromSHIdLookUpEdit.Focus();
                //    this.TransferFromSHIdLookUpEdit.EditValue = null;
                //}
                 GetShareTransferHistory(this._SHIdFrom,this._fiscalYear);

            }
           
                //if (this.IsNew)
                //    this.GetShareTransferEntry(this._SHIdFrom, _SHIdTo,this._Typeoftransfer,this._EffectiveDate);
            
           
        }

        private void TransferToSHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.TransferToSHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.TransferToSHIdLookUpEdit.EditValue))
                this._SHIdTo = 0;
            else
                this._SHIdTo = Convert.ToInt32(this.TransferToSHIdLookUpEdit.EditValue);
                
        }

        private void TypeofTransferLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            
            if (this.TypeofTransferLookUpEdit.EditValue == null || Convert.IsDBNull(this.TypeofTransferLookUpEdit.EditValue))
                this._Typeoftransfer = 0;
            else
                this._Typeoftransfer= Convert.ToInt32(this.TypeofTransferLookUpEdit.EditValue);

        }

        private void gridShareTransfer_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridShareTransfer.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridShareTransfer.GetDataRow(focused);
                this._TransferId = Convert.ToInt32(curRow["TransferId"]);
                this._SHIdFrom = Convert.ToInt32(curRow["TransferFromSHId"]);
               
                this.GetShareholderBrowse(this._SHIdFrom);
                this.GetShareTransferEntry(this._TransferId);

                this.gridShareTransfer.FocusedRowHandle = focused;
            }
        }

        private bool GetShareTransferHistory(int shId,string fiscalyear)
        {
            if (!this._isLoadingEntry)
            {

                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareTransferList, "SELECT * FROM tblShareTransfer WHERE IsCanceled=0 and TransferFromSHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();

                }
            }
            else
                return false;
        }

        private bool GetShareTransferEntry(int trnId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareTransfer, "SELECT * FROM tblShareTransfer WHERE TransferId=" + trnId);
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    this._isLoadingEntry = false;
                }
            }
            else
                return false;
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._ShareTransfer = this._tblShareTransfer.NewRow();
                clDatacon.SetToDatabaseDefaults(this._ShareTransfer, clMain.ConnString);
                if (this._fiscalYear != "0") this._ShareTransfer["FiscalYear"] = this._fiscalYear;
                if (this._SHIdFrom != 0) this._ShareTransfer["TransferFromSHId"] = this._SHIdFrom;
                if (this._SHIdTo != 0) this._ShareTransfer["TransferToSHId"] = this._SHIdTo;
                if (this._Typeoftransfer != 0) this._ShareTransfer["TypeofTransfer"] = this._Typeoftransfer;
                this._ShareTransfer["EffectiveDate"] = this._EffectiveDate;
                this._ShareTransfer["EffectiveDateEth"] = clUtility.GetEthDate(this._EffectiveDate);
                this._ShareTransfer["CrtBy"] = clMain.User.UserName;
                this._tblShareTransfer.Rows.Clear();
                this._tblShareTransfer.Rows.Add(this._ShareTransfer);
                this._isLoadingEntry = false;
                
            }
        }

        private bool GetShareTransferEntry(int SHIdfrom, int SHIdto,int transferType,DateTime effectivedate)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.ShareTransferExists(SHIdfrom, SHIdto, transferType, effectivedate))
                {
                    this._isLoadingEntry = false;
                   
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareTransfer, "set dateformat dmy SELECT * FROM tblShareTransfer WHERE TransferFromSHId=" + SHIdfrom + " and TransferToSHId=" + SHIdto + " and EffectiveDate='" + effectivedate + "' and IsCanceled=0");
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    this._isLoadingEntry = false;
                }
            }
            else
                return false;
        }

        public bool ShareTransferExists(int SHIdfrom, int SHIdto, int transferType, DateTime effectivedate)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (SHIdfrom == 0 || SHIdto == 0 || transferType==0)
                return false;
            try
            {
                DataObj.OpenConnection();
                cmdText = "set dateformat dmy SELECT * FROM tblShareTransfer WHERE TransferFromSHId=" + SHIdfrom + " and TransferToSHId=" + SHIdto + " and EffectiveDate='" + effectivedate + "' and IsCanceled=0";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    return true;
                else
                    return false;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private bool GetShareRegBookBySHId(int ShId)
        {
            object result;
            string cmdText;
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                   
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    cmdText = "SELECT SHId FROM tblShareRegBook WHERE SHId=" + ShId;
                     result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return true;
                else
                    
                    return false;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    this._isLoadingEntry = false;
                }
            }
            else
                return false;
        }

        private bool GetValidPaidUpShareRegBookBySHId(int ShId)
        {
            object result;
            string cmdText;
           
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    decimal transferamnt=0;
                    if(this.AmntOfShareTransferedTextBox.Text.Trim()!="")
                        transferamnt=Convert.ToDecimal(this.AmntOfShareTransferedTextBox.Text);
                    DataObj.OpenConnection();
                    cmdText = "SELECT SHId FROM tblShareRegBook WHERE isnull(PaidUpShareAmt,0)>=" + transferamnt + " and SHId=" + ShId;
                    result = DataObj.GetDataScalar(cmdText);
                    if (result != null)
                        return true;
                    else

                        return false;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    
                }
            
            
        }

        private bool GetShareRegBookListBySHId(int ShId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHIdFrom);
                DataObj.FillData(this._tblShareRegBookPrevFrom, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHIdFrom);
                if (this._tblShareRegBookList.Rows.Count > 0)
                {
                    
                    if(Convert.IsDBNull(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"])||this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]==null)
                        this._TotalPaidup = 0;
                    else
                        this._TotalPaidup = Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]);
                    this.TotalPaidupTextBox.Text = this._TotalPaidup.ToString();
                    return true;
                }
                else
                {
                    this._TotalPaidup = 0;
                    this.TotalPaidupTextBox.Text = "";
                    return false;
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
                
            }

        }

        private void GetShareRegBooBySHIdTo(int ShId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.FillData(this._tblShareRegBookPrevTo, "SELECT * FROM tblShareRegBook WHERE SHId=" + ShId);
               
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
               
            }
            finally
            {
                DataObj.CloseConnection();

            }

        }

        private void GetShareholderToTransfer(int ShIdFrom)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                DataObj.FillData(this._tblShareholderToTransfer, clShareholder.GetShareholderBrowseSql("SHStatus=1 and SHId !=" + ShIdFrom));

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void EffectiveDateDateTimePicker_Validated(object sender, EventArgs e)
        {

            this.EffectiveDateEthTextBox.Text = clUtility.GetEthDate(this.EffectiveDateDateTimePicker.Value);
            this._EffectiveDate = this.EffectiveDateDateTimePicker.Value;
            this.GetShareTransferEntry(this._SHIdFrom, this._SHIdTo, this._Typeoftransfer, this._EffectiveDate);
                  
        }

        #region Shareholder Browse
        private DataTable _tblShareholderDetailBrowse;
        
        private DataTable _tblSexLu;
        
        private void BindControlsSH()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblSexLu = DataObj.GetDataTable("tblSexLu");
               
               
                clMain.SetDataSource(this.sexLookUpEdit, this._tblSexLu);


                this._tblShareholderDetailBrowse = DataObj.GetDataTable("tblShareholderDetail");
               
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.sexLookUpEdit,
                    this.DORegDateTimePicker,
                    this.DORegEthTextBox,
                    this.RegCodeTextBox,
                    this.IsLBFounderCheckBox,
                    this.IsGBFounderCheckBox
                    
                });
                clMain.BindControls(cntrsList, this._tblShareholderDetailBrowse);
                cntrsList.Clear();

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void InitFormSH(bool All)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (All)
                {
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblSexLu, "SELECT * FROM tblSexLu");
                    
                
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void GetShareholderBrowse(int SHId)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT RegCode,Sex, DOReg, DORegEth, IsLBFounder, IsGBFounder  FROM tblShareholderDetail where SHId=" + SHId;
                

                DataObj.FillData(this._tblShareholderDetailBrowse, cmdText);

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }
        #endregion

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchByComboBox.SelectedIndex != -1)
            {
                this.TransferFromSHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

        private void AmntOfShareTransferedTextBox_Validated(object sender, EventArgs e)
        {
            if (this.AmntOfShareTransferedTextBox.Text.Trim() == string.Empty)
                AppMessageBox.ShowExclamation("Please enter the share amount");
            else
            {
                object shareAmount = this.AmntOfShareTransferedTextBox.Text.Trim();
                if (!clUtility.IsNumeric(shareAmount))
                {
                    AppMessageBox.ShowExclamation("Please enter valid share amount");
                    this.AmntOfShareTransferedTextBox.Focus();
                }
                else
                {
                    if (Convert.ToDecimal(this.AmntOfShareTransferedTextBox.Text) > this._TotalPaidup)
                    {
                        AppMessageBox.ShowExclamation("You can not transfer more than the total paidup share amount. Please enter valid share transfer amount.");
                        this.AmntOfShareTransferedTextBox.Focus();
                    }
                    else if (Convert.ToDecimal(this.AmntOfShareTransferedTextBox.Text) < 1000)
                    {
                        AppMessageBox.ShowExclamation("Share amount should not be less than 1000.");
                        this.AmntOfShareTransferedTextBox.Focus();
                    }
                    else
                        this.NoOfShareTransferedTextBox.Text = Convert.ToString(clUtility.GetShareNoByShareAmount(Convert.ToDecimal(this.AmntOfShareTransferedTextBox.Text.Trim())));
                }
                        
            }
        }

        private void AmntOfShareTransferedTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = this.AmntOfShareTransferedTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid share amount");
                this.AmntOfShareTransferedTextBox.Text = "";
                this.NoOfShareTransferedTextBox.Text = "";
            }
        }

       

       

      










    }
}



