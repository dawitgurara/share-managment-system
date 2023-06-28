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
    public partial class frmPayCashPayable : Form
    {
        #region Fields
        private string _title = "Cash Payable Payment";
        //private bool _isNew = true;
        //private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _TrnId = 0;

        private string _Message = string.Empty;
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";


        /*this field is a cash payable which is less than one thausand if the the shareholder paid over or under  1000 
        that difference amount is recorded as payable amount and at any apropraite time that amount can be paid to OS or to the shareholder himself/herself 
         */
        private decimal _CashtobePaid = 0;




        private DataTable _tblFiscalYear;
        //tblDividendPaid
        private DataTable _tblPayCashPayable;
        private DataRow _PayCashPayable;
        private DataTable _tblPayCashPayableList;
        private DataTable _tblCashPayableList;

        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;

        private DataTable _tblShareRegBookPrev;

        private DataTable _tblAuditLog;
        private DataRow _AuditLog;


        private DataTable _tblSharePayment;
        private DataRow _SharePayment;
        DateTime _CurrentDate;
        DateTime _PaymentDate = Convert.ToDateTime("01/01/1900");

        private int _TypeofPayment = 5;

        #endregion

        #region Properties
        //public bool IsNew
        //{
        //    get { return this._isNew; }
        //    set
        //    {
        //        this._isNew = value;
        //        //this.deleteToolStripButton.Enabled = !this._isNew;
        //    }
        //}
        #endregion

        public frmPayCashPayable()
        {
            InitializeComponent();
        }

        private void frmDividendPayable_Load(object sender, EventArgs e)
        {

            BindControls();
            InitForm(true);

            BindControlsSH();
            InitFormSH(true);
        }

        private void frmDividendPayable_KeyDown(object sender, KeyEventArgs e)
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
                this._tblCashPayableList = DataObj.GetDataTable("tblCashPayable");
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

                this._tblSharePayment = DataObj.GetDataTable("tblSharePayment");
                this._tblSharePayment.Columns["CrtDt"].ReadOnly = true;
                this._tblSharePayment.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.SHIdLookUpEdit,
                this.PVNoTextBox,
                this.RVNoTextBox,
                this.PaymentDateDateTimePicker,
                this.PaymentDateEthTextBox,
                this.PayableAmountTextBox,
                this.IsPaidtoShRadioButton,
                this.IsPaidtoOSRadioButton
                
               
                   
                });

                clMain.BindControls(cntrsList, this._tblPayCashPayable);
                cntrsList.Clear();

                clMain.SetDataSource(this.gctCashPayable, this._tblCashPayableList);
                clMain.SetDataSource(this.gctPaidCashPayable, this._tblPayCashPayableList);
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

                    DataObj.FillData(this._tblFiscalYear, "select distinct FiscalYear from tblCashPayable  where IsPaid=0 order by FiscalYear desc");


                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable WHERE IsPaid=0 ");
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * FROM tblPayCashPayable where IsCanceled=0");
                //GetDividendPaymentHistory(this._SHId, this._fiscalYear);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
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


                    this._PayCashPayable = this._tblPayCashPayable.Rows[0];

                    if (!ValidateValues())
                    {
                        AppMessageBox.ShowExclamation(this._Message);
                        return;
                    }


                    //if (this._isNew)
                    //{

                    DataObj.BeginTransaction();
                    this._PayCashPayable["IsPaidtoSh"]=this.IsPaidtoShRadioButton.Checked;
                    this._PayCashPayable["IsPaidtoOS"] = this.IsPaidtoOSRadioButton.Checked;
                    this._PayCashPayable["CrtBy"] = clMain._user.UserName;

                    if (DataObj.Insert(this._title, this._PayCashPayable, false))
                    {
                        string cmdText = "Update tblCashPayable set IsPaid=1 where TrNo=" + this._TrnId;
                        if (DataObj.Execute(cmdText))
                        {
                            if (this.IsPaidtoOSRadioButton.Checked)
                            {
                                GetPaymentEntry();

                                if (DataObj.Insert("Share Payment", this._SharePayment, false))
                                {
                                    if (InsertShareRegBook())
                                    {
                                        if (InsertAuditlog(this._PayCashPayable))
                                        {
                                            DataObj.CommitTransaction();
                                            AppMessageBox.ShowInformation("Cash payable payment transaction is saved successfully");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                        }
                                        else
                                        {
                                            DataObj.RollbackTransaction();
                                            AppMessageBox.ShowInformation("Cash payable payment transaction is failed");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                        }
                                    }
                                    else
                                    {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Cash payable payment transaction is failed");
                                        InitForm(false);
                                        this.refreshToolStripButton_Click(this, new EventArgs());
                                    }

                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Cash payable payment transaction is failed");
                                    InitForm(false);
                                    this.refreshToolStripButton_Click(this, new EventArgs());
                                }

                            }
                           

                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("Cash payale payment transaction is failed");
                            InitForm(false);
                            this.refreshToolStripButton_Click(this, new EventArgs());
                        }

                    }
                    else
                    {
                        DataObj.RollbackTransaction();
                        AppMessageBox.ShowInformation("Cash payable payment transaction is failed");
                        InitForm(false);
                        this.refreshToolStripButton_Click(this, new EventArgs());
                    }





                    //}

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
                string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0) +" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0) +" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
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
                        this._AuditLog["ActionTaken"] = "Cash payable paid to outstanding share";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) + (this._CashtobePaid) / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);

                        if (success)
                        {

                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Cash payable paid to outstanding share";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) + this._CashtobePaid);
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

        private void GetPaymentEntry()
        {

            string currentFisicalYar = "";
            currentFisicalYar=clUtility.GetCurrentFiscalYear();
            this._SharePayment = this._tblSharePayment.NewRow();
            clDatacon.SetToDatabaseDefaults(this._SharePayment, clMain.ConnString);

            this._PaymentDate = PaymentDateDateTimePicker.Value;
            this._SharePayment["FiscalYear"] = currentFisicalYar;
            if (this._SHId != 0) this._SharePayment["SHId"] = this._SHId;
            this._SharePayment["ReceiptNo"] = "Paid From Cash Payable of " + this._fiscalYear + " Fiscal Year";
            if (this._TypeofPayment != 0) this._SharePayment["TypeofPayment"] = this._TypeofPayment;
            this._SharePayment["AmntofSharePaid"] = this._CashtobePaid;
            this._SharePayment["NoofSharePaid"] = clUtility.GetShareNoByShareAmount(this._CashtobePaid);
            this._SharePayment["DateofPayment"] = this._PaymentDate;
            this._SharePayment["DateofPaymentEth"] = clUtility.GetEthDate(this._PaymentDate);
            this._SharePayment["CrtBy"] = clMain.User.UserName;

            
            
            int mon;
            int year;
            if (this._PaymentDate.Day >= 15)
            {

                if (this.PaymentDateDateTimePicker.Value.Month < 12)
                {
                    mon = this.PaymentDateDateTimePicker.Value.Month + 1;
                    year = this.PaymentDateDateTimePicker.Value.Year;
                }
                else
                {
                    mon = 1;
                    year = (this.PaymentDateDateTimePicker.Value.Year) + 1;
                }

                this._SharePayment["EffectiveDate"] = "01/" + mon + "/" + year;
                this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
            }
            else
            {
                this._SharePayment["EffectiveDate"] = "01/" + (this._PaymentDate.Month) + "/" + this._PaymentDate.Year;
                this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
            }
            
            
            this._tblSharePayment.Rows.Clear();
            this._tblSharePayment.Rows.Add(this._SharePayment);


        }

        private bool ValidateValues()
        {
            bool result = true;



            this._Message = string.Empty;
            if (this._PayCashPayable["PayableAmount"] != null)

                this._CashtobePaid = Convert.ToDecimal(this._PayCashPayable["PayableAmount"]);


            if (!(this.IsPaidtoShRadioButton.Checked || this.IsPaidtoOSRadioButton.Checked))
                this._Message = "Cash payale sould be Paid to either to Shareholder or to outstanding. So either 'Is Paid to Sh' or 'Is Paid to OS' Check Box should be checked\n";

            if (this.IsPaidtoShRadioButton.Checked)
            {

                if (this.PVNoTextBox.Text.Trim() == "" || this.PVNoTextBox.Text.Trim() == string.Empty)
                {
                    this._Message = "Please  enter PV No. if you want to pay cash payable to a shareholder\n";
                    this.PVNoTextBox.Focus();
                }

            }
            else if (this.IsPaidtoOSRadioButton.Checked && (this._CashtobePaid > Convert.ToDecimal(this.TotalUnpaidShareTextBox.Text)))
            {
                this._Message = "Cash payable To OS should not be greater than Total Unpaid Share!\n";
                
            }

            if (this._Message != string.Empty)
            
                result = false;
               
            return result;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TrnId = 0;
            this._SHId = 0;

            this.GetPayCashPayableEntry(this._SHId, this._fiscalYear);
            this.GetShareholderBrowse(this._SHId);
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SHIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._SHId = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                this.GetShareRegBookListBySHId(this._SHId);
                this.GetShareholderBrowse(this._SHId);
                this.GetCashPayableHistory(this._SHId, this._fiscalYear);

            }
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                this.GetShareholderByFiscalYear(this._fiscalYear);
                GetCashPayableHistoryByFisicalYear(this._fiscalYear);

            }
        }

        private void gridCashPayable_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridCashPayable.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridCashPayable.GetDataRow(focused);
                this._TrnId = Convert.ToInt32(curRow["TrNo"]);
                this._SHId = Convert.ToInt32(curRow["SHId"]);

                this.GetShareholderBrowse(this._SHId);
                this.GetPayCashPayableEntry(this._TrnId);

                this.gridCashPayable.FocusedRowHandle = focused;
            }
        }

        private bool GetCashPayableHistory(int shId, string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable WHERE IsPaid = 0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * FROM tblPayCashPayable WHERE IsCanceled=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");

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

        private bool GetCashPayableHistoryByFisicalYear(string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable WHERE IsPaid = 0  and FiscalYear='" + fiscalyear + "'");
                DataObj.FillData(this._tblPayCashPayableList, "SELECT * from tblPayCashPayable WHERE IsCanceled=0 and  FiscalYear='" + fiscalyear + "'");

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

                DataObj.FillData(this._tblShareholderDetailList, "SELECT  SHId, RegCode, FullName+Isnull(' /'+Title+'/','') AS FullName, (RegCode + ' - ' + FullName) AS SHRegCodeWithName FROM tblShareholderDetail WHERE  SHId in(select SHId from tblCashPayable where IsPaid=0) ORDER BY RegCode ");


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

        private bool GetPayCashPayableEntry(int trnId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblPayCashPayable, "SELECT TrNo,FiscalYear,SHId,RVNo,PayableAmount  FROM tblCashPayable WHERE TrNo=" + trnId);
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

            this._PayCashPayable = this._tblPayCashPayable.NewRow();
            clDatacon.SetToDatabaseDefaults(this._PayCashPayable, clMain.ConnString);
            if (this._fiscalYear != "0") this._PayCashPayable["FiscalYear"] = this._fiscalYear;
            if (this._SHId != 0) this._PayCashPayable["SHId"] = this._SHId;
            if (this._tblShareholderDetailBrowse != null && this._tblShareholderDetailBrowse.Rows.Count > 0 && this._tblShareholderDetailBrowse.Rows[0]["PayableAmount"] != null) this._PayCashPayable["PayableAmount"] = Convert.ToDecimal(this._tblShareholderDetailBrowse.Rows[0]["PayableAmount"]);
            this._PayCashPayable["CrtBy"] = clMain.User.UserName;
            this._tblPayCashPayable.Rows.Clear();
            this._tblPayCashPayable.Rows.Add(this._PayCashPayable);

        }

        private bool GetPayCashPayableEntry(int SHId, string FiscalYear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);



            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblPayCashPayable, "SELECT *  FROM tblPayCashPayable WHERE IsCanceled=0 and SHId=" + SHId + " AND FiscalYear='" + FiscalYear + "'");
                
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

                cmdText = "SELECT a.RegCode,a.Sex, a.DOReg, a.DORegEth, a.IsLBFounder, a.IsGBFounder,convert(numeric(18,2),b.PayableAmount,2) as PayableAmount  FROM tblShareholderDetail as a inner join tblCashPayable as b on a.SHId= b.SHId where b.IsPaid=0 and b.SHId=" + SHId + " and b.FiscalYear='" + this._fiscalYear + "'";

                if (_tblShareholderDetailBrowse != null)
                {
                    DataObj.FillData(this._tblShareholderDetailBrowse, cmdText);
                    if (this._tblShareholderDetailBrowse.Rows.Count > 0 && this._tblShareholderDetailBrowse.Rows[0]["PayableAmount"] != null)
                    {
                        this.PayableAmountTextBox.Text = this._tblShareholderDetailBrowse.Rows[0]["PayableAmount"].ToString();

                    }
                    else
                    {
                        this._tblShareholderDetailBrowse.Clear();
                        this.PayableAmountTextBox.Text = "0";
                        this.TotalUnpaidShareTextBox.Text = "0";
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
        }
        #endregion

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchByComboBox.SelectedIndex != -1)
            {
                this.SHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

       

        //private void IsPaidtoOSRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.IsPaidtoOSRadioButton.Checked)
        //        this._IsPaidtoOS = true;
        //    else
        //        this._IsPaidtoOS = false;
        //}

        //private void IsPaidtoShRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (IsPaidtoShRadioButton.Checked)
        //        this._IsPaid = true;
        //    else
        //        this._IsPaid = false;
        //}



















    }
}




