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
    public partial class frmCancelPaidDividend : Form
    {
        #region Fields
        private string _title = "Cancel Dividend Paid";
       

        private int _SHId = 0;
        private int _DividendTrnId = 0;

        private string _Message = string.Empty;
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";
        private decimal _DividendToSh=0;
        private decimal _DividendToOS=0;
        private decimal _DividendToCapitalized = 0;
        private byte _IsPaid = 0;
        private byte _IsPaidtoOS = 0;
        private byte _IsCapitalized = 0;
        private DateTime _PaymentDate;
        private int _TypeofPayment = 6;
        

        private DataTable _tblFiscalYear;
        //tblDividendPaid
        private DataTable _tblDividendPaid;
        private DataRow _DividendPaid;
        private DataTable _tblDividendPaidList;

        private DataTable _tblCancelPaidDividendTransaction;
        private DataRow _CancelPaidDividendTransaction;
        private DataTable _tblCancelPaidDividendTransactionList;
       

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
       

        private DataTable _tblShareRegBookPrev;
        

        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        public frmCancelPaidDividend()
        {
            InitializeComponent();
            
        }

        private void frmCancelPaidDividend_Load(object sender, EventArgs e)
        {
            
            
            this.DivGroupBox.Enabled = false;
            
            BindControls();
            BindControlsSH();
            InitForm(true);
            InitFormSH(true);
        }

        private void frmCancelPaidDividend_KeyDown(object sender, KeyEventArgs e)
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

               
                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);

                this._tblDividendPaidList = DataObj.GetDataTable("tblDividendPaid");
                this._tblFiscalYear = new DataTable("tblFisicalYear");
                this._tblFiscalYear.Columns.Add("FiscalYear", typeof(string));
                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);

                this._tblCancelPaidDividendTransactionList = DataObj.GetDataTable("tblCancelPaidDividendTransaction");
                
               
                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                this._tblDividendPaid = DataObj.GetDataTable("tblDividendPaid");
                this._tblDividendPaid.Columns["CrtDt"].ReadOnly = true;
                this._tblDividendPaid.Columns["CrtWs"].ReadOnly = true;
                this._tblDividendPaid.Columns["IsCanceled"].ReadOnly = true;

                this._tblCancelPaidDividendTransaction = DataObj.GetDataTable("tblCancelPaidDividendTransaction");
                this._tblCancelPaidDividendTransaction.Columns["CrtDt"].ReadOnly = true;
                this._tblCancelPaidDividendTransaction.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.SHIdLookUpEdit,
                this.PVNoTextBox,
                this.PaymentDateDateTimePicker,
                this.PaymentDateEthTextBox,
                this.GrossDividendTextBox,
                this.GrossDividendPaidtoShTextBox,
                this.GrossDividendPaidtoOSTextBox,
                this.GrossDividendCapitalizedTextBox,
                this.IsPaidtoShCheckBox,
                this.IsPaidtoOSCheckBox,
                this.IsCapitalizedCheckBox
               
               
                   
                });

                    clMain.BindControls(cntrsList, this._tblDividendPaid);
                    cntrsList.Clear();

                    clMain.SetDataSource(this.gctDividendPayment, this._tblDividendPaidList);
                    clMain.SetDataSource(this.gctCancelPayDividend, this._tblCancelPaidDividendTransactionList);
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

                    DataObj.FillData(this._tblFiscalYear, "select distinct FiscalYear from tblDividendEntitled  order by FiscalYear desc");

                    
                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId="+this._SHId);
                GetDividendPaymentHistory(this._SHId,this._fiscalYear);
                clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);
               
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
                
                if (this.Validate())
                {
                    if (this._SHId == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select a shareholder");
                        return;
                    }

                    DataObj.OpenConnection();
                    DataObj.BeginTransaction();
                    string cmdText;
                    this._CancelPaidDividendTransaction= this._tblCancelPaidDividendTransaction.Rows[0];

                 //   _CancelPaidDividendTransaction["CancelDate"] = clUtility.ToDMYDate(Convert.ToDateTime(this._tblCancelPaidDividendTransaction.Rows[0]["CancelDate"]));//Update 1 Dawit

                    this._PaymentDate = this.PaymentDateDateTimePicker.Value;
                         if (DataObj.Insert(this._title, this._CancelPaidDividendTransaction, false))
                         {

                             cmdText = "update tblSharePayment set IsCanceled=1 where IsCanceled=0 and FiscalYear='" + this._fiscalYear + "' and SHId=" + _SHId + " and ReceiptNo= 'Paid From Dividend of " + this._fiscalYear + " Fisical Year' and DateofPayment='" + this._PaymentDate + "' and TypeofPayment=" + this._TypeofPayment;
                             if(DataObj.Execute( cmdText))
                             {
                               if (UpdateShareRegBook(DataObj))
                                 {
                                     
                                     if (InsertAuditlog(this._DividendPaid, DataObj))
                                     {
                                         DataObj.CommitTransaction();
                                         AppMessageBox.ShowInformation("Cancel Dividend Payment Transaction is saved successfully");
                                         InitForm(false);
                                         this.refreshToolStripButton_Click(this, new EventArgs());
                                     }
                                     else
                                     {
                                         DataObj.RollbackTransaction();
                                         AppMessageBox.ShowInformation("Cancel Dividend Payment Transaction is failed");
                                         InitForm(false);
                                         this.refreshToolStripButton_Click(this, new EventArgs());
                                     }
                                 }
                                 else
                                 {
                                     DataObj.RollbackTransaction();
                                     AppMessageBox.ShowInformation("Cancel Dividend Payment Transaction is failed");
                                     InitForm(false);
                                     this.refreshToolStripButton_Click(this, new EventArgs());
                                 }
                             }
                             else
                             {
                                 DataObj.RollbackTransaction();
                                 AppMessageBox.ShowInformation("Cancel Dividend Payment Transaction is failed");
                                 InitForm(false);
                                 this.refreshToolStripButton_Click(this, new EventArgs());
                             }
                             

                         }
                         else
                         {
                             DataObj.RollbackTransaction();
                             AppMessageBox.ShowInformation("Cancel Dividend Payment Transaction is failed");
                             InitForm(false);
                             this.refreshToolStripButton_Click(this, new EventArgs());
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
                
            }
        }

        private bool UpdateShareRegBook(clDatacon DataObj)
        {
           
            bool success = true;
            string cmdText;
            try
            {



                if ((this._DividendToOS + this._DividendToCapitalized) > 0)
                {

                    decimal PaidShareNo = 0;
                    decimal PaidShareAmnt = 0;
                    PaidShareNo = this._DividendToOS / 1000 + this._DividendToCapitalized / 1000;
                    PaidShareAmnt = this._DividendToOS + this._DividendToCapitalized;
                    
                    cmdText = "Update tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0)-" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)-" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);

                    if (success && this._DividendToCapitalized > 0)
                    {
                        decimal CapitalizedShareNo = this._DividendToCapitalized / 1000;
                        decimal CapitalizedShareAmnt = this._DividendToCapitalized;

                        cmdText = "Update tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)-" + CapitalizedShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)-" + CapitalizedShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                        success = DataObj.Execute(cmdText);
                    }
                    
                    if (success)
                    {

                        cmdText = "UPDATE tblDividendPaid Set IsCanceled=1  WHERE TrnNo=" + this._DividendTrnId;
                        success = DataObj.Execute(cmdText);
                        if (success)
                        {
                            cmdText = "Update tblDividendEntitled set IsPaid=0,IsPaidToOutstanding=0,IsCapitalized=0 where SHID=" + this._SHId + " and FiscalYear='" + this._fiscalYear + "'";
                            success = DataObj.Execute(cmdText);
                        }
                        
                        //if (success)
                        //{
                        //    cmdText = "update tblSharePayment set IsCanceled=1 where IsCanceled=0 and FiscalYear='" + this._fiscalYear + "' and SHId=" + _SHId + " and ReceiptNo= 'Paid From Dividend'  and TypeofPayment=" + this._TypeofPayment;
                        //    success = DataObj.Execute(cmdText);
                        //}
                        

                    }
                    
                }
                else if (this._IsPaid>0)
                {
                    cmdText = "UPDATE tblDividendPaid Set IsCanceled=1  WHERE TrnNo=" + this._DividendTrnId;
                        success = DataObj.Execute(cmdText);
                        if (success)
                        {
                            cmdText = "Update tblDividendEntitled set IsPaid=0,IsPaidToOutstanding=0,IsCapitalized=0 where SHID=" + this._SHId + " and FiscalYear='" + this._fiscalYear + "'";
                            success = DataObj.Execute(cmdText);
                        }
                        
                        //if (success)
                        //{
                        //    cmdText = "update tblSharePayment set IsCanceled=1 where IsCanceled=0 and FiscalYear='" + this._fiscalYear + "' and SHId=" + _SHId + " and ReceiptNo= 'Paid From Dividend' and TypeofPayment=" + this._TypeofPayment; 
                        //    success = DataObj.Execute(cmdText);
                        //}
                        

                    
                }
                
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
           
            return success;
        }

        private bool InsertAuditlog(DataRow DividendPayment, clDatacon DataObj)
        {
            
            bool success = true;
            try
            {
                
                
                if (this._tblShareRegBookPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (this._DividendToOS> 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Cancele Dividend Paid to Outstanding Share";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"])- (this._DividendToOS) / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        
                        if (success )
                        {
                           
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Cancel Dividend Paid to Outstanding Share";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) - this._DividendToOS);
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                    }
                    if (this._DividendToCapitalized > 0)
                    {
                        
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Cancel Dividend Capitalized";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) - (this._DividendToOS) / 1000); 
                        this._AuditLog["NewValue"] = Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) - (this._DividendToOS / 1000)- (this._DividendToCapitalized / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        if (success)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Cancel Dividend Capitalized";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) - this._DividendToOS);
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"])- this._DividendToOS)- this._DividendToCapitalized;
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }

                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Cancel Dividend Capitalized";
                        this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"];
                        this._AuditLog["NewValue"] = Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"]) - (this._DividendToCapitalized / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        if (success)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Cancel Dividend Capitalized";
                            this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"]) - (this._DividendToCapitalized));
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
            
            return success;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._DividendTrnId = 0;
            this._SHId = 0;
           
           
            this.GetShareholderBrowse(this._SHId);
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SHIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._SHId = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                this.GetShareRegBookListBySHId(this._SHId);
                this.GetShareholderBrowse(this._SHId);
                this.GetDividendPaymentHistory(this._SHId,this._fiscalYear);
            }
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                this.GetShareholderByFiscalYear(this._fiscalYear);
                this.GetDividendPaymentHistoryByFiscalYear(this._fiscalYear);
              
            }
        }

        private bool GetDividendPaymentHistory(int shId, string fiscalyear)
        {
           

                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblDividendPaidList, "SELECT * FROM tblDividendPaid WHERE IsCanceled=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                    DataObj.FillData(this._tblCancelPaidDividendTransactionList, "SELECT * FROM tblCancelPaidDividendTransaction WHERE  SHId=" + shId);
                   
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

        private bool GetDividendPaymentHistoryByFiscalYear(string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblDividendPaidList, "SELECT * FROM tblDividendPaid WHERE IsCanceled=0 and  FiscalYear='" + fiscalyear + "'");
                

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

        private void GetShareholderByFiscalYear(string fiscalYear)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                DataObj.FillData(this._tblShareholderDetailList, "SELECT  SHId, RegCode, FullName+Isnull(' /'+Title+'/','') AS FullName, (RegCode + ' - ' + FullName) AS SHRegCodeWithName FROM tblShareholderDetail WHERE SHId in (select distinct SHId from tblDividendEntitled where FiscalYear='" + fiscalYear + "') ORDER BY RegCode ");
                

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

        private bool GetDividendPaymentEntry(int trnId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblDividendPaid, "SELECT * FROM tblDividendPaid WHERE TrnNo=" + trnId);
                    
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
            try{
                this._CancelPaidDividendTransaction = this._tblCancelPaidDividendTransaction.NewRow();
                clDatacon.SetToDatabaseDefaults(this._CancelPaidDividendTransaction, clMain.ConnString);
               
                if (this._SHId != 0) this._CancelPaidDividendTransaction["SHId"] = this._SHId;
                if (this._DividendTrnId != 0) this._CancelPaidDividendTransaction["TrnNo"] = this._DividendTrnId;
               // if (this._tblShareholderDetailBrowse!=null && this._tblShareholderDetailBrowse.Rows.Count > 0 && this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"] != null) this._tblDividendPaid.Rows[0]["GrossDividend"] = Convert.ToDecimal(this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"]);
                this._CancelPaidDividendTransaction["CancelDate"] = clUtility.GetCurrentDate();
                this._CancelPaidDividendTransaction["CancelDateEth"] = clUtility.GetEthiopicDate(clUtility.GetCurrentDate()); ;

                this._CancelPaidDividendTransaction["CrtBy"] = clMain.User.UserName;
                this._tblCancelPaidDividendTransaction.Rows.Clear();
                this._tblCancelPaidDividendTransaction.Rows.Add(this._CancelPaidDividendTransaction);
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

        private bool GetShareRegBookListBySHId(int ShId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId );
                DataObj.FillData(this._tblShareRegBookPrev, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId );
                if (this._tblShareRegBookList.Rows.Count > 0)
                {
                    
                    if(Convert.IsDBNull(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"])||this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]==null)
                        this._TotalUnpaidShare = Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]);
                    else
                        this._TotalUnpaidShare = Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]);
                    this.TotalUnpaidShareTextBox.Text = this._TotalUnpaidShare.ToString();
                    return true;
                }
                else
                {
                    this._TotalUnpaidShare = 0;
                    this.TotalUnpaidShareTextBox.Text = "";
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

        private void gridDividendPayment_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridDividendPayment.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridDividendPayment.GetDataRow(focused);
                this._DividendTrnId = Convert.ToInt32(curRow["TrnNo"]);
                this._SHId = Convert.ToInt32(curRow["SHId"]);
                this._IsPaid = Convert.ToByte(curRow["IsPaidtoSh"]);
                this._IsPaidtoOS = Convert.ToByte(curRow["IsPaidtoOS"]);
                this._IsCapitalized = Convert.ToByte(curRow["IsCapitalized"]);

                this._DividendToOS = Convert.ToDecimal(curRow["GrossDividendPaidtoOS"]);
                this._DividendToSh = Convert.ToDecimal(curRow["GrossDividendPaidtoSh"]);
                this._DividendToCapitalized = Convert.ToDecimal(curRow["GrossDividendCapitalized"]);


                this.GetShareholderBrowse(this._SHId);
                this.GetDividendPaymentEntry(this._DividendTrnId);
                GetNewEntry();
                this.gridDividendPayment.FocusedRowHandle = focused;
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

               
                cmdText = "SELECT RegCode,Sex, DOReg, DORegEth, IsLBFounder, IsGBFounder FROM tblShareholderDetail  where SHId=" + SHId ;

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
                this.SHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

        private void IsPaidtoShCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(IsPaidtoShCheckBox.Checked)
             this._IsPaid = 1;
            else
              this._IsPaid = 0;
        }

        private void IsPaidtoOSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.IsPaidtoOSCheckBox.Checked)
              this._IsPaidtoOS = 1;
            else
              this._IsPaidtoOS = 0;
        }

        private void IsCapitalizedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.IsCapitalizedCheckBox.Checked)
                this._IsCapitalized = 1;
            else
                this._IsCapitalized = 0;
        }

        private void PaymentDateDateTimePicker_Validated(object sender, EventArgs e)
        {

        }

        

       
      










    }
}