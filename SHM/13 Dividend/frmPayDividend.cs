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
    public partial class frmPayDividend : Form
    {
        #region Fields
        private string _title = "Dividend Payment";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _DividendTrnId = 0;

        private string _Message = string.Empty;
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";
        private decimal _DividendToSh=0;
        private decimal _DividendToOS=0;
        private decimal _DividendToCapitalized = 0;
        /*this field is a dividended payable which is less than one thausand if the total dividend amount 
        could not be paid to outstanding or capitalized in order to prevent fraction share balance
         */
        private decimal _DividendPayable = 0;
        private bool _IsPaid = false;
        private bool _IsPaidtoOS = false;
        private bool _IsCapitalized = false;
        private decimal _tax = 0;
        

        private DataTable _tblFiscalYear;
        //tblDividendPaid
        private DataTable _tblDividendPaid;
        private DataRow _DividendPaid;
        private DataTable _tblDividendPaidList;
       

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
       
        private DataTable _tblShareRegBookPrev;
       
        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        private DataTable _tblTypeofSharePayment;
        private DataTable _tblSharePayment;
        private DataRow _SharePayment;
        DateTime _CurrentDate;
        DateTime _PaymentDate = Convert.ToDateTime("01/01/1900");
        DateTime _EffectiveDate;
        string _EffectiveDateEth;
        decimal _SharAmount = 0;
        decimal _SharNo = 0;
        private int _TypeofPayment = 6;

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

        public frmPayDividend()
        {
            InitializeComponent();
            
        }

        private void frmPayDividend_Load(object sender, EventArgs e)
        {
            this.printToolStripButton.Visible = false;
            this.TaxAmntTextBox.Text = "0";
            this._tax = 0;
            BindControls();
            InitForm(true);
            
            BindControlsSH();
            InitFormSH(true);
        }

        private void frmPayDividend_KeyDown(object sender, KeyEventArgs e)
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
                
                this._tblSharePayment = DataObj.GetDataTable("tblSharePayment");
                this._tblSharePayment.Columns["CrtDt"].ReadOnly = true;
                this._tblSharePayment.Columns["CrtWs"].ReadOnly = true;

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
                this.DividendPayableTextBox,
                this.IsPaidtoShCheckBox,
                this.IsPaidtoOSCheckBox,
                this.IsCapitalizedCheckBox,
                this.DeductTaxLOSPCheckBox,
                this.TaxAmntTextBox,
                this.RemarkTextBox
               
                   
                });

                    clMain.BindControls(cntrsList, this._tblDividendPaid);
                    cntrsList.Clear();

                    clMain.SetDataSource(this.gctDividendPayment, this._tblDividendPaidList);
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
                   

                    this._DividendPaid = this._tblDividendPaid.Rows[0];

                    if (!ValidateValues())
                    {
                        AppMessageBox.ShowExclamation(this._Message);
                        return;
                    }


                    if (this._isNew)
                    {
                        if (!(this._IsPaidtoOS || this._IsCapitalized))
                        {
                            DataObj.BeginTransaction();
                            if (DataObj.Insert(this._title, this._DividendPaid, false))
                            {
                                string cmdText = "Update tblDividendEntitled set IsPaid='" + this._IsPaid + "',IsPaidToOutstanding='" + this._IsPaidtoOS + "',IsCapitalized='" + this._IsCapitalized + "' where SHID=" + this._SHId + " and FiscalYear='" + this._fiscalYear + "'";
                                if (DataObj.Execute(cmdText))
                                {
                                    //if (InsertShareRegBook())
                                    //{

                                        if (InsertAuditlog(this._DividendPaid))
                                        {
                                            DataObj.CommitTransaction();
                                            AppMessageBox.ShowInformation("Dividend payment transaction is saved successfully");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                        }
                                        else
                                        {
                                            DataObj.RollbackTransaction();
                                            AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                            InitForm(false);
                                            this.refreshToolStripButton_Click(this, new EventArgs());
                                        }
                                    //}
                                    //else
                                    //{
                                    //    DataObj.RollbackTransaction();
                                    //    AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                    //    InitForm(false);
                                    //    this.refreshToolStripButton_Click(this, new EventArgs());
                                    //}
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                    InitForm(false);
                                    this.refreshToolStripButton_Click(this, new EventArgs());
                                }

                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                InitForm(false);
                                this.refreshToolStripButton_Click(this, new EventArgs());
                            }
                        }
                        else
                        {
                            DataObj.BeginTransaction();
                            if (DataObj.Insert(this._title, this._DividendPaid, false))
                            {
                                string cmdText = "Update tblDividendEntitled set IsPaid='" + this._IsPaid + "',IsPaidToOutstanding='" + this._IsPaidtoOS + "',IsCapitalized='" + this._IsCapitalized + "' where SHID=" + this._SHId + " and FiscalYear='" + this._fiscalYear + "'";
                                if (DataObj.Execute(cmdText))
                                {
                                    GetPaymentEntry();
                                    if (DataObj.Insert("Share Payment", this._SharePayment, false))
                                    {
                                        
                                        
                                            if (InsertShareRegBook())
                                            {
                                                if (InsertAuditlog(this._DividendPaid))
                                                {
                                                    DataObj.CommitTransaction();
                                                    AppMessageBox.ShowInformation("Dividend payment transaction is saved successfully");
                                                    InitForm(false);
                                                    this.refreshToolStripButton_Click(this, new EventArgs());
                                                }
                                            }
                                            else
                                            {
                                                DataObj.RollbackTransaction();
                                                AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                                InitForm(false);
                                                this.refreshToolStripButton_Click(this, new EventArgs());
                                            }
                                        
                                   }
                                  else
                                   {
                                        DataObj.RollbackTransaction();
                                        AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                        InitForm(false);
                                        this.refreshToolStripButton_Click(this, new EventArgs());
                                    }
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                    InitForm(false);
                                    this.refreshToolStripButton_Click(this, new EventArgs());
                                }

                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Dividend payment transaction is failed");
                                InitForm(false);
                                this.refreshToolStripButton_Click(this, new EventArgs());
                            }
                        }

                        

                    }
                    else
                    {

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


                if ((this._DividendToOS + this._DividendToCapitalized) > 0)
                {
                    decimal PaidShareNo = 0;
                    decimal PaidShareAmnt = 0;
                    PaidShareNo = this._DividendToOS / 1000 + this._DividendToCapitalized / 1000;
                    PaidShareAmnt = this._DividendToOS + this._DividendToCapitalized;
                    string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0) +" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0) +" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);
                    if (success && this._DividendToCapitalized > 0)
                    {
                        decimal CapitalizedShareNo = this._DividendToCapitalized / 1000;
                        decimal CapitalizedShareAmnt = this._DividendToCapitalized;

                        cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)+" + CapitalizedShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)+" + CapitalizedShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                        success = DataObj.Execute(cmdText);
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


                    if (this._DividendToOS> 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Dividend Paid to Outstanding Share";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) + (this._DividendToOS) / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        
                        if (success )
                        {
                           
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Dividend Paid to Outstanding Share";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) + this._DividendToOS);
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }
                    }
                    if (this._DividendToCapitalized > 0)
                    {
                        
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Dividend Capitalized";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = (Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) + (this._DividendToOS) / 1000); 
                        this._AuditLog["NewValue"] = Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]) + (this._DividendToOS / 1000)+ (this._DividendToCapitalized / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        if (success)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Dividend Capitalized";
                            this._AuditLog["FldChged"] = "PaidUpShareAmt";
                            this._AuditLog["OldValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) + this._DividendToOS);
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]) + this._DividendToOS)+ this._DividendToCapitalized;
                            this._AuditLog["UserId"] = clMain.User.UserName;
                            success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        }

                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Dividend Capitalized";
                        this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"];
                        this._AuditLog["NewValue"] = Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"]) + (this._DividendToCapitalized / 1000);
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                        if (success)
                        {
                            this._AuditLog["TblName"] = "tblShareRegBook";
                            this._AuditLog["KeyFld"] = "SHId";
                            this._AuditLog["KeyFldValue"] = this._SHId;
                            this._AuditLog["ActionTaken"] = "Dividend Capitalized";
                            this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                            this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"];
                            this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"]) + (this._DividendToCapitalized));
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

                string currentFisicalYear = "";
                int year;
                currentFisicalYear = clUtility.GetCurrentFiscalYear();
                this._SharePayment = this._tblSharePayment.NewRow();
                clDatacon.SetToDatabaseDefaults(this._SharePayment, clMain.ConnString);
                
                
                this._SharePayment["FiscalYear"] = currentFisicalYear; 
                if (this._SHId != 0) this._SharePayment["SHId"] = this._SHId;
                this._SharePayment["ReceiptNo"] = "Paid From Dividend of " + this._fiscalYear + " Fisical Year"; 

               
                this._CurrentDate = clUtility.GetCurrentDate();
                if (this._PaymentDate.ToShortDateString() == "01/01/1900")
                    this._PaymentDate = this._CurrentDate;

                this._SharePayment["DateofPayment"] = this._PaymentDate;
                this._SharePayment["DateofPaymentEth"] = clUtility.GetEthDate(this._PaymentDate);
                
                year = clUtility.GetStartYearOfFisicalYear(currentFisicalYear);
                this._SharePayment["EffectiveDate"] = "01/07/" + year.ToString();
                this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
                    
                if (this._TypeofPayment != 0) this._SharePayment["TypeofPayment"] = this._TypeofPayment;
                this._SharePayment["AmntofSharePaid"] = this._DividendToOS + this._DividendToCapitalized;
                this._SharePayment["NoofSharePaid"] = clUtility.GetShareNoByShareAmount(this._DividendToOS + this._DividendToCapitalized);
                this._SharePayment["CrtBy"] = clMain.User.UserName;
                this._tblSharePayment.Rows.Clear();
                this._tblSharePayment.Rows.Add(this._SharePayment);
               
            
        }

        //private void GetPaymentEntry()
        //{
        //    if (!this._isLoadingEntry)
        //    {

        //        this._SharePayment = this._tblSharePayment.NewRow();
        //        clDatacon.SetToDatabaseDefaults(this._SharePayment, clMain.ConnString);

        //        if (this._fiscalYear != "0") this._SharePayment["FiscalYear"] = clMain.CurrentPeriod.FiscalYear;  // this._fiscalYear;
        //        if (this._SHId != 0) this._SharePayment["SHId"] = this._SHId;
        //        this._SharePayment["ReceiptNo"] = "Paid From Dividend";


        //        int mon, year;
        //        this._CurrentDate = clUtility.GetCurrentDate();
        //        if (this._PaymentDate.ToShortDateString() == "01/01/1900")
        //            this._PaymentDate = this._CurrentDate;

        //        this._SharePayment["DateofPayment"] = this._PaymentDate;
        //        this._SharePayment["DateofPaymentEth"] = clUtility.GetEthDate(this._PaymentDate);
        //        if (this._PaymentDate.Day >= 15)
        //        {

        //            if (this._PaymentDate.Month < 12)
        //            {
        //                mon = this._PaymentDate.Month + 1;
        //                year = this._PaymentDate.Year;
        //            }
        //            else
        //            {
        //                mon = 1;
        //                year = this._PaymentDate.Year + 1;
        //            }

        //            this._SharePayment["EffectiveDate"] = "01/" + mon + "/" + year;
        //            this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));


        //        }
        //        else
        //        {
        //            this._SharePayment["EffectiveDate"] = "01/" + (this._PaymentDate.Month) + "/" + this._PaymentDate.Year;
        //            this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));

        //        }
        //        if (this._TypeofPayment != 0) this._SharePayment["TypeofPayment"] = this._TypeofPayment;
        //        this._SharePayment["AmntofSharePaid"] = this._DividendToOS + this._DividendToCapitalized;
        //        this._SharePayment["NoofSharePaid"] = clUtility.GetShareNoByShareAmount(this._DividendToOS + this._DividendToCapitalized);
        //        this._SharePayment["CrtBy"] = clMain.User.UserName;
        //        this._tblSharePayment.Rows.Clear();
        //        this._tblSharePayment.Rows.Add(this._SharePayment);

        //    }
        //}

        private bool ValidateValues()
        {
            bool result = false;



            this._Message = "";
            if (this._DividendPaid["DividendPayable"] != null)
            
                this._DividendPayable = Convert.ToDecimal(this._DividendPaid["DividendPayable"]);


            if (this._DividendPaid["GrossDividendPaidtoSh"] != null)
            {
                _DividendToSh = Convert.ToDecimal(this._DividendPaid["GrossDividendPaidtoSh"]);
                if (_DividendToSh>0)
                {
                    
                        if (this.PVNoTextBox.Text.Trim() == "" || this.PVNoTextBox.Text.Trim() == string.Empty)
                        {
                            this._Message="Please  enter PV No. if you want to pay dividend to a shareholder\n";
                            this.PVNoTextBox.Focus();
                        }
                        if (!this._IsPaid)
                            this._Message = "If Dividend sould be Paid to a Shareholder,'Is Paid to Sh' Check Box should be checked\n";
                }
            }
            if (this._DividendPaid["GrossDividendPaidtoOS"] != null)
            {
                _DividendToOS = Convert.ToDecimal(this._DividendPaid["GrossDividendPaidtoOS"]);
                if (!this._IsPaidtoOS && _DividendToOS>0)
                {
                    this._Message = this._Message + "If Dividend should be Paid to outstanding share,'Is Paid to OS' Check Box should be checked\n";
                }
            }
            if (this._DividendPaid["GrossDividendCapitalized"] != null)
            {
                _DividendToCapitalized = Convert.ToDecimal(this._DividendPaid["GrossDividendCapitalized"]);
                if (!this._IsCapitalized && _DividendToCapitalized>0)
                {
                    this._Message = this._Message + "If Dividend should be capitalized,'Is  Capitalized' Check Box should be checked\n";
                }
            }
            if (this._Message != string.Empty)
            {
                result = false;
                return result;
            }
            else
            {
                if (_DividendToOS > Convert.ToDecimal(this.TotalUnpaidShareTextBox.Text))
                {
                    this._Message = "Dividend To OS should not be greater than Total Unpaid Share!\n";
                    result = false;
                }
                else if ((this._DividendToSh + this._DividendToOS + this._DividendToCapitalized+this._DividendPayable+this._tax) > Convert.ToDecimal(this._DividendPaid["GrossDividend"]))
                {
                    this._Message = " The Sum or each of Dividend To Sh,\n" +
                                    " Dividend To OS and \n" +
                                    " Dividend To Capitalized\n" +
                                    " Dividendd Payable\n"+
                                    " should not be greater than Gross Dividend !";
                    result = false;
                }
                //else if ((_DividendToSh + _DividendToOS + _DividendToCapitalized)+this._tax < Convert.ToDecimal(this._DividendPaid["GrossDividend"]))
                //{
                //    this._Message = " The Sum of Dividend To Sh,\n" +
                //                    " Dividend To OS and \n" +
                //                    " Dividend To Capitalized\n" +
                //                    " should not be less than Gross Dividend !";
                //    result = false;
                //}
                else if ((_DividendToSh + _DividendToOS + _DividendToCapitalized) == 0)
                {
                    this._Message = " Either of Dividend To Sh or \n" +
                                    " Dividend To OS or \n" +
                                    " Dividend To Capitalized\n" +
                                    " should  be greater than 0 !";
                    result = false;
                }
                else
                    result = true;
            }

            return result;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._DividendTrnId = 0;
            this._SHId = 0;
            this._DividendToOS = 0;
            this._DividendToSh = 0;
            this._DividendToCapitalized = 0;
           
            this.GetDividendPaymentEntry(this._SHId,  this._fiscalYear);
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
                this.TaxAmntTextBox.Text = "0";
            }
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                this.GetShareholderByFiscalYear(this._fiscalYear);
              
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
               
                this.GetShareholderBrowse(this._SHId);
                this.GetDividendPaymentEntry(this._DividendTrnId);

                this.gridDividendPayment.FocusedRowHandle = focused;
            }
        }

        private bool GetDividendPaymentHistory(int shId, string fiscalyear)
        {
            if (!this._isLoadingEntry)
            {

                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblDividendPaidList, "SELECT * FROM tblDividendPaid WHERE IsCanceled=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                    if (this._tblDividendPaidList.Rows.Count > 0 && !Convert.ToBoolean(this._tblDividendPaidList.Rows[0]["IsCanceled"]))
                    {
                        this.DivGroupBox.Enabled = false;
                        this.tspDivPayment.Enabled = false;
                    }
                    else
                    {
                        this.DivGroupBox.Enabled = true;
                        this.tspDivPayment.Enabled = true;
                    }
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
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
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
                this._DividendPaid = this._tblDividendPaid.NewRow();
                clDatacon.SetToDatabaseDefaults(this._DividendPaid, clMain.ConnString);
                if (this._fiscalYear != "0") this._DividendPaid["FiscalYear"] = this._fiscalYear;
                if (this._SHId != 0) this._DividendPaid["SHId"] = this._SHId;
                if (this._tblShareholderDetailBrowse!=null && this._tblShareholderDetailBrowse.Rows.Count > 0 && this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"] != null) this._DividendPaid["GrossDividend"] = Convert.ToDecimal(this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"]);
                this._DividendPaid["CrtBy"] = clMain.User.UserName;
                this._tblDividendPaid.Rows.Clear();
                this._tblDividendPaid.Rows.Add(this._DividendPaid);
                this._isLoadingEntry = false;
            }
        }

        private bool GetDividendPaymentEntry(int SHId, string FiscalYear)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.DividendPaymentExists(SHId, FiscalYear))
                {
                    this._isLoadingEntry = false;
                   
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblDividendPaid, "SELECT * FROM tblDividendPaid WHERE SHId=" + SHId + " AND FiscalYear='" + FiscalYear + "'");
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

        private bool DividendPaymentExists(int shId, string FiscalYear)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (shId == 0 || FiscalYear == string.Empty )
                return false;
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SHId FROM tblDividendPaid WHERE SHId=" + shId + " AND FiscalYear='" + FiscalYear + "'";
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

        private void ReceiptNoTextBox_Validated(object sender, EventArgs e)
        {
            this._ReceiptNo = this.PVNoTextBox.Text;


            if (this.IsNew)
                this.GetDividendPaymentEntry(this._SHId, this._ReceiptNo);
        }

        private void DateofPaymentDateTimePicker_Validated(object sender, EventArgs e)
        {
                
            this.PaymentDateEthTextBox.Text=clUtility.GetEthDate(this.PaymentDateDateTimePicker.Value);
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

                this._tblShareholderDetailBrowse.Columns.Add("GrossDividend", typeof(decimal));
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

                cmdText = "SELECT a.RegCode,a.Sex, a.DOReg, a.DORegEth, a.IsLBFounder, a.IsGBFounder,convert(numeric(18,2),b.DividendAmount,2) as GrossDividend  FROM tblShareholderDetail as a inner join tblDividendEntitled as b on a.SHId= b.SHId where b.SHId=" + SHId + " and b.FiscalYear='" + this._fiscalYear + "'";

                if (_tblShareholderDetailBrowse != null)
                {
                    DataObj.FillData(this._tblShareholderDetailBrowse, cmdText);
                    if (this._tblShareholderDetailBrowse.Rows.Count > 0 && this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"] != null)
                    {
                        this.GrossDividendTextBox.Text = this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"].ToString();
                        if (this._tblDividendPaidList.Rows.Count > 0)
                        {
                            this.GrossDividendPaidtoShTextBox.Text = "0";
                        }
                        else
                        {

                            this.GrossDividendPaidtoShTextBox.Text = (Convert.ToDecimal(this._tblShareholderDetailBrowse.Rows[0]["GrossDividend"]) - this._TotalUnpaidShare).ToString();
                        }
                        this.GrossDividendPaidtoOSTextBox.Text = this._TotalUnpaidShare.ToString();
                    }
                    else
                    {
                        this._tblShareholderDetailBrowse.Clear();
                        this.GrossDividendTextBox.Text = "0";
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

        private void GrossDividendPaidtoShTextBox_Validated(object sender, EventArgs e)
        {

            object shareAmount = this.GrossDividendPaidtoShTextBox.Text.Trim();
            if (!clUtility.IsNumeric(shareAmount) && this.GrossDividendPaidtoShTextBox.Text.Trim() != string.Empty)
            {
                AppMessageBox.ShowExclamation("Please enter valid  amount outstanding pay");
                this.GrossDividendPaidtoShTextBox.Focus();
            }
           
            

                  
            
        }

        private void GrossDividendPaidtoShTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = GrossDividendPaidtoShTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid share amount");
               
                this.GrossDividendPaidtoShTextBox.Text = ""; 
            }
        }

        private void GrossDividendCapitalizedTextBox_Validated(object sender, EventArgs e)
        {


            object shareAmount = this.GrossDividendCapitalizedTextBox.Text.Trim();
            if (!clUtility.IsNumeric(shareAmount) && this.GrossDividendCapitalizedTextBox.Text.Trim() != string.Empty)
            {
                AppMessageBox.ShowExclamation("Please enter valid capitalized amount");
                this.GrossDividendCapitalizedTextBox.Focus();
            }
            


        }

        private void GrossDividendCapitalizedTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = GrossDividendCapitalizedTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid capitalized amount");

                this.GrossDividendCapitalizedTextBox.Text = "";
            }
        }

        private void GrossDividendPaidtoOSTextBox_Validated(object sender, EventArgs e)
        {
            

            object shareAmount = this.GrossDividendPaidtoOSTextBox.Text.Trim();
            if (!clUtility.IsNumeric(shareAmount) && this.GrossDividendPaidtoOSTextBox.Text.Trim() != string.Empty)
            {
                AppMessageBox.ShowExclamation("Please enter valid share amount");
                this.GrossDividendPaidtoOSTextBox.Focus();
            }
            else
            {
                if (Convert.ToDecimal(this.GrossDividendPaidtoOSTextBox.Text) > this._TotalUnpaidShare)
                {
                    AppMessageBox.ShowExclamation("You can not pay to outstanding more than the total unpaid share amount. Please enter valid amount.");
                    this.GrossDividendPaidtoOSTextBox.Focus();
                }

                
            }
                     
        }

        private void GrossDividendPaidtoOSTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = GrossDividendPaidtoOSTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid  amount outstanding pay");

                this.GrossDividendPaidtoOSTextBox.Text = "";
            }
        }

        private void IsPaidtoShCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(IsPaidtoShCheckBox.Checked)
             this._IsPaid = true;
            else
              this._IsPaid = false;
        }

        private void IsPaidtoOSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.IsPaidtoOSCheckBox.Checked)
              this._IsPaidtoOS = true;
            else
              this._IsPaidtoOS = false;
        }

        private void IsCapitalizedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.IsCapitalizedCheckBox.Checked)
                this._IsCapitalized = true;
            else
                this._IsCapitalized = false;
        }

        private void DeductTaxLOSPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.DeductTaxLOSPCheckBox.Checked)
            {
                this.TaxAmntTextBox.Text = Math.Round((Convert.ToDecimal(this.GrossDividendTextBox.Text) * Convert.ToDecimal(0.1)),2).ToString();
                this._tax = Math.Round((Convert.ToDecimal(this.GrossDividendTextBox.Text) * Convert.ToDecimal(0.1)),2);
                this.GrossDividendPaidtoShTextBox.Text = (Convert.ToDecimal(GrossDividendTextBox.Text)-this._tax).ToString();
            }
            else
            {
                this.TaxAmntTextBox.Text = "0";
                this._tax = 0;
            }
        }

        
       
      










    }
}



