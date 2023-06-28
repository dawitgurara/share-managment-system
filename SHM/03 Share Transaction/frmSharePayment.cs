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
    public partial class frmSharePayment : Form
    {
        #region Fields
        private string _title = "Share Payment";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _PaymentTrnId = 0;
        private int _TypeofPayment = 0;
        DateTime _CurrentDate;
        DateTime _PaymentDate=Convert.ToDateTime("01/01/1900");
        DateTime _EffectiveDate;
        string _EffectiveDateEth;
        string _PaymentDateEth;
        
        private string _ReceiptNo = string.Empty;
        private decimal _TotalUnpaidShare = 0;
        private string _fiscalYear = "0";
        private DataTable _tblFiscalYear;
        private DataTable _tblTypeofSharePayment;
        private DataTable _tblSharePayment;
        private DataRow _SharePayment;
        private DataTable _tblSharePaymentList;


        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
        private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrev;


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

        public frmSharePayment()
        {
            InitializeComponent();

        }
       

        private void frmSharePayment_Load(object sender, EventArgs e)
        {
            

            BindControls();
            InitForm(true);

            BindControlsSH();
            InitFormSH(true);
        }

        private void frmSharePayment_KeyDown(object sender, KeyEventArgs e)
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
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                this._tblSharePayment = DataObj.GetDataTable("tblSharePayment");
                this._tblSharePayment.Columns["CrtDt"].ReadOnly = true;
                this._tblSharePayment.Columns["CrtWs"].ReadOnly = true;
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

                    DataObj.FillData(this._tblTypeofSharePayment, "SELECT * FROM tblTypeofSharePayment");
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
                    DataObj.BeginTransaction();

                    this._SharePayment = this._tblSharePayment.Rows[0];

                    if (this.NoofSharePaidTextBox.Text == string.Empty)

                        this._SharePayment["NoofSharePaid"] = Convert.ToString(clUtility.GetShareNoByShareAmount(Convert.ToDecimal(AmntofSharePaidTextBox.Text.Trim())));
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._SharePayment, false))
                        {
                            if (InsertShareRegBook())
                            {
                                if (InsertAuditlog(this._SharePayment))
                                {
                                    DataObj.CommitTransaction();
                                    AppMessageBox.ShowInformation("Share payment transaction is saved successfully");
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Share payment transaction is failed");
                                }
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Share payment transaction is failed");
                            }

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
            try
            {
                DataObj.OpenConnection();
                if (!this.GetShareRegBookBySHId(this._SHId))
                {
                    this._ShareRegBook = this._tblShareRegBook.NewRow();
                    this._ShareRegBook["SHId"] = this._SharePayment["SHId"];
                    this._ShareRegBook["PaidUpNoofShare"] = this._SharePayment["NoofSharePaid"];
                    this._ShareRegBook["PaidUpShareAmt"] = this._SharePayment["AmntofSharePaid"];
                    this._ShareRegBook["CrtBy"] = clMain.User.UserName;


                    success = DataObj.Insert(this._title, this._ShareRegBook, false, false);
                }
                else
                {
                    decimal PaidShareNo = 0;
                    decimal PaidShareAmnt = 0;
                    PaidShareNo = Convert.ToDecimal(this._SharePayment["NoofSharePaid"]);
                    PaidShareAmnt = Convert.ToDecimal(this._SharePayment["AmntofSharePaid"]);
                    string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=isnull(PaidUpNoofShare,0)+" + PaidShareNo + ", PaidUpShareAmt=isnull(PaidUpShareAmt,0)+" + PaidShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);
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

        private bool InsertAuditlog(DataRow SharePayment)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblShareRegBookPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToInt32(SharePayment["NoofSharePaid"].ToString()) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Share Payment";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(SharePayment["NoofSharePaid"]) + Convert.ToInt32(this._tblShareRegBookPrev.Rows[0]["PaidUpNoofShare"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && Convert.ToDecimal(SharePayment["AmntofSharePaid"]) > 0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Share Payment";
                        this._AuditLog["FldChged"] = "PaidUpShareAmt";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(SharePayment["AmntofSharePaid"]) + Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["PaidUpShareAmt"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
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
            this._PaymentTrnId = 0;
            this._SHId = 0;

            this.GetSharePaymentEntry(this._SHId, this._ReceiptNo,this._PaymentDate, this._TypeofPayment);
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
                GetShareRegBookListBySHId(this._SHId);
                
                GetSharePaymentHistory(this._SHId, this._fiscalYear);

            }

           

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

                this.gridSharePayment.FocusedRowHandle = focused;
            }
        }

        private bool GetSharePaymentHistory(int shId, string fiscalyear)
        {
            if (!this._isLoadingEntry)
            {

                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    
                    DataObj.FillData(this._tblSharePaymentList, "SELECT * FROM tblSharePayment WHERE IsCanceled=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
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

        private bool GetSharePaymentEntry(int trnId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
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
                this._SharePayment = this._tblSharePayment.NewRow();
                clDatacon.SetToDatabaseDefaults(this._SharePayment, clMain.ConnString);
                if (this._fiscalYear != "0") this._SharePayment["FiscalYear"] = this._fiscalYear;
                if (this._SHId != 0) this._SharePayment["SHId"] = this._SHId;
                if (this._ReceiptNo != string.Empty) this._SharePayment["ReceiptNo"] = this._ReceiptNo;
                

                int mon, year;
                this._CurrentDate = clUtility.GetCurrentDate();
                if (this._PaymentDate.ToShortDateString() == "01/01/1900")
                    this._PaymentDate = this._CurrentDate;

                this._SharePayment["DateofPayment"] = this._PaymentDate;
                this._SharePayment["DateofPaymentEth"] = clUtility.GetEthDate(this._PaymentDate);
                if (this._PaymentDate.Day >= 15)
                {

                    if (this._PaymentDate.Month < 12)
                    {
                        mon = this._PaymentDate.Month + 1;
                        year = this._PaymentDate.Year;
                    }
                    else
                    {
                        mon = 1;
                        year = this._PaymentDate.Year + 1;
                    }

                    this._SharePayment["EffectiveDate"] = "01/" + mon + "/" + year;
                    this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));

                    this.EffectiveDateDateTimePicker.Text = this._SharePayment["EffectiveDate"].ToString();
                    this.EffectiveDateEthTextBox.Text = this._SharePayment["EffectiveDateEth"].ToString();
                }
                else
                {
                    this._SharePayment["EffectiveDate"] = "01/" + (this._PaymentDate.Month) + "/" + this._PaymentDate.Year;
                    this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
                    this.EffectiveDateDateTimePicker.Text = this._SharePayment["EffectiveDate"].ToString();
                    this.EffectiveDateEthTextBox.Text = this._SharePayment["EffectiveDateEth"].ToString();
                }
                if (this._TypeofPayment != 0) this._SharePayment["TypeofPayment"] = this._TypeofPayment;
                this._SharePayment["CrtBy"] = clMain.User.UserName;
                this._tblSharePayment.Rows.Clear();
                this._tblSharePayment.Rows.Add(this._SharePayment);
                this._isLoadingEntry = false;
            }
        }

        private bool GetSharePaymentEntry(int SHId, string ReceiptNo,DateTime PaymentDate,int TypeofPayment)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.SharePaymentExists(SHId, ReceiptNo, PaymentDate, TypeofPayment))
                {
                    this._isLoadingEntry = false;

                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblSharePayment, "set dateformat dmy SELECT * FROM tblSharePayment WHERE IsCanceled=0 and SHId=" + SHId + " AND ReceiptNo='" + ReceiptNo + "' and EffectiveDate='" + PaymentDate.ToShortDateString() + "' and TypeofPayment=" + TypeofPayment);
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

        public bool SharePaymentExists(int shId, string ReceiptNo,DateTime PaymentDate, int TypeofPayment)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (shId == 0 || ReceiptNo == string.Empty)
                return false;
            try
            {
                DataObj.OpenConnection();
                cmdText = "set dateformat dmy SELECT SHId FROM tblSharePayment WHERE IsCanceled=0 and SHId=" + shId + " AND ReceiptNo='" + ReceiptNo + "' and EffectiveDate='" + PaymentDate.ToShortDateString() + "' and TypeofPayment=" + TypeofPayment;
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
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                DataObj.FillData(this._tblShareRegBookPrev, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
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

        private void ReceiptNoTextBox_Validated(object sender, EventArgs e)
        {
            this._ReceiptNo = this.ReceiptNoTextBox.Text;
        }

        private void DateofPaymentDateTimePicker_Validated(object sender, EventArgs e)
        {

            this.DateofPaymentEthTextBox.Text = clUtility.GetEthDate(this.DateofPaymentDateTimePicker.Value);
            this._PaymentDate = DateofPaymentDateTimePicker.Value;
            int year;
            int mon;
            if (this.DateofPaymentDateTimePicker.Value.Day >= 15)
            {
                
                if (this.DateofPaymentDateTimePicker.Value.Month < 12)
                {
                    mon = this.DateofPaymentDateTimePicker.Value.Month + 1;
                    year = this.DateofPaymentDateTimePicker.Value.Year;
                }
                else
                {
                    mon = 1;
                    year = (this.DateofPaymentDateTimePicker.Value.Year) + 1;
                }
                this._SharePayment["EffectiveDate"] = "01/" + mon + "/" + year;

                this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
                this.EffectiveDateDateTimePicker.Value = Convert.ToDateTime(this._SharePayment["EffectiveDate"]);
                this.EffectiveDateEthTextBox.Text = this._SharePayment["EffectiveDateEth"].ToString();
            }
            else
            {
                this._SharePayment["EffectiveDate"] = "01/" + (this.DateofPaymentDateTimePicker.Value.Month) + "/" + this.DateofPaymentDateTimePicker.Value.Year;
                this._SharePayment["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._SharePayment["EffectiveDate"]));
                this.EffectiveDateDateTimePicker.Value = Convert.ToDateTime(this._SharePayment["EffectiveDate"]);
                this.EffectiveDateEthTextBox.Text = this._SharePayment["EffectiveDateEth"].ToString();
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

        private void AmntofSharePaidTextBox_Validated(object sender, EventArgs e)
        {
            if (this.AmntofSharePaidTextBox.Text.Trim() == string.Empty)
                AppMessageBox.ShowExclamation("Please enter the share amount");
            else
            {
                object shareAmount = this.AmntofSharePaidTextBox.Text.Trim();
                if (!clUtility.IsNumeric(shareAmount))
                {
                    AppMessageBox.ShowExclamation("Please enter valid share amount");
                    this.AmntofSharePaidTextBox.Focus();
                }
                else
                {
                    if (Convert.ToDecimal(this.AmntofSharePaidTextBox.Text) > this._TotalUnpaidShare)
                    {
                        AppMessageBox.ShowExclamation("You can not pay more than the total unpaid share amount. Please enter valid paid share amount.");
                        this.AmntofSharePaidTextBox.Text = "";
                        this.AmntofSharePaidTextBox.Focus();
                    }
                    //else if (Convert.ToDecimal(this.AmntofSharePaidTextBox.Text) < 1000)
                    //{
                    //    AppMessageBox.ShowExclamation("Share amount should not be less than 1000.");
                    //    this.AmntofSharePaidTextBox.Focus();
                    //}
                    else
                        this.NoofSharePaidTextBox.Text = Convert.ToString(clUtility.GetShareNoByShareAmount(Convert.ToDecimal(AmntofSharePaidTextBox.Text.Trim())));
                }

            }
        }

        private void AmntofSharePaidTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = AmntofSharePaidTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid share amount");
                AmntofSharePaidTextBox.Text = "";
                this.NoofSharePaidTextBox.Text = "";
            }
        }

        private void TypeofPaymentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.TypeofPaymentLookUpEdit.EditValue != null || !Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._TypeofPayment = Convert.ToInt32(this.TypeofPaymentLookUpEdit.EditValue);
            }
            if (this.IsNew)
                this.GetSharePaymentEntry(this._SHId, this._ReceiptNo,this._PaymentDate,this._TypeofPayment);
        }












    }
}


