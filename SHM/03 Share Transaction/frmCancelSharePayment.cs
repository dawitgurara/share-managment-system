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
    public partial class frmCancelSharePayment : Form
    {
        #region Fields
        private string _title = "Cancel Share Payment";
        
       

        private int _SHId = 0;
        private int _PaymentTrnId = 0;
       // DateTime _CurrentDate;
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";
        private DataTable _tblFiscalYear;
        private DataTable _tblTypeofSharePayment;
        private DataTable _tblSharePayment;
        private DataRow _SharePayment;
        private DataTable _tblSharePaymentList;

        private DataTable _tblCancelSharePaymentTransaction;
        private DataRow _CancelSharePaymentTransaction;
        private DataTable _tblCancelSharePaymentTransactionList;


        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
        //private DataRow _ShareRegBook;


        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

       
        public frmCancelSharePayment()
        {
            InitializeComponent();

        }

        private void frmCancelSharePayment_Load(object sender, EventArgs e)
        {
           
            this.PayShareDetailGroupBox.Enabled = false;

            BindControls();
            InitForm(true);

            BindControlsSH();
            InitFormSH(true);
        }

        private void frmCancelSharePayment_KeyDown(object sender, KeyEventArgs e)
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

                this._tblTypeofSharePayment = DataObj.GetDataTable("tblTypeofSharePayment");
                
                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));

                this._tblSharePaymentList = DataObj.GetDataTable("tblSharePayment");
                this._tblFiscalYear = DataObj.GetDataTable("ViewFiscalYears");
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);

                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);
                clMain.SetDataSource(this.TypeofPaymentLookUpEdit, this._tblTypeofSharePayment);
                clMain.SetRepositoryDataSource(this.rluTypeofPayment, this._tblTypeofSharePayment);

                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblCancelSharePaymentTransactionList = DataObj.GetDataTable("tblCancelSharePaymentTransaction");

                this._tblSharePayment = DataObj.GetDataTable("tblSharePayment");
                this._tblSharePayment.Columns["CrtDt"].ReadOnly = true;
                this._tblSharePayment.Columns["CrtWs"].ReadOnly = true;


                this._tblCancelSharePaymentTransaction = DataObj.GetDataTable("tblCancelSharePaymentTransaction");
                this._tblCancelSharePaymentTransaction.Columns["CrtDt"].ReadOnly = true;
                this._tblCancelSharePaymentTransaction.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.SHIdLookUpEdit,
                this.ReceiptNoTextBox,
                this.DateofPaymentDateTimePicker,
                this.DateofPaymentEthTextBox,
                this.EffectiveDateDateTimePicker,
                this.EffectiveDateEthTextBox,
                this.TypeofPaymentLookUpEdit,
                this.NoofSharePaidTextBox,
                this.AmntofSharePaidTextBox
               
                   
                });

                clMain.BindControls(cntrsList, this._tblSharePayment);
                cntrsList.Clear();

                clMain.SetDataSource(this.gctSharePayment, this._tblSharePaymentList);
                clMain.SetDataSource(this.gctCancelSharePayment, this._tblCancelSharePaymentTransactionList);

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

                    
                    DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql("SHStatus=1 and SHId in (select SHId from tblShareRegBook)"));
                    clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);


                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                GetSharePaymentHistory(this._SHId, this._fiscalYear);


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

                if (AppMessageBox.ShowQuestion("If you cancel this paid share, all related transactions will be reversed. Are you sure you want to Cancel it?  " ) == DialogResult.Yes)
                {
                    if (this.Validate())
                    {
                        if (this._SHId == 0)
                        {
                            AppMessageBox.ShowExclamation("Please select a shareholder");
                            return;
                        }

                        DataObj.OpenConnection();
                        DataObj.BeginTransaction();

                        this._CancelSharePaymentTransaction = this._tblCancelSharePaymentTransaction.Rows[0];

                        this._SharePayment = this._tblSharePayment.Rows[0];



                        if (DataObj.Insert(this._title, this._CancelSharePaymentTransaction, false))
                        {
                            
                            if (UpdateShareRegBook(DataObj))
                            {
                                if (InsertAuditlog(this._SharePayment, DataObj))
                                {
                                    DataObj.CommitTransaction();
                                    AppMessageBox.ShowInformation("Cancel share payment transaction is saved successfully");
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Cancel share payment transaction is failed");
                                }
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Cancel share payment transaction is failed");
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
            try
            {


                if (this.GetShareRegBookBySHId(this._SHId))
                {
                    GetShareRegBookListBySHId(this._SHId);
                    int PaidShareNo = 0;
                    decimal PaidShareAmnt = 0;



                    PaidShareNo = Convert.ToInt32(this._SharePayment["NoofSharePaid"]);
                    PaidShareAmnt = Convert.ToDecimal(this._SharePayment["AmntofSharePaid"]);


                    string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0)-" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)-" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);
                        if (success)
                        {
                            cmdText = "UPDATE tblSharePayment Set IsCanceled=1  WHERE PaymentId=" + this._PaymentTrnId;
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

        private bool InsertAuditlog(DataRow SharePayment, clDatacon DataObj)
        {

            bool success = true;
            try
            {

                if (this._tblShareRegBookList.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToInt32(SharePayment["NoofSharePaid"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._PaymentTrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Share Paid";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookList.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookList.Rows[0]["PaidUpNoofShare"]) - Convert.ToInt32(SharePayment["NoofSharePaid"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && Convert.ToDecimal(SharePayment["AmntofSharePaid"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._PaymentTrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Share Paid";
                        this._AuditLog["FldChged"] = "PaidUpShareAmt";
                        this._AuditLog["OldValue"] = this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]) - Convert.ToDecimal(SharePayment["AmntofSharePaid"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success)
                    {
                        this._AuditLog["TblName"] = "tblSharePayment";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._PaymentTrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Share Paid";
                        this._AuditLog["FldChged"] = "IsCanceled";
                        this._AuditLog["OldValue"] = 0;
                        this._AuditLog["NewValue"] = 1;
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
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
            this._PaymentTrnId = 0;
            this._SHId = 0;
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

            if (this.SHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._SHId = 0;

                this._tblShareholderDetailBrowse.Rows.Clear();
            }
            else
            {
                this._SHId = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                this.GetShareholderBrowse(this._SHId);



            }
            GetSharePaymentHistory(this._SHId, this._fiscalYear);
            GetShareRegBookListBySHId(this._SHId);
            
           
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                //GetSharePaymentHistory(this._SHId, this._fiscalYear);
            }
        }

        //private void gridCancelSharePayment_DoubleClick(object sender, EventArgs e)
        //{
        //    int focused = this.gridCancelSharePayment.FocusedRowHandle;
        //    if (focused >= 0)
        //    {
        //        DataRow curRow = this.gridCancelSharePayment.GetDataRow(focused);
        //        this._PaymentTrnId = Convert.ToInt32(curRow["TrnId"]);
        //        this._SHId = Convert.ToInt32(curRow["SHId"]);

        //        this.GetShareholderBrowse(this._SHId);
        //        this.GetSharePaymentEntry(this._PaymentTrnId);
        //       // GetNewEntry();
        //        this.gridCancelSharePayment.FocusedRowHandle = focused;
        //    }
        //}

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void gridSharePayment_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridSharePayment.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridSharePayment.GetDataRow(focused);
                this._PaymentTrnId = Convert.ToInt32(curRow["PaymentId"]);
                this._SHId = Convert.ToInt32(curRow["SHId"]);

                this.GetShareholderBrowse(this._SHId);
                this.GetSharePaymentEntry(this._PaymentTrnId);
                GetNewEntry();
                this.gridSharePayment.FocusedRowHandle = focused;
            }
        }

        private bool GetSharePaymentHistory(int shId, string fiscalyear)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblSharePaymentList, "SELECT * FROM tblSharePayment WHERE IsCanceled=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                    DataObj.FillData(this._tblCancelSharePaymentTransactionList, "SELECT * FROM tblCancelSharePaymentTransaction WHERE  SHId=" + shId);
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

        private bool GetSharePaymentEntry(int trnId)
        {
            
               
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblSharePayment, "SELECT * FROM tblSharePayment WHERE PaymentId=" + trnId);
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
                this._CancelSharePaymentTransaction = this._tblCancelSharePaymentTransaction.NewRow();
                clDatacon.SetToDatabaseDefaults(this._CancelSharePaymentTransaction, clMain.ConnString);

                if (this._SHId != 0) this._CancelSharePaymentTransaction["SHId"] = this._SHId;
                if (this._PaymentTrnId != 0) this._CancelSharePaymentTransaction["TrnId"] = this._PaymentTrnId;


                this._CancelSharePaymentTransaction["EffectiveDate"] = clUtility.GetCurrentDate();
                this._CancelSharePaymentTransaction["EffectiveDateEth"] = clUtility.GetEthiopicDate(clUtility.GetCurrentDate());

                this._CancelSharePaymentTransaction["CrtBy"] = clMain.User.UserName;
                this._tblCancelSharePaymentTransaction.Rows.Clear();
                this._tblCancelSharePaymentTransaction.Rows.Add(this._CancelSharePaymentTransaction);
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
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                
                if (this._tblShareRegBookList.Rows.Count > 0)
                {

                    if (Convert.IsDBNull(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]) || this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"] == null)
                        this._TotalUnpaidShare = Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]);
                    else
                        this._TotalUnpaidShare = Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]);
                    this.TotalUnpaidSharetextBox.Text = this._TotalUnpaidShare.ToString();
                    return true;
                }
                else
                {
                    this._TotalUnpaidShare = 0;
                    this.TotalUnpaidSharetextBox.Text = "";
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
                this.SHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

       











    }
}


