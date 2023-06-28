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
    public partial class frmCancelPaidCashPayable : Form
    {
        #region Fields
        private string _title = "Cancel Cash Payable Payment";
        //private bool _isNew = true;
        //private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _TrnId = 0;

        private string _Message = string.Empty;
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";


        /*this field is a dividended payable which is less than one thausand if the total dividend amount 
        could not be paid to outstanding or capitalized in order to prevent fraction share balance
         */
        private decimal _CashtobePaid = 0;




        private DataTable _tblFiscalYear;
        private DataTable _tblPayCashPayable;
        private DataRow _PayCashPayable;
        private DataTable _tblPayCashPayableList;

        private DataTable _tblCancelPayCashPayable;
        private DataRow _CancelPayCashPayable;
        private DataTable _tblCancelPayCashPayableList;

        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;

        private DataTable _tblShareRegBookPrev;

        private DataTable _tblAuditLog;
        private DataRow _AuditLog;


        private DataTable _tblSharePayment;

        DateTime _CurrentDate;
        DateTime _PaymentDate = Convert.ToDateTime("01/01/1900");

        private int _TypeofPayment = 5;

        #endregion

        
        public frmCancelPaidCashPayable()
        {
            InitializeComponent();
        }
        private void frmCancelPaidCashPayable_Load(object sender, EventArgs e)
        {
            this.printToolStripButton.Visible = false;


            BindControls();
            InitForm(true);

            BindControlsSH();
            InitFormSH(true);
        }

        private void frmCancelPaidCashPayable_KeyDown(object sender, KeyEventArgs e)
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

                this._tblPayCashPayableList = DataObj.GetDataTable("tblPayCashPayable");
                this._tblCancelPayCashPayableList = DataObj.GetDataTable("tblCancelPayCashPayable");
                this._tblFiscalYear = new DataTable("tblFisicalYear");
                this._tblFiscalYear.Columns.Add("FiscalYear", typeof(string));
                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);




                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");

                this._tblPayCashPayable = DataObj.GetDataTable("tblPayCashPayable");
                this._tblPayCashPayable.Columns["CrtDt"].ReadOnly = true;
                this._tblPayCashPayable.Columns["CrtWs"].ReadOnly = true;
                this._tblPayCashPayable.Columns["IsCanceled"].ReadOnly = true;

                this._tblCancelPayCashPayable = DataObj.GetDataTable("tblCancelPayCashPayable");
                this._tblCancelPayCashPayable.Columns["CrtDt"].ReadOnly = true;
                this._tblCancelPayCashPayable.Columns["CrtWs"].ReadOnly = true;



                this._tblSharePayment = DataObj.GetDataTable("tblSharePayment");
                this._tblSharePayment.Columns["CrtDt"].ReadOnly = true;
                this._tblSharePayment.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.SHIdLookUpEdit,
                this.RVNoTextBox,
                this.PaymentDateDateTimePicker,
                this.PaymentDateEthTextBox,
                this.PayableAmountTextBox,
                this.IsPaidtoShRadioButton,
                this.IsPaidtoOSRadioButton
                
               
                   
                });

                clMain.BindControls(cntrsList, this._tblPayCashPayable);
                cntrsList.Clear();

                clMain.SetDataSource(this.gctCashPaidPayable, this._tblPayCashPayableList);
                clMain.SetDataSource(this.gctCancelCashPaidPayable, this._tblCancelPayCashPayableList);
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

                    DataObj.FillData(this._tblFiscalYear, "select distinct FiscalYear from tblPayCashPayable  where IsCanceled=0 order by FiscalYear desc");


                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                DataObj.FillData(this._tblCancelPayCashPayableList, "SELECT * FROM tblCancelPayCashPayable WHERE SHId=" + this._SHId);
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * FROM tblPayCashPayable where IsCanceled=0 and SHId=" + this._SHId);

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
                    if (this._SHId == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select a shareholder");
                        return;
                    }

                    DataObj.OpenConnection();


                    this._CancelPayCashPayable = this._tblCancelPayCashPayable.Rows[0];



                    DataObj.BeginTransaction();
                    string cmdText;
                    if (DataObj.Insert(this._title, this._CancelPayCashPayable, false))
                    {
                        cmdText = "delete tblPayCashPayable  where TrNo=" + this._TrnId;
                        if (DataObj.Execute(cmdText))
                        {
                            if (this.IsPaidtoOSRadioButton.Checked)
                            {
                               // this._PaymentDate = this.PaymentDateDateTimePicker.Value;
                                cmdText = "update tblSharePayment set IsCanceled=1 where FiscalYear='" + this._fiscalYear + "' and SHId=" + _SHId + " and ReceiptNo= 'Paid From Cash Payable of " + this._fiscalYear + " Fiscal Year' and DateofPayment='" + this._PaymentDate + "' and TypeofPayment=" + this._TypeofPayment;

                                if (DataObj.Execute(cmdText))
                                {
                                    cmdText = "Update tblCashPayable set IsPaid=0 where TrNo=" + this._TrnId;
                                    if (DataObj.Execute(cmdText))
                                     {
                                       if (InsertShareRegBook())
                                        {
                                          if (InsertAuditlog(this._CancelPayCashPayable))
                                           {
                                            DataObj.CommitTransaction();
                                            AppMessageBox.ShowInformation("Cash payable payment transaction is canceled successfully");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                           }
                                          else
                                           {
                                            DataObj.RollbackTransaction();
                                            AppMessageBox.ShowInformation("Canceling cash payable payment transaction is failed");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                           }
                                       }
                                     else
                                     {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Canceling cash payable payment transaction is failed");
                                        InitForm(false);
                                        this.refreshToolStripButton_Click(this, new EventArgs());
                                    }
                                  }
                                  else
                                    {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Canceling cash payable payment transaction is failed");
                                        InitForm(false);
                                        this.refreshToolStripButton_Click(this, new EventArgs());
                                    }

                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Canceling cash payable payment transaction is failed");
                                    InitForm(false);
                                    this.refreshToolStripButton_Click(this, new EventArgs());
                                }

                            }
                            else
                            {

                            }

                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("Canceling cash payale payment transaction is failed");
                            InitForm(false);
                            this.refreshToolStripButton_Click(this, new EventArgs());
                        }

                    }
                    else
                    {
                        DataObj.RollbackTransaction();
                        AppMessageBox.ShowInformation("Canceling cash payable payment transaction is failed");
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

        private bool InsertShareRegBook()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();



                decimal PaidShareNo = 0;
                decimal PaidShareAmnt = 0;
                PaidShareNo = this._CashtobePaid / 1000;
                PaidShareAmnt = this._CashtobePaid;
                string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0) -" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0) -" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                success = DataObj.Execute(cmdText);




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

        private bool InsertAuditlog(DataRow DividendPayment)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();

                if (this._tblShareRegBookPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (this.IsPaidtoOSRadioButton.Checked)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Canceling cash Payable Paid to Outstanding Share";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) - (this._CashtobePaid) / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);

                        if (success)
                        {

                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Canceling cash Paid to Outstanding Share";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) - this._CashtobePaid);
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
            this._TrnId = 0;
            this._SHId = 0;

            this.GetPaidCashPayableEntry(this._TrnId);
            this.GetShareholderBrowse(this._SHId);
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SHIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._SHId = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                this.GetShareRegBookListBySHId(this._SHId);
                this.GetShareholderBrowse(this._SHId);
                this.GetPaidshPayableHistory(this._SHId, this._fiscalYear);

            }
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                this.GetShareholderByFiscalYear(this._fiscalYear);
                GetPaidCashPayableHistoryByFisicalYear(this._fiscalYear);

            }
        }

        private void gridDividendPayable_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridCashPaidPayable.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridCashPaidPayable.GetDataRow(focused);
                this._TrnId = Convert.ToInt32(curRow["TrNo"]);
                this._fiscalYear = curRow["FiscalYear"].ToString();
                this._SHId = Convert.ToInt32(curRow["SHId"]);
                this._PaymentDate = Convert.ToDateTime(curRow["PaymentDate"]);
                this._CashtobePaid = Convert.ToDecimal(curRow["PayableAmount"]);

                this.GetShareholderBrowse(this._SHId);
                this.GetPaidCashPayableEntry(this._TrnId);
                this.PayableAmountTextBox.Text = this._CashtobePaid.ToString();
                GetNewEntry();
                this.gridCashPaidPayable.FocusedRowHandle = focused;
            }
        }

        private bool GetPaidshPayableHistory(int shId, string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblCancelPayCashPayableList, "SELECT * FROM tblCancelPayCashPayable WHERE  SHId=" + shId );
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * FROM tblPayCashPayable WHERE SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");

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

        private bool GetPaidCashPayableHistoryByFisicalYear(string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblCancelPayCashPayableList, "SELECT * FROM tblCancelPayCashPayable WHERE  SHId=" + this._SHId );
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * FROM tblPayCashPayable WHERE  FiscalYear='" + fiscalyear + "'");

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

                DataObj.FillData(this._tblShareholderDetailList, "SELECT  SHId, RegCode, FullName+Isnull(' /'+Title+'/','') AS FullName, (RegCode + ' - ' + FullName) AS SHRegCodeWithName FROM tblShareholderDetail WHERE SHId in (select distinct SHId from tblPayCashPayable where FiscalYear='" + fiscalYear + "') ORDER BY RegCode ");


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

        private bool GetPaidCashPayableEntry(int trnId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblPayCashPayable, "SELECT *  FROM tblPayCashPayable WHERE TrNo=" + trnId);
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

            this._CancelPayCashPayable = this._tblCancelPayCashPayable.NewRow();
            clDatacon.SetToDatabaseDefaults(this._CancelPayCashPayable, clMain.ConnString);

            if (this._SHId != 0) this._CancelPayCashPayable["SHId"] = this._SHId;
            if (this._TrnId != 0) this._CancelPayCashPayable["TrNo"] = this._TrnId;

            this._CancelPayCashPayable["CancelDate"] = clUtility.GetCurrentDate();
            this._CancelPayCashPayable["CancelDateEth"] = clUtility.GetEthiopicDate(clUtility.GetCurrentDate()); ;

            this._CancelPayCashPayable["CrtBy"] = clMain.User.UserName;
            this._tblCancelPayCashPayable.Rows.Clear();
            this._tblCancelPayCashPayable.Rows.Add(this._CancelPayCashPayable);




        }

        //private bool GetDividendPaymentEntry(int SHId, string FiscalYear)
        //{


        //    clDatacon DataObj = new clDatacon(clMain.ConnString);



        //    try
        //    {

        //        DataObj.OpenConnection();
        //        DataObj.FillData(this._tblCancelPayDividendPayable, "SELECT FiscalYear, SHId,DividendPayable  FROM tblDividendPaid WHERE IsCanceled=0 and SHId=" + SHId + " AND FiscalYear='" + FiscalYear + "'");
        //        //this.GetNewEntry();
        //        //DataObj.FillData(this._tblDividendPayable, "SELECT * FROM tblDividendPaid WHERE SHId=" + SHId + " AND FiscalYear='" + FiscalYear + "'");
        //        return true;
        //    }
        //    catch (Exception Ex)
        //    {
        //        AppMessageBox.ShowExclamation(Ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        DataObj.CloseConnection();

        //    }

        //}

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
                DataObj.FillData(this._tblShareRegBookPrev, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                if (this._tblShareRegBookList.Rows.Count > 0)
                {

                    if (Convert.IsDBNull(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]) || this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"] == null)
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

        private void DateofPaymentDateTimePicker_Validated(object sender, EventArgs e)
        {

            this.PaymentDateEthTextBox.Text = clUtility.GetEthDate(this.PaymentDateDateTimePicker.Value);
            this._PaymentDate = this.PaymentDateDateTimePicker.Value;

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

                cmdText = "SELECT a.RegCode,a.Sex, a.DOReg, a.DORegEth, a.IsLBFounder, a.IsGBFounder,convert(numeric(18,2),b.PayableAmount,2) as PayableAmount  FROM tblShareholderDetail as a inner join tblPayCashPayable as b on a.SHId= b.SHId where b.IsCanceled=0 and b.SHId=" + SHId + " and b.FiscalYear='" + this._fiscalYear + "'";

                if (_tblShareholderDetailBrowse != null)
                {
                    DataObj.FillData(this._tblShareholderDetailBrowse, cmdText);

                    this._tblShareholderDetailBrowse.Clear();
                    this.PayableAmountTextBox.Text = "0";
                    this.TotalUnpaidShareTextBox.Text = "0";

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






