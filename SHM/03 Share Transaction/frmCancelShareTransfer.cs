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
    public partial class frmCancelShareTransfer : Form
    {
        
        #region Fields
        private string _title = "Share Transfer";
      

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

        private DataTable _tblCancelShareTranseferTransaction;
        private DataRow _CancelShareTranseferTransaction;
        private DataTable _tblCancelShareTranseferTransactionList;

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;
        private DataTable _tblShareholderToTransfer;

        private DataTable _tblShareRegBook;
        //private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrevFrom;
        private DataTable _tblShareRegBookPrevTo;


        private DataTable _tblAuditLog;
        private DataRow _AuditLog;


        #endregion

        #region Properties
        
        #endregion

        public frmCancelShareTransfer()
        {
            InitializeComponent();
            
        }

        private void CancelShareTransfer_Load(object sender, EventArgs e)
        {
            this.CancelTransferGroupBox.Enabled = false;
            this._EffectiveDate = clUtility.GetCurrentDate();
           
            BindControls();
            InitForm(true);
            
            BindControlsSH();
            InitFormSH(true);
        }

        private void CancelShareTransfer_KeyDown(object sender, KeyEventArgs e)
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

                this._tblCancelShareTranseferTransactionList = DataObj.GetDataTable("tblCancelShareTranseferTransaction");

                this._tblShareRegBookPrevFrom = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrevTo = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareTransfer = DataObj.GetDataTable("tblShareTransfer");
                this._tblShareTransfer.Columns["CrtDt"].ReadOnly = true;
                this._tblShareTransfer.Columns["CrtWs"].ReadOnly = true;
                this._tblShareTransfer.Columns["IsCanceled"].ReadOnly = true;

                this._tblCancelShareTranseferTransaction = DataObj.GetDataTable("tblCancelShareTranseferTransaction");
                this._tblCancelShareTranseferTransaction.Columns["CrtDt"].ReadOnly = true;
                this._tblCancelShareTranseferTransaction.Columns["CrtWs"].ReadOnly = true;

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
                    clMain.SetDataSource(this.gctCancelTransfer, this._tblCancelShareTranseferTransactionList);
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

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                if (AppMessageBox.ShowQuestion("If you cancel this transfered share, all related transactions will be reversed. Are you sure you want to Cancel it?  ") == DialogResult.Yes)
                {
                    if (this.Validate())
                    {
                        if (this._SHIdFrom == 0)
                        {
                            AppMessageBox.ShowExclamation("Please select a shareholder");
                            return;
                        }

                        DataObj.OpenConnection();
                        DataObj.BeginTransaction();

                        this._CancelShareTranseferTransaction = this._tblCancelShareTranseferTransaction.Rows[0];
                        this._ShareTransfer = this._tblShareTransfer.Rows[0];

                        
                        
                            if (DataObj.Insert(this._title, this._CancelShareTranseferTransaction, false))
                            {
                                if (UpdateShareRegBook(DataObj))
                                {
                                    if (InsertAuditlog(this._ShareTransfer, DataObj))
                                    {
                                        DataObj.CommitTransaction();
                                        AppMessageBox.ShowInformation("Cancel share transfer transaction is saved successfully");
                                    }
                                    else
                                    {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Cancel share transfer transaction is failed");
                                    }
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Cancel share transfer transaction is failed");
                                }

                            }

                        InitForm(false);


                    }
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

        private bool UpdateShareRegBook(clDatacon DataObj)
        {
 
            bool success = true;
            string cmdText = "";
            int TransferShareNo = 0;
            decimal TransferShareAmnt = 0;
            
            try
            {


                if (this.GetShareRegBookBySHId(this._SHIdFrom))
                {
                   
                   
                    TransferShareNo = Convert.ToInt32(this._ShareTransfer["NoOfShareTransfered"]);
                    TransferShareAmnt = Convert.ToDecimal(this._ShareTransfer["AmntOfShareTransfered"]);


                    cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)+" + TransferShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)+" + TransferShareAmnt + ", PaidUpNoofShare=isnull(PaidUpNoofShare,0)+" + TransferShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)+" + TransferShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHIdFrom;
                   
                    success = DataObj.Execute(cmdText);
                    if (success)
                    {
                       
                        
                            cmdText = "UPDATE tblShareholderDetail Set SHStatus=1, LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHIdFrom;
                            success = DataObj.Execute(cmdText);
                       
                    }
                    if (success)
                    {
                       
                        cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)-" + TransferShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)-" + TransferShareAmnt + ", PaidUpNoofShare=isnull(PaidUpNoofShare,0)-" + TransferShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)-" + TransferShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHIdTo;
                        success = DataObj.Execute(cmdText);
                        if(success)
                        {
                            cmdText = "delete tblShareRegBook where PaidUpShareAmt=0 and SHId=" + this._SHIdTo;
                            success = DataObj.Execute(cmdText);

                        }
                    }
                    if (success)
                    {
                        cmdText = "UPDATE tblShareTransfer Set IsCanceled=1  WHERE TransferId=" + this._TransferId;
                        success = DataObj.Execute(cmdText);
                    }


                }

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                success = false;
            }

            return success;
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

        private bool InsertAuditlog(DataRow ShareTransfer, clDatacon DataObj)
        {
            
            bool success = true;
            try
            {
               
                if (this._tblShareRegBookPrevFrom.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                    {
                      this._AuditLog["TblName"] = "tblShareRegBook";
                      this._AuditLog["KeyFld"] = "SHId";
                      this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                      this._AuditLog["ActionTaken"] = "Cancel Share transfer from";
                      this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                      this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareNoModif"];
                      this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareNoModif"]) + Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
                      this._AuditLog["UserId"] = clMain.User.UserName;
                      success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (Convert.ToInt32(ShareTransfer["AmntOfShareTransfered"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                        this._AuditLog["ActionTaken"] = "Cancel Share Transfer from";
                        this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareAmtModif"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevFrom.Rows[0]["SubscribedShareAmtModif"]) + Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHIdFrom;
                        this._AuditLog["ActionTaken"] = "Cancel Share transfer from";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrevFrom.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevFrom.Rows[0]["PaidUpNoofShare"]) + Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
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


                    GetShareRegBookBySHIdTo(this._SHIdTo);
                    if (success && this._tblShareRegBookPrevTo.Rows.Count > 0)
                    {
                       
                        if (Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHIdTo;
                            this._AuditLog["ActionTaken"] = "Cancel Share transfer to";
                            this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"];
                            this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"]) - Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (success && Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHIdTo;
                            this._AuditLog["ActionTaken"] = "Cancel Share Transfer to";
                            this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareAmtModif"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["SubscribedShareNoModif"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["ActionTaken"] = "Cancel Share transfer to";
                            this._AuditLog["FldChged"] = "PaidUpNoofShare";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["PaidUpNoofShare"];
                            this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrevTo.Rows[0]["PaidUpNoofShare"]) - Convert.ToInt32(ShareTransfer["NoOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (success && Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]) > 0)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["ActionTaken"] = "Cancel Share Transfer to";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrevTo.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrevTo.Rows[0]["PaidUpShareAmt"]) - Convert.ToDecimal(ShareTransfer["AmntOfShareTransfered"]));
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                        if (success)
                        {
                            this._AuditLog["TblName"] = "tblShareTransfer";
                            this._AuditLog["KeyFld"] = "TransferId";
                            this._AuditLog["KeyFldValue"] = this._TransferId;
                            this._AuditLog["ActionTaken"] = "Cancel Share Transfer";
                            this._AuditLog["FldChged"] = "IsCanceled";
                            this._AuditLog["OldValue"] = 0;
                            this._AuditLog["NewValue"] = 1;
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
               

            }
            return success;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TransferId = 0;
            this._SHIdFrom = 0;
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
                
                 GetShareTransferHistory(this._SHIdFrom,this._fiscalYear);

            }
           
              
            
           
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
                this._SHIdTo = Convert.ToInt32(curRow["TransferToSHId"]);

                this.GetShareholderBrowse(this._SHIdFrom);
                this.GetShareTransferEntry(this._TransferId);
                GetNewEntry();
                this.gridShareTransfer.FocusedRowHandle = focused;
            }
        }

        private bool GetShareTransferHistory(int shId,string fiscalyear)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareTransferList, "SELECT * FROM tblShareTransfer WHERE IsCanceled=0 and TransferFromSHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                    DataObj.FillData(this._tblCancelShareTranseferTransactionList, "SELECT * FROM tblCancelShareTranseferTransaction WHERE  SHfrom=" + shId);
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

        private bool GetShareTransferEntry(int trnId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    
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
                    
                }
            
        }

        private void GetNewEntry()
        {
            try
            {
                
                this._CancelShareTranseferTransaction = this._tblCancelShareTranseferTransaction.NewRow();
                clDatacon.SetToDatabaseDefaults(this._CancelShareTranseferTransaction, clMain.ConnString);
                if (this._SHIdFrom != 0) this._CancelShareTranseferTransaction["SHfrom"] = this._SHIdFrom;
                if (this._SHIdTo != 0) this._CancelShareTranseferTransaction["SHto"] = this._SHIdTo;
                if (this._TransferId != 0) this._CancelShareTranseferTransaction["TrnId"] = this._TransferId;
                this._CancelShareTranseferTransaction["EffectiveDate"] = clUtility.GetCurrentDate();
                this._CancelShareTranseferTransaction["EffectiveDateEth"] = clUtility.GetEthiopicDate(clUtility.GetCurrentDate()); ;
                this._CancelShareTranseferTransaction["CrtBy"] = clMain.User.UserName;
                this._tblCancelShareTranseferTransaction.Rows.Clear();
                this._tblCancelShareTranseferTransaction.Rows.Add(this._CancelShareTranseferTransaction);
                

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);

            }
        }

        private bool GetShareRegBookBySHId(int ShId)
        {
            object result;
            string cmdText;
           
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                   
                    
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
                    
                }
           
        }

        

        private void GetShareRegBookBySHIdTo(int ShId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.FillData(this._tblShareRegBookPrevTo, "SELECT * FROM tblShareRegBook WHERE  SHId=" + ShId);
               
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

        

      

       

       

      










    }
}



